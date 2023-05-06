using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WpfApp1;

namespace WindowsFormsApp1
{
    partial class FormInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInput));
            this.inputValueText = new System.Windows.Forms.TextBox();
            this.inputAcceptButton = new System.Windows.Forms.Button();
            this.inputInformationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputValueText
            // 
            this.inputValueText.Location = new System.Drawing.Point(51, 46);
            this.inputValueText.Name = "inputValueText";
            this.inputValueText.Size = new System.Drawing.Size(100, 20);
            this.inputValueText.TabIndex = 0;
            this.inputValueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputValueText.TextChanged += new System.EventHandler(this.inputValueText_TextChanged);
            this.inputValueText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputValueText_KeyPress);
            // 
            // inputAcceptButton
            // 
            this.inputAcceptButton.Location = new System.Drawing.Point(175, 44);
            this.inputAcceptButton.Name = "inputAcceptButton";
            this.inputAcceptButton.Size = new System.Drawing.Size(36, 23);
            this.inputAcceptButton.TabIndex = 1;
            this.inputAcceptButton.Text = "OK";
            this.inputAcceptButton.UseVisualStyleBackColor = true;
            this.inputAcceptButton.Click += new System.EventHandler(this.inputAcceptButton_Click);
            // 
            // inputInformationText
            // 
            this.inputInformationText.AutoSize = true;
            this.inputInformationText.Location = new System.Drawing.Point(2, 4);
            this.inputInformationText.Name = "inputInformationText";
            this.inputInformationText.Size = new System.Drawing.Size(264, 39);
            this.inputInformationText.TabIndex = 2;
            this.inputInformationText.Text = "Write the PED value of this item. If you looted more\r\nthan one write here the val" +
    "ue of one item, not the sum,\r\nit will correct after next loot of this item.";
            this.inputInformationText.Click += new System.EventHandler(this.inputInformationText_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 90);
            this.Controls.Add(this.inputInformationText);
            this.Controls.Add(this.inputAcceptButton);
            this.Controls.Add(this.inputValueText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(280, 129);
            this.MinimumSize = new System.Drawing.Size(280, 129);
            this.Name = "FormInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Value";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public DataGridViewCell celda;
        private FormMain f1;
        //private IContainer components;
        private TextBox inputValueText;
        private Button inputAcceptButton;
        public Label inputInformationText;

        #endregion
    }
}