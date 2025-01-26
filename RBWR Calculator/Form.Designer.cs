namespace RBWR_Calculator
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.groupPower = new System.Windows.Forms.GroupBox();
            this.labelPowerExtraText = new System.Windows.Forms.Label();
            this.textboxPowerOutputFlow = new System.Windows.Forms.TextBox();
            this.labelFWFlow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlantUsage = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.labelPowerDescription = new System.Windows.Forms.Label();
            this.textboxPowerInputPlantUsage = new System.Windows.Forms.TextBox();
            this.textboxPowerOutputAPR = new System.Windows.Forms.TextBox();
            this.textboxPowerInputDemand = new System.Windows.Forms.TextBox();
            this.groupRepair = new System.Windows.Forms.GroupBox();
            this.labelRepairExtraText = new System.Windows.Forms.Label();
            this.labelRepairInputTime = new System.Windows.Forms.Label();
            this.textboxInputRepairTime = new System.Windows.Forms.TextBox();
            this.textboxRepairInputSoloPump = new System.Windows.Forms.TextBox();
            this.textboxInputRepairFlow = new System.Windows.Forms.TextBox();
            this.labelCRPumpCapacity = new System.Windows.Forms.Label();
            this.labelCROutflow = new System.Windows.Forms.Label();
            this.labelRepairDescription = new System.Windows.Forms.Label();
            this.groupRepairMarkers = new System.Windows.Forms.GroupBox();
            this.repairsGroupReactor = new System.Windows.Forms.GroupBox();
            this.checkboxRepairsReactorRecirc1 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsReactorRecirc2 = new System.Windows.Forms.CheckBox();
            this.repairsGroupCondenser = new System.Windows.Forms.GroupBox();
            this.checkboxRepairsCondenserRecirc2 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsCondenserRecirc1 = new System.Windows.Forms.CheckBox();
            this.repairsGroupMCC = new System.Windows.Forms.GroupBox();
            this.checkboxRepairsMCCCond2 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsPH1 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsPH2 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsFWP2 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsPH3 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsMCCCond1 = new System.Windows.Forms.CheckBox();
            this.checkboxRepairsFWP1 = new System.Windows.Forms.CheckBox();
            this.labelRepairHint = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelDoubleClickEasterEgg = new System.Windows.Forms.Label();
            this.groupPower.SuspendLayout();
            this.groupRepair.SuspendLayout();
            this.groupRepairMarkers.SuspendLayout();
            this.repairsGroupReactor.SuspendLayout();
            this.repairsGroupCondenser.SuspendLayout();
            this.repairsGroupMCC.SuspendLayout();
            this.SuspendLayout();
            //
            // groupPower
            //
            this.groupPower.Controls.Add(this.labelPowerExtraText);
            this.groupPower.Controls.Add(this.textboxPowerOutputFlow);
            this.groupPower.Controls.Add(this.labelFWFlow);
            this.groupPower.Controls.Add(this.label1);
            this.groupPower.Controls.Add(this.labelPlantUsage);
            this.groupPower.Controls.Add(this.labelDemand);
            this.groupPower.Controls.Add(this.labelPowerDescription);
            this.groupPower.Controls.Add(this.textboxPowerInputPlantUsage);
            this.groupPower.Controls.Add(this.textboxPowerOutputAPR);
            this.groupPower.Controls.Add(this.textboxPowerInputDemand);
            this.groupPower.Location = new System.Drawing.Point(12, 12);
            this.groupPower.Name = "groupPower";
            this.groupPower.Size = new System.Drawing.Size(260, 255);
            this.groupPower.TabIndex = 0;
            this.groupPower.TabStop = false;
            this.groupPower.Text = "MWe to APR";
            //
            // labelPowerExtraText
            //
            this.labelPowerExtraText.Location = new System.Drawing.Point(6, 180);
            this.labelPowerExtraText.Name = "labelPowerExtraText";
            this.labelPowerExtraText.Size = new System.Drawing.Size(239, 66);
            this.labelPowerExtraText.TabIndex = 9;
            this.labelPowerExtraText.Text = "No calculations performed.";
            this.labelPowerExtraText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // textboxPowerOutputFlow
            //
            this.textboxPowerOutputFlow.Location = new System.Drawing.Point(112, 155);
            this.textboxPowerOutputFlow.Name = "textboxPowerOutputFlow";
            this.textboxPowerOutputFlow.ReadOnly = true;
            this.textboxPowerOutputFlow.Size = new System.Drawing.Size(133, 20);
            this.textboxPowerOutputFlow.TabIndex = 8;
            //
            // labelFWFlow
            //
            this.labelFWFlow.Location = new System.Drawing.Point(6, 158);
            this.labelFWFlow.Name = "labelFWFlow";
            this.labelFWFlow.Size = new System.Drawing.Size(100, 23);
            this.labelFWFlow.TabIndex = 7;
            this.labelFWFlow.Text = "Feedwater Flow";
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "APR";
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
            // labelPowerDescription
            //
            this.labelPowerDescription.Location = new System.Drawing.Point(6, 16);
            this.labelPowerDescription.Name = "labelPowerDescription";
            this.labelPowerDescription.Size = new System.Drawing.Size(239, 58);
            this.labelPowerDescription.TabIndex = 3;
            this.labelPowerDescription.Text = "Used formula assumes that the turbine is running at 7100 kPa and all preheaters a" + "re OK. Fun fact: If you have a different output and the turbine is running at 71" + "00, you have a broken preheater.";
            //
            // textboxPowerInputPlantUsage
            //
            this.textboxPowerInputPlantUsage.Location = new System.Drawing.Point(112, 103);
            this.textboxPowerInputPlantUsage.Name = "textboxPowerInputPlantUsage";
            this.textboxPowerInputPlantUsage.Size = new System.Drawing.Size(133, 20);
            this.textboxPowerInputPlantUsage.TabIndex = 2;
            this.textboxPowerInputPlantUsage.Text = "61.32";
            this.textboxPowerInputPlantUsage.TextChanged += new System.EventHandler(this.ForceRecalculationLoad);
            //
            // textboxPowerOutputAPR
            //
            this.textboxPowerOutputAPR.Location = new System.Drawing.Point(112, 129);
            this.textboxPowerOutputAPR.Name = "textboxPowerOutputAPR";
            this.textboxPowerOutputAPR.Size = new System.Drawing.Size(133, 20);
            this.textboxPowerOutputAPR.TabIndex = 1;
            this.textboxPowerOutputAPR.TextChanged += new System.EventHandler(this.ForceRecalculationAPRUpdated);
            //
            // textboxPowerInputDemand
            //
            this.textboxPowerInputDemand.Location = new System.Drawing.Point(112, 77);
            this.textboxPowerInputDemand.Name = "textboxPowerInputDemand";
            this.textboxPowerInputDemand.Size = new System.Drawing.Size(133, 20);
            this.textboxPowerInputDemand.TabIndex = 0;
            this.textboxPowerInputDemand.TextChanged += new System.EventHandler(this.ForceRecalculationLoad);
            //
            // groupRepair
            //
            this.groupRepair.Controls.Add(this.labelRepairExtraText);
            this.groupRepair.Controls.Add(this.labelRepairInputTime);
            this.groupRepair.Controls.Add(this.textboxInputRepairTime);
            this.groupRepair.Controls.Add(this.textboxRepairInputSoloPump);
            this.groupRepair.Controls.Add(this.textboxInputRepairFlow);
            this.groupRepair.Controls.Add(this.labelCRPumpCapacity);
            this.groupRepair.Controls.Add(this.labelCROutflow);
            this.groupRepair.Controls.Add(this.labelRepairDescription);
            this.groupRepair.Location = new System.Drawing.Point(278, 12);
            this.groupRepair.Name = "groupRepair";
            this.groupRepair.Size = new System.Drawing.Size(275, 255);
            this.groupRepair.TabIndex = 1;
            this.groupRepair.TabStop = false;
            this.groupRepair.Text = "MCC Repair Assist";
            //
            // labelRepairExtraText
            //
            this.labelRepairExtraText.Location = new System.Drawing.Point(6, 180);
            this.labelRepairExtraText.Name = "labelRepairExtraText";
            this.labelRepairExtraText.Size = new System.Drawing.Size(263, 66);
            this.labelRepairExtraText.TabIndex = 7;
            this.labelRepairExtraText.Text = "No calculations performed";
            this.labelRepairExtraText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // labelRepairInputTime
            //
            this.labelRepairInputTime.Location = new System.Drawing.Point(6, 153);
            this.labelRepairInputTime.Name = "labelRepairInputTime";
            this.labelRepairInputTime.Size = new System.Drawing.Size(148, 23);
            this.labelRepairInputTime.TabIndex = 6;
            this.labelRepairInputTime.Text = "Expected Repairs Time";
            this.labelRepairInputTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // textboxInputRepairTime
            //
            this.textboxInputRepairTime.Location = new System.Drawing.Point(169, 155);
            this.textboxInputRepairTime.Name = "textboxInputRepairTime";
            this.textboxInputRepairTime.Size = new System.Drawing.Size(100, 20);
            this.textboxInputRepairTime.TabIndex = 5;
            this.textboxInputRepairTime.Text = "330";
            this.textboxInputRepairTime.TextChanged += new System.EventHandler(this.ForceRecalculationColdRun);
            //
            // textboxRepairInputSoloPump
            //
            this.textboxRepairInputSoloPump.Location = new System.Drawing.Point(169, 129);
            this.textboxRepairInputSoloPump.Name = "textboxRepairInputSoloPump";
            this.textboxRepairInputSoloPump.Size = new System.Drawing.Size(100, 20);
            this.textboxRepairInputSoloPump.TabIndex = 4;
            this.textboxRepairInputSoloPump.TextChanged += new System.EventHandler(this.ForceRecalculationColdRun);
            //
            // textboxInputRepairFlow
            //
            this.textboxInputRepairFlow.Location = new System.Drawing.Point(169, 103);
            this.textboxInputRepairFlow.Name = "textboxInputRepairFlow";
            this.textboxInputRepairFlow.Size = new System.Drawing.Size(100, 20);
            this.textboxInputRepairFlow.TabIndex = 3;
            this.textboxInputRepairFlow.TextChanged += new System.EventHandler(this.ForceRecalculationColdRun);
            //
            // labelCRPumpCapacity
            //
            this.labelCRPumpCapacity.Location = new System.Drawing.Point(6, 128);
            this.labelCRPumpCapacity.Name = "labelCRPumpCapacity";
            this.labelCRPumpCapacity.Size = new System.Drawing.Size(111, 22);
            this.labelCRPumpCapacity.TabIndex = 2;
            this.labelCRPumpCapacity.Text = "Solo Pump Capacity";
            this.labelCRPumpCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // labelCROutflow
            //
            this.labelCROutflow.Location = new System.Drawing.Point(6, 101);
            this.labelCROutflow.Name = "labelCROutflow";
            this.labelCROutflow.Size = new System.Drawing.Size(111, 23);
            this.labelCROutflow.TabIndex = 1;
            this.labelCROutflow.Text = "RPV Outflow ";
            this.labelCROutflow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // labelRepairDescription
            //
            this.labelRepairDescription.Location = new System.Drawing.Point(6, 15);
            this.labelRepairDescription.Name = "labelRepairDescription";
            this.labelRepairDescription.Size = new System.Drawing.Size(263, 85);
            this.labelRepairDescription.TabIndex = 0;
            this.labelRepairDescription.Text = resources.GetString("labelRepairDescription.Text");
            //
            // groupRepairMarkers
            //
            this.groupRepairMarkers.Controls.Add(this.repairsGroupReactor);
            this.groupRepairMarkers.Controls.Add(this.repairsGroupCondenser);
            this.groupRepairMarkers.Controls.Add(this.repairsGroupMCC);
            this.groupRepairMarkers.Controls.Add(this.labelRepairHint);
            this.groupRepairMarkers.Location = new System.Drawing.Point(559, 12);
            this.groupRepairMarkers.Name = "groupRepairMarkers";
            this.groupRepairMarkers.Size = new System.Drawing.Size(275, 255);
            this.groupRepairMarkers.TabIndex = 2;
            this.groupRepairMarkers.TabStop = false;
            this.groupRepairMarkers.Text = "Repairs Flagger";
            //
            // repairsGroupReactor
            //
            this.repairsGroupReactor.Controls.Add(this.checkboxRepairsReactorRecirc1);
            this.repairsGroupReactor.Controls.Add(this.checkboxRepairsReactorRecirc2);
            this.repairsGroupReactor.Location = new System.Drawing.Point(148, 161);
            this.repairsGroupReactor.Name = "repairsGroupReactor";
            this.repairsGroupReactor.Size = new System.Drawing.Size(121, 88);
            this.repairsGroupReactor.TabIndex = 3;
            this.repairsGroupReactor.TabStop = false;
            this.repairsGroupReactor.Text = "Reactor";
            //
            // checkboxRepairsReactorRecirc1
            //
            this.checkboxRepairsReactorRecirc1.Location = new System.Drawing.Point(6, 19);
            this.checkboxRepairsReactorRecirc1.Name = "checkboxRepairsReactorRecirc1";
            this.checkboxRepairsReactorRecirc1.Size = new System.Drawing.Size(104, 24);
            this.checkboxRepairsReactorRecirc1.TabIndex = 2;
            this.checkboxRepairsReactorRecirc1.Text = "Recirc 1";
            this.checkboxRepairsReactorRecirc1.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsReactorRecirc2
            //
            this.checkboxRepairsReactorRecirc2.Location = new System.Drawing.Point(6, 38);
            this.checkboxRepairsReactorRecirc2.Name = "checkboxRepairsReactorRecirc2";
            this.checkboxRepairsReactorRecirc2.Size = new System.Drawing.Size(104, 24);
            this.checkboxRepairsReactorRecirc2.TabIndex = 4;
            this.checkboxRepairsReactorRecirc2.Text = "Recirc 2";
            this.checkboxRepairsReactorRecirc2.UseVisualStyleBackColor = true;
            //
            // repairsGroupCondenser
            //
            this.repairsGroupCondenser.Controls.Add(this.checkboxRepairsCondenserRecirc2);
            this.repairsGroupCondenser.Controls.Add(this.checkboxRepairsCondenserRecirc1);
            this.repairsGroupCondenser.Location = new System.Drawing.Point(148, 77);
            this.repairsGroupCondenser.Name = "repairsGroupCondenser";
            this.repairsGroupCondenser.Size = new System.Drawing.Size(121, 84);
            this.repairsGroupCondenser.TabIndex = 3;
            this.repairsGroupCondenser.TabStop = false;
            this.repairsGroupCondenser.Text = "Condenser";
            //
            // checkboxRepairsCondenserRecirc2
            //
            this.checkboxRepairsCondenserRecirc2.Location = new System.Drawing.Point(6, 38);
            this.checkboxRepairsCondenserRecirc2.Name = "checkboxRepairsCondenserRecirc2";
            this.checkboxRepairsCondenserRecirc2.Size = new System.Drawing.Size(104, 24);
            this.checkboxRepairsCondenserRecirc2.TabIndex = 1;
            this.checkboxRepairsCondenserRecirc2.Text = "Recirc 2";
            this.checkboxRepairsCondenserRecirc2.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsCondenserRecirc1
            //
            this.checkboxRepairsCondenserRecirc1.Location = new System.Drawing.Point(6, 19);
            this.checkboxRepairsCondenserRecirc1.Name = "checkboxRepairsCondenserRecirc1";
            this.checkboxRepairsCondenserRecirc1.Size = new System.Drawing.Size(104, 24);
            this.checkboxRepairsCondenserRecirc1.TabIndex = 0;
            this.checkboxRepairsCondenserRecirc1.Text = "Recirc 1";
            this.checkboxRepairsCondenserRecirc1.UseVisualStyleBackColor = true;
            //
            // repairsGroupMCC
            //
            this.repairsGroupMCC.Controls.Add(this.checkboxRepairsMCCCond2);
            this.repairsGroupMCC.Controls.Add(this.checkboxRepairsPH1);
            this.repairsGroupMCC.Controls.Add(this.checkboxRepairsPH2);
            this.repairsGroupMCC.Controls.Add(this.checkboxRepairsFWP2);
            this.repairsGroupMCC.Controls.Add(this.checkboxRepairsPH3);
            this.repairsGroupMCC.Controls.Add(this.checkboxRepairsMCCCond1);
            this.repairsGroupMCC.Controls.Add(this.checkboxRepairsFWP1);
            this.repairsGroupMCC.Location = new System.Drawing.Point(6, 77);
            this.repairsGroupMCC.Name = "repairsGroupMCC";
            this.repairsGroupMCC.Size = new System.Drawing.Size(136, 172);
            this.repairsGroupMCC.TabIndex = 19;
            this.repairsGroupMCC.TabStop = false;
            this.repairsGroupMCC.Text = "MCC";
            //
            // checkboxRepairsMCCCond2
            //
            this.checkboxRepairsMCCCond2.Location = new System.Drawing.Point(6, 96);
            this.checkboxRepairsMCCCond2.Name = "checkboxRepairsMCCCond2";
            this.checkboxRepairsMCCCond2.Size = new System.Drawing.Size(96, 20);
            this.checkboxRepairsMCCCond2.TabIndex = 18;
            this.checkboxRepairsMCCCond2.Text = "Cond 2";
            this.checkboxRepairsMCCCond2.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsPH1
            //
            this.checkboxRepairsPH1.Location = new System.Drawing.Point(6, 19);
            this.checkboxRepairsPH1.Name = "checkboxRepairsPH1";
            this.checkboxRepairsPH1.Size = new System.Drawing.Size(96, 20);
            this.checkboxRepairsPH1.TabIndex = 12;
            this.checkboxRepairsPH1.Text = "PH1";
            this.checkboxRepairsPH1.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsPH2
            //
            this.checkboxRepairsPH2.Location = new System.Drawing.Point(6, 36);
            this.checkboxRepairsPH2.Name = "checkboxRepairsPH2";
            this.checkboxRepairsPH2.Size = new System.Drawing.Size(96, 20);
            this.checkboxRepairsPH2.TabIndex = 14;
            this.checkboxRepairsPH2.Text = "PH2";
            this.checkboxRepairsPH2.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsFWP2
            //
            this.checkboxRepairsFWP2.Location = new System.Drawing.Point(6, 139);
            this.checkboxRepairsFWP2.Name = "checkboxRepairsFWP2";
            this.checkboxRepairsFWP2.Size = new System.Drawing.Size(96, 20);
            this.checkboxRepairsFWP2.TabIndex = 16;
            this.checkboxRepairsFWP2.Text = "FWP2";
            this.checkboxRepairsFWP2.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsPH3
            //
            this.checkboxRepairsPH3.Location = new System.Drawing.Point(6, 53);
            this.checkboxRepairsPH3.Name = "checkboxRepairsPH3";
            this.checkboxRepairsPH3.Size = new System.Drawing.Size(96, 20);
            this.checkboxRepairsPH3.TabIndex = 13;
            this.checkboxRepairsPH3.Text = "PH3";
            this.checkboxRepairsPH3.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsMCCCond1
            //
            this.checkboxRepairsMCCCond1.Location = new System.Drawing.Point(6, 79);
            this.checkboxRepairsMCCCond1.Name = "checkboxRepairsMCCCond1";
            this.checkboxRepairsMCCCond1.Size = new System.Drawing.Size(96, 20);
            this.checkboxRepairsMCCCond1.TabIndex = 17;
            this.checkboxRepairsMCCCond1.Text = "Cond 1";
            this.checkboxRepairsMCCCond1.UseVisualStyleBackColor = true;
            //
            // checkboxRepairsFWP1
            //
            this.checkboxRepairsFWP1.Location = new System.Drawing.Point(6, 122);
            this.checkboxRepairsFWP1.Name = "checkboxRepairsFWP1";
            this.checkboxRepairsFWP1.Size = new System.Drawing.Size(96, 20);
            this.checkboxRepairsFWP1.TabIndex = 15;
            this.checkboxRepairsFWP1.Text = "FWP1";
            this.checkboxRepairsFWP1.UseVisualStyleBackColor = true;
            //
            // labelRepairHint
            //
            this.labelRepairHint.Location = new System.Drawing.Point(6, 16);
            this.labelRepairHint.Name = "labelRepairHint";
            this.labelRepairHint.Size = new System.Drawing.Size(263, 63);
            this.labelRepairHint.TabIndex = 0;
            this.labelRepairHint.Text = "This section contains checkmarks that you can use to mark broken stuff. While you" + " could just use in-game clipboard, this might be useful if you get disconnected " + "from time to time.\r\n";
            //
            // labelCredit
            //
            this.labelCredit.Location = new System.Drawing.Point(12, 270);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(822, 23);
            this.labelCredit.TabIndex = 3;
            this.labelCredit.Text = "Created by Treeshold (artv1505). ~ Please announce RSTs or shutdowns before tripp" + "ing stuff. PA exists for this sole reason.";
            //
            // labelDoubleClickEasterEgg
            //
            this.labelDoubleClickEasterEgg.Location = new System.Drawing.Point(12, 300);
            this.labelDoubleClickEasterEgg.Name = "labelDoubleClickEasterEgg";
            this.labelDoubleClickEasterEgg.Size = new System.Drawing.Size(822, 23);
            this.labelDoubleClickEasterEgg.TabIndex = 3;
            this.labelDoubleClickEasterEgg.Text = "You are not a good person. You know this, right?";
            //
            // Form
            //
            this.ClientSize = new System.Drawing.Size(843, 291);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.labelDoubleClickEasterEgg);
            this.Controls.Add(this.groupRepairMarkers);
            this.Controls.Add(this.groupRepair);
            this.Controls.Add(this.groupPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form";
            this.Text = "RBWR thingy";
            this.Shown += new System.EventHandler(this.Loaded);
            this.groupPower.ResumeLayout(false);
            this.groupPower.PerformLayout();
            this.groupRepair.ResumeLayout(false);
            this.groupRepair.PerformLayout();
            this.groupRepairMarkers.ResumeLayout(false);
            this.repairsGroupReactor.ResumeLayout(false);
            this.repairsGroupCondenser.ResumeLayout(false);
            this.repairsGroupMCC.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelDoubleClickEasterEgg;

        private System.Windows.Forms.GroupBox repairsGroupReactor;
        private System.Windows.Forms.CheckBox checkboxRepairsReactorRecirc2;
        private System.Windows.Forms.CheckBox checkboxRepairsReactorRecirc1;

        private System.Windows.Forms.GroupBox repairsGroupCondenser;
        private System.Windows.Forms.CheckBox checkboxRepairsCondenserRecirc1;
        private System.Windows.Forms.CheckBox checkboxRepairsCondenserRecirc2;

        private System.Windows.Forms.CheckBox checkboxRepairsPH1;
        private System.Windows.Forms.CheckBox checkboxRepairsPH3;
        private System.Windows.Forms.CheckBox checkboxRepairsPH2;
        private System.Windows.Forms.CheckBox checkboxRepairsFWP1;
        private System.Windows.Forms.CheckBox checkboxRepairsFWP2;
        private System.Windows.Forms.CheckBox checkboxRepairsMCCCond1;
        private System.Windows.Forms.CheckBox checkboxRepairsMCCCond2;
        private System.Windows.Forms.GroupBox repairsGroupMCC;

        private System.Windows.Forms.GroupBox groupRepairMarkers;
        private System.Windows.Forms.Label labelRepairHint;

        private System.Windows.Forms.TextBox textboxInputRepairTime;
        private System.Windows.Forms.Label labelRepairInputTime;

        private System.Windows.Forms.Label labelCROutflow;

        private System.Windows.Forms.TextBox textboxRepairInputSoloPump;

        private System.Windows.Forms.TextBox textboxInputRepairFlow;

        private System.Windows.Forms.Label labelRepairExtraText;

        private System.Windows.Forms.Label labelRepairDescription;

        private System.Windows.Forms.GroupBox groupRepair;

        private System.Windows.Forms.Label labelPowerExtraText;

        private System.Windows.Forms.TextBox textboxPowerOutputFlow;

        private System.Windows.Forms.Label labelFWFlow;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelDemand;

        private System.Windows.Forms.Label labelPowerDescription;
        private System.Windows.Forms.Label labelPlantUsage;

        private System.Windows.Forms.TextBox textboxPowerInputPlantUsage;

        private System.Windows.Forms.TextBox textboxPowerInputDemand;
        private System.Windows.Forms.TextBox textboxPowerOutputAPR;

        private System.Windows.Forms.GroupBox groupPower;

        private System.Windows.Forms.Label labelCRPumpCapacity;

        #endregion
    }
}