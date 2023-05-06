
namespace WindowsFormsApp1
{
    partial class Settings
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
                this.f1.isCompact = false;
                this.f1.CalculateProfit();
                this.f1.Show();
                this.Hide();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.DarkModeCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.HidingOption = new System.Windows.Forms.CheckBox();
            this.pathTitle = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathShowButton = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ResetOverlay = new System.Windows.Forms.Button();
            this.FlagProfUse = new System.Windows.Forms.CheckBox();
            this.MobsKilled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MobsKilledPointEvery = new System.Windows.Forms.TextBox();
            this.NumOfLinesLabel = new System.Windows.Forms.Label();
            this.MobsKilledNumLines = new System.Windows.Forms.TextBox();
            this.MobsKilledAutoSize = new System.Windows.Forms.CheckBox();
            this.MiningMode = new System.Windows.Forms.CheckBox();
            this.DPSOnTime = new System.Windows.Forms.CheckBox();
            this.SecBeforeAFKTimerBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsingEButton = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSGIO = new System.Windows.Forms.CheckBox();
            this.ScrollingGearOverlay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChooseColorDM = new System.Windows.Forms.Button();
            this.ChooseColorDMText = new System.Windows.Forms.Button();
            this.ChooseColorDMStat = new System.Windows.Forms.Button();
            this.checkBoxLootAmmo = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupTeam = new System.Windows.Forms.CheckBox();
            this.NickName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonResetGlobals = new System.Windows.Forms.Button();
            this.checkBoxOutValue = new System.Windows.Forms.CheckBox();
            this.checkBoxUnusedItems = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DarkModeCheck
            // 
            this.DarkModeCheck.AutoSize = true;
            this.DarkModeCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DarkModeCheck.Location = new System.Drawing.Point(2, 32);
            this.DarkModeCheck.Name = "DarkModeCheck";
            this.DarkModeCheck.Size = new System.Drawing.Size(76, 17);
            this.DarkModeCheck.TabIndex = 105;
            this.DarkModeCheck.Text = "DarkMode";
            this.DarkModeCheck.UseVisualStyleBackColor = true;
            this.DarkModeCheck.CheckedChanged += new System.EventHandler(this.DarkModeCheck_CheckedChanged);
            // 
            // checkBoxBackup
            // 
            this.checkBoxBackup.AutoSize = true;
            this.checkBoxBackup.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxBackup.Location = new System.Drawing.Point(99, 78);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(65, 17);
            this.checkBoxBackup.TabIndex = 106;
            this.checkBoxBackup.Text = "BackUp";
            this.checkBoxBackup.UseVisualStyleBackColor = true;
            this.checkBoxBackup.CheckedChanged += new System.EventHandler(this.checkBoxBackup_CheckedChanged);
            this.checkBoxBackup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBoxBackup_MouseMove);
            // 
            // HidingOption
            // 
            this.HidingOption.AutoSize = true;
            this.HidingOption.Location = new System.Drawing.Point(14, 55);
            this.HidingOption.Name = "HidingOption";
            this.HidingOption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HidingOption.Size = new System.Drawing.Size(96, 17);
            this.HidingOption.TabIndex = 113;
            this.HidingOption.Text = "NotHidingMain";
            this.HidingOption.UseVisualStyleBackColor = true;
            this.HidingOption.CheckedChanged += new System.EventHandler(this.HidingOption_CheckedChanged);
            this.HidingOption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HidingOption_MouseMove);
            // 
            // pathTitle
            // 
            this.pathTitle.AutoSize = true;
            this.pathTitle.Location = new System.Drawing.Point(3, 9);
            this.pathTitle.Name = "pathTitle";
            this.pathTitle.Size = new System.Drawing.Size(82, 13);
            this.pathTitle.TabIndex = 114;
            this.pathTitle.Text = "Chat Log Folder";
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(91, 6);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(137, 20);
            this.pathText.TabIndex = 115;
            // 
            // pathShowButton
            // 
            this.pathShowButton.Location = new System.Drawing.Point(234, 5);
            this.pathShowButton.Name = "pathShowButton";
            this.pathShowButton.Size = new System.Drawing.Size(25, 21);
            this.pathShowButton.TabIndex = 116;
            this.pathShowButton.Text = "···";
            this.pathShowButton.UseVisualStyleBackColor = true;
            this.pathShowButton.Click += new System.EventHandler(this.pathShowButton_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonSave.Location = new System.Drawing.Point(105, 364);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(48, 26);
            this.ButtonSave.TabIndex = 117;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.ButtonSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonSave_MouseMove);
            // 
            // ResetOverlay
            // 
            this.ResetOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ResetOverlay.Location = new System.Drawing.Point(3, 364);
            this.ResetOverlay.Name = "ResetOverlay";
            this.ResetOverlay.Size = new System.Drawing.Size(96, 26);
            this.ResetOverlay.TabIndex = 118;
            this.ResetOverlay.Text = "ResetOverlay";
            this.ResetOverlay.UseVisualStyleBackColor = false;
            this.ResetOverlay.Click += new System.EventHandler(this.ResetOverlay_Click);
            // 
            // FlagProfUse
            // 
            this.FlagProfUse.AutoSize = true;
            this.FlagProfUse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FlagProfUse.Location = new System.Drawing.Point(88, 32);
            this.FlagProfUse.Name = "FlagProfUse";
            this.FlagProfUse.Size = new System.Drawing.Size(83, 17);
            this.FlagProfUse.TabIndex = 119;
            this.FlagProfUse.Text = "BindButtons";
            this.FlagProfUse.UseVisualStyleBackColor = true;
            this.FlagProfUse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FlagProfUse_MouseMove);
            // 
            // MobsKilled
            // 
            this.MobsKilled.Enabled = false;
            this.MobsKilled.Location = new System.Drawing.Point(39, 231);
            this.MobsKilled.Name = "MobsKilled";
            this.MobsKilled.Size = new System.Drawing.Size(46, 20);
            this.MobsKilled.TabIndex = 120;
            this.MobsKilled.Text = "100";
            this.MobsKilled.TextChanged += new System.EventHandler(this.MobsKilled_TextChanged);
            this.MobsKilled.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobsKilled_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "MobsKilled Point Every";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Show Every X Point";
            // 
            // MobsKilledPointEvery
            // 
            this.MobsKilledPointEvery.Enabled = false;
            this.MobsKilledPointEvery.Location = new System.Drawing.Point(51, 252);
            this.MobsKilledPointEvery.Name = "MobsKilledPointEvery";
            this.MobsKilledPointEvery.Size = new System.Drawing.Size(34, 20);
            this.MobsKilledPointEvery.TabIndex = 120;
            this.MobsKilledPointEvery.Text = "1";
            this.MobsKilledPointEvery.TextChanged += new System.EventHandler(this.MobsKilledPointEvery_TextChanged);
            this.MobsKilledPointEvery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobsKilledPointEvery_KeyPress);
            // 
            // NumOfLinesLabel
            // 
            this.NumOfLinesLabel.AccessibleDescription = "Applies after 10 points";
            this.NumOfLinesLabel.AutoSize = true;
            this.NumOfLinesLabel.Location = new System.Drawing.Point(89, 276);
            this.NumOfLinesLabel.Name = "NumOfLinesLabel";
            this.NumOfLinesLabel.Size = new System.Drawing.Size(146, 13);
            this.NumOfLinesLabel.TabIndex = 123;
            this.NumOfLinesLabel.Text = "Num of lines MobsKilled(±1-2)";
            this.NumOfLinesLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumOfLinesLable_MouseMove);
            // 
            // MobsKilledNumLines
            // 
            this.MobsKilledNumLines.Location = new System.Drawing.Point(51, 273);
            this.MobsKilledNumLines.Name = "MobsKilledNumLines";
            this.MobsKilledNumLines.Size = new System.Drawing.Size(34, 20);
            this.MobsKilledNumLines.TabIndex = 124;
            this.MobsKilledNumLines.Text = "10";
            this.MobsKilledNumLines.TextChanged += new System.EventHandler(this.MobsKilledNumLines_TextChanged);
            this.MobsKilledNumLines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobsKilledNumLines_KeyPress);
            // 
            // MobsKilledAutoSize
            // 
            this.MobsKilledAutoSize.AutoSize = true;
            this.MobsKilledAutoSize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MobsKilledAutoSize.Checked = true;
            this.MobsKilledAutoSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MobsKilledAutoSize.Location = new System.Drawing.Point(89, 297);
            this.MobsKilledAutoSize.Name = "MobsKilledAutoSize";
            this.MobsKilledAutoSize.Size = new System.Drawing.Size(88, 17);
            this.MobsKilledAutoSize.TabIndex = 125;
            this.MobsKilledAutoSize.Text = "AutoSizeGraf";
            this.MobsKilledAutoSize.UseVisualStyleBackColor = true;
            this.MobsKilledAutoSize.CheckedChanged += new System.EventHandler(this.MobsKilledAutoSize_CheckedChanged);
            this.MobsKilledAutoSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MobsKilledAutoSize_MouseMove);
            // 
            // MiningMode
            // 
            this.MiningMode.AutoSize = true;
            this.MiningMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MiningMode.Location = new System.Drawing.Point(175, 32);
            this.MiningMode.Name = "MiningMode";
            this.MiningMode.Size = new System.Drawing.Size(87, 17);
            this.MiningMode.TabIndex = 126;
            this.MiningMode.Text = "Mining Mode";
            this.MiningMode.UseVisualStyleBackColor = true;
            this.MiningMode.CheckedChanged += new System.EventHandler(this.MiningMode_CheckedChanged);
            this.MiningMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MiningMode_MouseMove);
            // 
            // DPSOnTime
            // 
            this.DPSOnTime.AutoSize = true;
            this.DPSOnTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DPSOnTime.Location = new System.Drawing.Point(167, 124);
            this.DPSOnTime.Name = "DPSOnTime";
            this.DPSOnTime.Size = new System.Drawing.Size(85, 17);
            this.DPSOnTime.TabIndex = 127;
            this.DPSOnTime.Text = "DPSOnTime";
            this.DPSOnTime.UseVisualStyleBackColor = true;
            this.DPSOnTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DPSOnTime_MouseMove);
            // 
            // SecBeforeAFKTimerBox
            // 
            this.SecBeforeAFKTimerBox.Location = new System.Drawing.Point(48, 192);
            this.SecBeforeAFKTimerBox.Name = "SecBeforeAFKTimerBox";
            this.SecBeforeAFKTimerBox.Size = new System.Drawing.Size(34, 20);
            this.SecBeforeAFKTimerBox.TabIndex = 128;
            this.SecBeforeAFKTimerBox.Text = "60";
            this.SecBeforeAFKTimerBox.TextChanged += new System.EventHandler(this.SecBeforeAFKTimerBox_TextChanged);
            this.SecBeforeAFKTimerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecBeforeAFKTimerBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 129;
            this.label3.Text = "Seconds Before Stop Timer";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // UsingEButton
            // 
            this.UsingEButton.AutoSize = true;
            this.UsingEButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsingEButton.Location = new System.Drawing.Point(2, 78);
            this.UsingEButton.Name = "UsingEButton";
            this.UsingEButton.Size = new System.Drawing.Size(91, 17);
            this.UsingEButton.TabIndex = 130;
            this.UsingEButton.Text = "UsingEButton";
            this.UsingEButton.UseVisualStyleBackColor = true;
            this.UsingEButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UsingEButton_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 131;
            this.label4.Text = "TT Return Graf";
            // 
            // checkBoxSGIO
            // 
            this.checkBoxSGIO.AutoSize = true;
            this.checkBoxSGIO.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSGIO.Checked = true;
            this.checkBoxSGIO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSGIO.Location = new System.Drawing.Point(123, 101);
            this.checkBoxSGIO.Name = "checkBoxSGIO";
            this.checkBoxSGIO.Size = new System.Drawing.Size(130, 17);
            this.checkBoxSGIO.TabIndex = 134;
            this.checkBoxSGIO.Text = "Show Gear In Overlay";
            this.checkBoxSGIO.UseVisualStyleBackColor = true;
            // 
            // ScrollingGearOverlay
            // 
            this.ScrollingGearOverlay.Location = new System.Drawing.Point(48, 171);
            this.ScrollingGearOverlay.Name = "ScrollingGearOverlay";
            this.ScrollingGearOverlay.Size = new System.Drawing.Size(34, 20);
            this.ScrollingGearOverlay.TabIndex = 128;
            this.ScrollingGearOverlay.Text = "0";
            this.ScrollingGearOverlay.TextChanged += new System.EventHandler(this.SecBeforeAFKTimerBox_TextChanged);
            this.ScrollingGearOverlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecBeforeAFKTimerBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 129;
            this.label5.Text = "Speed Of Scroll In Overlay";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // ChooseColorDM
            // 
            this.ChooseColorDM.Location = new System.Drawing.Point(3, 319);
            this.ChooseColorDM.Name = "ChooseColorDM";
            this.ChooseColorDM.Size = new System.Drawing.Size(86, 39);
            this.ChooseColorDM.TabIndex = 135;
            this.ChooseColorDM.Text = "Choose Color For DM Back";
            this.ChooseColorDM.UseVisualStyleBackColor = true;
            this.ChooseColorDM.Click += new System.EventHandler(this.ChooseColorDM_Click);
            // 
            // ChooseColorDMText
            // 
            this.ChooseColorDMText.Location = new System.Drawing.Point(91, 319);
            this.ChooseColorDMText.Name = "ChooseColorDMText";
            this.ChooseColorDMText.Size = new System.Drawing.Size(80, 39);
            this.ChooseColorDMText.TabIndex = 136;
            this.ChooseColorDMText.Text = "Choose Color For DM Text";
            this.ChooseColorDMText.UseVisualStyleBackColor = true;
            this.ChooseColorDMText.Click += new System.EventHandler(this.ChooseColorDMText_Click);
            // 
            // ChooseColorDMStat
            // 
            this.ChooseColorDMStat.Location = new System.Drawing.Point(173, 319);
            this.ChooseColorDMStat.Name = "ChooseColorDMStat";
            this.ChooseColorDMStat.Size = new System.Drawing.Size(90, 39);
            this.ChooseColorDMStat.TabIndex = 137;
            this.ChooseColorDMStat.Text = "Choose Color For DM Stat";
            this.ChooseColorDMStat.UseVisualStyleBackColor = true;
            this.ChooseColorDMStat.Click += new System.EventHandler(this.ChooseColorDMStat_Click);
            // 
            // checkBoxLootAmmo
            // 
            this.checkBoxLootAmmo.AutoSize = true;
            this.checkBoxLootAmmo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLootAmmo.Location = new System.Drawing.Point(9, 101);
            this.checkBoxLootAmmo.Name = "checkBoxLootAmmo";
            this.checkBoxLootAmmo.Size = new System.Drawing.Size(108, 17);
            this.checkBoxLootAmmo.TabIndex = 138;
            this.checkBoxLootAmmo.Text = "Loot% AmmoCost";
            this.checkBoxLootAmmo.UseVisualStyleBackColor = true;
            this.checkBoxLootAmmo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBoxLootAmmo_MouseMove);
            // 
            // checkBoxBackupTeam
            // 
            this.checkBoxBackupTeam.AutoSize = true;
            this.checkBoxBackupTeam.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxBackupTeam.Location = new System.Drawing.Point(167, 78);
            this.checkBoxBackupTeam.Name = "checkBoxBackupTeam";
            this.checkBoxBackupTeam.Size = new System.Drawing.Size(95, 17);
            this.checkBoxBackupTeam.TabIndex = 106;
            this.checkBoxBackupTeam.Text = "Team BackUp";
            this.checkBoxBackupTeam.UseVisualStyleBackColor = true;
            this.checkBoxBackupTeam.CheckedChanged += new System.EventHandler(this.checkBoxBackupTeam_CheckedChanged);
            this.checkBoxBackupTeam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBoxBackupTeam_MouseMove);
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(86, 145);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(171, 20);
            this.NickName.TabIndex = 120;
            this.NickName.Text = "Testing Nick Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 139;
            this.label6.Text = "Nick In Game:";
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // buttonResetGlobals
            // 
            this.buttonResetGlobals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonResetGlobals.Location = new System.Drawing.Point(159, 364);
            this.buttonResetGlobals.Name = "buttonResetGlobals";
            this.buttonResetGlobals.Size = new System.Drawing.Size(104, 26);
            this.buttonResetGlobals.TabIndex = 140;
            this.buttonResetGlobals.Text = "Reset Globals";
            this.buttonResetGlobals.UseVisualStyleBackColor = false;
            this.buttonResetGlobals.Click += new System.EventHandler(this.buttonResetGlobals_Click);
            // 
            // checkBoxOutValue
            // 
            this.checkBoxOutValue.AutoSize = true;
            this.checkBoxOutValue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOutValue.Location = new System.Drawing.Point(9, 124);
            this.checkBoxOutValue.Name = "checkBoxOutValue";
            this.checkBoxOutValue.Size = new System.Drawing.Size(146, 17);
            this.checkBoxOutValue.TabIndex = 141;
            this.checkBoxOutValue.Text = "Output decay\\loot values";
            this.checkBoxOutValue.UseVisualStyleBackColor = true;
            this.checkBoxOutValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBoxOutValue_MouseMove);
            // 
            // checkBoxUnusedItems
            // 
            this.checkBoxUnusedItems.AutoSize = true;
            this.checkBoxUnusedItems.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUnusedItems.Checked = true;
            this.checkBoxUnusedItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUnusedItems.Location = new System.Drawing.Point(131, 55);
            this.checkBoxUnusedItems.Name = "checkBoxUnusedItems";
            this.checkBoxUnusedItems.Size = new System.Drawing.Size(122, 17);
            this.checkBoxUnusedItems.TabIndex = 142;
            this.checkBoxUnusedItems.Text = "Track Unused Items";
            this.checkBoxUnusedItems.UseVisualStyleBackColor = true;
            this.checkBoxUnusedItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBoxUnusedItems_MouseMove);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 396);
            this.Controls.Add(this.checkBoxUnusedItems);
            this.Controls.Add(this.checkBoxOutValue);
            this.Controls.Add(this.buttonResetGlobals);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxLootAmmo);
            this.Controls.Add(this.ChooseColorDMStat);
            this.Controls.Add(this.ChooseColorDMText);
            this.Controls.Add(this.ChooseColorDM);
            this.Controls.Add(this.checkBoxSGIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumOfLinesLabel);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.MobsKilled);
            this.Controls.Add(this.MobsKilledPointEvery);
            this.Controls.Add(this.UsingEButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScrollingGearOverlay);
            this.Controls.Add(this.SecBeforeAFKTimerBox);
            this.Controls.Add(this.MobsKilledNumLines);
            this.Controls.Add(this.DPSOnTime);
            this.Controls.Add(this.MiningMode);
            this.Controls.Add(this.MobsKilledAutoSize);
            this.Controls.Add(this.FlagProfUse);
            this.Controls.Add(this.ResetOverlay);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.pathShowButton);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.pathTitle);
            this.Controls.Add(this.HidingOption);
            this.Controls.Add(this.checkBoxBackupTeam);
            this.Controls.Add(this.checkBoxBackup);
            this.Controls.Add(this.DarkModeCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(281, 435);
            this.MinimumSize = new System.Drawing.Size(281, 435);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox DarkModeCheck;
        public System.Windows.Forms.CheckBox checkBoxBackup;
        public System.Windows.Forms.CheckBox HidingOption;
        private System.Windows.Forms.Label pathTitle;
        public System.Windows.Forms.TextBox pathText;
        public System.Windows.Forms.Button pathShowButton;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ResetOverlay;
        public System.Windows.Forms.CheckBox FlagProfUse;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MobsKilled;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox MobsKilledPointEvery;
        private System.Windows.Forms.Label NumOfLinesLabel;
        public System.Windows.Forms.TextBox MobsKilledNumLines;
        public System.Windows.Forms.CheckBox MobsKilledAutoSize;
        public System.Windows.Forms.CheckBox MiningMode;
        public System.Windows.Forms.CheckBox DPSOnTime;
        public System.Windows.Forms.TextBox SecBeforeAFKTimerBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox UsingEButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox checkBoxSGIO;
        public System.Windows.Forms.TextBox ScrollingGearOverlay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChooseColorDM;
        private System.Windows.Forms.Button ChooseColorDMText;
        private System.Windows.Forms.Button ChooseColorDMStat;
        public System.Windows.Forms.CheckBox checkBoxLootAmmo;
        public System.Windows.Forms.CheckBox checkBoxBackupTeam;
        public System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonResetGlobals;
        public System.Windows.Forms.CheckBox checkBoxOutValue;
        public System.Windows.Forms.CheckBox checkBoxUnusedItems;
    }
}