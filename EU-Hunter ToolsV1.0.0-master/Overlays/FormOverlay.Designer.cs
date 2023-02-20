using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WpfApp1;

namespace WindowsFormsApp1
{
    public partial class FormOverlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverlay));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ammoCostTxt2 = new System.Windows.Forms.Label();
            this.lootValueTxt2 = new System.Windows.Forms.Label();
            this.profitTxt2 = new System.Windows.Forms.Label();
            this.effiTxt2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lootValueTxt3 = new System.Windows.Forms.Label();
            this.profitTxt3 = new System.Windows.Forms.Label();
            this.effiTxt3 = new System.Windows.Forms.Label();
            this.MUonly = new System.Windows.Forms.Label();
            this.HalfMode = new System.Windows.Forms.Button();
            this.StartStop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MobsKilledLabel = new System.Windows.Forms.Label();
            this.ProfTextBox = new System.Windows.Forms.TextBox();
            this.timerScrolling = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(137, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ammo Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LootV+MU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total + MU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Loot Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "TT%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "MU only";
            // 
            // ammoCostTxt2
            // 
            this.ammoCostTxt2.ForeColor = System.Drawing.Color.Red;
            this.ammoCostTxt2.Location = new System.Drawing.Point(58, 6);
            this.ammoCostTxt2.MinimumSize = new System.Drawing.Size(120, 0);
            this.ammoCostTxt2.Name = "ammoCostTxt2";
            this.ammoCostTxt2.Size = new System.Drawing.Size(120, 13);
            this.ammoCostTxt2.TabIndex = 34;
            this.ammoCostTxt2.Text = "0.00 PED";
            // 
            // lootValueTxt2
            // 
            this.lootValueTxt2.AutoSize = true;
            this.lootValueTxt2.ForeColor = System.Drawing.Color.ForestGreen;
            this.lootValueTxt2.Location = new System.Drawing.Point(58, 96);
            this.lootValueTxt2.MinimumSize = new System.Drawing.Size(120, 0);
            this.lootValueTxt2.Name = "lootValueTxt2";
            this.lootValueTxt2.Size = new System.Drawing.Size(120, 13);
            this.lootValueTxt2.TabIndex = 35;
            this.lootValueTxt2.Text = "0.00 PED";
            this.lootValueTxt2.Click += new System.EventHandler(this.lootValueTxt2_Click);
            // 
            // profitTxt2
            // 
            this.profitTxt2.AutoSize = true;
            this.profitTxt2.Location = new System.Drawing.Point(58, 111);
            this.profitTxt2.MinimumSize = new System.Drawing.Size(120, 0);
            this.profitTxt2.Name = "profitTxt2";
            this.profitTxt2.Size = new System.Drawing.Size(120, 13);
            this.profitTxt2.TabIndex = 36;
            this.profitTxt2.Text = "0.00 PED";
            // 
            // effiTxt2
            // 
            this.effiTxt2.AutoSize = true;
            this.effiTxt2.Location = new System.Drawing.Point(58, 126);
            this.effiTxt2.MinimumSize = new System.Drawing.Size(120, 0);
            this.effiTxt2.Name = "effiTxt2";
            this.effiTxt2.Size = new System.Drawing.Size(120, 13);
            this.effiTxt2.TabIndex = 37;
            this.effiTxt2.Text = "0%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "TT% + MU";
            // 
            // lootValueTxt3
            // 
            this.lootValueTxt3.AutoSize = true;
            this.lootValueTxt3.ForeColor = System.Drawing.Color.ForestGreen;
            this.lootValueTxt3.Location = new System.Drawing.Point(58, 21);
            this.lootValueTxt3.MinimumSize = new System.Drawing.Size(120, 0);
            this.lootValueTxt3.Name = "lootValueTxt3";
            this.lootValueTxt3.Size = new System.Drawing.Size(120, 13);
            this.lootValueTxt3.TabIndex = 35;
            this.lootValueTxt3.Text = "0.00 PED";
            // 
            // profitTxt3
            // 
            this.profitTxt3.AutoSize = true;
            this.profitTxt3.Location = new System.Drawing.Point(58, 36);
            this.profitTxt3.MinimumSize = new System.Drawing.Size(120, 0);
            this.profitTxt3.Name = "profitTxt3";
            this.profitTxt3.Size = new System.Drawing.Size(120, 13);
            this.profitTxt3.TabIndex = 36;
            this.profitTxt3.Text = "0.00 PED";
            // 
            // effiTxt3
            // 
            this.effiTxt3.AutoSize = true;
            this.effiTxt3.Location = new System.Drawing.Point(58, 51);
            this.effiTxt3.MinimumSize = new System.Drawing.Size(120, 0);
            this.effiTxt3.Name = "effiTxt3";
            this.effiTxt3.Size = new System.Drawing.Size(120, 13);
            this.effiTxt3.TabIndex = 37;
            this.effiTxt3.Text = "0%";
            // 
            // MUonly
            // 
            this.MUonly.AutoSize = true;
            this.MUonly.Location = new System.Drawing.Point(58, 81);
            this.MUonly.MinimumSize = new System.Drawing.Size(120, 0);
            this.MUonly.Name = "MUonly";
            this.MUonly.Size = new System.Drawing.Size(120, 13);
            this.MUonly.TabIndex = 37;
            this.MUonly.Text = "0.00 PED";
            // 
            // HalfMode
            // 
            this.HalfMode.Location = new System.Drawing.Point(137, 60);
            this.HalfMode.Name = "HalfMode";
            this.HalfMode.Size = new System.Drawing.Size(25, 33);
            this.HalfMode.TabIndex = 40;
            this.HalfMode.Text = "H";
            this.HalfMode.UseVisualStyleBackColor = true;
            this.HalfMode.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartStop
            // 
            this.StartStop.Location = new System.Drawing.Point(137, 33);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(25, 25);
            this.StartStop.TabIndex = 100;
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.OverlayStartStop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "MobsKilled";
            // 
            // MobsKilledLabel
            // 
            this.MobsKilledLabel.AutoSize = true;
            this.MobsKilledLabel.Location = new System.Drawing.Point(58, 66);
            this.MobsKilledLabel.Name = "MobsKilledLabel";
            this.MobsKilledLabel.Size = new System.Drawing.Size(13, 13);
            this.MobsKilledLabel.TabIndex = 102;
            this.MobsKilledLabel.Text = "0";
            // 
            // ProfTextBox
            // 
            this.ProfTextBox.Location = new System.Drawing.Point(5, 142);
            this.ProfTextBox.Name = "ProfTextBox";
            this.ProfTextBox.ReadOnly = true;
            this.ProfTextBox.Size = new System.Drawing.Size(154, 20);
            this.ProfTextBox.TabIndex = 111;
            // 
            // timerScrolling
            // 
            this.timerScrolling.Enabled = true;
            this.timerScrolling.Interval = 1000;
            this.timerScrolling.Tick += new System.EventHandler(this.timerScrolling_Tick);
            // 
            // FormOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 141);
            this.Controls.Add(this.ProfTextBox);
            this.Controls.Add(this.MobsKilledLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.HalfMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.effiTxt2);
            this.Controls.Add(this.profitTxt2);
            this.Controls.Add(this.lootValueTxt2);
            this.Controls.Add(this.effiTxt3);
            this.Controls.Add(this.profitTxt3);
            this.Controls.Add(this.lootValueTxt3);
            this.Controls.Add(this.ammoCostTxt2);
            this.Controls.Add(this.MUonly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(180, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(180, 180);
            this.Name = "FormOverlay";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FormOverlay_Activated);
            this.Load += new System.EventHandler(this.FormOverlay_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.Move += new System.EventHandler(this.FormOverlay_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label13;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public Label ammoCostTxt2;
        public Label lootValueTxt2;
        public Label profitTxt2;
        public Label effiTxt2;
        public Label lootValueTxt3;
        public Label profitTxt3;
        public Label effiTxt3;
        public Label MUonly;
        #endregion

        public Button HalfMode;
        public Label MobsKilledLabel;
        public TextBox ProfTextBox;
        public Timer timerScrolling;
        public Label label8;
        public Button StartStop;
        public Button button1;
    }
}