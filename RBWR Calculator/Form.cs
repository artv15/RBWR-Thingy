using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RBWR_Calculator.Features;

// ReSharper disable LocalizableElement

namespace RBWR_Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        internal static Form Instance => Application.OpenForms[nameof(Form)] as Form;

        public Form()
        {
            InitializeComponent();
        }

        private bool _suppressUpdates;

        private void ForceRecalculationAprUpdated(object sender, EventArgs e)
        {
            if (_suppressUpdates)
                return;

            try
            {
                _suppressUpdates = true;
                double apr;
                textboxPowerOutputAPR.BackColor = Color.Red;

                try
                {
                    apr = double.Parse(textboxPowerOutputAPR.Text);
                }
                catch
                {
                    labelPowerExtraText.Text = "APR value is not a number!";
                    return;
                }

                if (apr < 0 || apr > 125)
                {
                    labelPowerExtraText.Text = "APR out of range!";
                    return;
                }

                labelPowerExtraText.Text = "All clear!";
                double projectedLoad = Calculations.CalculateMWeFromApr(apr);

                textboxPowerInputPlantUsage.Text = "0";
                textboxPowerInputDemand.Text = projectedLoad.ToString("0.00");
                textboxPowerOutputAPR.BackColor = SystemColors.Window;
                _suppressUpdates = false;
                ForceRecalculationExtra();
            }
            finally
            {
                _suppressUpdates = false;
            }
        }

        private void ForceRecalculationLoad(object sender, EventArgs e)
        {
            if (_suppressUpdates)
                return;

            try
            {
                _suppressUpdates = true;
                textboxPowerOutputAPR.BackColor = Color.Red;
                textboxPowerOutputFlow.BackColor = Color.Red;

                bool fla = !double.TryParse(textboxPowerInputDemand.Text, out var mwResult);
                bool flb = !double.TryParse(textboxPowerInputPlantUsage.Text, out var plantUsageResult);
                if (fla || flb)
                {
                    textboxPowerOutputAPR.Text = "Error: NaN";
                    textboxPowerOutputFlow.Text = "Error: NaN";
                    labelPowerExtraText.Text = "At least one value is not a number!";
                    return;
                }

                if (mwResult < 0 || plantUsageResult < 0)
                {
                    textboxPowerOutputAPR.Text = "Error: Negative";
                    textboxPowerOutputFlow.Text = "Error: Negative";
                    labelPowerExtraText.Text = "At least one value supplied is negative!";
                    return;
                }

                double totalRequested = mwResult + plantUsageResult;
                double apr = Calculations.CalculateApr(totalRequested, !checkBoxAPRIsUnit2.Checked);
                double flow = Calculations.CalculateFlow(totalRequested);

                textboxPowerOutputAPR.BackColor = SystemColors.Window;
                textboxPowerOutputFlow.BackColor = SystemColors.Window;

                string extraText = "";
                List<string> notes = new List<string>();
                if (flow > 1000)
                {
                    extraText = "Above safe repair threshold.";
                }

                if (apr > 108)
                {
                    extraText = "APR > 108%. Are you certain whatever you are doing is worth it?";
                    textboxPowerOutputAPR.BackColor = Color.Red;
                }
                else if (apr > 100)
                {
                    extraText = "Warning, high load.";
                    textboxPowerOutputAPR.BackColor = Color.DarkOrange;
                }

                if (extraText != "")
                {
                    notes.Add(extraText);
                }

                labelPowerExtraText.Text = "";
                for (int i = 0; i < notes.Count; i++)
                {
                    if (i < notes.Count)
                    {
                        labelPowerExtraText.Text += "\n";
                    }

                    labelPowerExtraText.Text += notes[i];
                }

                if (labelPowerExtraText.Text == "")
                {
                    labelPowerExtraText.Text = "All clear!";
                }

                textboxPowerOutputAPR.Text = $@"{apr:0.00}";
                if (apr > 125 || totalRequested > 1600)
                {
                    textboxPowerOutputAPR.Text = @"reactor explodet";
                    textboxPowerOutputFlow.Text = @"0.00";
                    labelPowerExtraText.Text = "reactor explodet";
                    return;
                }

                ForceRecalculationExtra();
            }
            finally
            {
                _suppressUpdates = false;
            }
        }

        private void ForceRecalculationExtra(object sender = null, EventArgs e = null)
        {
            bool fla = !double.TryParse(textboxPowerInputDemand.Text, out var mwResult);
            bool flb = !double.TryParse(textboxPowerInputPlantUsage.Text, out var plantUsageResult);
            if (fla || flb)
            {
                return;
            }

            double totalRequested = mwResult + plantUsageResult;
            double flow = Calculations.CalculateFlow(totalRequested);
            textboxPowerOutputFlow.Text = $@"{flow:0.00}";
            textboxInputRepairFlow.Text = $@"{flow:0.00}";

            double turbineValve = Calculations.CalculateTurbineValve(totalRequested);
            textBoxOutputTurbineInletValve.Text = $@"{turbineValve:0.00}";
            double condenserFlowU1 = Calculations.CalculateCondenserFlowU1(totalRequested);
            textBoxOutputCondenserFlowU1.Text = $@"{condenserFlowU1:0.00}";
            double steamSealingU2 = Calculations.CalculateSealingU2(totalRequested);
            textBoxOutputSteamSealingU2.Text = $@"{steamSealingU2:0.00}";
            double oilCoolingU2 = Calculations.CalculateCoolingU2(totalRequested);
            textBoxOutputOilCoolingU2.Text = $@"{oilCoolingU2:0.00}";
        }

        private void ForceRecalculationColdRun(object sender = null, EventArgs e = null)
        {
            bool fla = !double.TryParse(textboxInputRepairFlow.Text, out var coreOutflow);
            bool flb = !double.TryParse(textboxRepairInputSoloPump.Text, out var pumpOutflow);
            bool flc = !double.TryParse(textboxInputRepairTime.Text, out var repairTime);

            if (fla || flb || flc)
            {
                labelRepairExtraText.Text = "At least one value is not a number!";
                return;
            }

            if (pumpOutflow < 0 || coreOutflow < 0 || repairTime < 0)
            {
                // to add, at least one value is negative
                labelRepairExtraText.Text = "At least one value is negative!";
                return;
            }

            if (pumpOutflow > 1000)
            {
                // one pump is able to output 1000 kg/s max
                labelRepairExtraText.Text = "Solo pump output is too high! 1000 kg/s max!";
                return;
            }

            double reactorDeficit = coreOutflow - pumpOutflow;
            if (reactorDeficit <= 0)
            {
                // no deficit
                labelRepairExtraText.Text = "No deficit, no repairs needed!";
                return;
            }

            // we don't care about condenser or deaerator capacity per meter, since only core output matters.
            // Condenser can be made up from CST, and deaerator should have the same output as hotwell.
            // Solo pump output should be capped at the lowest of condenser pumps or feedwater pumps.
            const double coreCapacityPerMeter = 7500;

            // More than 5 meters will cause RPV drain, less than -4 meters will scram the reactor. Since MCC is hard, we'll just use 4.5m as the initial level.
            const double coreInitialLevel = 4.5;

            double totalWaterDeficit = reactorDeficit * repairTime;
            double levelAtTheEnd = coreInitialLevel - (totalWaterDeficit / coreCapacityPerMeter);

            string extraText;
            if (levelAtTheEnd < -4)
            {
                extraText = "Reactor will scram, repairs impossible at this load";
            }
            else if (levelAtTheEnd < -3.8)
            {
                extraText = "Repairs possible, but not recommended, as the reactor will get quite thirsty";
            }
            else if (levelAtTheEnd < -3)
            {
                extraText = "Repairs possible, reactor will be thirsty though according to annunciation panel";
            }
            else
            {
                extraText = "Repairs possible!";
            }

            extraText += $" Reactor expected level: {levelAtTheEnd:0.00}m";
            labelRepairExtraText.Text = extraText;
        }

        private void Loaded(object sender, EventArgs e)
        {
            var tooltip = new ToolTip();

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;

            tooltip.ShowAlways = true;

            tooltip.SetToolTip(textboxPowerInputDemand, "Unit demand in MWe. Sums with unit usage to get target gen load.");
            tooltip.SetToolTip(textboxPowerInputPlantUsage, "Unit usage in MWe. Sums with unit demand to get target gen load.");
            tooltip.SetToolTip(textboxPowerOutputAPR, "Target Reactor APR. Can be adjusted, will display resulting gen load in demand input.");
            tooltip.SetToolTip(textboxPowerOutputFlow, "Expected reactor steam flow. Automatically replicated to MCC Repair Assist flow input upon update.");
            tooltip.SetToolTip(textboxInputRepairFlow, "Reactor outflow. Highly recommend to increase it by 10 kg/s.");
            tooltip.SetToolTip(textboxInputRepairTime, "Expected repair time. Less devices you mark for repairs, less time it will take. Highly suggest leaving it at a default value.");
            tooltip.SetToolTip(textboxRepairInputSoloPump, "Best pump output capacity of both sets.");
            tooltip.SetToolTip(checkBoxAPRIsUnit2, "Use Unit 2 formula for APR calculations.");

            string phToolTip =
                "Increases reactor efficiency by preheating incoming feedwater. " +
                "If any one of them is broken, demand calculator will produce incorrect values. " +
                "To check, switch them off, then check them one by one to see if the feedwater temperature matches. " +
                "If it does not, lower than maximum pre-heaters are broken.";
            string fwpToolTip =
                "Transfers water from the deaerator back to the reactor, closing the coolant loop. " +
                "1% of FWP is 10 kg/s of flow. If it doesn't match up with actual outflow, a pump is broken. " +
                "Easier to detect in unit 2.";
            string condPumpToolTip =
                "Transfers water from the hotwell (condenser) to the deaerator. A single pump has nominal output of 1000 kg/s. " +
                "If a single pump is maxed out and has less outflow than 1000 kg/s, it's broken. Easier to test in unit 1.";
            string condRecircToolTip =
                "Increases condenser vacuum by condensing steam back into water, leaving nothing, or vacuum, behind. " +
                "A single pump has 2500 kg/s recirculation capacity. If a maxed out pump outputs less water, it's broken. Easier to test in unit 1.";
            string condSjaeToolTip =
                "Ejects non-condensable gases. Can be used to lower the pressure in a pinch. Enable only one at a time (to use in emergencies), quickly switch them to test. " +
                "If recently enabled SJAE removes less gases (pressure goes up), it's (more) broken than another SJAE.";
            string reactorRecircToolTip =
                "Increases reactivity by removing steam voids. Has an opposite effect on RBMK. 1% = 5 kg/s, if outflow doesn't match the percentage, recirculation pump is broken.";

            tooltip.SetToolTip(checkboxRepairsPH1, phToolTip);
            tooltip.SetToolTip(checkboxRepairsPH2, phToolTip);
            tooltip.SetToolTip(checkboxRepairsPH3, phToolTip);

            tooltip.SetToolTip(checkboxRepairsFWP1, fwpToolTip);
            tooltip.SetToolTip(checkboxRepairsFWP2, fwpToolTip);

            tooltip.SetToolTip(checkboxRepairsMCCCond1, condPumpToolTip);
            tooltip.SetToolTip(checkboxRepairsMCCCond2, condPumpToolTip);

            tooltip.SetToolTip(checkboxRepairsCondenserRecirc1, condRecircToolTip);
            tooltip.SetToolTip(checkboxRepairsCondenserRecirc2, condRecircToolTip);

            tooltip.SetToolTip(checkboxRepairsCondenserSJAE1, condSjaeToolTip);
            tooltip.SetToolTip(checkboxRepairsCondenserSJAE2, condSjaeToolTip);

            tooltip.SetToolTip(checkboxRepairsReactorRecirc1, reactorRecircToolTip);
            tooltip.SetToolTip(checkboxRepairsReactorRecirc2, reactorRecircToolTip);
        }
    }
}