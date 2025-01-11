using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace RBWR_Calculator
{
    // Fun fact: this code sucks, but it works. It's a calculator for a fictional nuclear reactor anyway which I made because I was bored soloing unit 2.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ForceRecalculationLoad(object sender, EventArgs e)
        {
            outputAPR.BackColor = Color.Red;
            outputFWFlow.BackColor = Color.Red;

            bool fla = !double.TryParse(inputMWe.Text, out var mwResult);
            bool flb = !double.TryParse(inputPlantUsage.Text, out var plantUsageResult);
            if (fla || flb)
            {
                this.outputAPR.Text = "Error: NaN";
                this.outputFWFlow.Text = "Error: NaN";
                extraNote.Text = "At least one value is not a number!";
                return;
            }

            if (mwResult < 0 || plantUsageResult < 0)
            {
                this.outputAPR.Text = "Error: Negative";
                this.outputFWFlow.Text = "Error: Negative";
                extraNote.Text = "At least one value supplied is negative!";
                return;
            }

            double totalRequested = mwResult + plantUsageResult;

            double apr = (totalRequested + 163) / 14.3;
            double flow = 82.8 + (13.7 * apr) + (5.87 * Math.Pow(10, -3) * Math.Pow(apr, 2));

            outputAPR.BackColor = Color.GhostWhite;
            outputFWFlow.BackColor = Color.GhostWhite;
            List<string> notes = new List<string>();
            if (flow > 1212.5)
            {
                outputFWFlow.BackColor = Color.DarkOrange;
                notes.Add("Pump repairs may be impossible.");
            }
            else if (flow > 1187.5)
            {
                outputFWFlow.BackColor = Color.Orange;
                notes.Add("Pump repairs may be unsafe, reactor level will drop below -3m.");
            }
            else if (flow > 990)
            {
                outputFWFlow.BackColor = Color.Yellow;
                notes.Add("Pump repairs may possible, use 'Pump Deficit Run' to check.");
            }

            string extraTextLoad = "";
            if (apr > 108)
            {
                extraTextLoad = "Danger, APR > 108%!";
                outputAPR.BackColor = Color.Red;
            }
            else if (apr > 100)
            {
                extraTextLoad = "Warning, high load.";
                outputAPR.BackColor = Color.DarkOrange;
            }

            if (extraTextLoad != "")
            {
                notes.Add(extraTextLoad);
            }

            extraNote.Text = "";
            for (int i = 0; i < notes.Count; i++)
            {
                if (i < notes.Count)
                {
                    // ReSharper disable once LocalizableElement
                    extraNote.Text += "\n";
                }

                extraNote.Text += notes[i];
            }

            if (extraNote.Text == "")
            {
                extraNote.Text = "All clear!";
            }

            this.outputAPR.Text = $@"{apr:0.00}";
            this.outputFWFlow.Text = $@"{flow:0.00}";
            this.inputCRRVPOutflow.Text = $@"{flow:0.00}";
        }

        private void ForceRecalculationColdRun(object sender = null, EventArgs e = null)
        {
            bool fla = !double.TryParse(inputCRRVPOutflow.Text, out var coreOutflow);
            bool flb = !double.TryParse(inputCRSoloPumpOut.Text, out var pumpOutflow);
            bool flc = !double.TryParse(inputCRTimeRepairs.Text, out var repairTime);

            if (fla || flb || flc)
            {
                labelCRExtraText.Text = "At least one value is not a number!";
                return;
            }

            if (pumpOutflow < 0 || coreOutflow < 0 || repairTime < 0)
            {
                // to add, at least one value is negative
                labelCRExtraText.Text = "At least one value is negative!";
                return;
            }

            if (pumpOutflow > 1000)
            {
                // one pump is able to output 1000 kg/s max
                labelCRExtraText.Text = "Solo pump output is too high! 1000 kg/s max!";
                return;
            }

            double reactorDeficit = coreOutflow - pumpOutflow;
            if (reactorDeficit <= 0)
            {
                // no deficit
                labelCRExtraText.Text = "No deficit, no repairs needed!";
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
            labelCRExtraText.Text = extraText;
        }
    }
}