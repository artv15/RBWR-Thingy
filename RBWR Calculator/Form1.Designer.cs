namespace RBWR_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.extraNote = new System.Windows.Forms.Label();
            this.outputFWFlow = new System.Windows.Forms.TextBox();
            this.labelFWFlow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlantUsage = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.warningPrecision = new System.Windows.Forms.Label();
            this.inputPlantUsage = new System.Windows.Forms.TextBox();
            this.outputAPR = new System.Windows.Forms.TextBox();
            this.inputMWe = new System.Windows.Forms.TextBox();
            this.groupColdRun = new System.Windows.Forms.GroupBox();
            this.labelCRExtraText = new System.Windows.Forms.Label();
            this.labelCRRepairsTime = new System.Windows.Forms.Label();
            this.inputCRTimeRepairs = new System.Windows.Forms.TextBox();
            this.inputCRSoloPumpOut = new System.Windows.Forms.TextBox();
            this.inputCRRVPOutflow = new System.Windows.Forms.TextBox();
            this.labelCRPumpCapacity = new System.Windows.Forms.Label();
            this.labelCROutflow = new System.Windows.Forms.Label();
            this.labelPumpDeficit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupColdRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.extraNote);
            this.groupBox1.Controls.Add(this.outputFWFlow);
            this.groupBox1.Controls.Add(this.labelFWFlow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelPlantUsage);
            this.groupBox1.Controls.Add(this.labelDemand);
            this.groupBox1.Controls.Add(this.warningPrecision);
            this.groupBox1.Controls.Add(this.inputPlantUsage);
            this.groupBox1.Controls.Add(this.outputAPR);
            this.groupBox1.Controls.Add(this.inputMWe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MWe to APR";
            // 
            // extraNote
            // 
            this.extraNote.Location = new System.Drawing.Point(6, 187);
            this.extraNote.Name = "extraNote";
            this.extraNote.Size = new System.Drawing.Size(239, 47);
            this.extraNote.TabIndex = 9;
            this.extraNote.Text = "No calculations performed.";
            this.extraNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputFWFlow
            // 
            this.outputFWFlow.Location = new System.Drawing.Point(112, 161);
            this.outputFWFlow.Name = "outputFWFlow";
            this.outputFWFlow.ReadOnly = true;
            this.outputFWFlow.Size = new System.Drawing.Size(133, 20);
            this.outputFWFlow.TabIndex = 8;
            // 
            // labelFWFlow
            // 
            this.labelFWFlow.Location = new System.Drawing.Point(6, 164);
            this.labelFWFlow.Name = "labelFWFlow";
            this.labelFWFlow.Size = new System.Drawing.Size(100, 23);
            this.labelFWFlow.TabIndex = 7;
            this.labelFWFlow.Text = "Feedwater Flow";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "APR (approx)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlantUsage
            // 
            this.labelPlantUsage.Location = new System.Drawing.Point(6, 100);
            this.labelPlantUsage.Name = "labelPlantUsage";
            this.labelPlantUsage.Size = new System.Drawing.Size(100, 23);
            this.labelPlantUsage.TabIndex = 5;
            this.labelPlantUsage.Text = "Plant usage (MWe)";
            this.labelPlantUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDemand
            // 
            this.labelDemand.Location = new System.Drawing.Point(6, 77);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(100, 23);
            this.labelDemand.TabIndex = 4;
            this.labelDemand.Text = "Demand (MWe)";
            this.labelDemand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // warningPrecision
            // 
            this.warningPrecision.Location = new System.Drawing.Point(6, 16);
            this.warningPrecision.Name = "warningPrecision";
            this.warningPrecision.Size = new System.Drawing.Size(239, 58);
            this.warningPrecision.TabIndex = 3;
            this.warningPrecision.Text = resources.GetString("warningPrecision.Text");
            // 
            // inputPlantUsage
            // 
            this.inputPlantUsage.Location = new System.Drawing.Point(112, 103);
            this.inputPlantUsage.Name = "inputPlantUsage";
            this.inputPlantUsage.Size = new System.Drawing.Size(133, 20);
            this.inputPlantUsage.TabIndex = 2;
            this.inputPlantUsage.Text = "61.32";
            this.inputPlantUsage.TextChanged += new System.EventHandler(this.ForceRecalculationLoad);
            // 
            // outputAPR
            // 
            this.outputAPR.Location = new System.Drawing.Point(112, 138);
            this.outputAPR.Name = "outputAPR";
            this.outputAPR.ReadOnly = true;
            this.outputAPR.Size = new System.Drawing.Size(133, 20);
            this.outputAPR.TabIndex = 1;
            // 
            // inputMWe
            // 
            this.inputMWe.Location = new System.Drawing.Point(112, 77);
            this.inputMWe.Name = "inputMWe";
            this.inputMWe.Size = new System.Drawing.Size(133, 20);
            this.inputMWe.TabIndex = 0;
            this.inputMWe.TextChanged += new System.EventHandler(this.ForceRecalculationLoad);
            // 
            // groupColdRun
            // 
            this.groupColdRun.Controls.Add(this.labelCRExtraText);
            this.groupColdRun.Controls.Add(this.labelCRRepairsTime);
            this.groupColdRun.Controls.Add(this.inputCRTimeRepairs);
            this.groupColdRun.Controls.Add(this.inputCRSoloPumpOut);
            this.groupColdRun.Controls.Add(this.inputCRRVPOutflow);
            this.groupColdRun.Controls.Add(this.labelCRPumpCapacity);
            this.groupColdRun.Controls.Add(this.labelCROutflow);
            this.groupColdRun.Controls.Add(this.labelPumpDeficit);
            this.groupColdRun.Location = new System.Drawing.Point(278, 12);
            this.groupColdRun.Name = "groupColdRun";
            this.groupColdRun.Size = new System.Drawing.Size(275, 237);
            this.groupColdRun.TabIndex = 1;
            this.groupColdRun.TabStop = false;
            this.groupColdRun.Text = "Pump Deficit Run";
            // 
            // labelCRExtraText
            // 
            this.labelCRExtraText.Location = new System.Drawing.Point(6, 187);
            this.labelCRExtraText.Name = "labelCRExtraText";
            this.labelCRExtraText.Size = new System.Drawing.Size(263, 47);
            this.labelCRExtraText.TabIndex = 7;
            this.labelCRExtraText.Text = "No calculations performed";
            this.labelCRExtraText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCRRepairsTime
            // 
            this.labelCRRepairsTime.Location = new System.Drawing.Point(6, 150);
            this.labelCRRepairsTime.Name = "labelCRRepairsTime";
            this.labelCRRepairsTime.Size = new System.Drawing.Size(148, 23);
            this.labelCRRepairsTime.TabIndex = 6;
            this.labelCRRepairsTime.Text = "Expected Repairs Time";
            this.labelCRRepairsTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputCRTimeRepairs
            // 
            this.inputCRTimeRepairs.Location = new System.Drawing.Point(169, 152);
            this.inputCRTimeRepairs.Name = "inputCRTimeRepairs";
            this.inputCRTimeRepairs.Size = new System.Drawing.Size(100, 20);
            this.inputCRTimeRepairs.TabIndex = 5;
            this.inputCRTimeRepairs.Text = "330";
            this.inputCRTimeRepairs.TextChanged += new System.EventHandler(this.ForceRecalculationColdRun);
            // 
            // inputCRSoloPumpOut
            // 
            this.inputCRSoloPumpOut.Location = new System.Drawing.Point(169, 126);
            this.inputCRSoloPumpOut.Name = "inputCRSoloPumpOut";
            this.inputCRSoloPumpOut.Size = new System.Drawing.Size(100, 20);
            this.inputCRSoloPumpOut.TabIndex = 4;
            this.inputCRSoloPumpOut.TextChanged += new System.EventHandler(this.ForceRecalculationColdRun);
            // 
            // inputCRRVPOutflow
            // 
            this.inputCRRVPOutflow.Location = new System.Drawing.Point(169, 100);
            this.inputCRRVPOutflow.Name = "inputCRRVPOutflow";
            this.inputCRRVPOutflow.Size = new System.Drawing.Size(100, 20);
            this.inputCRRVPOutflow.TabIndex = 3;
            this.inputCRRVPOutflow.TextChanged += new System.EventHandler(this.ForceRecalculationColdRun);
            // 
            // labelCRPumpCapacity
            // 
            this.labelCRPumpCapacity.Location = new System.Drawing.Point(6, 124);
            this.labelCRPumpCapacity.Name = "labelCRPumpCapacity";
            this.labelCRPumpCapacity.Size = new System.Drawing.Size(111, 22);
            this.labelCRPumpCapacity.TabIndex = 2;
            this.labelCRPumpCapacity.Text = "Solo Pump Capacity";
            this.labelCRPumpCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCROutflow
            // 
            this.labelCROutflow.Location = new System.Drawing.Point(6, 98);
            this.labelCROutflow.Name = "labelCROutflow";
            this.labelCROutflow.Size = new System.Drawing.Size(111, 23);
            this.labelCROutflow.TabIndex = 1;
            this.labelCROutflow.Text = "RPV Outflow ";
            this.labelCROutflow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPumpDeficit
            // 
            this.labelPumpDeficit.Location = new System.Drawing.Point(6, 15);
            this.labelPumpDeficit.Name = "labelPumpDeficit";
            this.labelPumpDeficit.Size = new System.Drawing.Size(263, 71);
            this.labelPumpDeficit.TabIndex = 0;
            this.labelPumpDeficit.Text = resources.GetString("labelPumpDeficit.Text");
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(565, 261);
            this.Controls.Add(this.groupColdRun);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "RBWR thingy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupColdRun.ResumeLayout(false);
            this.groupColdRun.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox inputCRTimeRepairs;
        private System.Windows.Forms.Label labelCRRepairsTime;

        private System.Windows.Forms.Label labelCROutflow;

        private System.Windows.Forms.TextBox inputCRSoloPumpOut;

        private System.Windows.Forms.TextBox inputCRRVPOutflow;

        private System.Windows.Forms.Label labelCRExtraText;

        private System.Windows.Forms.Label labelPumpDeficit;

        private System.Windows.Forms.GroupBox groupColdRun;

        private System.Windows.Forms.Label extraNote;

        private System.Windows.Forms.TextBox outputFWFlow;

        private System.Windows.Forms.Label labelFWFlow;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelDemand;

        private System.Windows.Forms.Label warningPrecision;
        private System.Windows.Forms.Label labelPlantUsage;

        private System.Windows.Forms.TextBox inputPlantUsage;

        private System.Windows.Forms.TextBox inputMWe;
        private System.Windows.Forms.TextBox outputAPR;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label labelCRPumpCapacity;

        #endregion
    }
}