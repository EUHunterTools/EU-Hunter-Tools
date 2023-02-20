
namespace WindowsFormsApp1
{
    partial class CostCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostCount));
            this.comboBoxWeaponList = new System.Windows.Forms.ComboBox();
            this.comboBoxAmpList = new System.Windows.Forms.ComboBox();
            this.comboBoxScope = new System.Windows.Forms.ComboBox();
            this.comboBoxLaser1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLaser2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDMGList = new System.Windows.Forms.ComboBox();
            this.comboBoxTool = new System.Windows.Forms.ComboBox();
            this.FlagUsingEMode = new System.Windows.Forms.CheckBox();
            this.WeapontListTxt = new System.Windows.Forms.Label();
            this.AmplifierListTxt = new System.Windows.Forms.Label();
            this.DMGEnhCountTxt = new System.Windows.Forms.Label();
            this.ScopeListTxt = new System.Windows.Forms.Label();
            this.LaserList1Txt = new System.Windows.Forms.Label();
            this.LaserList2Txt = new System.Windows.Forms.Label();
            this.ToolListTxt = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Label();
            this.Prof1 = new System.Windows.Forms.Button();
            this.Prof2 = new System.Windows.Forms.Button();
            this.Prof3 = new System.Windows.Forms.Button();
            this.Prof4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.TextBoxReload = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReloadSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxWeaponList
            // 
            this.comboBoxWeaponList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxWeaponList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxWeaponList.FormattingEnabled = true;
            this.comboBoxWeaponList.Location = new System.Drawing.Point(11, 26);
            this.comboBoxWeaponList.Name = "comboBoxWeaponList";
            this.comboBoxWeaponList.Size = new System.Drawing.Size(158, 21);
            this.comboBoxWeaponList.TabIndex = 0;
            this.comboBoxWeaponList.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeaponList_SelectedIndexChanged_1);
            // 
            // comboBoxAmpList
            // 
            this.comboBoxAmpList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAmpList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAmpList.FormattingEnabled = true;
            this.comboBoxAmpList.Location = new System.Drawing.Point(11, 74);
            this.comboBoxAmpList.Name = "comboBoxAmpList";
            this.comboBoxAmpList.Size = new System.Drawing.Size(158, 21);
            this.comboBoxAmpList.TabIndex = 1;
            this.comboBoxAmpList.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmpList_SelectedIndexChanged_1);
            // 
            // comboBoxScope
            // 
            this.comboBoxScope.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxScope.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxScope.FormattingEnabled = true;
            this.comboBoxScope.Location = new System.Drawing.Point(302, 26);
            this.comboBoxScope.Name = "comboBoxScope";
            this.comboBoxScope.Size = new System.Drawing.Size(144, 21);
            this.comboBoxScope.TabIndex = 2;
            this.comboBoxScope.SelectedIndexChanged += new System.EventHandler(this.comboBoxScope_SelectedIndexChanged);
            // 
            // comboBoxLaser1
            // 
            this.comboBoxLaser1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLaser1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLaser1.FormattingEnabled = true;
            this.comboBoxLaser1.Location = new System.Drawing.Point(175, 26);
            this.comboBoxLaser1.Name = "comboBoxLaser1";
            this.comboBoxLaser1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLaser1.TabIndex = 3;
            this.comboBoxLaser1.SelectedIndexChanged += new System.EventHandler(this.comboBoxLaser1_SelectedIndexChanged);
            // 
            // comboBoxLaser2
            // 
            this.comboBoxLaser2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLaser2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLaser2.FormattingEnabled = true;
            this.comboBoxLaser2.Location = new System.Drawing.Point(175, 74);
            this.comboBoxLaser2.Name = "comboBoxLaser2";
            this.comboBoxLaser2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLaser2.TabIndex = 4;
            this.comboBoxLaser2.SelectedIndexChanged += new System.EventHandler(this.comboBoxLaser2_SelectedIndexChanged);
            // 
            // comboBoxDMGList
            // 
            this.comboBoxDMGList.FormattingEnabled = true;
            this.comboBoxDMGList.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxDMGList.Location = new System.Drawing.Point(302, 74);
            this.comboBoxDMGList.Name = "comboBoxDMGList";
            this.comboBoxDMGList.Size = new System.Drawing.Size(57, 21);
            this.comboBoxDMGList.TabIndex = 5;
            this.comboBoxDMGList.Text = "0";
            this.comboBoxDMGList.SelectedIndexChanged += new System.EventHandler(this.comboBoxDMGList_SelectedIndexChanged);
            // 
            // comboBoxTool
            // 
            this.comboBoxTool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTool.FormattingEnabled = true;
            this.comboBoxTool.Location = new System.Drawing.Point(12, 124);
            this.comboBoxTool.Name = "comboBoxTool";
            this.comboBoxTool.Size = new System.Drawing.Size(157, 21);
            this.comboBoxTool.TabIndex = 6;
            this.comboBoxTool.SelectedIndexChanged += new System.EventHandler(this.comboBoxTool_SelectedIndexChanged);
            // 
            // FlagUsingEMode
            // 
            this.FlagUsingEMode.AutoSize = true;
            this.FlagUsingEMode.Location = new System.Drawing.Point(34, 55);
            this.FlagUsingEMode.Name = "FlagUsingEMode";
            this.FlagUsingEMode.Size = new System.Drawing.Size(92, 17);
            this.FlagUsingEMode.TabIndex = 7;
            this.FlagUsingEMode.Text = "Using E mode";
            this.FlagUsingEMode.UseVisualStyleBackColor = true;
            this.FlagUsingEMode.CheckedChanged += new System.EventHandler(this.FlagUsingEMode_CheckedChanged);
            // 
            // WeapontListTxt
            // 
            this.WeapontListTxt.AutoSize = true;
            this.WeapontListTxt.Location = new System.Drawing.Point(13, 9);
            this.WeapontListTxt.Name = "WeapontListTxt";
            this.WeapontListTxt.Size = new System.Drawing.Size(67, 13);
            this.WeapontListTxt.TabIndex = 8;
            this.WeapontListTxt.Text = "WeapontList";
            // 
            // AmplifierListTxt
            // 
            this.AmplifierListTxt.AutoSize = true;
            this.AmplifierListTxt.Location = new System.Drawing.Point(12, 57);
            this.AmplifierListTxt.Name = "AmplifierListTxt";
            this.AmplifierListTxt.Size = new System.Drawing.Size(62, 13);
            this.AmplifierListTxt.TabIndex = 9;
            this.AmplifierListTxt.Text = "AmplifierList";
            // 
            // DMGEnhCountTxt
            // 
            this.DMGEnhCountTxt.AutoSize = true;
            this.DMGEnhCountTxt.Location = new System.Drawing.Point(298, 57);
            this.DMGEnhCountTxt.Name = "DMGEnhCountTxt";
            this.DMGEnhCountTxt.Size = new System.Drawing.Size(61, 13);
            this.DMGEnhCountTxt.TabIndex = 10;
            this.DMGEnhCountTxt.Text = "DMG Enh\'s";
            // 
            // ScopeListTxt
            // 
            this.ScopeListTxt.AutoSize = true;
            this.ScopeListTxt.Location = new System.Drawing.Point(299, 9);
            this.ScopeListTxt.Name = "ScopeListTxt";
            this.ScopeListTxt.Size = new System.Drawing.Size(54, 13);
            this.ScopeListTxt.TabIndex = 11;
            this.ScopeListTxt.Text = "ScopeList";
            // 
            // LaserList1Txt
            // 
            this.LaserList1Txt.AutoSize = true;
            this.LaserList1Txt.Location = new System.Drawing.Point(172, 9);
            this.LaserList1Txt.Name = "LaserList1Txt";
            this.LaserList1Txt.Size = new System.Drawing.Size(58, 13);
            this.LaserList1Txt.TabIndex = 12;
            this.LaserList1Txt.Text = "LaserList 1";
            // 
            // LaserList2Txt
            // 
            this.LaserList2Txt.AutoSize = true;
            this.LaserList2Txt.Location = new System.Drawing.Point(172, 57);
            this.LaserList2Txt.Name = "LaserList2Txt";
            this.LaserList2Txt.Size = new System.Drawing.Size(58, 13);
            this.LaserList2Txt.TabIndex = 13;
            this.LaserList2Txt.Text = "LaserList 2";
            // 
            // ToolListTxt
            // 
            this.ToolListTxt.AutoSize = true;
            this.ToolListTxt.Location = new System.Drawing.Point(13, 106);
            this.ToolListTxt.Name = "ToolListTxt";
            this.ToolListTxt.Size = new System.Drawing.Size(44, 13);
            this.ToolListTxt.TabIndex = 14;
            this.ToolListTxt.Text = "ToolList";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SaveButton.Location = new System.Drawing.Point(335, 181);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save All Profiles";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Location = new System.Drawing.Point(12, 159);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(75, 13);
            this.Profile.TabIndex = 16;
            this.Profile.Text = "Curient Profile:";
            // 
            // Prof1
            // 
            this.Prof1.Location = new System.Drawing.Point(11, 181);
            this.Prof1.Name = "Prof1";
            this.Prof1.Size = new System.Drawing.Size(75, 23);
            this.Prof1.TabIndex = 17;
            this.Prof1.Text = "Profile 1";
            this.Prof1.UseVisualStyleBackColor = true;
            this.Prof1.Click += new System.EventHandler(this.Prof1_Click);
            // 
            // Prof2
            // 
            this.Prof2.Location = new System.Drawing.Point(92, 181);
            this.Prof2.Name = "Prof2";
            this.Prof2.Size = new System.Drawing.Size(75, 23);
            this.Prof2.TabIndex = 18;
            this.Prof2.Text = "Profile 2";
            this.Prof2.UseVisualStyleBackColor = true;
            this.Prof2.Click += new System.EventHandler(this.Prof2_Click);
            // 
            // Prof3
            // 
            this.Prof3.Location = new System.Drawing.Point(173, 181);
            this.Prof3.Name = "Prof3";
            this.Prof3.Size = new System.Drawing.Size(75, 23);
            this.Prof3.TabIndex = 19;
            this.Prof3.Text = "Profile 3";
            this.Prof3.UseVisualStyleBackColor = true;
            this.Prof3.Click += new System.EventHandler(this.Prof3_Click_1);
            // 
            // Prof4
            // 
            this.Prof4.Location = new System.Drawing.Point(254, 181);
            this.Prof4.Name = "Prof4";
            this.Prof4.Size = new System.Drawing.Size(75, 23);
            this.Prof4.TabIndex = 20;
            this.Prof4.Text = "Profile 4";
            this.Prof4.UseVisualStyleBackColor = true;
            this.Prof4.Click += new System.EventHandler(this.Prof4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cost \\ Use (Pec)";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(7, 32);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(83, 20);
            this.textBoxCost.TabIndex = 22;
            this.textBoxCost.TextChanged += new System.EventHandler(this.textBoxCost_TextChanged);
            // 
            // TextBoxReload
            // 
            this.TextBoxReload.Location = new System.Drawing.Point(95, 32);
            this.TextBoxReload.MaximumSize = new System.Drawing.Size(57, 20);
            this.TextBoxReload.MinimumSize = new System.Drawing.Size(57, 20);
            this.TextBoxReload.Name = "TextBoxReload";
            this.TextBoxReload.Size = new System.Drawing.Size(57, 20);
            this.TextBoxReload.TabIndex = 23;
            this.TextBoxReload.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Uses\\Min";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.TextBoxReload);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FlagUsingEMode);
            this.groupBox1.Location = new System.Drawing.Point(286, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 75);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ReloadSpeed
            // 
            this.ReloadSpeed.Location = new System.Drawing.Point(365, 74);
            this.ReloadSpeed.Name = "ReloadSpeed";
            this.ReloadSpeed.Size = new System.Drawing.Size(81, 20);
            this.ReloadSpeed.TabIndex = 26;
            this.ReloadSpeed.TextChanged += new System.EventHandler(this.ReloadSpeed_TextChanged);
            this.ReloadSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReloadSpeed_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "ReloadSpeed%";
            // 
            // ProfNum
            // 
            this.ProfNum.Location = new System.Drawing.Point(93, 156);
            this.ProfNum.Name = "ProfNum";
            this.ProfNum.ReadOnly = true;
            this.ProfNum.Size = new System.Drawing.Size(13, 20);
            this.ProfNum.TabIndex = 28;
            this.ProfNum.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(175, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 54);
            this.label4.TabIndex = 29;
            this.label4.Text = "If E mode active, all next pressing on profile button will count as use";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CostCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProfNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReloadSpeed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Prof4);
            this.Controls.Add(this.Prof3);
            this.Controls.Add(this.Prof2);
            this.Controls.Add(this.Prof1);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ToolListTxt);
            this.Controls.Add(this.LaserList2Txt);
            this.Controls.Add(this.LaserList1Txt);
            this.Controls.Add(this.ScopeListTxt);
            this.Controls.Add(this.DMGEnhCountTxt);
            this.Controls.Add(this.AmplifierListTxt);
            this.Controls.Add(this.WeapontListTxt);
            this.Controls.Add(this.comboBoxTool);
            this.Controls.Add(this.comboBoxDMGList);
            this.Controls.Add(this.comboBoxLaser2);
            this.Controls.Add(this.comboBoxLaser1);
            this.Controls.Add(this.comboBoxScope);
            this.Controls.Add(this.comboBoxAmpList);
            this.Controls.Add(this.comboBoxWeaponList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(467, 251);
            this.MinimumSize = new System.Drawing.Size(467, 251);
            this.Name = "CostCount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CostCount";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CostCount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWeaponList;
        private System.Windows.Forms.ComboBox comboBoxAmpList;
        private System.Windows.Forms.ComboBox comboBoxScope;
        private System.Windows.Forms.ComboBox comboBoxLaser1;
        private System.Windows.Forms.ComboBox comboBoxLaser2;
        private System.Windows.Forms.ComboBox comboBoxDMGList;
        private System.Windows.Forms.ComboBox comboBoxTool;
        private System.Windows.Forms.CheckBox FlagUsingEMode;
        private System.Windows.Forms.Label WeapontListTxt;
        private System.Windows.Forms.Label AmplifierListTxt;
        private System.Windows.Forms.Label DMGEnhCountTxt;
        private System.Windows.Forms.Label ScopeListTxt;
        private System.Windows.Forms.Label LaserList1Txt;
        private System.Windows.Forms.Label LaserList2Txt;
        private System.Windows.Forms.Label ToolListTxt;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Profile;
        private System.Windows.Forms.Button Prof1;
        private System.Windows.Forms.Button Prof2;
        private System.Windows.Forms.Button Prof3;
        private System.Windows.Forms.Button Prof4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox TextBoxReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ReloadSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox ProfNum;
    }
}