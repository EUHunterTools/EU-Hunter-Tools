using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WpfApp1;

namespace WindowsFormsApp1
{
    public partial class Settings : Form
    {
        private FormMain f1;
#pragma warning disable CS0169 // Поле "Settings.f3" никогда не используется.
        private FormOverlay f3;
#pragma warning restore CS0169 // Поле "Settings.f3" никогда не используется.
#pragma warning disable CS0169 // Поле "Settings.fCC" никогда не используется.
        private CostCount fCC;
#pragma warning restore CS0169 // Поле "Settings.fCC" никогда не используется.
        private FormOverlay formOverlay;
        public Color DMBackColor = Color.FromArgb(70, 70, 70);
        public Color DMTextColor = Color.White;
        public Color DMTablesColor = Color.Gray;

        public Settings(FormMain parent)
        {            
            this.f1 = parent;
            this.InitializeComponent();            

        }

        public Settings(FormOverlay formOverlay)
        {
            this.formOverlay = formOverlay;
        }

        public void DarkModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.f1.SwitchDarkmode();
        }

        private void pathShowButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            int num = (int)openFileDialog.ShowDialog();
            pathText.Text = openFileDialog.FileName;
        }

        private void HidingOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.f1.button1_Click_1();
        }

        public void ResetOverlay_Click(object sender, EventArgs e)
        {
            this.f1.SetOverlayNull();
        }

        private void MobsKilledAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            if(MobsKilledAutoSize.Checked)
            {
                MobsKilled.Text = "100";
                MobsKilled.Enabled = false;
                MobsKilledPointEvery.Text = "1";
                MobsKilledPointEvery.Enabled = false;
                MobsKilledNumLines.Text = "10";
            }
            else
            {
                MobsKilled.Enabled = true;
                MobsKilledPointEvery.Enabled = true;
            }
        }

        private void MobsKilled_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(MobsKilled.Text) == 0)
                {
                    MobsKilled.Text = "1";
                }                 
            }
#pragma warning disable CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            catch(Exception ex)
#pragma warning restore CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            {
                MobsKilled.Text = "1";
                return;
            }
        
        
        }

        private void MobsKilledPointEvery_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(MobsKilledPointEvery.Text) == 0)
                {
                    MobsKilledPointEvery.Text = "1";
                }                   
            }
#pragma warning disable CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            catch (Exception ex)
#pragma warning restore CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            {
                MobsKilledPointEvery.Text = "1";
                return;
            }
        }

        private void MobsKilledNumLines_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(MobsKilledNumLines.Text) == 0)
                {
                    MobsKilledNumLines.Text = "1";
                }                   
            }
