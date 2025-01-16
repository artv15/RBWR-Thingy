using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace RBWR_Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        internal static Form Instance => Application.OpenForms[nameof(Form)] as Form;

        private void Loaded(object sender, EventArgs e)
        {
            Features.Calculations.CalculateMeetingPoint();
        }

        internal enum FormulaStatus
        {
            Auto,
            Linear,
            Quadratic
        }

        internal FormulaStatus FormulaUsage
        {
            get
            {
                if (radioPowerFormulaAuto.Checked)
                    return FormulaStatus.Auto;
                if (radioPowerFormulaLinear.Checked)
                    return FormulaStatus.Linear;
                return FormulaStatus.Quadratic;
            }
        }

        public Form()
        {
            InitializeComponent();
        }

        private void ForceRecalculationLoad(object sender, EventArgs e)
        {
            textboxPowerOutputAPR.BackColor = Color.Red;
            textboxPowerOutputFlow.BackColor = Color.Red;

            bool fla = !double.TryParse(textboxPowerInputDemand.Text, out var mwResult);
            bool flb = !double.TryParse(textboxPowerInputPlantUsage.Text, out var plantUsageResult);
            if (fla || flb)
            {
                this.textboxPowerOutputAPR.Text = "Error: NaN";
                this.textboxPowerOutputFlow.Text = "Error: NaN";
                labelPowerExtraText.Text = "At least one value is not a number!";
                return;
            }

            if (mwResult < 0 || plantUsageResult < 0)
            {
                this.textboxPowerOutputAPR.Text = "Error: Negative";
                this.textboxPowerOutputFlow.Text = "Error: Negative";
                labelPowerExtraText.Text = "At least one value supplied is negative!";
                return;
            }

            double totalRequested = mwResult + plantUsageResult;
            double apr = Features.Calculations.CalculateApr(totalRequested);
            double flow = Features.Calculations.CalculateFlow(apr);

            textboxPowerOutputAPR.BackColor = Color.GhostWhite;
            textboxPowerOutputFlow.BackColor = Color.GhostWhite;


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

            this.textboxPowerOutputAPR.Text = $@"{apr:0.00}";
            if (apr > 125 || totalRequested > 1600) // Quadratic stops making sense above 1600-ish, but why you would try to target anything above 1260 in the first place?
            {
                this.textboxPowerOutputAPR.Text = $@"reactor explodet";
                this.textboxPowerOutputFlow.Text = $@"0.00";
                labelPowerExtraText.Text = "reactor explodet";
                return;
            }

            this.textboxPowerOutputFlow.Text = $@"{flow:0.00}";
            this.textboxInputRepairFlow.Text = $@"{flow:0.00}";
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
    }
}