#pragma warning disable CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            catch (Exception ex)
#pragma warning restore CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            {
                MobsKilledNumLines.Text = "1";
                return;
            }
        }

        private void MobsKilled_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void MobsKilledPointEvery_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
           
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void MobsKilledNumLines_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void SecBeforeAFKTimerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void SecBeforeAFKTimerBox_TextChanged(object sender, EventArgs e)
        {
            this.f1.SecondsBeforeAFKTimer = Convert.ToInt32(SecBeforeAFKTimerBox.Text);
        }

        private void FlagProfUse_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.FlagProfUse, 
            "Allows to switch between profiles, using 1-4 buttons on keyboard and also add \ndecay of profile if E mode active by tapping again on the same button");

        private void DPSOnTime_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.DPSOnTime, 
            "Using time to calculate DPS instead of reload speed of the weapon");

        private void MiningMode_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.MiningMode, 
            "Makes adding decay of current profile after receiving item (looting item), if it hasn't got an E mode flag");

        private void HidingOption_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.HidingOption, 
            "Makes to not hide main window with all info while overlay window is active");

        private void checkBoxBackup_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.checkBoxBackup, 
            "Auto saves all data during hunt/shooting and load it after closing the app,\nduplicate data backup saves data after crit shot and loads it if the main backup file broken");

        private void UsingEButton_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.UsingEButton, 
            "Binds button E instead of Profile Button that usses for E mode\n(instead of second tap on same profile button to count decay, u can use E button)");

        private void MobsKilledAutoSize_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.MobsKilledAutoSize, 
            "Makes default settings for TT return graf");

        private void label3_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.label3, 
            "Makes to stop the timer if not shooting after this amount of seconds");

        private void ButtonSave_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.ButtonSave, 
            "Saves all settings from this window and also overlay position");

        private void NumOfLinesLable_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.NumOfLinesLabel, 
            "Applies after 10 points");

        private void checkBoxLootAmmo_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.checkBoxLootAmmo, 
            "Counts Loot% that depends on AmmoCost instead of LootValue");

        private void checkBoxOutValue_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.checkBoxOutValue, 
            "Creates a file in the same folder, where .exe located that contains decay and tt return from each mob");

        private void checkBoxBackupTeam_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.checkBoxBackupTeam, 
            "Auto saves all data from team hunt and load it after closing the app");

        private void checkBoxUnusedItems_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.checkBoxUnusedItems, 
            "In addons there is a file *Unuseditems*, all items those written in here will be ignored while looting.\r\n" +
            "Turning on this option will track those items, but give to them 0 TT value.\r\n" +
            "It used to not track refined or converted stuff, you can change that file by yourself");


        private void MiningMode_CheckedChanged(object sender, EventArgs e)
        {
            if (MiningMode.Checked)
            {
                this.f1.balanceGrid.Rows[5].Cells[0].Value = (object)"Climes excavated";
                this.f1.chengeToMiningModeOverlay(true);
            }
            else
            {
                this.f1.balanceGrid.Rows[5].Cells[0].Value = (object)"Enemies killed";
                this.f1.chengeToMiningModeOverlay(false);
            }
        }

        private void checkBoxBackup_CheckedChanged(object sender, EventArgs e)// удаление бекапа и дубликата, при снятии галочки
        {
            try
            {
                if (!checkBoxBackup.Checked && (File.Exists(this.f1.BackUpPath) | File.Exists(this.f1.BackUpPathDuplicate)))
                {
                    DialogResult Del = MessageBox.Show("Delete backup files?", "Disabling Backup", MessageBoxButtons.YesNo);

                    if (Del == DialogResult.Yes)
                    {
                        File.Delete(this.f1.BackUpPath);
                        File.Delete(this.f1.BackUpPathDuplicate);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("checkBoxBackup:" + ex);
            }
        }

        private void ChooseColorDM_Click(object sender, EventArgs e)
        {

            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.AnyColor = true;
            MyDialog.SolidColorOnly = false;
            MyDialog.ShowHelp = false;
            MyDialog.Color = DMBackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                         
                DMBackColor = MyDialog.Color;                
           
            this.f1.SwitchDarkmode();
        }

        private void ChooseColorDMText_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.AnyColor = true;
            MyDialog.SolidColorOnly = false;
            MyDialog.ShowHelp = false;
            MyDialog.Color = DMTextColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                DMTextColor = MyDialog.Color;
            this.f1.SwitchDarkmode();
        }

        private void ChooseColorDMStat_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.AnyColor = true;
            MyDialog.SolidColorOnly = false;
            MyDialog.ShowHelp = false;
            MyDialog.Color = DMTablesColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                DMTablesColor = MyDialog.Color;
            this.f1.SwitchDarkmode();
        }

        private void checkBoxBackupTeam_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!checkBoxBackupTeam.Checked && File.Exists(this.f1.TeamBackupPath))
                {
                    DialogResult Del = MessageBox.Show("Delete team backup files?", "Disabling Backup", MessageBoxButtons.YesNo);

                    if (Del == DialogResult.Yes)
                    {
                        File.Delete(this.f1.TeamBackupPath);                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("checkBoxBackup:" + ex);
            }
        }

        private void label6_MouseMove(object sender, MouseEventArgs e) => this.f1.toolTip1.SetToolTip((Control)this.NickName, "Uses for tracking Globals and Hofs");

        private void buttonResetGlobals_Click(object sender, EventArgs e)
        {
            DialogResult Del = MessageBox.Show("Reset all globals and hofs?", "Reset globals", MessageBoxButtons.YesNo);

            if (Del == DialogResult.Yes)
            {
                this.f1.resetGlobals();
            }            
        }
    }
}
