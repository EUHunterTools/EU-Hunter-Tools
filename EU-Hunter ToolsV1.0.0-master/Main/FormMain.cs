
/*  READ BEFORE WORKING WITH CODE FOR FIRST TIME!
 *  
 * Wellcome to crappy remade code from Arkshija by bad software engineer me (K0lb)
 * If you are reading this, this might mean that you want to change something or add something, so here is a little reminder
 * it was really hard to fix the original decompiled code to make forms work properly,
 * main forms wasnt working at all, most variable were named like thing1...thing23,and as the cherry on the cake,
 * the logic was completely illogical (if you want to try to do it yourself, original files are posted on same github)
 * I kinda solved this puzzle, but even with my comments it will be hard to understand and change core logic and wotk with this chaotick file 
 * (orginaly this file got 3.5k strings of code, i really wanted to put they all in separate thematic files and folders, but no, it was just waste of time)
 * and of course there are plenty things of bad coder stuff, don't blame me if you see button_5, bad gramma (naming strings like lines or other grammar issues)
 * or so, some things were made in a hurry, with not enough skills and plan of what to do
 * and some of them made for test but stayed as working stuff, because of no intrest of continuing working with, so be prepared to work with really bad code
 * if you will have bit troubles with understanding or working with smth, you can PM me in discord (https://discord.gg/ESNY9JxsSC)
 * 
*/

using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;
using LiveCharts;
using LiveCharts.Wpf;
using Timer = System.Windows.Forms.Timer;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MMC20;
using Microsoft.VisualBasic;
using System.Security.Policy;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Microsoft.Office.Interop.Excel;
using Microsoft.Vbe.Interop;
using Label = System.Windows.Forms.Label;
using CheckBox = System.Windows.Forms.CheckBox;
using GroupBox = System.Windows.Forms.GroupBox;
using Axis = LiveCharts.Wpf.Axis;
using SeriesCollection = LiveCharts.SeriesCollection;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace WpfApp1
{
    public partial class FormMain : Form
    {
        private FormOverlay f3;
        private Settings STT;
        private CostCount fCC;
        private FormInput inputForm;
        //private LicenceForm fl; //unused because sub system deleted

        public bool _isRunning;
        public double ammoSpent;
        public double repairs;
        private double totalAttacks;
        public double ammoPerShot;
        public double attacksPerMinute;
        private double dodgedAt;
        private double crits;
        private double evaded;
        private double atRecividos;
        private double critRecividos;
        private double tDamage;
        private double tReloadC;
        private double tCritDamage;
        private double tDamageRec;
        private double tCritDamageRec;
        private string nombre = "";
        public double lootValue;
        public double BUHelp;

        public List<Items> listaItems = new List<Items>();
        private List<Items> listaItemsT1 = new List<Items>();
        private List<Items> listaItemsT2 = new List<Items>();
        private List<Items> listaItemsT3 = new List<Items>();
        public List<EnhItems> listaItemsEnh = new List<EnhItems>();
        public List<SkillCount> listSkills = new List<SkillCount>();
        public List<TieringItems> listTiering = new List<TieringItems>();
        private List<PlayerData> playerDataList = new List<PlayerData>();
        private List<BackUp> BackUpList = new List<BackUp>();
        private List<GrafCounting> GrafCountings = new List<GrafCounting>();
        private List<StatusItems> StatusItems = new List<StatusItems>();
        private bool trackTeam;
        private bool teamWait = false;
        private bool loading = true;
        public bool isCompact;

        private CultureInfo ci = CultureInfo.InvariantCulture;
        private string fPath = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsConfig.txt";
        public string BackUpPath = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsBackUp.csv";
        public string BackUpPathDuplicate = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsBackUpDuplicate.csv";
        public string TeamBackupPath = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsTeamBackUp.csv";
        public string GlobalsPath = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsGlobals.csv";
        public string UnusedPath = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsUnusedItems.csv";

        public int mobsKilled;
        private int ticks;
        private int tickLooted;
        private int delay = 10;
        public double balanceGridHelpRow71;
        public double balanceGridHelpTTCheck;
        public double balanceGridHelpRow2;
        bool FlagBUAfterReset = false;
        public List<Weapons> Weapons = new List<Weapons>();
        public List<Amps> Amps = new List<Amps>();
        public int mobskilledv2 = 0;
        public int CProf; //Currient prof, так котоаря сейчас, испоьзуетс ядля даблтапа

        public string FullTeamInfo = "";
        public double fullTeamTT = 0;

        public double CostUseProf1;
        public double CostUseProf2;
        public double CostUseProf3;
        public double CostUseProf4;

        public double SpeedUseProf1;
        public double SpeedUseProf2;
        public double SpeedUseProf3;
        public double SpeedUseProf4;

        public bool[] UseEflag = new bool[4] { false, false, false, false };
        //DateTime date1 = new DateTime(0, 0);
        public int tSecondHunt = 0;
        public int SecondsBeforeAFKTimer;
        public bool FormOverlayGealLineHelper;

        public double GlobalsTT = 0;
        public double TTDecayForExc = 0;
        public double TTBackForExc = 0;
        public bool TTDecRerurnRepeat = false;
        public bool globalFlagUnused = false;

        public FormMain()
        {
            try {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                Bind1to4.Presss += new Bind1to4.Press(KBDHook_OnHookKeyPressEventHandler);
                Bind1to4.LocalHook = false;
                this.KeyPreview = true;
                this.f3 = new FormOverlay(this);
                this.fCC = new CostCount(this);
                this.inputForm = new FormInput(this);
                this.STT = new Settings(this);
                FormOverlayGealLineHelper = STT.checkBoxSGIO.Checked;
                
                this.InitializeComponent();

                this.SecondsBeforeAFKTimer = Convert.ToInt32(this.STT.SecBeforeAFKTimerBox.Text);

                this.dGV1.Columns[0].ValueType = typeof(double);
                this.dGV1.Columns[1].ValueType = typeof(string);
                this.dGV1.Columns[2].ValueType = typeof(double);
                this.dGV1.Columns[3].ValueType = typeof(double);
                this.dGV1.Columns[4].ValueType = typeof(double);
                this.dGV1.Columns[5].ValueType = typeof(double);

                this.dGVEnh.Columns[0].ValueType = typeof(double);
                this.dGVEnh.Columns[1].ValueType = typeof(string);
                this.dGVEnh.Columns[2].ValueType = typeof(double);
                this.dGVEnh.Columns[3].ValueType = typeof(double);
                this.dGVEnh.Columns[4].ValueType = typeof(double);

                this.balanceGrid.Rows.Add();// left Grid with info
                this.balanceGrid.Rows[0].Cells[0].Value = (object)"Extra expenses"; // each is 22 pixels up-down
                this.balanceGrid.Rows[0].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                this.balanceGrid.Rows[0].Cells[1].ToolTipText = "Click this cell to edit your repair, decays or extra expenses.";
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[1].Cells[0].Value = (object)"Ammo Cost";
                this.balanceGrid.Rows[1].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows[1].Cells[1].Style.ForeColor = Color.Red;
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[2].Cells[0].Value = (object)"Loot Value + MU";
                this.balanceGrid.Rows[2].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows[2].Cells[1].Style.ForeColor = Color.ForestGreen;
                balanceGridHelpRow2 = 0;
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[3].Cells[0].Value = (object)"Total + MU";
                this.balanceGrid.Rows[3].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[4].Cells[0].Value = (object)"TT % + MU";
                this.balanceGrid.Rows[4].Cells[1].Value = (object)"0 %";
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[5].Cells[0].Value = (object)"Enemies killed";
                this.balanceGrid.Rows[5].Cells[1].Value = (object)"0";
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[6].Cells[0].Value = (object)"Average loot + MU";
                this.balanceGrid.Rows[6].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[7].Cells[0].Value = (object)"Loot Value";
                this.balanceGrid.Rows[7].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows[7].Cells[1].Style.ForeColor = Color.ForestGreen;
                balanceGridHelpRow71 = 0;
                balanceGridHelpTTCheck = 0;
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[8].Cells[0].Value = (object)"Only MU";
                this.balanceGrid.Rows[8].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[9].Cells[0].Value = (object)"TT %";
                this.balanceGrid.Rows[9].Cells[1].Value = (object)"0 %";

                this.balanceGrid.Rows.Add();
                this.balanceGrid.Rows[10].Cells[0].Value = (object)"Total";
                this.balanceGrid.Rows[10].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows.Add();

                this.statsGrid.Rows.Add();//right grid of info
                this.statsGrid.Rows[0].Cells[0].Value = (object)"Shots";
                this.statsGrid.Rows[0].Cells[1].Value = (object)"0";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[1].Cells[0].Value = (object)"Criticals ( %)";
                this.statsGrid.Rows[1].Cells[1].Value = (object)"0 (0 %)";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[2].Cells[0].Value = (object)"Damage done";
                this.statsGrid.Rows[2].Cells[1].Value = (object)"0";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[3].Cells[0].Value = (object)"Crit. dmg. done";
                this.statsGrid.Rows[3].Cells[1].Value = (object)"0";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[4].Cells[0].Value = (object)"Missed attacks";
                this.statsGrid.Rows[4].Cells[1].Value = (object)"0";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[5].Cells[0].Value = (object)"Accuracy %";
                this.statsGrid.Rows[5].Cells[1].Value = (object)"0 %";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[6].Cells[0].Value = (object)"Missed hits rec.( %)";
                this.statsGrid.Rows[6].Cells[1].Value = (object)"0 (0 %)";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[7].Cells[0].Value = (object)"Hits received";
                this.statsGrid.Rows[7].Cells[1].Value = (object)"0";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[8].Cells[0].Value = (object)"Crit. hits rec.( %)";
                this.statsGrid.Rows[8].Cells[1].Value = (object)"0 (0 %)";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[9].Cells[0].Value = (object)"Damage received";
                this.statsGrid.Rows[9].Cells[1].Value = (object)"0";
                this.statsGrid.Rows.Add();
                this.statsGrid.Rows[10].Cells[0].Value = (object)"Crit. dmg. rec.";
                this.statsGrid.Rows[10].Cells[1].Value = (object)"0";

                //backup backupDuplicate
                if (File.Exists(BackUpPath) | File.Exists(BackUpPathDuplicate)) 
                {
                    DialogResult num = MessageBox.Show("Found recordings from last run, use them?", "Back Up System", MessageBoxButtons.YesNo);

                    if (num == DialogResult.Yes)
                    {
                        try
                        {
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); //using again because sometimes it changes to other while working,just ignore this line
                            using (TextFieldParser textFieldParser = new TextFieldParser(this.BackUpPath))
                            {
                                LoadCSV(textFieldParser);
                            }

                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                DialogResult num2 = MessageBox.Show("Main BackUp file dammaged, load duplicate?", "Back Up System", MessageBoxButtons.YesNo);
                                if (num2 == DialogResult.Yes)
                                {

                                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                                    using (TextFieldParser textFieldParser = new TextFieldParser(this.BackUpPathDuplicate))
                                    {
                                        LoadCSV(textFieldParser);
                                    }
                                }
                            }
                            catch (Exception ex2) { MessageBox.Show("Duplicate / Main file dammaged or empty, data lost: " + ex + "\r\n" + ex2, "Back Up System"); }
                        }
                    }
                    this.CalculateProfit(); //after all info placed use this to update info
                }

                //teamBackup
                if (File.Exists(TeamBackupPath))
                {
                    DialogResult num = MessageBox.Show("Found recordings from last TEAM run, use them?", "Back Up System TEAM", MessageBoxButtons.YesNo);

                    try
                    {
                        if (num == DialogResult.Yes)
                        {
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                            using (TextFieldParser textFieldParser1 = new TextFieldParser(TeamBackupPath))
                            {
                                FullTeamInfo = textFieldParser1.ReadToEnd();
                                textFieldParser1.Close();
                            }

                            TeamTotalCount();

                            string copyFullTeamInfo = FullTeamInfo.Replace(";\r\n", ";");
                            while (copyFullTeamInfo.Contains(";"))
                            {
                                cB_SelectTeamMember.Items.Add(copyFullTeamInfo.Remove(copyFullTeamInfo.IndexOf(" : ")));
                                copyFullTeamInfo = copyFullTeamInfo.Remove(0, copyFullTeamInfo.IndexOf(";") + 1);
                            }

                            cB_SelectTeamMember.SelectedIndex = 0; //Darkmode crutch
                        }
                    }
                    catch (Exception ex2) { MessageBox.Show("File dammaged or empty, data lost: " + ex2, "Back Up System TEAM"); }

                }




                for (int index = 0; index < 10; ++index)//Darkmode crutch
                {
                    this.statsGrid.Rows[index].Cells[0].Selected = true;
                    this.statsGrid.Rows[index].Cells[0].Selected = false;
                    this.balanceGrid.Rows[index].Cells[0].Selected = true;
                    this.balanceGrid.Rows[index].Cells[0].Selected = false;                    
                }

                //settings load
                try
                {
                    this.LoadConfig();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loading setting failed, reconfigure settings or delete EUHunterToolsConfig.txt", "WARNING!");
                }

                //globals load
                try
                {
                    AutoLoadGlobals();
                    if (this.dGVGlobals.Rows.Count > 0)//Darkmode crutch
                    {
                        this.dGVGlobals.Rows[0].Cells[0].Selected = true;
                        this.dGVGlobals.Rows[0].Cells[0].Selected = false;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Loading globals failed, check EUHunterToolsGlobals.csv in Addons folder","WARNING!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Main:" + ex);
            }
        }

        //Key hook usage(buttons 1-4 (d1-d4)), for more info about hook go Bind1to4.cs
        //it was made just for test but stayed like this, u can remake to make universal class
        void KBDHook_OnHookKeyPressEventHandler(BindArgs e) 
        {

            if ((this.STT.FlagProfUse.Checked == true) & (e.IsPressed == false))
                switch (e.Keys)
                {
                    case Keys.D1:

                        this.ammoPerShot = this.fCC.ProfList[0].COSTUSEPROF;
                        this.attacksPerMinute = this.fCC.ProfList[0].SPEEDUSEPROF;
                        this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                        this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                        if (CProf == 1)// Cprof = current profile
                        {   //if after pressing button 1 current prof = same profile (1) and Emode on, than add decay
                            if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning & !this.STT.UsingEButton.Checked)
                            {
                                this.ammoSpent += this.ammoPerShot;
                                SecondsBeforeAFKTimer = 0;
                                AddItemStatus(0);
                            }
                            break;
                        }

                        //if not, than change profile to pressed button (1)
                        CProf = 1;

                        if (this.fCC.ProfList[0].USEEFLAG)
                        {
                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "1E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "1E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }
                            this.f3.HalfMode.Text = "1E";

                        }

                        else
                        {
                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "1 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "1 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }

                            this.f3.HalfMode.Text = "1";
                        }

                        break;

                    case Keys.D2:

                        this.ammoPerShot = this.fCC.ProfList[1].COSTUSEPROF;
                        this.attacksPerMinute = this.fCC.ProfList[1].SPEEDUSEPROF;
                        this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                        this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                        if (CProf == 2)
                        {
                            string ProfTetboxHelp = ProfTextBox.Text.Replace("E", "");

                            if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning & !this.STT.UsingEButton.Checked)
                            {
                                this.ammoSpent += this.ammoPerShot;
                                SecondsBeforeAFKTimer = 0;
                                AddItemStatus(0);
                            }
                            break;
                        }
                        CProf = 2;

                        if (this.fCC.ProfList[1].USEEFLAG)
                        {
                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "2E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "2E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }

                            this.f3.HalfMode.Text = "2E";

                        }
                        else
                        {
                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "2 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "2 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }
                            this.f3.HalfMode.Text = "2";
                        }

                        break;

                    case Keys.D3:


                        this.ammoPerShot = this.fCC.ProfList[2].COSTUSEPROF;
                        this.attacksPerMinute = this.fCC.ProfList[2].SPEEDUSEPROF;
                        this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                        this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                        if (CProf == 3)
                        {
                            string ProfTetboxHelp = ProfTextBox.Text.Replace("E", "");

                            if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning & !this.STT.UsingEButton.Checked)
                            {
                                this.ammoSpent += this.ammoPerShot;
                                SecondsBeforeAFKTimer = 0;
                                AddItemStatus(0);
                            }
                            break;
                        }
                        CProf = 3;

                        if (this.fCC.ProfList[2].USEEFLAG)
                        {

                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "3E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "3E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }
                            this.f3.HalfMode.Text = "3E";

                        }
                        else
                        {
                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "3 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "3 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }
                            this.f3.HalfMode.Text = "3";
                        }

                        break;

                    case Keys.D4:

                        this.ammoPerShot = this.fCC.ProfList[3].COSTUSEPROF;
                        this.attacksPerMinute = this.fCC.ProfList[3].SPEEDUSEPROF;
                        this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                        this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                        if (CProf == 4)
                        {
                            string ProfTetboxHelp = ProfTextBox.Text.Replace("E", "");

                            if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning & !this.STT.UsingEButton.Checked)
                            {
                                this.ammoSpent += this.ammoPerShot;
                                AddItemStatus(0);
                                SecondsBeforeAFKTimer = 0;
                            }
                            break;
                        }
                        CProf = 4;

                        if (this.fCC.ProfList[3].USEEFLAG)
                        {
                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "4E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "4E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }
                            this.f3.HalfMode.Text = "4E";

                        }
                        else
                        {
                            if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                            {
                                ProfTextBox.Text = "4 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                            }

                            else
                            {
                                ProfTextBox.Text = "4 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                                this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                            }
                            this.f3.HalfMode.Text = "4";
                        }
                        break;

                    case Keys.E: //E button use if this.STT.UsingEButton.Checked and Emode is true
                        if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning & this.STT.UsingEButton.Checked)
                        {
                            this.ammoSpent += this.ammoPerShot;
                            SecondsBeforeAFKTimer = 0;
                            AddItemStatus(0);
                        }
                        break;
                }
            CalculateProfit();
        }

        //Setting gear in app after clicking button in SET PROFILES
        //Same as KBDHook_OnHookKeyPressEventHandler, made for test and can be remade
        public void AfterSetProf(int num) // используется после Save\Select для обозначения быстрого таба
        {
            switch (num)
            {
                case 1:

                    this.ammoPerShot = this.fCC.ProfList[0].COSTUSEPROF;
                    this.attacksPerMinute = this.fCC.ProfList[0].SPEEDUSEPROF;
                    this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                    this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                    //its not a bug, its planned feature, after additional pressing a button, adds decay but was erased, Cpof 
                    //is always = 0 when pressing button in formCostCount, comment it in ProfX_Click() if you want this to work
                    if (CProf == 1)
                    {
                        if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning)
                        {
                            this.ammoSpent += this.ammoPerShot;
                            AddItemStatus(0);                           
                        }
                        break;
                    }

                    CProf = 1;

                    if (this.fCC.ProfList[0].USEEFLAG)
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "1E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "1E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "1E";

                    }

                    else
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "1 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "1 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "1";
                    }

                    break;

                case 2:

                    this.ammoPerShot = this.fCC.ProfList[1].COSTUSEPROF;
                    this.attacksPerMinute = this.fCC.ProfList[1].SPEEDUSEPROF;
                    this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                    this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                    if (CProf == 2)
                    {
                        string ProfTetboxHelp = ProfTextBox.Text.Replace("E", "");

                        if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning)
                        {
                            this.ammoSpent += this.ammoPerShot;
                            AddItemStatus(0);
                        }
                        break;
                    }
                    CProf = 2;

                    if (this.fCC.ProfList[1].USEEFLAG)
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "2E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "2E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "2E";

                    }

                    else
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "2 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "2 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "2";
                    }

                    break;

                case 3:

                    this.ammoPerShot = this.fCC.ProfList[2].COSTUSEPROF;
                    this.attacksPerMinute = this.fCC.ProfList[2].SPEEDUSEPROF;
                    this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                    this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                    if (CProf == 3)
                    {
                        string ProfTetboxHelp = ProfTextBox.Text.Replace("E", "");

                        if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning)
                        {
                            this.ammoSpent += this.ammoPerShot;
                            AddItemStatus(0);
                        }
                        break;
                    }
                    CProf = 3;

                    if (this.fCC.ProfList[2].USEEFLAG)
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "3E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "3E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "3E";

                    }

                    else
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "3 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "3 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "3";
                    }

                    break;

                case 4:


                    
                    this.ammoPerShot = this.fCC.ProfList[3].COSTUSEPROF;
                    this.attacksPerMinute = this.fCC.ProfList[3].SPEEDUSEPROF;
                    this.ammoBurnTxt.Text = Convert.ToString(this.ammoPerShot);
                    this.textBox1.Text = Convert.ToString(this.attacksPerMinute);

                    if (CProf == 4)
                    {
                        string ProfTetboxHelp = ProfTextBox.Text.Replace("E", "");

                        if (this.fCC.ProfList[CProf - 1].USEEFLAG & this._isRunning)
                        {
                            this.ammoSpent += this.ammoPerShot;
                            AddItemStatus(0);
                        }
                        break;
                    }
                    CProf = 4;

                    if (this.fCC.ProfList[3].USEEFLAG)
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "4E : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "4E : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "4E";

                    }

                    else
                    {
                        if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                        {
                            ProfTextBox.Text = "4 : " + this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME + "  ";
                        }

                        else
                        {
                            ProfTextBox.Text = "4 : " + this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;
                            this.f3.ProfTextBox.Text = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME + " | " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME + "  ";
                        }
                        this.f3.HalfMode.Text = "4";
                    }
                    break;
            }
        }
        
        //Getting total MarkUp loss for enhancers to count them in total loss
        public double GetEnhMUTT()
        {
            double s = 0;
            for (int RowCount = 0; RowCount < this.dGVEnh.RowCount; RowCount++)
            {
                s = s + Convert.ToDouble(dGVEnh.Rows[RowCount].Cells[3].Value);
            }
            return s;
        }

        //Working and updating info after looting
        //Not seriosly changed from begining
        public void CalculateProfit()
        {
            try
            {
                double totalOut = this.GetTotalOut(); //ammo spend + repairs
                double EnhMUTT = this.GetEnhMUTT();
                lootValue = this.GetLootValue() - EnhMUTT;
                double num1 = lootValue - totalOut;
                if (this.repairs == 0.0)
                    this.balanceGrid.Rows[0].Cells[1].Value = (object)"0.00 PED";
                Label avDmgTxt = this.avDmgTxt;
                double num2 = this.GetAverageDmg();
                string str1 = num2.ToString("N1");
                avDmgTxt.Text = str1;
                Label dpsTxt = this.dpsTxt;
                Label DPPShow = this.DPPShow;
                double DPPHelp = this.GetDPP();
                num2 = this.GetDPS();
                string str2 = num2.ToString("N1");
                dpsTxt.Text = str2;
                DPPShow.Text = DPPHelp.ToString("F4");
                

                string ConvertVRows2 = null;
                string ConvertVRows1 = null;

                if (!this.isCompact) //counting if overlay is not on
                {
                    //I dont understand why is was originally made like this(when u can just remake .value) but I dont want to remake it
                    DataGridViewCell cell1 = this.balanceGrid.Rows[1].Cells[1]; 
                    num2 = this.ammoSpent * 0.01 + this.repairs;

                    string str3 = num2.ToString("F2") + " PED";
                    cell1.Value = (object)str3;
                    this.balanceGrid.Rows[2].Cells[1].Value = (object)(lootValue.ToString("F2") + " PED"); // loot value + MU
                    this.balanceGrid.Rows[3].Cells[1].Value = (object)(num1.ToString("F2") + " PED");      // Total + MU
                    DataGridViewCell cell2 = this.balanceGrid.Rows[4].Cells[1];                            // TT% + MU
                    double ttcount = lootValue * 100.0 / totalOut;

                    //I wasnt understanding how it works, so just made this crutch
                    ConvertVRows2 = this.balanceGrid.Rows[2].Cells[1].Value.ToString();
                    ConvertVRows1 = this.balanceGrid.Rows[1].Cells[1].Value.ToString();                    // Ammo cost

                    if (ConvertVRows2.IndexOf(" PED") > 0)
                        ConvertVRows2 = ConvertVRows2.Remove(ConvertVRows2.IndexOf(" PED"), 4);

                    if (ConvertVRows2.IndexOf(" ") > 0)
                        ConvertVRows2 = ConvertVRows2.Remove(ConvertVRows2.IndexOf(" "), 1);

                    if (ConvertVRows1.IndexOf(" PED") > 0)
                        ConvertVRows1 = ConvertVRows1.Remove(ConvertVRows1.IndexOf(" PED"), 4);

                    if (ConvertVRows1.IndexOf(" ") > 0)
                        ConvertVRows1 = ConvertVRows1.Remove(ConvertVRows1.IndexOf(" "), 1);

                    //...Help are vars, that used localy to store and work values
                    balanceGridHelpTTCheck = (balanceGridHelpRow71 / (this.ammoSpent * 0.01 + this.repairs)) * 100;
                    balanceGridHelpRow2 = Math.Round(lootValue - balanceGridHelpRow71, 4);
                    this.balanceGrid.Rows[8].Cells[1].Value = (object)(balanceGridHelpRow2.ToString("F2") + " PED");  // Only MU                                                                                                                  
                    this.balanceGrid.Rows[9].Cells[1].Value = (object)(balanceGridHelpTTCheck.ToString("F2") + " %"); // TT%
                    this.balanceGrid.Rows[10].Cells[1].Value = (object)(Math.Round((balanceGridHelpRow71              // Total
                        - (this.ammoSpent * 0.01 + this.repairs)), 2) + " PED");

                    string str4 = ttcount.ToString("F2") + " %";
                    cell2.Value = (object)str4;
                    this.balanceGrid.Rows[5].Cells[1].Value = (object)this.mobsKilled.ToString("N0");
                    this.f3.MobsKilledLabel.Text = this.mobsKilled.ToString("N0");
                    DataGridViewCell cell3 = this.balanceGrid.Rows[6].Cells[1];
                    ttcount = lootValue / (double)this.mobsKilled;
                    string str5 = ttcount.ToString("F2") + " PED";
                    cell3.Value = (object)str5;
                }
                else //counting if overlay is on
                {
                    Label ammoCostTxt2 = this.f3.ammoCostTxt2;
                    Label lootValueTxt3 = this.f3.lootValueTxt3;
                    Label profitTxt3 = this.f3.profitTxt3;
                    Label effiTxt3 = this.f3.effiTxt3;
                    Label MUonly = this.f3.MUonly;
                    num2 = this.ammoSpent * 0.01 + this.repairs;
                    DataGridViewCell cell1 = this.balanceGrid.Rows[1].Cells[1];
                    string str3 = num2.ToString("F2") + " PED";
                    cell1.Value = (object)str3;
                    this.balanceGrid.Rows[2].Cells[1].Value = (object)(lootValue.ToString("F2") + " PED"); // loot value + MU
                    this.balanceGrid.Rows[3].Cells[1].Value = (object)(num1.ToString("F2") + " PED");      // Total + MU
                    DataGridViewCell cell2 = this.balanceGrid.Rows[4].Cells[1];                            // TT% + MU
                    double ttcount = lootValue * 100.0 / totalOut;           
                    string str4 = ttcount.ToString("F2") + " %";
                    cell2.Value = (object)str4;
                    this.balanceGrid.Rows[5].Cells[1].Value = (object)this.mobsKilled.ToString("N0");
                    this.f3.MobsKilledLabel.Text = this.mobsKilled.ToString("N0");
                    DataGridViewCell cell3 = this.balanceGrid.Rows[6].Cells[1];
                    ttcount = lootValue / (double)this.mobsKilled;
                    string str5 = ttcount.ToString("F2") + " PED";
                    cell3.Value = (object)str5;

                    ConvertVRows2 = this.balanceGrid.Rows[2].Cells[1].Value.ToString();
                    ConvertVRows1 = this.balanceGrid.Rows[1].Cells[1].Value.ToString();                    // Ammo cost

                    if (ConvertVRows2.IndexOf(" PED") > 0)
                        ConvertVRows2 = ConvertVRows2.Remove(ConvertVRows2.IndexOf(" PED"), 3);

                    if (ConvertVRows2.IndexOf(" ") > 0)
                        ConvertVRows2 = ConvertVRows2.Remove(ConvertVRows2.IndexOf(" "), 1);

                    if (ConvertVRows1.IndexOf(" PED") > 0)
                        ConvertVRows1 = ConvertVRows1.Remove(ConvertVRows1.IndexOf(" PED"), 3);

                    if (ConvertVRows1.IndexOf(" ") > 0)
                        ConvertVRows1 = ConvertVRows1.Remove(ConvertVRows1.IndexOf(" "), 1);

                    balanceGridHelpTTCheck = (balanceGridHelpRow71 / (this.ammoSpent * 0.01 + this.repairs)) * 100;
                    balanceGridHelpRow2 = Math.Round(lootValue - balanceGridHelpRow71, 4);
                    this.balanceGrid.Rows[8].Cells[1].Value = (object)(balanceGridHelpRow2.ToString("F2") + " PED");  // Only MU    
                    this.balanceGrid.Rows[9].Cells[1].Value = (object)(balanceGridHelpTTCheck.ToString("F2") + " %"); // TT%
                    this.balanceGrid.Rows[10].Cells[1].Value = (object)((balanceGridHelpRow71                         // Total
                        - (this.ammoSpent * 0.01 + this.repairs)).ToString("F2") + " PED");

                    string str6 = ttcount.ToString("F2") + " PED";
                    ammoCostTxt2.Text = this.balanceGrid.Rows[1].Cells[1].Value.ToString();
                    this.f3.lootValueTxt2.Text = lootValue.ToString("F2") + " PED";
                    this.f3.lootValueTxt3.Text = (string)this.balanceGrid.Rows[7].Cells[1].Value;                     // loot value
                    this.f3.profitTxt2.Text = num1.ToString("F2") + " PED";
                    this.f3.profitTxt3.Text = (string)this.balanceGrid.Rows[10].Cells[1].Value;
                    this.f3.effiTxt3.Text = (string)this.balanceGrid.Rows[9].Cells[1].Value;
                    this.f3.MUonly.Text = (string)this.balanceGrid.Rows[8].Cells[1].Value;

                    Label effiTxt2 = this.f3.effiTxt2;
                    ttcount = lootValue * 100.0 / totalOut;
                    string str7 = ttcount.ToString("F2") + " %";
                    effiTxt2.Text = str7;

                }

                if (num1 >= 0.0) // turns green when value profitable or red if not
                {
                    //this.balanceGrid.Rows[2].Cells[1].Style.ForeColor = Color.ForestGreen;
                    this.balanceGrid.Rows[3].Cells[1].Style.ForeColor = Color.ForestGreen;
                    this.balanceGrid.Rows[4].Cells[1].Style.ForeColor = Color.ForestGreen;
                    this.balanceGrid.Rows[8].Cells[1].Style.ForeColor = Color.ForestGreen;
                    this.f3.effiTxt2.ForeColor = Color.ForestGreen;
                    this.f3.profitTxt2.ForeColor = Color.ForestGreen;
                    this.f3.MUonly.ForeColor = Color.ForestGreen;
                    this.f3.ammoCostTxt2.ForeColor = Color.Red;
                }
                else
                {
                    //this.balanceGrid.Rows[2].Cells[1].Style.ForeColor = Color.Red;
                    this.balanceGrid.Rows[3].Cells[1].Style.ForeColor = Color.Red;
                    this.balanceGrid.Rows[4].Cells[1].Style.ForeColor = Color.Red;
                    this.balanceGrid.Rows[8].Cells[1].Style.ForeColor = Color.Red;
                    this.f3.effiTxt2.ForeColor = Color.Red;
                    this.f3.profitTxt2.ForeColor = Color.Red;
                    this.f3.MUonly.ForeColor = Color.Red;
                    this.f3.ammoCostTxt2.ForeColor = Color.Red;
                }

                if ((balanceGridHelpRow71 - (this.ammoSpent * 0.01 + this.repairs)) >= 0.0)
                {
                    this.balanceGrid.Rows[9].Cells[1].Style.ForeColor = Color.ForestGreen;
                    this.balanceGrid.Rows[10].Cells[1].Style.ForeColor = Color.ForestGreen;
                    this.f3.effiTxt3.ForeColor = Color.ForestGreen;
                    this.f3.profitTxt3.ForeColor = Color.ForestGreen;
                    this.f3.ammoCostTxt2.ForeColor = Color.Red;
                }
                else
                {
                    this.balanceGrid.Rows[9].Cells[1].Style.ForeColor = Color.Red;
                    this.balanceGrid.Rows[10].Cells[1].Style.ForeColor = Color.Red;
                    this.f3.effiTxt3.ForeColor = Color.Red;
                    this.f3.profitTxt3.ForeColor = Color.Red;
                    this.f3.ammoCostTxt2.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CalculateProfit():" + ex);
            }

        }

        //Getting total TT from looted items
        private double GetLootValue()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double num;
            //exporting from backup file was erased
            if (!File.Exists(BackUpPath) || FlagBUAfterReset)
                num = 0.0;
            else
                num = BUHelp;

            foreach (DataGridViewRow row in (IEnumerable)this.dGV1.Rows)
                num += Convert.ToDouble(row.Cells[3].Value);
            return num;
        }

        private double GetTotalOut() => this.ammoSpent * 0.01 + this.repairs;

        private double GetDPS()
        {
            //t in var means total
            double Helper = 0;
            if (!this.STT.DPSOnTime.Checked)
                Helper = (this.tDamage / this.totalAttacks) * ((this.tReloadC / this.totalAttacks) / 60.0);
            else
                Helper = this.tDamage / tSecondHunt;

            return Helper;
        }

        private double GetDPP() => this.tDamage / this.ammoSpent;

        private double GetAverageDmg() => this.tDamage / this.totalAttacks;

        public void startButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.STT.pathText.Text != "")
                {
                    if (!this._isRunning) //turning on
                    {
                        this._isRunning = true;
                        this.startButton.Text = "WORKING";
                        this.startButton.BackColor = Color.Green;
                        this.backgroundWorker1.RunWorkerAsync(); //check chat.log updates and reads last string if sting was added
                        if (this.STT.FlagProfUse.Checked == true)
                        {
                            Bind1to4.InstallHook();
                        }

                        timer2.Enabled = true;
                    }
                    else //turning off
                    {
                        Bind1to4.UnInstallHook();
                        this._isRunning = false;
                        this.startButton.Text = "START";
                        this.startButton.BackColor = Color.Empty;
                        this.backgroundWorker1.CancelAsync();
                        this.startButton.Enabled = false;
                        timer2.Enabled = false;
                    }
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Chose a file before start '^·^");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("startButton_Click_1: " + ex);
            }
        }

        private void buttonCopyC_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText("Hunt Summary [Cost: " + this.balanceGrid.Rows[1].Cells[1].Value + "] " +
                    "[Loot Value+MU: " + this.balanceGrid.Rows[2].Cells[1].Value + " Loot Value: " + this.balanceGrid.Rows[7].Cells[1].Value + "] " +
                    "[TT %+MU: " + this.balanceGrid.Rows[4].Cells[1].Value + " TT %: " + this.balanceGrid.Rows[9].Cells[1].Value + "] " +
                    "[Total+MU: " + this.balanceGrid.Rows[3].Cells[1].Value + " Total: " + this.balanceGrid.Rows[10].Cells[1].Value + " OnlyMU: " + this.balanceGrid.Rows[8].Cells[1].Value + " ]");
            }
            catch(Exception ex)
            {
                MessageBox.Show("buttonCopyC_Click: " + ex);
            }
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult num = MessageBox.Show("Are u sure to reset all data?",
       "Reset all data", MessageBoxButtons.YesNo);

            if (num == DialogResult.Yes)
            {
                this.listaItems.Clear();
                this.listaItemsT1.Clear();
                this.listaItemsT2.Clear();
                this.listaItemsT3.Clear();
                this.totalAttacks = 0.0;
                this.dodgedAt = 0.0;
                this.crits = 0.0;
                this.repairs = 0.0;
                this.ammoSpent = 0.0;
                this.dodgedAt = 0.0;
                this.evaded = 0.0;
                this.tDamage = 0.0;
                this.tCritDamage = 0.0;
                this.atRecividos = 0.0;
                this.tDamageRec = 0.0;
                this.tCritDamageRec = 0.0;
                this.critRecividos = 0.0;
                this.statsGrid.Rows[0].Cells[0].Value = (object)"Shots";
                this.statsGrid.Rows[0].Cells[1].Value = (object)"0";
                this.statsGrid.Rows[1].Cells[0].Value = (object)"Criticals ( %)";
                this.statsGrid.Rows[1].Cells[1].Value = (object)"0 (0 %)";
                this.statsGrid.Rows[2].Cells[0].Value = (object)"Damage done";
                this.statsGrid.Rows[2].Cells[1].Value = (object)"0";
                this.statsGrid.Rows[3].Cells[0].Value = (object)"Crit. dmg. done";
                this.statsGrid.Rows[3].Cells[1].Value = (object)"0";
                this.statsGrid.Rows[4].Cells[0].Value = (object)"Missed attacks";
                this.statsGrid.Rows[4].Cells[1].Value = (object)"0";
                this.statsGrid.Rows[5].Cells[0].Value = (object)"Accuracy %";
                this.statsGrid.Rows[5].Cells[1].Value = (object)"0 %";
                this.statsGrid.Rows[6].Cells[0].Value = (object)"Missed hits rec.( %)";
                this.statsGrid.Rows[6].Cells[1].Value = (object)"0 (0 %)";
                this.statsGrid.Rows[7].Cells[0].Value = (object)"Hits received";
                this.statsGrid.Rows[7].Cells[1].Value = (object)"0";
                this.statsGrid.Rows[8].Cells[0].Value = (object)"Crit. hits rec.( %)";
                this.statsGrid.Rows[8].Cells[1].Value = (object)"0 (0 %)";
                this.statsGrid.Rows[9].Cells[0].Value = (object)"Damage received";
                this.statsGrid.Rows[9].Cells[1].Value = (object)"0";
                this.statsGrid.Rows[10].Cells[0].Value = (object)"Crit. dmg. rec.";
                this.statsGrid.Rows[10].Cells[1].Value = (object)"0";
                this.balanceGrid.Rows[7].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows[8].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows[5].Cells[1].Value = (object)"0";
                this.balanceGrid.Rows[8].Cells[1].Value = (object)"0.00 PED";
                this.balanceGrid.Rows[10].Cells[1].Value = (object)"0.00 PED";
                mobsKilled = 0;
                mobskilledv2 = 0;
                balanceGridHelpRow2 = 0;
                balanceGridHelpRow71 = 0;
                balanceGridHelpTTCheck = 0;
                tSecondHunt = 0;
                tReloadC = 0;
                TotalHuntTime.Text = "00:00:00";
                AVGTTK.Text = "00:00";
                SecondsBeforeAFKTimer = Convert.ToInt32(this.STT.SecBeforeAFKTimerBox.Text);
                cartesianChart1.AxisX.Clear();
                this.dGV1.Rows.Clear();
                this.dGVEnh.Rows.Clear();
                this.GrafCountings.Clear();
                this.dGVTiring.Rows.Clear();
                this.dGVStatus.Rows.Clear();
                this.dGVSkill.Rows.Clear();
                FlagBUAfterReset = true;
                cartesianChart1.Series.Clear();
                this.CalculateProfit();
                dGVSkillTotalPoints.HeaderText = "TotalPoints";
                dGVSkillSummons.HeaderText = "Summons";
                TTDecayForExc = 0;
                TTBackForExc = 0;
                TTDecRerurnRepeat = false;

            }
        }

        //instruction button
        private void button3_MouseMove(object sender, MouseEventArgs e) => this.toolTip1.SetToolTip((Control)this.button3, 
            "In game Main Chat Logging MUST be enabled. Press 'O' to open Options\n" +
            "Menu, then go to 'Interface' and 'Enable Main Chat Logging'\n\n" +
            "Select your chat.log file. By default you should find this file on" +
            "\nC:\\Users\\YourComputerName\\Documents\\Entropia Universe\n\n" +
            "On 'Ammo burn' write how much ammo you use on every shot.\n" +
            "You can find this by checking your weapon information or using tabs in program.\n\n" +
            "WARNING! Not all data about cost of shot on WIKI is correct, try to count yourself if you have problems.\n\n" +
            "Now press the Start Button and good luck!");

        //overlay button
        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.STT.HidingOption.Checked == false)
                    this.Hide();
                this.isCompact = true;
                this.CalculateProfit();
                FormOverlayGealLineHelper = this.STT.checkBoxSGIO.Checked;
                this.f3.checkGear();
                this.f3.MaximumSize = new System.Drawing.Size(180, this.f3.ResoulutionX);
                this.f3.MinimumSize = new System.Drawing.Size(180, this.f3.ResoulutionX);
                this.f3.ClientSize = new System.Drawing.Size(180, this.f3.ResoulutionX);
                this.f3.HalfMode.Location = new System.Drawing.Point(137, 62);
                this.f3.StartStop.Location = new System.Drawing.Point(137, 34);
                this.f3.StartStop.Size = new System.Drawing.Size(25, 25);
                this.f3.button1.Size = new System.Drawing.Size(25, 25);
                this.f3.button1.Location = new System.Drawing.Point(137, 6);
                this.f3.FlagHalfMode = false;
                this.f3.checkScroll(Convert.ToInt32(this.STT.ScrollingGearOverlay.Text));
                int num = (int)this.f3.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some problems with settings: " + ex);
            }

        }

        //chat.log checker
        //if chat.log updates, reads last string if sting was added
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                Thread.Sleep(1);
                using (StreamReader streamReader = new StreamReader((Stream)new FileStream(this.STT.pathText.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    long offset = streamReader.BaseStream.Length;
                    while (!this.backgroundWorker1.CancellationPending)
                    {
                        Thread.Sleep(100);
                        if (streamReader.BaseStream.Length != offset)
                        {
                            streamReader.BaseStream.Seek(offset, SeekOrigin.Begin);
                            string str;
                            while ((str = streamReader.ReadLine()) != null)
                                this.backgroundWorker1.ReportProgress(0, (object)str);
                            offset = streamReader.BaseStream.Position;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.backgroundWorker1.ReportProgress(0, (object)ex);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) => this.analyseLine(e.UserState.ToString());

        //line from chat.log checker
        private void analyseLine(string line)
        {
            //     ..........::::::^^~~~~~^~~~~~~~^:::^^:::^^:::::^^^^^^::.:::^:::^^:.::^:.:::.:^^:..:.:^^:..::..:::....:^:.....:^:....:^^^^^^^^^^^~~~~!!!!7!!!!~~~~^^^^^:...:
            //    ..........::...:^^~~~~~~~~~~~~~^.5G5 ~GG! ^P##B5::^^.^P###G7.PGG..GGG..GG5^GG5..?B##BJ..5GG::GGY 5GGGB7 ?B##B5:.^5##B5:.^^~~~~~~~~~~!!!!!7!!!!!~~~^^^^^:..:^
            //  .................:^~~~~~~~!~~~~~~^ &@@7!@@?.@@@7@@&.::.@@@7P@@^B@@!^@@@^~@@#^@@@ G@@5J@@B &@@^^@@& &@@B5^7@@&~@@#.@@@7@@@.:^~~~~~~~~~~!!!!!!!!!!!~~~~~^^^^:^:^
            // ..................:^~~~~~!!!~~~~~~^ &@@@P@@?:@@&.@@@.:^.#@@#5!: ?@@JJ@@@Y7@@?:@@& #@@~:&&B &@@PP@@& &@@57:~@@@GJ^..~~^ @@@:.^^^~~~~~~~!!77!!!!!!!!~~~~~~~~^^^^^
            //..................:^~~~~!!!!~~~~~~!~.&@@@@@@?:@@&.@@@.:~:.!G@@@B.:@@##@B@#B@@:^@@& #@@7 ^^^ &@@&&@@& &@@&&J :J#@@&J P##Y@@@:.^^^~~~!!!!!!!!!!!!!!!~~~~~~~~~~^^^^
            //..................:^~~~!!!!~~~~~!!7~.&@@Y@@@?:@@&.@@@.:^.BB5 B@@P &@&@@:@@&@@ ^@@& #@@~^@@& &@@~~@@& &@@~  7#B^:@@@:G&&5BG!.^^^~~~~!!!77!!!!!!!!!!!~~~~~~~~~^^^^
            //..................:~~~!!!!~~~~!!777!.&@@.&@@J #@@G@@B.^^.#@@5&@@J G@@@B G@@@B ~@@@ ?@@##@@Y &@@~~@@& &@@@&G~@@&P@@&.G&& .:^~~~~~~~~~!!77!!!!!!!!!!!~~~~~~~~~^^^^
            //..................^~~!!~~~~~!!777?77^7?7.^??^::!J5J!:^~~^:!J55?^::^?7?^.^?7?^.^?77::^?55?^::!7?::?7!.!777?7.^7Y5Y!:.!?7:^~~~~~~~~~~~!!777!!!!!!!!!!~~~~~!!~^^^^~
            //..................^~~!~~~~!!777??7777!~~~~^^~!~~^^^~~!~!!!~^^^^~~!~^^^~!~^^^~~~^^~~~~^^^^~~~~^^~~^^^~^^^^^^~^^:::^^~^:^^~~~~~~~!!!!!!!!!!!!!!!!!!!!!!!!!!!~^^^^~
            //.................:^~!!~~!!777????77!!!!~~~~~~~!!!!!!!!!!!!!!!!!!!!~~~~~~!!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!!!777!!!!!!!!!!!!!!!!!!!!!!~^^^^^
            // ................:~~~~~!77??????77!!!~~~~~~~~~!!!!!!!!!!!!!!!!!!!!!!!~~!!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!!7??7!!!!!!!!!!!!!!!!!!!!!~^^^^^
            //  .... ..      ..^~~~!!77??????77!!!~~~~~~~~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!~~~~~~~~~~~~~~~~!!!!!!!~~~~~~~~~~~~~~~~~~~~~~~~~~~!!!!!7777!!!!!!!!!!!!!!!!!!7!^^^^^^
            //   ...  ...    ..^~!!77??J???77!!!~~~~~~~~~~!!!!!777!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!~~~~~~~~~~~~~~~~~~~~~~~~!!!!!!!!777!!!!!!!!!!!!!!!!!77~^^^^^^
            //         ...   .:~!!7??JJ??77!!!!~~~~~~~~~~~~!!!!7777!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!~~!!~~~~~~~~~~~~~~~~~~~~~~~!!!!!!!!!7777!!!!!!!!!!!!!!!77!^:^^^:^
            //      ........ .:!7??J???77!!!!!~~~~~~~~~~~~~~~!!77777777!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!~~~~~~~~~~~~~~~~~~~~!!!!!!!!!!77777!7!!!!!!!!!!7777~::::::^
            //      .........:~7???777!!!!!!!~~~~~~~~~~~~~~~~!!77777777!!!!!!!!!!!!!!!!!!!!!!!!777777777777777!!!!!!!!~~~~~~~~~~~~~~~!!!!!!!777777777777!!!!!!!!!777?!^::::::^
            //      ........:~77777!!!!!!!!!~~~~~~~~~~~~~~~~~~!!77777777777!!!!!!!!!!!!!!!!!!!!!7777777777777777777!!!!!!!!!!~!!~!!!!!!!!!!!777777777777!!!!!!!!777?7~:::::::^
            //      ........^!!!!!!!!!!!!~~~~~~~~~~~~~~~~~~~~~~!!77777777777!!!!!!!!!!!!!!!!!!!!!!!!777777????????77777!!!!!!!!!!!!!!!!!!!!7777777777777!!!!!!!7777?!::::::::^
            //   ..........^!!!!!!!!!!!~~~~~~~~~~~~~~^^^^^~~~~~~~!7777777777!!!!!!!!!!!!!!!!!!!!!!!!!777777???????????7777!!!!!!!!!!!7777777777777777777!!!!!77777?!^::::::::^
            // ...........:~!!!!~~~!!!~~~~~~~~~~^^^^::..::^~~~~~~~!7!!7777777!!!!!!!!!!!!!!!!!!!!!!!!!!!7777????????????77777!!!77777777777777777777777!!!!!!777??7^:::::::::^
            //............:!!!!~~~~~~~~~~~~^^^:::........:^~~~~~~^:~!77!!77!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77777???????????77777777777777777777777777777!!!!77777??~::::::::::^
            //............:^~~~~^~~^^^^^:::...... ......:^^~~~~~!^..:~!!!77!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!7777777???????77777777777?????77777?77777!!!!!!7777??~:::::::::::^
            //.................:::::.......        ...:^^~~~~~~~!~^...:^~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77777777????777777???????????????77777!!!!!!!777??~::::::::::::^
            //............  ............        ...::^^~~~~~~~~~~~~^.. .::^~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77777777?????????????????????7777!!!!!!!777??~:::::::::::::^
            //.....  .....                  ....:::^^~~~~~~~~~~~~~~~~^......:^~~~~~~~~~~~~~!!!!!!~~!!!!!!!!!!!!!!!!!!!77777?????????????????77777!!!!!!!!77???~:::::::::::::::
            //......   ....          .....::::^^^^^~~~~~~~!!~~~~~~~~~!~^:. ....:::^^^^~~~~~~~~^^^^^^~~~~~~~~!!!!!!!!!!!77777?????????JJ?????7777!!!!!!!!777?7^::::::::::::.. .
            //.......  ....      ...:::^^^^^^^~~~~~~~~~~~~~!~!~~~~~~~~~!~~:.. ..........:................::^^^~~~~~~~!!!!777????JJJJJJJ????7777!!!!!!!!777?7^::::::::::..   .:
            //...............    .:^^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!~~^:..    ...              ........:::^^~~~~~!!!77???JJJJJJJJJ??777!!!!!!!!!77??!::::::::::.   ..::^
            //....................:^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~^::..            ..   .............::^~~~~!!77???JJJJJJJJJ??77!!!!!!!!!!7?7^::::::::..   ..::::^
            //.....................:^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~^::....                  . ......:^^~~~!!77??JJJJJJJJ??77!!!~~!!!!!77!::.::::..   ..:::::::^
            //.......................:^~~~~~~~~~~~~~~~~~~~~~~~~~~~~!~~~~~~~~~~~~~~~~~~^^^::...                .......:^~~~!77???JJJJJJJ?77!!~~~~~!!77!^:.::::.    ..:::::::::^
            //.........................:^~~~~~~~~~~~~~~~~~~~~~~~~~!!!~~~~~~~~~~~~~~~~~~~~~~^^^^^:::...          ......:^~~!!7???JJJJJJ?77!!~~~~~!!7!^:......   ..::::::::::::^
            //............................:^~~~~~~^^^^^^^^^^~~~~~~!!!~~~^^~~~~~~~~~~~~~~~~~~~~~^~~~~^^^::..       ....::^~~!7??JJJJJJ?77!!~~~~!!!!~:......   ..::::::::::::::^
            //..............................:^~~~~^^::::^^^^^^^^~~!!~~~^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~^^::..    .....:^~!7??JJJJJ??7!~~~~~!!~^:.....    ..::::::::::::::::^
            //.................................::.      ..:::^^^^~!!~~~^^^^~~~^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~^^^::.......:^~!7??JJJJJ?7!~~~~~^::......    ....:.:::::::::::::::
            //........................            .^^:.     ..::^~!!~~~^^^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~~~^^^::....:^!7??JJJJ?7!~~~~^.   ...     .........::::::::::::::
            //..................                .!5Y?~:..      .:^~!!~~^^^^^^^^^^^^^^^^^^^^::^^^^^^^^^^~~~~~~~~~~~~~^^::.:^~7??JJJ?7!~~~:.           ..............:::::::::::
            //................                 .7P5YJ~...       .:~!~~~^^^^^^^^^^^^:::::......::::::^^^^^^~~~~~~~~~~~^^^::^~7?JJJ?7!!!~.   .:^~~.  ....................:::::::
            //..............                   ^PPYJJ?:     :~~. .~!!~~^^^^^^^^^^:::..           ...:::^^^^^~~~~~~~~~~^^^^^!7?JJJ?7!7!^.::^!777~:............................:
            //............                     !P55J^.     .^!!.  ~!!~~^^^^^^^::::.....:::..          .::^^^^^^~^^~~^^^^^~~!7JJJ?7!~^:::^~~~^^:.. ...........................:
            //..........                      .!555?^..           ~!!~~^^^^^^^::...:~!77!^:.            ..::^^^^^^^^^^^^~~!7?JJJ7!^:.::^^::::..     .........................:
            //.......                        .::~JYJ^.....       .!!~~^^^^^^^::...^!?JYJ^....             ..:^^^^^^^^^^~~!7?JYJ7~::::^~^..::.        ........................:
            //..                     .      :!~:::^!7~:... ...   ^7!~~^^^^^^^:...:!?JY5?^.    .::.          .:^^^^^^^^^~~!?JYJ7~:::^~~^.::.           .......................:
            //                              ~7!~^:::.:::........^77!~~^^^^^^^:...^7JYY7:..   .~7!^    ..:.   .:^~~^^^^~~7?JYJ!^::::^^:::.               .....................:
            //                             .~!!~~^:::::.......:~777!~^^^^^^^^:...~7JYJ7:.    ..:..    .^~~: .:^~!!!!!!!7?JYJ!:::::::::.              .    ...................:
            //             .                ~7!!~~^^::::::::^~!777!~~^^^^^^^^::..^7?JJ7^.             :!??~..^!77???JJJJYYY7!::^^^^:.                  .... .................:
            //         ..                   ^77!!!~~~^^~~~~!!7??7!~~~^^^^^^^:::...~7JJJ!:.......... .:!?J7^:^!7?JJJYYYYY5Y7!~~~^^:.                       ...  ...............
            //     ....                     :!7!!!!~~~!!!7777??7!~~^^^^^^^^:::::...:~7?J7~:.:::.....:~!~^::^!?JJYYYY55555?!~^:.                              .................
            //  ... .^^.....              ...~!!!!!!!!!7777???7!~~^^^^^^^^^^:::::.....::^~^:.......::::::^~!7?JJYYY55555Y7^.                                   ...............
            //..      ..:....................^!!!!!~~~!777??77!~^^^^^^^^^^^^^:::::.:::::........::::^^^^~!77?JJYYYY55YYJ!.                                        ............
            //           ..:.......:::.......:~!~~~~!77????7!~~^^^^^^^^^^^^^^^^::::::::::::::::::::::^~~!77?JJJYYYYYYY7:                                             ....  ...
            //               ...........:::...^!~~~!7????77!~~~^^^^^^^^^^^~~~^^^^^^^^::::::::::::^^^~!!777???JJJJJJJJ!.                                                ....  .
            //                  ......       .^~~!!77???77!~~~~^^^^^^^^^~~~~^^~~~^~~^^^^^^^^^^^^~~~~!!!!77777???????~. .. .                                               ....
            //                     ..         .~!77?????7!~~~~~~~~~~^~~~~~~~^^^~~~~~~~~~~~~~~~~~~~~~~~~~!!!!!777777^......:..                                                .
            //                    ...    .   .^!77????77!~~!!!!!~~~~~~~~~~~~~^^^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!!!77~:.....:^:....                                              
            //                    ...........^777????77!!!!!!!!!777!!!!!~~~~~~~^^~~~~~~~^^^^^^^^^^^^^^^~~~~~~!!77!:..   .^........           ...                              
            //                    ..........^77?????77!!7777777?????777!!!~~~~~~~~~~~~^^^^^^^^^^^^^^^^~~~~~!!!77!^~^.  .^:...........      ...:!?:                            
            //                    .........:!7?????77777????JJJJJJJ???77!!!!!~~~^^^^^^^^^^^^^^^^^^^^^~~~~~!!77?!:^??~::::..::.:::............ :5Y.                            
            //                     .......:~7??????777??JJJYYYYYYYYJJ??777777!!~^^^^^^^^^^^^^^^^^^^~~~~~~!!77?!...~!!~^^:::::::::::........  .~J:                             
            //                     .......:!??????????JJYYY5555555YJJ???7?7777!~^^^^^^^^^^^^^^^^^^~~~~~!!!7??7.   :^^:^^^^:::::::::...      .:~:.                             
            //                     ......^!??JJ????JJJYY5555PPPP55YJJJ?????77!~^^^^^^^^^^^^^^^^^^~~~~~!!77??7.    .^^...:::::::::::......   .:...                             
            //                      .. .^7??JJJJJJJYYY555PPPPPP55YYJJJJ???77!~^^^^^^^^^^^^^^^^^^~~~~!!!77??7.      ... ....::::::..................                           
            //                       .:~7?JJJJYYYYY5555PPPPPPP55YYJJJ???77!~^^^^^^^^^^^^^^^^^^~~~~!!777???7.             ....................:::::....                        
            //                      .^77?JJJYYYYY5555PPPPPPP555YYJ??77!!~~^^^^^^^^^^^^^^^^^^^~~~!!!77????!.                 .....................:::....                      
            //                     .^7?7?JJJJYYY5555PPPPP5555YYJ?7!!~~~~~~~~~~~^^^^^^^^^^^^~~~~!!777????!.                      ...........................                   
            //                      .^~!!77?JJYYY55555555YYYJ?7!!!!!!7777777!!!~~~^^^^^^^^^~~!!!77???J?!.                                  ..................                 
            //                       .^~~~~!7?JJJJYYYYYJJ??77!!!77???JJJJJJ???7!!~~^^^^^^^^~~!!77?????~.                                      .................   ..          
            //                      ..:^~~~~~!77??????77!!!!!77??JJYYYYYYYYYJJ??7!~~~^^^^^~~!!77?????~.                                           ..............    ..        
            //                 ..   ....:^^^^~~~!!!!~~~~~~!!77??JJJYYYYYYYYYYYJJ?7!!~^^^^^~!!777???7^.                                       ..      ............      ..     
            //                ..    ..   ..::::^~~^^^^:::::^^~~!!!77777777??JYYJJ?7!~~^^^~~!!77???!:                                                        .....             
            //               ...              .:~~^^::::::::::^^^~!!!7!!!~^^^~7?J??7!~^^^~~!777?7~.                                                                          .
            //              ...                :~~^:.....:::::^^~~!77?JJYYJ7!^:^~7?7!^^^^~!!777!^.                                                                           .
            //             ...                .:~~^:.    ...:::^^^~~!!!777????7~^^!!!^^^~~!777!^..   ...                                                                      
            // :::.:::^:..:.:::.             ..^~^^:.      ..::^^^^^^^^^~~~!!777!~^~~^^^~!!7!~:.........                                                                      
            // ...::..... . ....            ...:^^:..      ...:::::::^^^^^^~~~~!!!^::::^~~~~^:.........                                                                        
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");               
                string ProfTetboxHelp = Convert.ToString(CProf);
                bool saveBU = false; //bu = backUp
                //shot comfirm if not Emode
                if ((line.Contains("[System] [] You inflicted")) && (!this.fCC.ProfList[Convert.ToInt32(ProfTetboxHelp) - 1].USEEFLAG))
                {
                    DecReturnReact();
                    ++this.totalAttacks;
                    tReloadC = tReloadC + this.attacksPerMinute;
                    this.ammoSpent += this.ammoPerShot;
                    SecondsBeforeAFKTimer = 0;
                    AddItemStatus(double.Parse(line.Substring(line.IndexOf("inflicted ")).Split((char[])null)[1], (IFormatProvider)this.ci));
                    this.tDamage += double.Parse(line.Substring(line.IndexOf("inflicted ")).Split((char[])null)[1], (IFormatProvider)this.ci);
                    this.statsGrid.Rows[0].Cells[1].Value = (object)this.totalAttacks.ToString("N0"); //shots
                    this.statsGrid.Rows[1].Cells[1].Value = (object)(this.crits.ToString("N0") + " (" + (this.crits * 100.0 / this.totalAttacks).ToString("F2") + " %)"); //criticals
                    this.statsGrid.Rows[2].Cells[1].Value = (object)this.tDamage.ToString("N2"); //dmg done
                    this.statsGrid.Rows[5].Cells[1].Value = (object)((100.0 - this.dodgedAt * 100.0 / this.totalAttacks).ToString("F2") + " %"); //accuracy(not missed %)
                    saveBU = true;
                }
                //crit shot comfirm if not Emode
                if (line.Contains("[System] [] Critical hit") && line.Contains("You inflicted") && (!this.fCC.ProfList[Convert.ToInt32(ProfTetboxHelp) - 1].USEEFLAG))
                {
                    DecReturnReact();
                    SecondsBeforeAFKTimer = 0;
                    ++this.totalAttacks;
                    this.ammoSpent += this.ammoPerShot;
                    ++this.crits;
                    double num = double.Parse(line.Substring(line.IndexOf("inflicted ")).Split((char[])null)[1], (IFormatProvider)this.ci);
                    AddItemStatus(num);
                    this.tDamage += num;
                    this.tCritDamage += num;
                    this.statsGrid.Rows[0].Cells[1].Value = (object)this.totalAttacks.ToString("N0"); //shots
                    this.statsGrid.Rows[1].Cells[1].Value = (object)(this.crits.ToString("N0") + " (" + (this.crits * 100.0 / this.totalAttacks).ToString("F2") + " %)"); //criticals
                    this.statsGrid.Rows[2].Cells[1].Value = (object)this.tDamage.ToString("N2"); //dmg done
                    this.statsGrid.Rows[3].Cells[1].Value = (object)this.tCritDamage.ToString("N2"); //critdmg done
                    this.statsGrid.Rows[5].Cells[1].Value = (object)((100.0 - this.dodgedAt * 100.0 / this.totalAttacks).ToString("F2") + " %"); //accuracy(not missed %)

                    //saves dublicate of backup
                    if (this.STT.checkBoxBackup.Checked)
                    {
                        using (StreamWriter writer = new StreamWriter(new FileStream(this.BackUpPathDuplicate, FileMode.Create, FileAccess.Write)))
                        {
                            SaveCSV(writer);
                        }
                    }

                    saveBU = true;
                }
                //mob dodged/evaded/jammed
                if ((line.Contains("[System] [] The target Dodged")) | (line.Contains("[System] [] The target Evaded")) | (line.Contains("[System] [] The target Jammed")))
                {
                    DecReturnReact();                   
                    ++this.totalAttacks;
                    ++this.dodgedAt;
                    this.ammoSpent += this.ammoPerShot;
                    AddItemStatus(0);
                    this.statsGrid.Rows[0].Cells[1].Value = (object)this.totalAttacks.ToString("N0"); //shots
                    this.statsGrid.Rows[4].Cells[1].Value = (object)this.dodgedAt.ToString("N0"); //missed attacks
                    this.statsGrid.Rows[5].Cells[1].Value = (object)((100.0 - this.dodgedAt * 100.0 / this.totalAttacks).ToString("F2") + " %"); //accuracy(not missed %)
                    saveBU = true;
                }
                //missed shot
                if (line.Contains("[System] [] You missed"))
                {
                    DecReturnReact();
                    ++this.totalAttacks;
                    this.ammoSpent += this.ammoPerShot;
                    ++this.dodgedAt;
                    AddItemStatus(0);
                    this.statsGrid.Rows[0].Cells[1].Value = (object)this.totalAttacks.ToString("N0"); //shots
                    this.statsGrid.Rows[4].Cells[1].Value = (object)this.dodgedAt.ToString("N0"); //missed attacks
                    this.statsGrid.Rows[5].Cells[1].Value = (object)((100.0 - this.dodgedAt * 100.0 / this.totalAttacks).ToString("F2") + " %"); //accuracy(not missed %)
                    saveBU = true;
                }
                //dmg received by avatar
                if (line.Contains("[System] [] You took"))
                {
                    this.tDamageRec += (double)float.Parse(line.Substring(line.IndexOf("took ")).Split((char[])null)[1], (IFormatProvider)this.ci);
                    ++this.atRecividos;
                    this.statsGrid.Rows[6].Cells[1].Value = (object)(this.evaded.ToString("N0") + " (" + (this.evaded * 100.0 / this.atRecividos).ToString("F2") + " %)"); //missed hits received
                    this.statsGrid.Rows[7].Cells[1].Value = (object)this.atRecividos.ToString("N0"); //hits received
                    this.statsGrid.Rows[8].Cells[1].Value = (object)(this.critRecividos.ToString("N0") + " (" + (this.critRecividos * 100.0 / this.atRecividos).ToString("F2") + " %)"); //crit hits received 
                    this.statsGrid.Rows[9].Cells[1].Value = (object)this.tDamageRec.ToString("N2"); //dmg received
                    saveBU = true;
                }
                //crit dmg received by avatar
                if (line.Contains("[System] [] Critical hit") && line.Contains("You took"))
                {
                    string[] strArray = line.Substring(line.IndexOf("took ")).Split((char[])null);
                    this.tDamageRec += double.Parse(strArray[1], (IFormatProvider)this.ci);
                    this.tCritDamageRec += double.Parse(strArray[1], (IFormatProvider)this.ci);
                    ++this.atRecividos;
                    ++this.critRecividos;
                    this.statsGrid.Rows[6].Cells[1].Value = (object)(this.evaded.ToString("N0") + " (" + (this.evaded * 100.0 / this.atRecividos).ToString("F2") + " %)"); //missed hits received
                    this.statsGrid.Rows[7].Cells[1].Value = (object)this.atRecividos.ToString("N0"); //hits received
                    this.statsGrid.Rows[8].Cells[1].Value = (object)(this.critRecividos.ToString("N0") + " (" + (this.critRecividos * 100.0 / this.atRecividos).ToString("F2") + " %)"); //crit hits received 
                    this.statsGrid.Rows[9].Cells[1].Value = (object)this.tDamageRec.ToString("N2"); //dmg received
                    this.statsGrid.Rows[10].Cells[1].Value = (object)this.tCritDamageRec.ToString("N2"); //crit dmg received
                    saveBU = true;
                }
                //avatar dodged/evaded/jammed
                if (line.Contains("[System] [] You Dodged the attack") || line.Contains("[System] [] You Evaded the attack") || line.Contains("[System] [] The attack missed you") || line.Contains("[System] [] You Jammed the attack"))
                {
                    ++this.atRecividos;
                    ++this.evaded;
                    this.statsGrid.Rows[6].Cells[1].Value = (object)(this.evaded.ToString("N0") + " (" + (this.evaded * 100.0 / this.atRecividos).ToString("F2") + " %)"); //missed hits received
                    this.statsGrid.Rows[7].Cells[1].Value = (object)this.atRecividos.ToString("N0"); //hits received
                    saveBU = true;
                }

                //avatar's armor deflected
                if (line.Contains("[System] [] Damage deflected!"))
                {
                    ++this.atRecividos;
                    this.statsGrid.Rows[6].Cells[1].Value = (object)(this.evaded.ToString("N0") + " (" + (this.evaded * 100.0 / this.atRecividos).ToString("F2") + " %)"); //missed hits received
                    this.statsGrid.Rows[7].Cells[1].Value = (object)this.atRecividos.ToString("N0"); //hits received
                    saveBU = true;
                }

                //unused
                line.Contains("[System] [] You healed yourself");
                //unused
                line.Contains("[System] [] You died");

                //enh breack track
                if (line.Contains("[System] [] Your enhancer"))// чек экхансера
                {
                    this.AddEnhancer(this.listaItemsEnh, line, true);
                    saveBU = true;
                }

                //tier of gear track
                if (line.Contains("[System] []") && line.Contains(" has reached"))// чек таира
                {
                    this.AddTierItem(this.listTiering, line, true);
                    saveBU = true;
                }

                //loot check
                if (line.Contains("[System] [] You received"))// тут изменяется лут                
                {
                    //main class for working with loot
                    this.AddItems(this.listaItems, line, true);

                    //if mining mode on and Emode of current prof off, add decay (made for excovators track)
                    if (this.STT.MiningMode.Checked && (!this.fCC.ProfList[Convert.ToInt32(ProfTetboxHelp) - 1].USEEFLAG))
                    {
                        SecondsBeforeAFKTimer = 0;
                        this.ammoSpent += this.ammoPerShot;
                        AddItemStatus(0);
                        CalculateProfit();
                    }

                    //timer loot events to count right amount of killed mobs
                    if ((this.ticks > this.tickLooted + this.delay) && !this.STT.MiningMode.Checked)
                    {
                        //not count loot event if item from unused list
                        if (!globalFlagUnused)
                            GrafMobCountAdd();
                        else
                            globalFlagUnused = false; //setting it to def value for next loot
                    }

                    this.tickLooted = this.ticks;

                    DecReturnWrite();

                    saveBU = true;
                }

                //mining mode count climes, mot mobs killed
                if (this.STT.MiningMode.Checked && line.Contains("[System] [] This resource is depleted"))
                {
                    GrafMobCountAdd();
                    this.ammoSpent += this.ammoPerShot;
                    saveBU = true;
                }

                //skills track
                if (line.Contains("[System] [] You have gained") || (line.Contains("has improved by") && (line.Contains("[System] [] Your"))))// чек cскилов
                {
                    if (!line.Contains("[System] [] You have gained a new rank"))
                        this.AddSkill(this.listaItemsEnh, line, true);
                    saveBU = true;
                }

                //team track
                if (this.trackTeam & line.Contains("[Team] [] ") && line.Contains("received"))
                {
                    string sortTeamNick = line.Substring(line.IndexOf("[]") + 3, line.IndexOf("received") - line.IndexOf("[]") - 4);
                    string sortTeamItem;
                    int sortTeamNum;
                    if (line.Contains(" a "))
                    {
                        sortTeamItem = line.Substring(line.IndexOf(" a ") + 3);
                        sortTeamNum = 1;
                    }
                    else
                    {
                        sortTeamItem = line.Substring(line.IndexOf("received") + 9, (line.LastIndexOf(" (") - line.IndexOf("received") - 9));
                        sortTeamNum = Convert.ToInt32(line.Substring(line.LastIndexOf("(") + 1, line.LastIndexOf(")") - line.LastIndexOf("(") - 1));
                    }
                    TeamReactItem(sortTeamNick, sortTeamItem, sortTeamNum, line);

                    //team backup save
                    if(this.STT.checkBoxBackupTeam.Checked)
                    {  
                        using (StreamWriter writer = new StreamWriter(TeamBackupPath))
                        {
                            writer.Write(FullTeamInfo);
                        }
                    }
                    //saveBU = true; is not necessary
                }

                //global track
                if (line.Contains("[Globals] [] ") && line.Contains(this.STT.NickName.Text) && !this.STT.NickName.Text.Equals(""))
                {
                    GlobalChecker(line);
                    //saveBU = true; is not necessary
                }

                this.CalculateProfit();

                //after some line used, saves backUp oh hunt\mine
                if (this.STT.checkBoxBackup.Checked && saveBU)
                    BackUpFunction(this.listaItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show("analyseLine(): " + line + ex);
            }
        }

 
        public void GlobalChecker(string line)
        {
            bool flagNotUsual = false;
            string item;
            string value;
            string LineForSwitch = "";
            int rows;
            string lineSplit = line.Remove(0, line.IndexOf(this.STT.NickName.Text) + this.STT.NickName.Text.Length + 1);
            if (lineSplit.StartsWith("is") || lineSplit.Contains("has found a rare item"))
            {
                flagNotUsual = true;
                LineForSwitch = "is";
            }
            else
            {
                if (lineSplit.Contains("killed a creature"))
                    LineForSwitch = "killed";
                else if (lineSplit.Contains("constructed"))
                    LineForSwitch = "constructed";
                else if (lineSplit.Contains("found"))
                    LineForSwitch = "found";
            }


            switch (LineForSwitch)
            {
                case "killed":
                    item = line.Remove(0, line.IndexOf("a creature ") + 12);
                    item = item.Remove(item.LastIndexOf(")"));
                    value = line.Remove(0, line.IndexOf("with a value of ") + 16);
                    value = value.Remove(value.IndexOf(" "));
                    rows = dGVGlobals.RowCount;
                    dGVGlobals.Rows.Add();

                    if (line.Contains("A record has been added to the Hall of Fame!"))
                        dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                    else
                        dGVGlobals.Rows[rows].Cells[0].Value = "(G)";
                    dGVGlobals.Rows[rows].Cells[1].Value = item;
                    dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);

                    textBoxGlobals.Text = line + "\r\n" + textBoxGlobals.Text;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = true;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = false;
                    break;

                case "constructed":
                    item = line.Remove(0, line.IndexOf("constructed an item ") + 21);
                    item = item.Remove(item.LastIndexOf(")"));
                    value = line.Remove(0, line.IndexOf("worth") + 6);
                    value = value.Remove(value.IndexOf(" "));
                    rows = dGVGlobals.RowCount;
                    dGVGlobals.Rows.Add();

                    if (line.Contains("A record has been added to the Hall of Fame!"))
                        dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                    else
                        dGVGlobals.Rows[rows].Cells[0].Value = "(G)";
                    dGVGlobals.Rows[rows].Cells[1].Value = item;
                    dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);
                    textBoxGlobals.Text = line + "\r\n" + textBoxGlobals.Text;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = true;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = false;
                    break;

                case "found":
                    item = line.Remove(0, line.IndexOf("a deposit ") + 11);
                    item = item.Remove(item.LastIndexOf(")"));
                    value = line.Remove(0, line.IndexOf("with a value of") + 16);
                    value = value.Remove(value.IndexOf(" "));
                    rows = dGVGlobals.RowCount;
                    dGVGlobals.Rows.Add();

                    if (line.Contains("A record has been added to the Hall of Fame!"))
                        dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                    else
                        dGVGlobals.Rows[rows].Cells[0].Value = "(G)";
                    dGVGlobals.Rows[rows].Cells[1].Value = item;
                    dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);

                    textBoxGlobals.Text = line + "\r\n" + textBoxGlobals.Text;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = true;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = false;
                    break;

                case "is": //rare find
                    if (line.Contains("is the first colonist to reach"))
                    {
                        item = line.Remove(0, line.IndexOf("to reach tier") + 9);
                        item = item.Remove(item.IndexOf("!"));
                        value = "0";
                    }
                    else if (line.Contains("has found a rare item"))
                    {
                        item = line.Remove(0, line.IndexOf("(") + 1);
                        item = item.Remove(item.LastIndexOf(")"));
                        value = line.Remove(0, line.IndexOf("with a value of") + 16);
                        if (value.Contains("PEC!"))
                        {
                            value = value.Remove(value.IndexOf(" "));
                            value = Convert.ToString(Convert.ToDouble(value) * 0.01);
                        }
                        else
                            value = value.Remove(value.IndexOf(" "));
                    }
                    else
                    {
                        item = line.Remove(0, line.IndexOf("to discover ") + 12);
                        item = item.Remove(item.IndexOf("!"));
                        value = "0";
                    }
                    rows = dGVGlobals.RowCount;
                    dGVGlobals.Rows.Add();
                    dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                    dGVGlobals.Rows[rows].Cells[1].Value = item;
                    dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);

                    textBoxGlobals.Text = line + "\r\n" + textBoxGlobals.Text;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = true;
                    this.dGVGlobals.Rows[0].Cells[0].Selected = false;
                    break;
            }

            //for header of global counters
            GlobalsTT = 0;
            int G = 0, H = 0;
            for (int i = 0; i < dGVGlobals.RowCount; i++)
            {
                GlobalsTT += Convert.ToDouble(dGVGlobals.Rows[i].Cells[2].Value);
                if (Convert.ToString(dGVGlobals.Rows[i].Cells[0].Value) == "(G)")
                    G++;
                else
                    H++;
            }

            dGVGlobalsVolume.HeaderText = "Value: " + GlobalsTT;
            dGVGlobalsObject.HeaderText = "Globals: " + G + "\r\nHofs: " + H;

            AutoSaveGlobals();
        }

        //Decay and return writer to file
        //Excel addons working rly slow, so better was just using .csv to import (u can actually just open it with Excel)
        private void DecReturnWrite()
        {
            try
            {
                if (TTBackForExc != 0 && this.STT.checkBoxOutValue.Checked)
                {
                    string InfoFromCsv = "";
                    //checks, is there already a file
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Decay and loot values.csv"))
                    {
                        using (StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Decay and loot values.csv"))
                        {
                            InfoFromCsv = streamReader.ReadToEnd();
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Decay and loot values.csv", FileMode.Create, FileAccess.Write)))
                    {
                        
                        if (!InfoFromCsv.Equals(""))
                        {
                            //to count multi loot stuff from one mob, it uses this var, it sets true after first loot and sets false after shot
                            //(check DecReturnReact() usage in analyseLine() for more info)
                            //if true, rewrites lst line
                            if (TTDecRerurnRepeat)
                            {
                                //checking does it have notes or one note
                                if (InfoFromCsv.LastIndexOf(";\r\n") > 0)
                                {
                                    InfoFromCsv = InfoFromCsv.Remove(InfoFromCsv.LastIndexOf(";\r\n"));
                                    InfoFromCsv = InfoFromCsv + ";\r\n" + TTDecayForExc + ";" + TTBackForExc;
                                }
                                else
                                    InfoFromCsv = TTDecayForExc + ";" + TTBackForExc;
                            }
                            else //writing last line
                                InfoFromCsv = InfoFromCsv + ";\r\n" + TTDecayForExc + ";" + TTBackForExc;
                        }
                        else //writing first line
                            InfoFromCsv = TTDecayForExc + ";" + TTBackForExc;

                        InfoFromCsv = InfoFromCsv.Replace(".", ",");
                        writer.Write(InfoFromCsv);
                    }
                }
                TTDecRerurnRepeat = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("DecReturnWrite(): " + ex);
            }

        }

        //Reacting on decay/return after shot
        private void DecReturnReact()
        {
            if (TTBackForExc > 0)
                TTDecayForExc = 0;
            TTBackForExc = 0;
            TTDecRerurnRepeat = false;
            TTDecayForExc += (this.ammoPerShot * 0.01);
            TTDecayForExc = Math.Round(TTDecayForExc, 4);
        }

        //Track team (from analyseLine())
        public void TeamReactItem(string nick, string item, int num, string line)
        {
            try
            {
                teamWait = true;
                string playerLine;
                bool flagRN = false; //avatar is last in file
                string NanValue = "";

                //there is one main file for all team stuff, its just shows who what looted, u can check that file in Addons folder
                //if file already have this avatar, than finds his line...
                if (FullTeamInfo.Contains(nick))
                {   
                    //...gets that line...
                    playerLine = FullTeamInfo.Substring(FullTeamInfo.IndexOf(nick));
                    playerLine = playerLine.Substring(0, playerLine.IndexOf(";") + 1);
                    // ...deletes from original var...
                    if (FullTeamInfo.Contains(playerLine + "\r\n"))
                    {
                        FullTeamInfo = FullTeamInfo.Replace(playerLine + "\r\n", "");
                    }
                    else
                    {
                        FullTeamInfo = FullTeamInfo.Replace(playerLine, "");
                        flagRN = true;
                    }
                    //...and if it already have this item, than rewrites it with new values
                    if (playerLine.Contains(item))
                    {
                        string newNumSTR = playerLine.Remove(0, playerLine.IndexOf(item) + item.Length + 3);
                        newNumSTR = newNumSTR.Replace(",", ";");
                        string oldnumHelp = newNumSTR.Remove(newNumSTR.IndexOf(";"), newNumSTR.Length - newNumSTR.IndexOf(";"));
                        // * in filen means there is custom TT value for that item
                        if (oldnumHelp.Contains("*"))
                        {
                            NanValue = oldnumHelp.Remove(0, oldnumHelp.IndexOf("*"));
                            oldnumHelp = oldnumHelp.Remove(oldnumHelp.IndexOf("*"));
                        }
                        int oldNum = Convert.ToInt32(oldnumHelp);
                        int newNum = oldNum + num;
                        playerLine = playerLine.Replace(item + " x " + oldNum + NanValue, item + " x " + newNum + NanValue);
                        if (flagRN)
                            FullTeamInfo = FullTeamInfo + playerLine;
                        else
                            FullTeamInfo = FullTeamInfo + "\r\n" + playerLine;
                    }
                    else //...and if it dont have this item, adds it
                    {
                        playerLine = playerLine.Replace(";", ", ") + item + " x " + num + ";";
                        if (flagRN)
                            FullTeamInfo = FullTeamInfo + playerLine;
                        else
                            FullTeamInfo = FullTeamInfo + "\r\n" + playerLine;
                    }
                }
                else //if dont have, than just adds him with loot
                {
                    if (FullTeamInfo == "")
                        FullTeamInfo = nick + " : " + item + " x " + num + ";";
                    else
                        FullTeamInfo = FullTeamInfo + "\r\n" + nick + " : " + item + " x " + num + ";";

                    cB_SelectTeamMember.Items.Add(nick);

                }
                teamWait = false;// unused

                //checking tt value frim EUmats (file in addons)
                using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUmats.csv"))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(",");                    
                    while (!textFieldParser.EndOfData)
                    {
                        string[] strArray2 = textFieldParser.ReadFields();
                        foreach (string str4 in strArray2)
                        {
                            if (str4 == item)
                            {
                                double ttPerUnit = double.Parse(strArray2[1], (IFormatProvider)this.ci);
                                fullTeamTT = fullTeamTT + Convert.ToDouble((num * ttPerUnit));
                                break;
                            }
                        }
                    }
                }

                //selecting first member in tab if firstly open 
                if(cB_SelectTeamMember.Text.Equals(""))
                    cB_SelectTeamMember.SelectedIndex = 0;

                //pressing on cell undder TT column, to make custom value for item
                EventArgs e = null;
                if ((totalTeam.SelectedTab == tt) && !FullTeamInfo.Equals(""))
                    cB_SelectTeamMember_SelectedIndexChanged(1, e);

                //if team totalTeam tab seleted and there are team loot, count and show info in diagram
                //made for optimization
                if ((totalTeam.SelectedTab == TotalTeamdGV) && !FullTeamInfo.Equals(""))
                    TeamTotalCount();

                //backUp for team located in analyseLine()
            }
            catch (Exception ex)
            {
                MessageBox.Show("TeamReactItem(): " + line + "\r\n" + FullTeamInfo + ex);
            }
        }

        //Counting total values of all Team stuff and dGV (dataGridView) showing
        private void TeamTotalCount()
        {
            try
            {                
                dGVTeamTotal.Rows.Clear();//dont like it, but didnt foind any other options how to proprly update it
                string FullTeamCopy = FullTeamInfo.Replace(";\r\n", ";");                    

                string item;
                string volume;
                        
                string line = FullTeamCopy.Remove(0, FullTeamCopy.IndexOf(" : ") + 3);
                //seperates original file and line by line analyses it
                if (!line.IndexOf(";").Equals(line.Length - 1))
                    line = line.Remove(line.IndexOf(";") + 1);

                while (!FullTeamCopy.Equals(""))
                {
                    bool noItem = false; //no value for item set(custom set)
                    item = line.Remove(line.IndexOf(" x "), line.Length - line.IndexOf(" x "));
                    double ttValueNan = 0;
                    //getting volume of item and custom tt if set
                    if (line.Contains(","))// if line have more than one item
                    {                                
                        volume = line.Remove(0, line.IndexOf(" x ") + 3);
                        volume = volume.Remove(volume.IndexOf(","));
                        if(volume.Contains("*"))//custom tt
                        {
                            ttValueNan = Convert.ToDouble(volume.Remove(0, volume.IndexOf("*") + 1));
                            volume = volume.Remove(volume.IndexOf("*"));
                            noItem = true;
                        }
                        //deletes item from line
                        line = line.Remove(0, line.IndexOf(",") + 2);
                    }
                    else//if line got only one item
                    {
                        volume = line.Remove(0, line.IndexOf(" x ") + 3);
                        volume = volume.Remove(volume.IndexOf(";"));
                        if (volume.Contains("*"))
                        {
                            ttValueNan = Convert.ToDouble(volume.Remove(0, volume.IndexOf("*") + 1));
                            volume = volume.Remove(volume.IndexOf("*"));
                            noItem = true;
                        }

                        FullTeamCopy = FullTeamCopy.Remove(0, FullTeamCopy.IndexOf(";") + 1);

                        //totaly deletes line
                        if (!FullTeamCopy.Equals(""))
                            line = FullTeamCopy.Remove(0, FullTeamCopy.IndexOf(" : ") + 3);
                        if(!line.IndexOf(";").Equals(line.Length - 1))
                            line = line.Remove(line.IndexOf(";") + 1);
                    }   
                    
                double ttValueUnit = 0;

                    //checkign tt value of item  
                    using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUmats.csv"))
                    {
                        textFieldParser.TextFieldType = FieldType.Delimited;
                        textFieldParser.SetDelimiters(",");
                        bool BreakPoint = false;
                        while (!textFieldParser.EndOfData)
                        {
                            string[] strArray2 = textFieldParser.ReadFields();
                            foreach (string str4 in strArray2)
                            {
                                if (str4 == item)
                                {
                                ttValueUnit = double.Parse(strArray2[1], (IFormatProvider)this.ci);
                                BreakPoint = true;
                                break;
                                }
                            }
                        if (BreakPoint)
                            break;
                        }
                    }

                    bool FlagTTfound = false;
                    //putting info in dGV
                    foreach (DataGridViewRow row in (IEnumerable)this.dGVTeamTotal.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(item))
                        {

                        if (noItem)
                        {
                            row.Cells[2].Value = Convert.ToDouble(row.Cells[2].Value) + ttValueNan;
                            row.Cells[0].Value = Convert.ToInt32(row.Cells[0].Value) + Convert.ToInt32(volume);
                            noItem = false;
                        }
                        else
                        {
                            row.Cells[0].Value = Convert.ToInt32(row.Cells[0].Value) + Convert.ToInt32(volume);
                            row.Cells[2].Value = Convert.ToDouble(Convert.ToDouble(row.Cells[2].Value) + Convert.ToInt32(volume) * ttValueUnit).ToString("F2");
                        }
                            FlagTTfound = true;                                
                            row.Cells[0].Selected = false;
                            break;
                        }
                    }

                    //if no TT value of item in EUmats
                    if (!FlagTTfound)
                    {
                        int RNum = dGVTeamTotal.RowCount;
                        dGVTeamTotal.Rows.Add();
                        dGVTeamTotal.Rows[RNum].Cells[1].Value = item;
                        dGVTeamTotal.Rows[RNum].Cells[0].Value = Convert.ToInt32(volume);
                        if (noItem)
                        { 
                            dGVTeamTotal.Rows[RNum].Cells[2].Value = ttValueNan.ToString("F2");
                            noItem = false;
                        }
                        else
                        dGVTeamTotal.Rows[RNum].Cells[2].Value = Convert.ToDouble(Convert.ToInt32(volume) * ttValueUnit).ToString("F2");
                    }                        
                }

                double fullTeamTTFromdGV = 0;
                foreach (DataGridViewRow row in (IEnumerable)this.dGVTeamTotal.Rows)
                {
                    fullTeamTTFromdGV += Convert.ToDouble(row.Cells[2].Value);                    
                }
                fullTeamTT = fullTeamTTFromdGV;
                labelTotalTeamTT.Text = fullTeamTTFromdGV.ToString("F2");
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("TeamTotalCount():" + ex);
            }
        }   

        //Adding point is ReturnGraf
        private void GrafMobCountAdd()
        {           
            ++this.mobsKilled;
            ++this.mobskilledv2;
            if (((this.mobsKilled % Convert.ToInt32(this.STT.MobsKilled.Text)) == 0) & (this.mobsKilled != 0))// тут формируются точки для графа
            {
                string ttmu = (string)this.balanceGrid.Rows[4].Cells[1].Value;
                ttmu = ttmu.Replace(" %", "");
                string mu = (string)this.balanceGrid.Rows[8].Cells[1].Value;
                mu = mu.Replace(" PED", "");
                string tt = (string)this.balanceGrid.Rows[9].Cells[1].Value;
                tt = tt.Replace(" %", "");


                GrafCountings.Add(new GrafCounting(mobsKilled, Convert.ToDouble(tt), Convert.ToDouble(ttmu), Convert.ToDouble(mu)));

                if (tabGraf.SelectedTab == tabPage3)
                    cartesianChart1count();
            }
        }

        //Adding info about used gear
        private void AddItemStatus(double damage)
        {
            try
            {
                string ItemName;

                if (this.fCC.ProfList[CProf - 1].WEAPONINDEX == 0)
                    ItemName = this.fCC.Tools[this.fCC.ProfList[CProf - 1].TOOLINDEX].NAME;

                else
                {
                    ItemName = this.fCC.Weapons[this.fCC.ProfList[CProf - 1].WEAPONINDEX].NAME;
                    if (this.fCC.ProfList[CProf - 1].AMPINDEX > 0)
                        ItemName += " " + this.fCC.Amps[this.fCC.ProfList[CProf - 1].AMPINDEX].NAME;

                    if (this.fCC.ProfList[CProf - 1].LASER1INDEX > 0)
                        ItemName += " " + this.fCC.Lasers[this.fCC.ProfList[CProf - 1].LASER1INDEX].NAME;

                    if (this.fCC.ProfList[CProf - 1].LASER2INDEX > 0)
                        ItemName += " " + this.fCC.Lasers[this.fCC.ProfList[CProf - 1].LASER2INDEX].NAME;

                    if (this.fCC.ProfList[CProf - 1].SCOPEINDEX > 0)
                        ItemName += " " + this.fCC.Scopes[this.fCC.ProfList[CProf - 1].SCOPEINDEX].NAME;

                    if (this.fCC.ProfList[CProf - 1].DMGENHCOUNT > 0)
                        ItemName += " DMGEnh's:" + this.fCC.ProfList[CProf - 1].DMGENHCOUNT;

                }

                bool FlagItemExist = false;

                for (int RowCount = 0; RowCount < this.dGVStatus.RowCount; RowCount++)
                {
                    if (Convert.ToString(this.dGVStatus.Rows[RowCount].Cells[0].Value) == ItemName)
                    {
                        //all this Lists were made for future use, but now they are unused
                        StatusItems.Add(new StatusItems(ItemName, Convert.ToInt32(this.dGVStatus.Rows[RowCount].Cells[1].Value) + 1,
                            Convert.ToDouble(this.dGVStatus.Rows[RowCount].Cells[2].Value) + (this.fCC.ProfList[CProf - 1].COSTUSEPROF),
                            Convert.ToDouble(this.dGVStatus.Rows[RowCount].Cells[2].Value) + Convert.ToDouble(damage)));
                        FlagItemExist = true;
                        this.dGVStatus.Rows[RowCount].Cells[0].Value = ItemName; //Item
                        this.dGVStatus.Rows[RowCount].Cells[1].Value = Convert.ToInt32(this.dGVStatus.Rows[RowCount].Cells[1].Value) + 1; //Uses
                        this.dGVStatus.Rows[RowCount].Cells[2].Value = Convert.ToDouble(this.dGVStatus.Rows[RowCount].Cells[2].Value) + (this.fCC.ProfList[CProf - 1].COSTUSEPROF / 100); //PedCycled
                        this.dGVStatus.Rows[RowCount].Cells[3].Value = Convert.ToDouble(this.dGVStatus.Rows[RowCount].Cells[3].Value) + Convert.ToDouble(damage); //DmgDone
                        this.dGVStatus.Rows[0].Cells[0].Selected = false; //Darkmode crutch
                        break;
                    }
                }
                if (!FlagItemExist)
                {
                    int RowCount1 = this.dGVStatus.RowCount;
                    StatusItems.Add(new StatusItems(ItemName, 1, this.fCC.ProfList[CProf - 1].COSTUSEPROF, damage));
                    this.dGVStatus.Rows.Add();
                    FlagItemExist = true;
                    this.dGVStatus.Rows[RowCount1].Cells[0].Value = ItemName; //Item
                    this.dGVStatus.Rows[RowCount1].Cells[1].Value = 1; //Uses
                    this.dGVStatus.Rows[RowCount1].Cells[2].Value = this.fCC.ProfList[CProf - 1].COSTUSEPROF / 100;//PedCycled
                    this.dGVStatus.Rows[RowCount1].Cells[3].Value = damage; //DmgDone
                    this.dGVStatus.Rows[0].Cells[0].Selected = false; //Darkmode crutch
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error AddItemStatus(): " + ex);
            }



        }

        //Checking tiering events
        private void AddTierItem(List<TieringItems> listTiering, string line, bool _isMain)
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string Item;
                string ItemTierR;
                string Date = line.Remove(19, line.Length - 19);                
                int found = line.IndexOf("Your ") + 5;
                Item = line.Remove(0, found);
                int HasRech = Item.IndexOf(" has reached");
                Item = Item.Remove(HasRech, Item.Length - HasRech);                
                ItemTierR = line.Remove(0, line.IndexOf("tier ") + 5);                
                bool FlagItemExist = false;
                double AmmoLastTime = 0;
                int UsesLastTime = 0;
                int RowCountSave = 0;

                //im not sure that i done this right, but in all cases where i tested shows right
                for (int RowCount1 = 0; RowCount1 < this.dGVStatus.RowCount; RowCount1++) //uses dGVStatus info for calculating uses and ped cycle
                {
                    for (int RowCount = 0; RowCount < this.dGVTiring.RowCount; RowCount++)
                    {                    
                        //if this gear already in dGVTiring
                        if ((((string)this.dGVTiring.Rows[RowCount].Cells[0].Value) == Item) && (Convert.ToString(this.dGVStatus.Rows[RowCount1].Cells[0].Value).Contains(Item)))
                        {
                            UsesLastTime += Convert.ToInt32(this.dGVStatus.Rows[RowCount1].Cells[1].Value);
                            AmmoLastTime += Convert.ToDouble(this.dGVStatus.Rows[RowCount1].Cells[2].Value);
                            RowCountSave = RowCount;
                            FlagItemExist = true;
                            break;
                            
                        } 
                    }
                }
                //if this gear is not in dGVTiring
                if (!FlagItemExist)
                {
                    for (int RowCount1 = 0; RowCount1 < this.dGVStatus.RowCount; RowCount1++)
                    {
                         if ((Convert.ToString(this.dGVStatus.Rows[RowCount1].Cells[0].Value).Contains(Item)))
                         {
                            UsesLastTime += Convert.ToInt32(this.dGVStatus.Rows[RowCount1].Cells[1].Value);
                            AmmoLastTime += Convert.ToDouble(this.dGVStatus.Rows[RowCount1].Cells[2].Value);
                         }
                    }
                    UsesLastTime++;
                    AmmoLastTime += this.ammoPerShot / 100;
                    int RowCount = this.dGVTiring.RowCount;
                    listTiering.Add(new TieringItems(Item, Convert.ToDouble(ItemTierR), UsesLastTime, AmmoLastTime, Date));
                    this.dGVTiring.Rows.Add();
                    this.dGVTiring.Rows[RowCount].Cells[0].Value = Item;
                    this.dGVTiring.Rows[RowCount].Cells[1].Value = Convert.ToDouble(ItemTierR);
                    this.dGVTiring.Rows[RowCount].Cells[2].ValueType = typeof(int);
                    this.dGVTiring.Rows[RowCount].Cells[2].Value = Convert.ToInt32(UsesLastTime).ToString("F0");
                    this.dGVTiring.Rows[RowCount].Cells[3].Value = AmmoLastTime;
                    this.dGVTiring.Rows[RowCount].Cells[4].Value = Date;
                    this.dGVTiring.Rows[RowCount].Cells[0].Selected = false;//Darkmode crutch

                }
                else//if this gear already in dGVTiring
                {
                    double TotalUsedTier = 0;
                    double TotalAmmoUsedTier = 0;
                    int RowCount = this.dGVTiring.RowCount;
                    for(int RowCount2 = 0; RowCount2 < this.dGVTiring.RowCount; RowCount2++)
                    {                        
                        if (Convert.ToString(this.dGVTiring.Rows[RowCount2].Cells[0].Value).Contains(Item))
                        {
                            TotalUsedTier += Convert.ToDouble(this.dGVTiring.Rows[RowCount2].Cells[2].Value);
                            TotalAmmoUsedTier += Convert.ToDouble(this.dGVTiring.Rows[RowCount2].Cells[3].Value);
                        }
                    }
                    TotalUsedTier--;
                    TotalAmmoUsedTier -=  this.ammoPerShot / 100;
                    listTiering.Add(new TieringItems(Item, Convert.ToDouble(ItemTierR), UsesLastTime - Convert.ToInt32(TotalUsedTier), AmmoLastTime - TotalAmmoUsedTier, Date));
                    this.dGVTiring.Rows.Add();
                    this.dGVTiring.Rows[RowCount].Cells[0].Value = Item;
                    this.dGVTiring.Rows[RowCount].Cells[1].Value = Convert.ToDouble(ItemTierR);
                    this.dGVTiring.Rows[RowCount].Cells[2].ValueType = typeof(int);
                    this.dGVTiring.Rows[RowCount].Cells[2].Value = (UsesLastTime - TotalUsedTier).ToString("F0");
                    this.dGVTiring.Rows[RowCount].Cells[3].Value = AmmoLastTime - TotalAmmoUsedTier;
                    this.dGVTiring.Rows[RowCount].Cells[4].Value = Date;
                    this.dGVTiring.Rows[RowCount].Cells[0].Selected = false;//Darkmode crutch
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("AddTierItem(): " + ex);
            }

        }

        //Enhancer breaking check
        private void AddEnhancer(List<EnhItems> listEnh, string line, bool _isMain)
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string EnhName;
                string EnhTTstr;

                //it just checks spec of broken enh...
                int found = line.IndexOf("Your enhancer ");
                EnhName = line.Remove(0, found);
                if (line.IndexOf("Enhancer 10") > 1)
                    EnhName = EnhName.Remove(EnhName.IndexOf("Enhancer") + 11, (EnhName.IndexOf("Shrapnel") + 9) - (EnhName.IndexOf("Enhancer") + 10));
                else
                    EnhName = EnhName.Remove(EnhName.IndexOf("Enhancer") + 10, (EnhName.IndexOf("Shrapnel") + 9) - (EnhName.IndexOf("Enhancer") + 9));  
                
                EnhName = EnhName.Remove(0, 14);             
                EnhTTstr = line.Remove(0, line.IndexOf("received") + 9);
                EnhTTstr = EnhTTstr.Remove(4, 16);
                double EnhTT = Convert.ToDouble(EnhTTstr);
                bool FlagEnhExist = false;

                //...is it in dGV already...
                for (int RowCount = 0; RowCount < this.dGVEnh.RowCount; RowCount++)
                {
                    //...and puts values...
                    if (((string)this.dGVEnh.Rows[RowCount].Cells[1].Value) == EnhName)
                    {
                        listEnh.Add(new EnhItems(1, EnhName, EnhTT, Convert.ToDouble(this.dGVEnh.Rows[RowCount].Cells[4].Value)));
                        FlagEnhExist = true;
                        this.dGVEnh.Rows[RowCount].Cells[0].Value = (Convert.ToInt32(dGVEnh.Rows[RowCount].Cells[0].Value) + 1);
                        this.dGVEnh.Rows[RowCount].Cells[2].Value = (Convert.ToDouble(dGVEnh.Rows[RowCount].Cells[2].Value) + EnhTT);
                        this.dGVEnh.Rows[RowCount].Cells[3].Value = (Convert.ToDouble(dGVEnh.Rows[RowCount].Cells[3].Value) + (EnhTT * (Convert.ToDouble(this.dGVEnh.Rows[RowCount].Cells[4].Value) / 100) - EnhTT));
                        this.dGVEnh.Rows[0].Cells[0].Selected = false;//Darkmode crutch
                        break;
                    }
                }
                //...if its not, just adds it
                if (!FlagEnhExist)
                {
                    listEnh.Add(new EnhItems(1, EnhName, EnhTT, 100.0));
                    int RowCount1 = this.dGVEnh.RowCount;
                    this.dGVEnh.Rows.Add();
                    this.dGVEnh.Rows[RowCount1].Cells[0].Value = 1;
                    this.dGVEnh.Rows[RowCount1].Cells[1].Value = EnhName;
                    this.dGVEnh.Rows[RowCount1].Cells[2].Value = EnhTT;
                    this.dGVEnh.Rows[RowCount1].Cells[4].Value = 100;
                    this.dGVEnh.Rows[RowCount1].Cells[3].Value = EnhTT * (100 / Convert.ToDouble(this.dGVEnh.Rows[RowCount1].Cells[4].Value)) - EnhTT;
                    this.dGVEnh.Rows[0].Cells[0].Selected = false;//Darkmode crutch
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error AddEnhancer()" + ex);
            }

            this.CalculateProfit();

        }

        //Skill gaining check
        private void AddSkill(List<EnhItems> listEnh, string line, bool _isMain)
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                
                string SkillName;
                string SkillPoints;

                //just checks spec of skill and fills var...
                if (line.IndexOf(" skill") > 0)
                {
                    int found = line.IndexOf("your ");
                    SkillName = line.Remove(0, found + 5);                   
                    SkillName = SkillName.Remove(SkillName.IndexOf(" skill"), 6);
                    SkillPoints = line.Remove(0, line.IndexOf("gained ") + 7);
                    SkillPoints = SkillPoints.Remove(SkillPoints.IndexOf(" "), SkillPoints.Length - SkillPoints.IndexOf(" "));                    
                }
                else if (line.Contains("has improved by"))
                {
                    int found = line.IndexOf("Your ");
                    SkillName = line.Remove(0, found + 5);
                    SkillName = SkillName.Remove(SkillName.IndexOf(" "), SkillName.Length - SkillName.IndexOf(" "));
                    SkillPoints = line.Remove(0, line.IndexOf("by ") + 3);                    
                }
                else 
                {
                    int found = line.IndexOf(".");
                    SkillName = line.Remove(0, found + 6);
                    SkillPoints = line.Remove(0, line.IndexOf("gained ") + 7);
                    SkillPoints = SkillPoints.Remove(SkillPoints.IndexOf(" "), SkillPoints.Length - SkillPoints.IndexOf(" "));
                }
                
                
                bool FlagEnhExist = false;
                //... than check is it in dGV and and adds them...
                for (int RowCount = 0; RowCount < this.dGVSkill.RowCount; RowCount++)
                {
                    if (((string)this.dGVSkill.Rows[RowCount].Cells[0].Value) == SkillName)
                    {
                        listSkills.Add(new SkillCount(SkillName, Convert.ToDouble(SkillPoints), Convert.ToInt32(this.dGVSkill.Rows[RowCount].Cells[2].Value) + 1));
                        FlagEnhExist = true;
                        this.dGVSkill.Rows[RowCount].Cells[1].Value = Math.Round(Convert.ToDouble(dGVSkill.Rows[RowCount].Cells[1].Value) + Convert.ToDouble(SkillPoints), 4);
                        this.dGVSkill.Rows[RowCount].Cells[2].Value = Convert.ToInt32(this.dGVSkill.Rows[RowCount].Cells[2].Value) + 1;
                        this.dGVSkill.Rows[0].Cells[0].Selected = false;
                        break;
                    }
                }
                //...if it isnt in dGV, adds it 
                if (!FlagEnhExist)
                {
                    listSkills.Add(new SkillCount(SkillName, Convert.ToDouble(SkillPoints), 1));
                    int RowCount1 = this.dGVSkill.RowCount;
                    this.dGVSkill.Rows.Add();
                    this.dGVSkill.Rows[RowCount1].Cells[0].Value = SkillName;
                    this.dGVSkill.Rows[RowCount1].Cells[1].Value = Math.Round(Convert.ToDouble(SkillPoints), 4);
                    this.dGVSkill.Rows[RowCount1].Cells[2].Value = 1;
                    //this.dGVEnh.Rows[RowCount1].ReadOnly = true;
                    this.dGVSkill.Rows[0].Cells[0].Selected = false;
                }

                //heder total count
                double totalPoints = 0;
                int totalSummons = 0;
                for (int i = 0; i < this.dGVSkill.RowCount; i++)
                {
                    totalPoints += Convert.ToDouble(this.dGVSkill.Rows[i].Cells[1].Value);
                    totalSummons += Convert.ToInt32(this.dGVSkill.Rows[i].Cells[2].Value);
                }
                dGVSkillTotalPoints.HeaderText = "TotalPoints: " + totalPoints;
                dGVSkillSummons.HeaderText = "Summons: " + totalSummons;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error AddSkill()" + ex +" " + line);
            }

            this.CalculateProfit();

        }

        //loot event check
        private void AddItems(List<Items> lista, string line, bool _isMain)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            bool localFlagUnused = false;
            string str1 = "";
            int num1 = 1;
            int num2 = 1;
            //checking is lotted item single
            if (line.Contains(" a "))
            {
                num1 = 2;
                num2 = 0;
            }

            //original code
            string[] strArray1 = line.Substring(line.IndexOf("received ")).Split((char[])null);
            for (int index = num1; index < strArray1.Length - num2; ++index)
                str1 = str1 + strArray1[index] + " ";

            int found = str1.IndexOf(" x ");
            int TTvalueTextIndex = str1.LastIndexOf(": ") + 2;
            string TTvalueText = str1.Substring(TTvalueTextIndex); // PED  
            TTvalueText = TTvalueText.Remove(TTvalueText.IndexOf(" "), 1);
            double check = Convert.ToDouble(TTvalueText);
            string _nombre = str1.Substring(0, found); //_nombre = name

            //original code
            string s;
            if (num1 != 2)
            {
                string str2 = strArray1[strArray1.Length - 4]; 
                string str3 = str2.Remove(str2.IndexOf("("), 1);
                s = str3.Remove(str3.IndexOf(")"), 1);
            }
            else
                s = "1";
            string listOfUnused;


            using (TextFieldParser textFieldParser = new TextFieldParser(UnusedPath))
            {
                listOfUnused = textFieldParser.ReadToEnd();
            }

            bool FlagItemPoint3 = false; //used to check, do it need to add tt value to global tt of values (a little outdated)  

            //checking is item unused
            if (listOfUnused.Contains(_nombre)) 
            {
                globalFlagUnused = true;
                //showing unused items in dGV with 0 tt value
                if (STT.checkBoxUnusedItems.Checked)
                    localFlagUnused = true;
                else
                    return;
            }
            else
                FlagItemPoint3 = true;

            TTBackForExc += check;//DecReturnWrite() DecReturnReact() check

            double LootHelper;
            double _cantidad = double.Parse(s);
            bool flag1 = false;
           
            //is file already in list, planned to use list in future, but now unised
            foreach (Items items in lista)
            {
                if (items.NOMBRE == _nombre)
                {
                    flag1 = true;
                    break;
                }
            }

            //if not in list..
            if (!flag1)
            {
                try
                {
                    using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUmats.csv"))
                    {
                        textFieldParser.TextFieldType = FieldType.Delimited;
                        textFieldParser.SetDelimiters(",");
                        bool flag2 = false;
                        //checking whole EUmats for item...
                        while (!textFieldParser.EndOfData)
                        {
                            string[] strArray2 = textFieldParser.ReadFields();
                            foreach (string str4 in strArray2)
                            {
                                //...and if finds it, adds it
                                if (str4 == _nombre)
                                {
                                    double _precio = double.Parse(strArray2[1], (IFormatProvider)this.ci);
                                    lista.Add(new Items(_nombre, _cantidad, _precio, 100.0));
                                    if (_isMain)
                                    {
                                        if (localFlagUnused)
                                            _precio = 0;

                                        int rowCount = this.dGV1.RowCount;
                                        this.dGV1.Rows.Add();
                                        this.dGV1.Rows[rowCount].Cells[0].ValueType = typeof(double);
                                        this.dGV1.Rows[rowCount].Cells[3].ValueType = typeof(double);
                                        this.dGV1.Rows[rowCount].Cells[0].Value = (object)_cantidad; //amount
                                        this.dGV1.Rows[rowCount].Cells[1].Value = (object)_nombre; //item
                                        this.dGV1.Rows[rowCount].Cells[2].Value = (object)_precio; //tt value of one item = _precio
                                        this.dGV1.Rows[rowCount].Cells[4].Value = (object)Math.Round(Convert.ToDouble(_precio * _cantidad), 2); //value+MU
                                        this.dGV1.Rows[rowCount].Cells[5].ValueType = typeof(double);
                                        this.dGV1.Rows[rowCount].Cells[5].Value = (object)100.0; //MU%
                                        this.dGV1.Rows[rowCount].Cells[3].Value = (object)(_precio * _cantidad); //value
                                        
                                        this.dGV1.Rows[rowCount].ReadOnly = true;
                                        this.dGV1.Rows[0].Cells[0].Selected = false;


                                        if (FlagItemPoint3)
                                        {
                                            balanceGridHelpRow71 += _precio * _cantidad;
                                            this.balanceGrid.Rows[7].Cells[1].Value = (object)(balanceGridHelpRow71.ToString("F2") + " PED"); //loot value
                                            FlagItemPoint3 = false;
                                        }                                       

                                        //loot% ammo cost in Settings
                                        if (!this.STT.checkBoxLootAmmo.Checked)
                                            LootHelper = balanceGridHelpRow71;
                                        else
                                            LootHelper = this.ammoSpent * 0.01 + this.repairs;

                                        for (int i = 0; i < this.dGV1.Rows.Count; i++)
                                            this.dGV1.Rows[i].Cells[6].Value = (object)Math.Round((Convert.ToDouble(this.dGV1.Rows[i].Cells[4].Value) / LootHelper) * 100, 2); //loot%

                                        flag2 = true;
                                        break;
                                    }
                                    break;
                                }
                            }
                        }
                        //if not found in EUmats and run button is "Start"
                        if (!(!flag2 & _isMain))
                            return;
                        //_cantidad = volume of item
                        lista.Add(new Items(_nombre, _cantidad, 0.0, 100.0));
                        if (localFlagUnused)
                            TTvalueText = "0";

                        int rowCount1 = this.dGV1.RowCount;
                        this.dGV1.Rows.Add();
                        this.dGV1.Rows[rowCount1].Cells[0].ValueType = typeof(double);
                        this.dGV1.Rows[rowCount1].Cells[3].ValueType = typeof(double);
                        this.dGV1.Rows[rowCount1].Cells[0].Value = (object)_cantidad; //amount
                        this.dGV1.Rows[rowCount1].Cells[1].Value = (object)_nombre; //item
                        this.dGV1.Rows[rowCount1].Cells[2].Value = (object)(Convert.ToDouble(TTvalueText) / _cantidad); //tt value of one item
                        this.dGV1.Rows[rowCount1].Cells[3].Value = (object)Convert.ToDouble(TTvalueText); //value
                        this.dGV1.Rows[rowCount1].Cells[4].Value = (object)Convert.ToDouble(TTvalueText); //value+MU
                        this.dGV1.Rows[rowCount1].Cells[5].ValueType = typeof(double);
                        this.dGV1.Rows[rowCount1].Cells[5].Value = (object)100.0; //MU%
                        this.dGV1.Rows[rowCount1].ReadOnly = true;
                        this.dGV1.Rows[0].Cells[0].Selected = false;

                        if (FlagItemPoint3)
                        {
                            balanceGridHelpRow71 = (_cantidad * Convert.ToDouble(this.dGV1.Rows[rowCount1].Cells[2].Value)) + balanceGridHelpRow71;
                            this.balanceGrid.Rows[7].Cells[1].Value = (object)(balanceGridHelpRow71.ToString("F2") + " PED"); //loot value
                            FlagItemPoint3 = false;
                        }                        

                        if (!this.STT.checkBoxLootAmmo.Checked)
                            LootHelper = balanceGridHelpRow71;
                        else
                            LootHelper = this.ammoSpent * 0.01 + this.repairs;

                        for (int i = 0; i < this.dGV1.Rows.Count; i++)
                            this.dGV1.Rows[i].Cells[6].Value = (object)Math.Round((Convert.ToDouble(this.dGV1.Rows[i].Cells[4].Value) / LootHelper) * 100, 2); //loot%
                    }
                }
                catch
                {
                    this._isRunning = false;
                    this.startButton.Text = "START";
                    this.startButton.BackColor = Color.Empty;
                    this.backgroundWorker1.CancelAsync();
                    this.startButton.Enabled = false;
                    int num3 = (int)MessageBox.Show("Cant find the file EUmats.csv that contains the item Database on the EU Hunter Tools folder.");
                }
            }
            else//if it already in list...
            {
                try
                {
                    if (_isMain)//...app running...
                    {
                        using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUmats.csv"))
                        {
                            textFieldParser.TextFieldType = FieldType.Delimited;
                            textFieldParser.SetDelimiters(",");
                            bool flag3 = false;
                            //...check all EUmats for that item...
                            while (!textFieldParser.EndOfData)
                            {
                                foreach (string readField in textFieldParser.ReadFields())
                                {
                                    //...if fount it...
                                    if (readField == _nombre)
                                    {
                                        //...checks it in dGV...
                                        foreach (DataGridViewRow row in (IEnumerable)this.dGV1.Rows)
                                        {   //... and if find it, adds in list and change to new values in dGV
                                            if (row.Cells[1].Value.ToString().Equals(_nombre))
                                            {
                                                foreach (Items items in lista)
                                                {
                                                    if (items.NOMBRE == _nombre)
                                                    {
                                                        items.CANTIDAD += _cantidad;

                                                        if (localFlagUnused)
                                                        {                                                            
                                                            row.Cells[0].Value = (object)(Convert.ToInt32(row.Cells[0].Value) + _cantidad); //amount
                                                            row.Cells[4].Value = 0; //value+MU
                                                            row.Cells[3].Value = 0; //value
                                                            flag3 = true;

                                                            if (FlagItemPoint3)                                                            
                                                                FlagItemPoint3 = false;
                                                            
                                                        }
                                                        else
                                                        {                                                            
                                                            row.Cells[0].Value = (object)(Convert.ToInt32(row.Cells[0].Value) + _cantidad); //amount
                                                            row.Cells[4].Value = (object)Convert.ToDouble((items.CANTIDAD * items.PRECIO)); //value+MU
                                                            row.Cells[3].Value = (object)(items.CANTIDAD * items.PRECIO * (items.MU / 100.0)); //value
                                                            flag3 = true;

                                                            if (FlagItemPoint3)
                                                            {
                                                                balanceGridHelpRow71 = (_cantidad * items.PRECIO) + balanceGridHelpRow71;
                                                                this.balanceGrid.Rows[7].Cells[1].Value = (object)(balanceGridHelpRow71.ToString("F2") + " PED"); //loot value
                                                                FlagItemPoint3 = false;
                                                            }
                                                        }

                                                        if (!this.STT.checkBoxLootAmmo.Checked)
                                                            LootHelper = balanceGridHelpRow71;
                                                        else
                                                            LootHelper = this.ammoSpent * 0.01 + this.repairs;

                                                        for (int i = 0; i < this.dGV1.Rows.Count; i++)
                                                            this.dGV1.Rows[i].Cells[6].Value = (object)Math.Round((Convert.ToDouble(this.dGV1.Rows[i].Cells[4].Value) / LootHelper) * 100, 2); //loot%
                                                        row.Cells[0].ReadOnly = true;
                                                        row.Cells[0].Selected = false;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            //if find it, quits
                            if (flag3)
                                return;

                            bool flag4 = false;
                            //if not, hoho....
                            foreach (DataGridViewRow row in (IEnumerable)this.dGV1.Rows)
                            {   //check all dGV for match...
                                if (row.Cells[1].Value.ToString().Equals(_nombre))
                                {//...also in list....
                                    foreach (Items items in lista)
                                    {   //...and...
                                        if (items.NOMBRE == _nombre && //...if finds it and...
                                            (((items.CANTIDAD > 1) || (_cantidad > 1)) || //...or it have volume > 1 from looted or in dGV...
                                            (!_nombre.Contains("(L)") && (Convert.ToDouble(row.Cells[3].Value) == Convert.ToDouble(TTvalueText)))))//...or name dont have (L) and tt value of looted = value of one same item
                                        {//...than updates that item in dGV
                                         //it was made to seperate new items and (L) with (UL) stuff with different value when looted
                                         //(like new tokens, new animals drop and some ul drops in dungeons)
                                            items.CANTIDAD += _cantidad;
                                            if (localFlagUnused)
                                                TTvalueText = "0";

                                            row.Cells[0].Value = (object)(Convert.ToInt32(row.Cells[0].Value) + _cantidad); //amount
                                            row.Cells[4].Value = (object)((Convert.ToDouble(row.Cells[4].Value) + Convert.ToDouble(TTvalueText))); //value+MU
                                            row.Cells[3].Value = (object)((Convert.ToDouble(row.Cells[4].Value)) * (items.MU / 100.0)); //value
                                            flag4 = true;

                                            if (FlagItemPoint3)
                                            {
                                                balanceGridHelpRow71 = (Convert.ToDouble(TTvalueText)) + balanceGridHelpRow71;
                                                this.balanceGrid.Rows[7].Cells[1].Value = (object)(balanceGridHelpRow71.ToString("F2") + " PED"); //loot value
                                                FlagItemPoint3 = false;
                                            }                                             

                                            if (!this.STT.checkBoxLootAmmo.Checked)
                                                LootHelper = balanceGridHelpRow71;
                                            else
                                                LootHelper = this.ammoSpent * 0.01 + this.repairs;

                                            for (int i = 0; i < this.dGV1.Rows.Count; i++)
                                                this.dGV1.Rows[i].Cells[6].Value = (object)Math.Round((Convert.ToDouble(this.dGV1.Rows[i].Cells[4].Value) / LootHelper) * 100, 2);//loot%
                                            row.Cells[0].ReadOnly = true;
                                            row.Cells[0].Selected = false;
                                            return;
                                        }
                                    }
                                }
                            }
                            //if find it, quits
                            if (flag4)
                                return;
                            //if not, just adds it like new item to dGV
                            lista.Add(new Items(_nombre, _cantidad, 0.0, 100.0));
                            if (localFlagUnused)
                                TTvalueText = "0";

                            int rowCount = this.dGV1.RowCount;
                            this.dGV1.Rows.Add();
                            this.dGV1.Rows[rowCount].Cells[0].ValueType = typeof(double);
                            this.dGV1.Rows[rowCount].Cells[0].Value = (object)_cantidad; //amount
                            this.dGV1.Rows[rowCount].Cells[1].Value = (object)_nombre; //item
                            this.dGV1.Rows[rowCount].Cells[2].Value = (object)(Convert.ToDouble(TTvalueText) / _cantidad);//tt value of one item
                            this.dGV1.Rows[rowCount].Cells[3].ValueType = typeof(double);
                            this.dGV1.Rows[rowCount].Cells[3].Value = (object)Convert.ToDouble(TTvalueText); //value
                            this.dGV1.Rows[rowCount].Cells[4].ValueType = typeof(double);
                            this.dGV1.Rows[rowCount].Cells[4].Value = (object)Convert.ToDouble(TTvalueText); //value+MU
                            this.dGV1.Rows[rowCount].Cells[5].ValueType = typeof(double);
                            this.dGV1.Rows[rowCount].Cells[5].Value = (object)100.0; //MU%
                            this.dGV1.Rows[rowCount].ReadOnly = true;
                            this.dGV1.Rows[0].Cells[0].Selected = false;

                            if (FlagItemPoint3)
                            {
                                balanceGridHelpRow71 = (_cantidad * Convert.ToDouble(this.dGV1.Rows[rowCount].Cells[2].Value)) + balanceGridHelpRow71;
                                this.balanceGrid.Rows[7].Cells[1].Value = (object)(balanceGridHelpRow71.ToString("F2") + " PED"); //loot value
                                FlagItemPoint3 = false;
                            }
                            

                            if (!this.STT.checkBoxLootAmmo.Checked)
                                LootHelper = balanceGridHelpRow71;
                            else
                                LootHelper = this.ammoSpent * 0.01 + this.repairs;

                            for (int i = 0; i < this.dGV1.Rows.Count; i++)
                                this.dGV1.Rows[i].Cells[6].Value = (object)Math.Round((Convert.ToDouble(this.dGV1.Rows[i].Cells[4].Value) / LootHelper) * 100, 2); //loot%
                        }
                    }
                    else//was in original code, unused
                    {
                        foreach (Items items in lista)
                        {
                            if (items.NOMBRE == _nombre)
                            {
                                items.CANTIDAD += _cantidad;
                                break;
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    int num4 = (int)MessageBox.Show(ex.Message);
                }
            }
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) => this.startButton.Enabled = true;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                this.trackTeam = true;
            else
                this.trackTeam = false;
        }

        //BackUp writer
        private void BackUpFunction(List<Items> lista)
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                using (StreamWriter writer = new StreamWriter(new FileStream(this.BackUpPath, FileMode.Create, FileAccess.Write)))
                {
                    SaveCSV(writer);
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error saving: " + (object)ex);
                return;
            }
        }

        public void buttonSettings_Click(object sender, EventArgs e)
        {
            this.isCompact = true;
            this.CalculateProfit();
            int num = (int)this.STT.ShowDialog();
        }

        //Save button in settings
        public void button1_Click_1()
        {
            if (this.STT.pathText.Text != "")
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(this.fPath))
                    {
                        this.playerDataList.Clear();
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        MemoryStream memoryStream1 = new MemoryStream();
                        PlayerConfig playerConfig1 = new PlayerConfig();                        
                        this.playerDataList.Add(new PlayerData(this.STT.checkBoxBackup.Checked, this.STT.pathText.Text,
                            this.STT.DarkModeCheck.Checked, this.STT.HidingOption.Checked, this.f3.OverlayLocX, this.f3.OverlayLocY, this.STT.FlagProfUse.Checked,
                            Convert.ToInt32(this.STT.MobsKilled.Text), Convert.ToInt32(this.STT.MobsKilledPointEvery.Text), Convert.ToInt32(this.STT.MobsKilledNumLines.Text),
                            this.STT.MobsKilledAutoSize.Checked, this.STT.MiningMode.Checked, this.STT.DPSOnTime.Checked, Convert.ToInt32(this.STT.SecBeforeAFKTimerBox.Text),
                            this.STT.UsingEButton.Checked, this.STT.checkBoxSGIO.Checked, Convert.ToInt32(this.STT.ScrollingGearOverlay.Text),
                            this.STT.DMBackColor, this.STT.DMTextColor, this.STT.DMTablesColor, this.STT.checkBoxLootAmmo.Checked, this.STT.checkBoxBackupTeam.Checked,
                            this.STT.NickName.Text, this.STT.checkBoxOutValue.Checked, this.STT.checkBoxUnusedItems.Checked));
                        playerConfig1.playerDataList = this.playerDataList;
                        MemoryStream memoryStream2 = memoryStream1;
                        PlayerConfig playerConfig2 = playerConfig1;
                        binaryFormatter.Serialize((Stream)memoryStream2, (object)playerConfig2);
                        string base64String = Convert.ToBase64String(memoryStream1.ToArray());
                        streamWriter.Write(base64String);
                        streamWriter.Close();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error saving: " + (object)ex);
                    return;
                }

            }
            int num1 = (int)MessageBox.Show("You must fill the chat log path before save!");
        }

        public void SetOverlayNull()
        {
            this.f3.Location = new System.Drawing.Point(0, 0);
        }


        private void button1_Click_ExcelExport(object sender, EventArgs e)
        {

            string ConvertVRows1 = this.balanceGrid.Rows[1].Cells[1].Value.ToString();
            string ConvertVRows2 = this.balanceGrid.Rows[7].Cells[1].Value.ToString();
            string ConvertVRows3 = this.balanceGrid.Rows[10].Cells[1].Value.ToString();
            string ConvertVRows4 = this.balanceGrid.Rows[9].Cells[1].Value.ToString();
            string ConvertVRows5 = this.balanceGrid.Rows[8].Cells[1].Value.ToString();
            string ConvertVRows6 = this.balanceGrid.Rows[4].Cells[1].Value.ToString();

            //its baaaaad, why i was so dumb
            if (ConvertVRows1.IndexOf(" PED") > 0)
                ConvertVRows1 = ConvertVRows1.Remove(ConvertVRows1.IndexOf(" PED"), 4);

            if (ConvertVRows1.IndexOf(" ") > 0)
                ConvertVRows1 = ConvertVRows1.Remove(ConvertVRows1.IndexOf(" "), 1);

            if (ConvertVRows2.IndexOf(" PED") > 0)
                ConvertVRows2 = ConvertVRows2.Remove(ConvertVRows2.IndexOf(" PED"), 4);

            if (ConvertVRows2.IndexOf(" ") > 0)
                ConvertVRows2 = ConvertVRows2.Remove(ConvertVRows2.IndexOf(" "), 1);

            if (ConvertVRows3.IndexOf(" PED") > 0)
                ConvertVRows3 = ConvertVRows3.Remove(ConvertVRows3.IndexOf(" PED"), 4);

            if (ConvertVRows3.IndexOf(" ") > 0)
                ConvertVRows3 = ConvertVRows3.Remove(ConvertVRows3.IndexOf(" "), 1);

            if (ConvertVRows5.IndexOf(" PED") > 0)
                ConvertVRows5 = ConvertVRows5.Remove(ConvertVRows5.IndexOf(" PED"), 4);

            if (ConvertVRows5.IndexOf(" ") > 0)
                ConvertVRows5 = ConvertVRows5.Remove(ConvertVRows5.IndexOf(" "), 1);

            try
            {
                using (ExcelWork.ExcelWork worker = new ExcelWork.ExcelWork())
                {
                    worker.Open(filePath: Path.Combine(Environment.CurrentDirectory, "EUHunter.xlsx"));

                    //worker.Set(column: "A", row: 1, data: "123qwe");
                    worker.SetHuntData(ConvertVRows1,
                        ConvertVRows2,
                        ConvertVRows3,
                        ConvertVRows4,
                        ConvertVRows5,
                        ConvertVRows6
                        );
                    worker.Close();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        //Load settings
        //planned to make different profile using list, but unused
        private void LoadConfig()
        {
            try
            {
                if (File.Exists(this.fPath))
                using (StreamReader streamReader = new StreamReader(this.fPath))
                {
                    this.playerDataList = ((PlayerConfig)new BinaryFormatter().Deserialize((Stream)new MemoryStream(Convert.FromBase64String(streamReader.ReadToEnd())))).playerDataList;
                    this.STT.checkBoxBackup.Checked = this.playerDataList[0].NOMBRE;                    
                    this.STT.DMBackColor = this.playerDataList[0].DMBACKCOLOR;
                    this.STT.DMTextColor = this.playerDataList[0].DMTEXTCOLOR;
                    this.STT.DMTablesColor = this.playerDataList[0].DMSTATCOLOR;
                    this.STT.DarkModeCheck.Checked = this.playerDataList[0].DARKMODE;
                    SwitchDarkmode();
                    this.STT.HidingOption.Checked = this.playerDataList[0].NOHIDINGMAIN;
                    this.STT.FlagProfUse.Checked = this.playerDataList[0].FLAGPROFUSE;
                    this.STT.pathText.Text = this.playerDataList[0].PATH;
                    this.STT.MobsKilled.Text = Convert.ToString(this.playerDataList[0].MOBSKILLEDPOINT);
                    this.STT.MobsKilledPointEvery.Text = Convert.ToString(this.playerDataList[0].MOBSKILLEDEVERYPOINT);
                    this.STT.MobsKilledNumLines.Text = Convert.ToString(this.playerDataList[0].MOBSKILLEDNUMLINES);
                    this.STT.MobsKilledAutoSize.Checked = this.playerDataList[0].MOBSKILLEDAUTOSIZE;
                    this.STT.MiningMode.Checked = this.playerDataList[0].MININGMODE;
                    this.STT.DPSOnTime.Checked = this.playerDataList[0].DPSONTIME;
                    this.STT.SecBeforeAFKTimerBox.Text = Convert.ToString(this.playerDataList[0].SBAFKTB);
                    SecondsBeforeAFKTimer = Convert.ToInt32(this.playerDataList[0].SBAFKTB);
                    this.STT.UsingEButton.Checked = this.playerDataList[0].USINGE;
                    this.STT.checkBoxSGIO.Checked = this.playerDataList[0].OVERLAYGEAR;
                    this.STT.ScrollingGearOverlay.Text = Convert.ToString(this.playerDataList[0].OVERLAYGEARSPEED);
                    this.STT.checkBoxLootAmmo.Checked = this.playerDataList[0].LOOTAMMO;
                    this.STT.checkBoxBackupTeam.Checked = this.playerDataList[0].TEAMBACKUP;
                    this.STT.NickName.Text = this.playerDataList[0].NICKNAME;
                    this.STT.checkBoxOutValue.Checked = this.playerDataList[0].OUTVALUE;
                    this.STT.checkBoxUnusedItems.Checked = this.playerDataList[0].UNUSEDITEMS;
                    this.f3.OverlayLocX = this.playerDataList[0].OVERLAYX;
                    this.f3.OverlayLocY = this.playerDataList[0].OVERLAYY;
                    if ((this.f3.OverlayLocX > 0) || (this.f3.OverlayLocY > 0))
                    {
                        this.f3.Location = new System.Drawing.Point(this.f3.OverlayLocX, this.f3.OverlayLocY);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadConfig():" + ex);
            }
        }

        //Adding value to Extra expenses
        private void balanceGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.balanceGrid.CurrentCell.ColumnIndex == 1 && this.balanceGrid.CurrentCell.RowIndex == 0)
            {
                this.inputForm.inputInformationText.Text = "Write the total PED value of your expenses.";
                this.inputForm.mode = "balance";
                int num = (int)this.inputForm.ShowDialog();
            }            
                this.balanceGrid.CurrentCell.Selected = false;
        }


        //private void pictureBox1_Click(object sender, EventArgs e) => Process.Start("https://discordapp.com/invite/X6P2ZEc"); //Arkshija old discord

        //Copy stats dGV button
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText("Hunt Stats [Shots: " + this.statsGrid.Rows[0].Cells[1].Value + "] [Crt( %): " + this.statsGrid.Rows[1].Cells[1].Value + "] [Dmg: " + this.statsGrid.Rows[2].Cells[1].Value + "] [Crt.Dmg: " + this.statsGrid.Rows[3].Cells[1].Value + "] [Acc %: " + this.statsGrid.Rows[5].Cells[1].Value + "]");
            }
            catch{}
        }

        //Remaking value of item or MU of item in dGV1
        private void dGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dGV1.CurrentCell == null)
                return;
            if (this.dGV1.CurrentCell.ColumnIndex == 3)
            {
                this.inputForm.inputInformationText.Text = "Write the PED value of this item.";
                this.inputForm.mode = "itemsMU";
                this.inputForm.celda = this.dGV1.CurrentCell;
                int num = (int)this.inputForm.ShowDialog();
            }
            else if (this.dGV1.CurrentCell.ColumnIndex == 5)
            {
                this.inputForm.inputInformationText.Text = "Write the MU value of this item.";
                this.inputForm.mode = "mu";
                this.inputForm.celda = this.dGV1.CurrentCell;
                int num = (int)this.inputForm.ShowDialog();
            }
            else
                this.dGV1.CurrentCell.Selected = false;  
            
            this.dGV1.CurrentCell.Selected = false;

        }

        //Adding MU of enhancer
        private void dGVEnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dGVEnh.CurrentCell.Selected = true;
            if (this.dGVEnh.CurrentCell.ColumnIndex == 4)
            {
                this.inputForm.inputInformationText.Text = "Write the MU value of this item.";
                this.inputForm.mode = "muEnh";
                this.inputForm.celda = this.dGVEnh.CurrentCell;
                int num = (int)this.inputForm.ShowDialog();
            }
            else
                this.dGVEnh.CurrentCell.Selected = false;

            this.dGVEnh.CurrentCell.Selected = false;
        }

        private void statsGrid_CellClick(object sender, DataGridViewCellEventArgs e) => this.statsGrid.CurrentCell.Selected = false; //i hate Darkmode

        //Used to make own decay and reload speed for weapon, partially unused
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(this.textBox1.Text);            
            if (result < 0.0 && result > 999999.0 && this.textBox1.Text != "")
            {
                this.attacksPerMinute = 0.0;
                this.textBox1.Text = this.attacksPerMinute.ToString();
            }
            else
            {
                this.attacksPerMinute = result;
            }
        }

        //unused
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (char.IsDigit(keyChar) || keyChar == '\b')
                return;
            e.Handled = true;
        }

        //main timer for loot events
        private void timer1_Tick(object sender, EventArgs e) => ++this.ticks;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Changes color of form and its elements
        public void SwitchDarkmode()
        {
            try
            {
                //darkmode off
                if (!this.STT.DarkModeCheck.Checked)
                {
                    this.BackColor = SystemColors.Control;
                    cartesianChart1.BackColor = SystemColors.Control;
                    DPPHide.BackColor = SystemColors.Control;

                    foreach (var it in Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = Color.Black;
                        }
                        if (it is DataGridView)
                        {
                            ((DataGridView)it).Rows[0].Selected = false;
                            ((DataGridView)it).RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                            ((DataGridView)it).AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                        }
                        if (it is CheckBox)
                        {
                            ((CheckBox)it).ForeColor = Color.Black;
                        }
                    }

                    this.statsGrid.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.statsGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGV1.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGV1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVEnh.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGVEnh.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVTiring.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGVTiring.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVStatus.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGVStatus.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVSkill.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGVSkill.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVTeamMember.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGVTeamMember.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVTeamTotal.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGVTeamTotal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVGlobals.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dGVGlobals.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                }
                else//darkmode on
                {
                    this.BackColor = this.BackColor = this.STT.DMBackColor;
                    cartesianChart1.BackColor = this.STT.DMBackColor;
                    DPPHide.BackColor = this.STT.DMBackColor;

                    foreach (var it in Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = this.STT.DMTextColor;
                        }
                        if (it is DataGridView)
                        {
                            ((DataGridView)it).Rows[0].Selected = false;

                            ((DataGridView)it).RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                            ((DataGridView)it).AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        }
                        if (it is CheckBox)
                        {
                            ((CheckBox)it).ForeColor = this.STT.DMTextColor;
                        }
                    }
                    
                    this.statsGrid.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.statsGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    this.statsGrid.Rows[0].Selected = false;

                    this.dGV1.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGV1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));                    

                    this.dGVEnh.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGVEnh.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVTiring.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGVTiring.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVStatus.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGVStatus.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVSkill.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGVSkill.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVTeamMember.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGVTeamMember.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVTeamTotal.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGVTeamTotal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                    this.dGVGlobals.RowsDefaultCellStyle.BackColor = this.STT.DMTablesColor;
                    this.dGVGlobals.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                }
                //darkmode off for overlay
                if (!this.STT.DarkModeCheck.Checked)
                {

                    this.f3.BackColor = SystemColors.Control;
                    foreach (var it in f3.Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = Color.Black;
                        }
                    }

                    this.fCC.BackColor = SystemColors.Control;
                    foreach (var it in fCC.Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = Color.Black;
                        }

                        if (it is CheckBox)
                        {
                            ((CheckBox)it).ForeColor = Color.Black;
                        }

                    }

                    this.STT.BackColor = SystemColors.Control;
                    foreach (var it in STT.Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = Color.Black;
                        }                       
                        if (it is CheckBox)
                        {
                            ((CheckBox)it).ForeColor = Color.Black;
                        }
                        if (it is GroupBox)
                        {
                            ((GroupBox)it).ForeColor = Color.Black;
                        }
                    }
                }
                else //darkmode on for overlay
                {
                    this.f3.BackColor = this.STT.DMBackColor;
                    foreach (var it in f3.Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = this.STT.DMTextColor;
                        }
                    }

                    this.fCC.BackColor = this.STT.DMBackColor;
                    foreach (var it in fCC.Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = this.STT.DMTextColor;
                        }
                        if (it is CheckBox)
                        {
                            ((CheckBox)it).ForeColor = this.STT.DMTextColor;
                        }
                    }

                    this.STT.BackColor = this.STT.DMBackColor;
                    foreach (var it in STT.Controls)
                    {
                        if (it is Label)
                        {
                            ((Label)it).ForeColor = this.STT.DMTextColor;
                        }
                        if (it is CheckBox)
                        {
                            ((CheckBox)it).ForeColor = this.STT.DMTextColor;
                        }
                    }

                }
            }

            catch (Exception ex) { MessageBox.Show("DarkMode():" + ex); }


        }
        private void DarkModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            SwitchDarkmode();            
        }

        //Set profiles button
        private void button5_Click(object sender, EventArgs e)
        { 
            this.isCompact = true;
            int num = (int)this.fCC.ShowDialog();
        }

        //Export hunt/mine button, prepares path and name
        private void ExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string DataTimeHelp = Convert.ToString(DateTime.Now);
                DataTimeHelp = DataTimeHelp.Replace('/', '.');
                DataTimeHelp = DataTimeHelp.Replace(':', '.');
                Stream ExportPath;
                SaveFileDialog ExportDialog = new System.Windows.Forms.SaveFileDialog();

                ExportDialog.Filter = "All files (*.*)|*.*|Csv files (*.csv)|*.csv";
                ExportDialog.FilterIndex = 2;
                ExportDialog.FileName = DataTimeHelp;
                ExportDialog.RestoreDirectory = true;
                if (ExportDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((ExportPath = ExportDialog.OpenFile()) != null)
                    {
                        using (StreamWriter writer = new StreamWriter(ExportPath))
                        {
                            SaveCSV(writer);
                        }
                        ExportPath.Close();
                        MessageBox.Show("All current data saved.", "Saved");
                    }
                }   
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error saving: " + (object)ex);
                return;
            }
        }

        //Export all hunt/mine data to file
        private void SaveCSV(StreamWriter writer)
        {            
                for (int i = 0; i < 11; i++)
                    writer.Write((string)this.balanceGrid.Rows[i].Cells[1].Value + ";");
                writer.WriteLine("");

                for (int i = 0; i < 11; i++)
                    writer.Write(this.statsGrid.Rows[i].Cells[1].Value + ";");
                writer.Write(tReloadC + ";");
            
                writer.WriteLine("");
                writer.Write(tSecondHunt + ";");

                writer.WriteLine("");

                if (this.dGVEnh.RowCount > 0)
                {
                    for (int i = 0; i < this.dGVEnh.RowCount; i++)
                    {
                        writer.WriteLine(this.dGVEnh.Rows[i].Cells[0].Value + ";" + this.dGVEnh.Rows[i].Cells[1].Value + ";" +
                            this.dGVEnh.Rows[i].Cells[2].Value + ";" + this.dGVEnh.Rows[i].Cells[3].Value + ";" +
                            this.dGVEnh.Rows[i].Cells[4].Value);
                    }
                }

                writer.WriteLine(" ;");

                if (GrafCountings.Count > 0)
                {
                    for (int i = 0; i < GrafCountings.Count; i++)
                    {
                        writer.WriteLine(GrafCountings[i].MOBSKILLED + ";" +
                            GrafCountings[i].TT + ";" +
                            GrafCountings[i].TTMU + ";" +
                            GrafCountings[i].MU);
                    }
                }

                writer.WriteLine(" ;");

                if (this.dGVTiring.RowCount > 0)
                {
                    for (int i = 0; i < this.dGVTiring.RowCount; i++)
                    {
                        writer.WriteLine(this.dGVTiring.Rows[i].Cells[0].Value + ";" + this.dGVTiring.Rows[i].Cells[1].Value + ";" +
                            this.dGVTiring.Rows[i].Cells[2].Value + ";" + this.dGVTiring.Rows[i].Cells[3].Value + ";" +
                            this.dGVTiring.Rows[i].Cells[4].Value);
                    }
                }

                writer.WriteLine(" ;");

                if (this.dGVStatus.RowCount > 0)
                {
                    for (int i = 0; i < this.dGVStatus.RowCount; i++)
                    {
                        writer.WriteLine(this.dGVStatus.Rows[i].Cells[0].Value + ";" + this.dGVStatus.Rows[i].Cells[1].Value + ";" +
                            this.dGVStatus.Rows[i].Cells[2].Value + ";" + this.dGVStatus.Rows[i].Cells[3].Value);
                    }
                }

                writer.WriteLine(" ;");

                if (this.dGVSkill.RowCount > 0)
                {
                    for (int i = 0; i < this.dGVSkill.RowCount; i++)
                    {
                        writer.WriteLine(this.dGVSkill.Rows[i].Cells[0].Value + ";" + this.dGVSkill.Rows[i].Cells[1].Value + ";" + this.dGVSkill.Rows[i].Cells[2].Value);
                    }
                }

                writer.WriteLine(" ;");

                for (int i = 0; i < this.dGV1.RowCount; i++)
                {
                    writer.WriteLine(this.dGV1.Rows[i].Cells[0].Value + ";" + this.dGV1.Rows[i].Cells[1].Value + ";" +
                        this.dGV1.Rows[i].Cells[2].Value + ";" + this.dGV1.Rows[i].Cells[3].Value + ";" +
                        this.dGV1.Rows[i].Cells[4].Value + ";" + this.dGV1.Rows[i].Cells[5].Value);
                }

        }

        //Import hunt/mine button, prepares path
        private void ImportCSV_Click(object sender, EventArgs e) // импорт файла
        {

            try
            {
                DialogResult num = MessageBox.Show("All current data will be lost, continue?", "WARNING!!!", MessageBoxButtons.YesNo);

                if (num == DialogResult.Yes)
                {
                    resetButton_Click(sender, e);
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;

                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    using (TextFieldParser textFieldParser = new TextFieldParser(openFileDialog.FileName))
                    {
                        LoadCSV(textFieldParser);
                    }
                    
                }
                else if (num == DialogResult.No)
                    return;


                this.CalculateProfit();
            }
            catch (Exception ex) { MessageBox.Show("Exeption allert, data dont load correcly: " + ex.Message); }
        }

        //Import all hunt/mine data to file
        public void LoadCSV(TextFieldParser textFieldParser)
        {
            textFieldParser.TextFieldType = FieldType.Delimited;
            textFieldParser.SetDelimiters(";");

            string[] Helper = textFieldParser.ReadFields();
            string HelperConvert;

            //Extra expenses
            this.balanceGrid.Rows[0].Cells[1].Value = (object)Helper[0];
            HelperConvert = Helper[0];
            HelperConvert = HelperConvert.Remove(Helper[0].IndexOf(" "), 4);
            this.repairs = Convert.ToDouble(HelperConvert);

            //Ammo cost
            this.balanceGrid.Rows[1].Cells[1].Value = Helper[1];
            HelperConvert = Helper[1];
            HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), 4);
            this.ammoSpent = (Convert.ToDouble(HelperConvert) - this.repairs) * 100;

            //Loot value + MU
            this.balanceGrid.Rows[2].Cells[1].Value = Helper[2];

            //Total + MU
            this.balanceGrid.Rows[3].Cells[1].Value = Helper[3];

            //TT % + MU
            this.balanceGrid.Rows[4].Cells[1].Value = Helper[4];

            //Enemies killed
            this.balanceGrid.Rows[5].Cells[1].Value = Helper[5];
            if (Helper[5].IndexOf(",") > 0)
                HelperConvert = Helper[5].Remove(Helper[5].IndexOf(","), 1);
            else
                HelperConvert = Helper[5];
            this.mobsKilled = Convert.ToInt32(HelperConvert);

            //Average loot + MU
            this.balanceGrid.Rows[6].Cells[1].Value = Helper[6];

            //Loot Value
            this.balanceGrid.Rows[7].Cells[1].Value = Helper[7];
            HelperConvert = Helper[7];
            HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), 4);
            balanceGridHelpRow71 = Convert.ToDouble(HelperConvert);

            //Only MU
            this.balanceGrid.Rows[8].Cells[1].Value = Helper[8];

            //TT%
            this.balanceGrid.Rows[9].Cells[1].Value = Helper[9];

            //Total
            this.balanceGrid.Rows[10].Cells[1].Value = Helper[10];


            Helper = textFieldParser.ReadFields();

            for (int i = 0; i < 10; i++)
                this.statsGrid.Rows[i].Cells[1].Value = Helper[i];
            
            //Shots
            this.totalAttacks = Convert.ToDouble(Helper[0]);

            //Criticals
            HelperConvert = Helper[1];
            if (HelperConvert.IndexOf(" ") > 0)
                HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));
            this.crits = Convert.ToDouble(HelperConvert);

            //Damage done
            HelperConvert = Helper[2];
            if (HelperConvert.IndexOf(" ") > 0)
                HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));   
            this.tDamage = Convert.ToDouble(HelperConvert);

            //Crit. Dmd done
            this.tCritDamage = Convert.ToDouble(Helper[3]);

            //Missed attacks
            this.dodgedAt = Convert.ToDouble(Helper[4]);

            //Missed hits received
            if (!Helper[6].Contains("PED"))//was a lost PEDs parameter, was remade to this
            {
                Helper[6] = Helper[6].Replace(",", "");
                HelperConvert = Convert.ToString(this.evaded + Convert.ToInt32(Helper[6].Remove(Helper[6].IndexOf(" "), Helper[6].Length - Helper[6].IndexOf(" "))));
                this.evaded = Convert.ToInt32(HelperConvert);
            }
            else
                MessageBox.Show("This data contains WASTED PED info instead of evade, dodge etc. Evade, dodge etc will not be calculated correct!", "WARNING!!!");
            
            //Hits received
            HelperConvert = Helper[7];            
            this.atRecividos = Convert.ToDouble(HelperConvert);

            //Crit. hits received
            HelperConvert = Helper[8];
            if (HelperConvert.IndexOf(" ") > 0)
                HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));
            this.critRecividos = Convert.ToDouble(HelperConvert);

            //Damage received
            HelperConvert = Helper[9];
            if (HelperConvert.IndexOf(" ") > 0)
                HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));
            this.tDamageRec = Convert.ToDouble(HelperConvert);

            //Crit dmg received
            this.tCritDamageRec = Convert.ToDouble(Helper[10]);
            this.statsGrid.Rows[10].Cells[1].Value = this.tCritDamageRec;


            for (int index = 0; index < 10; ++index)
            {
                this.statsGrid.Rows[index].Cells[0].Selected = true;
                this.statsGrid.Rows[index].Cells[0].Selected = false;
                this.balanceGrid.Rows[index].Cells[0].Selected = true;
                this.balanceGrid.Rows[index].Cells[0].Selected = false;
            }

            if (!Helper[11].Equals(null))
                tReloadC = Convert.ToDouble(Helper[11]);

            Helper = textFieldParser.ReadFields();

            if (!Helper[0].Equals(""))
            {
                if (Helper[1].Equals(""))
                {
                    tSecondHunt = Convert.ToInt32(Helper[0]);
                    Helper = textFieldParser.ReadFields();
                }
            }



            if (!(Helper[0].Equals("")))
            {
                for (; !(Helper[0].Equals(""));)
                {
                    int rowCount = this.dGVEnh.RowCount;
                    this.dGVEnh.Rows.Add();
                    this.dGVEnh.Rows[rowCount].Cells[0].Value = (object)Convert.ToDouble(Helper[0]);
                    if (Helper[1].LastIndexOf(" ") == Helper[1].Length)
                    Helper[1] = Helper[1].Remove(Helper[1].Length - 1, 1);
                    this.dGVEnh.Rows[rowCount].Cells[1].Value = (object)Helper[1];
                    this.dGVEnh.Rows[rowCount].Cells[2].Value = (object)(Convert.ToDouble(Helper[2]).ToString("F2"));
                    this.dGVEnh.Rows[rowCount].Cells[3].Value = (object)(Convert.ToDouble(Helper[3]).ToString("F2"));
                    this.dGVEnh.Rows[rowCount].Cells[4].Value = (object)(Convert.ToDouble(Helper[4]).ToString("F2"));
                    this.dGVEnh.Rows[rowCount].ReadOnly = true;
                    this.dGVEnh.Rows[rowCount].Selected = false;
                    this.dGVEnh.Rows[0].Cells[0].Selected = true;
                    this.dGVEnh.Rows[0].Cells[0].Selected = false;
                    Helper = textFieldParser.ReadFields();
                }
            }
            Helper = textFieldParser.ReadFields();


            if (!(Helper[0].Equals("")))
            {
                for (int i = 0; !(Helper[0].Equals("")); i++)
                {
                    this.GrafCountings.Add(new GrafCounting(Convert.ToInt32(Helper[0]), Convert.ToDouble(Helper[1]), Convert.ToDouble(Helper[2]), Convert.ToDouble(Helper[3])));
                    cartesianChart1count();
                    Helper = textFieldParser.ReadFields();
                }
            }

            Helper = textFieldParser.ReadFields();

            if (!(Helper[0].Equals("")))
            {
                for (; !(Helper[0].Equals(""));)
                {
                    int rowCount = this.dGVTiring.RowCount;
                    this.dGVTiring.Rows.Add();
                    this.dGVTiring.Rows[rowCount].Cells[0].Value = (object)Convert.ToString(Helper[0]);
                    this.dGVTiring.Rows[rowCount].Cells[1].Value = (object)Convert.ToDouble(Helper[1]);
                    this.dGVTiring.Rows[rowCount].Cells[2].Value = (object)Convert.ToDouble(Helper[2]).ToString("F0");
                    this.dGVTiring.Rows[rowCount].Cells[3].Value = (object)Convert.ToDouble(Helper[3]);
                    this.dGVTiring.Rows[rowCount].Cells[4].Value = (object)Convert.ToString(Helper[4]);
                    this.dGVTiring.Rows[rowCount].Selected = false;
                    this.dGVTiring.Rows[0].Cells[0].Selected = true;
                    this.dGVTiring.Rows[0].Cells[0].Selected = false;
                    Helper = textFieldParser.ReadFields();
                }
            }

            Helper = textFieldParser.ReadFields();

            if (!(Helper[0].Equals("")))
            {
                for (; !(Helper[0].Equals(""));)
                {
                    int rowCount = this.dGVStatus.RowCount;
                    this.dGVStatus.Rows.Add();
                    this.dGVStatus.Rows[rowCount].Cells[0].Value = (object)Convert.ToString(Helper[0]);
                    this.dGVStatus.Rows[rowCount].Cells[1].Value = (object)Convert.ToInt32(Helper[1]);
                    this.dGVStatus.Rows[rowCount].Cells[2].Value = (object)Convert.ToDouble(Helper[2]);
                    this.dGVStatus.Rows[rowCount].Cells[3].Value = (object)Convert.ToDouble(Helper[3]);                        
                    this.dGVStatus.Rows[rowCount].ReadOnly = true;
                    this.dGVStatus.Rows[rowCount].Selected = false;
                    this.dGVStatus.Rows[0].Cells[0].Selected = true;
                    this.dGVStatus.Rows[0].Cells[0].Selected = false;
                    Helper = textFieldParser.ReadFields();
                }
            }

        Helper = textFieldParser.ReadFields();

            if (!(Helper[0].Equals("")) && !(Regex.IsMatch(Helper[0], @"^[0-9]")))//костыльно, но работает
            {
                for (; !(Helper[0].Equals(""));)
                {
                    int rowCount = this.dGVSkill.RowCount;
                    this.dGVSkill.Rows.Add();
                    this.dGVSkill.Rows[rowCount].Cells[0].Value = (object)Convert.ToString(Helper[0]);
                    this.dGVSkill.Rows[rowCount].Cells[1].Value = (object)Convert.ToDouble(Helper[1]);
                    this.dGVSkill.Rows[rowCount].Cells[2].Value = (object)Convert.ToInt32(Helper[2]);
                    this.dGVSkill.Rows[rowCount].ReadOnly = true; ///todo проверить, можно ли изменять значение из функций если тут False
                    this.dGVSkill.Rows[rowCount].Selected = false;
                    this.dGVSkill.Rows[0].Cells[0].Selected = true;
                    this.dGVSkill.Rows[0].Cells[0].Selected = false;
                    Helper = textFieldParser.ReadFields();

                    double totalPoints = 0;
                    int totalSummons = 0;
                    for (int i = 0; i < this.dGVSkill.RowCount; i++)
                    {
                        totalPoints += Convert.ToDouble(this.dGVSkill.Rows[i].Cells[1].Value);
                        totalSummons += Convert.ToInt32(this.dGVSkill.Rows[i].Cells[2].Value);
                    }
                    dGVSkillTotalPoints.HeaderText = "TotalPoints: " + totalPoints;
                    dGVSkillSummons.HeaderText = "Summons: " + totalSummons;
                }
            }


            for (; !textFieldParser.EndOfData;)
            {
                    Helper = textFieldParser.ReadFields();
                    listaItems.Add(new Items(Helper[1], Convert.ToDouble(Helper[0]), Convert.ToDouble(Helper[2]), Convert.ToDouble(Helper[5])));
                    int rowCount = this.dGV1.RowCount;
                    this.dGV1.Rows.Add();
                    this.dGV1.Rows[rowCount].Cells[0].ValueType = typeof(double);
                    this.dGV1.Rows[rowCount].Cells[0].Value = (object)Convert.ToDouble(Helper[0]);
                    this.dGV1.Rows[rowCount].Cells[1].Value = (object)Helper[1];
                    this.dGV1.Rows[rowCount].Cells[2].ValueType = typeof(double);
                    this.dGV1.Rows[rowCount].Cells[2].Value = (object)Convert.ToDouble(Helper[2]);
                    this.dGV1.Rows[rowCount].Cells[3].ValueType = typeof(double);
                    this.dGV1.Rows[rowCount].Cells[3].Value = (object)Convert.ToDouble(Helper[3]);
                    this.dGV1.Rows[rowCount].Cells[4].ValueType = typeof(double);
                    this.dGV1.Rows[rowCount].Cells[4].Value = (object)Convert.ToDouble(Helper[4]);
                    this.dGV1.Rows[rowCount].Cells[5].ValueType = typeof(double);
                    this.dGV1.Rows[rowCount].Cells[5].Value = (object)(Convert.ToDouble(Helper[5]).ToString("F2"));
                    double LootHelper;

                if (!this.STT.checkBoxLootAmmo.Checked)
                    LootHelper = balanceGridHelpRow71;
                else
                    LootHelper = this.ammoSpent * 0.01 + this.repairs;                
                    this.dGV1.Rows[rowCount].Cells[6].Value = (object)Math.Round((Convert.ToDouble(this.dGV1.Rows[rowCount].Cells[4].Value) / LootHelper) * 100, 2);
                    this.dGV1.Rows[rowCount].ReadOnly = true;
                    this.dGV1.Rows[rowCount].Selected = false;
                    this.dGV1.Rows[0].Cells[0].Selected = true;
                    this.dGV1.Rows[0].Cells[0].Selected = false;
            }

            TotalHuntTime.Text = ((new TimeSpan(0, 0, tSecondHunt)).ToString()).Replace(".", " ");

            if (mobsKilled > 0)
                AVGTTK.Text = ((new TimeSpan(0, 0, tSecondHunt / this.mobsKilled)).ToString()).Replace(".", " ");

        }

        //Graf making solution
        //better use documentation to understand how to work with it
        public void cartesianChart1count() // визуализация графика
        {
            try
            {                
                SeriesCollection series = new SeriesCollection();

                ChartValues<double> TTValues = new ChartValues<double>();
                ChartValues<double> TTMUValues = new ChartValues<double>();
                ChartValues<double> MUValues = new ChartValues<double>();

                List<string> MobsKilled = new List<string>();
                if (GrafCountings.Count == 0)
                    return;

                foreach (var Selecting in GrafCountings)
                {
                    if (((Selecting.MOBSKILLED / Convert.ToInt32(this.STT.MobsKilled.Text)) % Convert.ToInt32(this.STT.MobsKilledPointEvery.Text)) == 0)
                    {
                        TTValues.Add(Selecting.TT);
                        TTMUValues.Add(Selecting.TTMU);
                        MUValues.Add(Selecting.MU);
                        MobsKilled.Add(Convert.ToString(Selecting.MOBSKILLED));
                    }
                }

                System.Windows.Media.BrushConverter converter = new System.Windows.Media.BrushConverter();
                System.Windows.Media.Brush brush = (System.Windows.Media.Brush)converter.ConvertFromString("#585858");

                int LineHelper;
                if (this.STT.MobsKilledAutoSize.Checked)
                {

                    if (mobsKilled >= 1000)
                        LineHelper = mobsKilled / ((Convert.ToInt32(this.STT.MobsKilledNumLines.Text)) * 100) - 1;
                    else
                        LineHelper = 1;
                }
                else
                {
                    if (mobsKilled >= 1000)
                        LineHelper = mobsKilled / ((Convert.ToInt32(this.STT.MobsKilledNumLines.Text)) * 100) / Convert.ToInt32(this.STT.MobsKilledPointEvery.Text) - 1;
                    else
                        LineHelper = 1;
                }


                if (LineHelper < 1)
                    return;


                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisX.Add(new Axis()                
                {
                    Title = "MobsKilled",
                    Labels = MobsKilled,
                    Separator = new LiveCharts.Wpf.Separator()
                    {                       
                        Step = LineHelper,
                        Stroke = brush,
                    }
                });

                cartesianChart1.AxisY.Clear();
               
                cartesianChart1.AxisY.Add(new Axis()
                {
                    Separator = new LiveCharts.Wpf.Separator()
                    {
                        Step = 10.0,
                        Stroke = brush
                    }
                });
                

                brush = (System.Windows.Media.Brush)converter.ConvertFromString("#1837a8");
                LineSeries lineTT = new LineSeries();
                lineTT.Title = "TT %";
                lineTT.Values = TTValues;
                lineTT.Stroke = brush;
                lineTT.PointGeometrySize = 1;
                lineTT.StrokeThickness = 1;
                series.Add(lineTT);

                brush = (System.Windows.Media.Brush)converter.ConvertFromString("#1895a8");
                LineSeries lineTTMU = new LineSeries();
                lineTTMU.Title = "TTMU %";
                lineTTMU.Values = TTMUValues;
                lineTTMU.Stroke = brush;
                lineTTMU.PointGeometrySize = 1;
                lineTTMU.StrokeThickness = 1;
                series.Add(lineTTMU);

                //MU only line, uncomment if want to work
                //brush = (System.Windows.Media.Brush)converter.ConvertFromString("#21a818");
                //LineSeries lineMU = new LineSeries();
                //lineMU.Title = "MU";
                //lineMU.Values = MUValues;
                //lineMU.Stroke = brush;
                //lineMU.PointGeometrySize = 5;
                //lineMU.StrokeThickness = 1;
                //series.Add(lineMU);

                cartesianChart1.Series = series;
            }
            catch (Exception ex) { MessageBox.Show("Graf error: " + ex.Message); }

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            cartesianChart1count();
        }

        private void cartesianChart1count(object sender, EventArgs e)
        {
            if(tabGraf.SelectedTab == tabPage3)
            cartesianChart1count();
        }


        private void ammoBurnTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!this.loading)
            {
                try
                {
                    double result = Convert.ToDouble(this.ammoBurnTxt.Text);
                    if (result < 0.0 && result > 999999.0 && this.ammoBurnTxt.Text != "")
                    {
                        this.ammoBurnTxt.Text = "0";
                    }
                    else
                    {
                        this.ammoPerShot = result;
                        this.CalculateProfit();
                    }

                }
                catch (Exception ex)
                {
                    this.ammoBurnTxt.Text = "0";
                }
            }

            else
                this.loading = false;
            
            
        }

        //Hide DPP
        private void button5_Click_1(object sender, EventArgs e)
        {           
                this.DPPHide.Visible = false;           
        }

        //Show DPP
        private void label4_Click(object sender, EventArgs e)
        {
            this.DPPHide.Visible = true;
        }

        //Show DPP
        private void DPPShow_Click(object sender, EventArgs e)
        {

            this.DPPHide.Visible = true;
        }

        //Selecting first profile after loading app
        private void FormMain_Shown(object sender, EventArgs e)
        {            
            BindArgs e1 = new BindArgs(Keys.D1, false, 1, 1);
            KBDHook_OnHookKeyPressEventHandler(e1);            
            this.fCC.Prof1_Click(sender, e);
            this.fCC.Prof1_Click(sender, e);

        }

        //Timer for hunting time and dps check
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (SecondsBeforeAFKTimer < Convert.ToInt32(this.STT.SecBeforeAFKTimerBox.Text))
            {
                tSecondHunt++;
                SecondsBeforeAFKTimer++;
            }            

            TotalHuntTime.Text = ((new TimeSpan(0, 0, tSecondHunt)).ToString()).Replace("."," ");

            if(mobsKilled > 0)
            AVGTTK.Text = ((new TimeSpan(0, 0, tSecondHunt / this.mobsKilled)).ToString()).Replace(".", " ");

        }        

        private void label8_MouseMove(object sender, MouseEventArgs e) => this.toolTip1.SetToolTip((Control)this.label8, 
            "Avarage Time To Kill or\nAvarage time to find and dig one claim (Time Between Climes)");

        //Union files
        private void FileManagerbutton_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (this.fCC.ProfList[CProf-1].USEEFLAG)
                {
                    MessageBox.Show("Set not E weapon");
                    return;
                }
                string FilePath2;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                FilePath2 = openFileDialog.FileName;

                using (TextFieldParser textFieldParser = new TextFieldParser(FilePath2))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(";");
                    string[] Helper = textFieldParser.ReadFields();
                    string HelperConvert;
                    string HelperConvertString1;
                    double HelperConvertDouble1;

                    //Extra expenses
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[0].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[0].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[0].Remove(Helper[0].LastIndexOf(" "), 4)) + " PED");
                    this.repairs = HelperConvertDouble1 + Convert.ToDouble(Helper[0].Remove(Helper[0].LastIndexOf(" "), 4));

                    //Ammo cost
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[1].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[1].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[1].Remove(Helper[1].LastIndexOf(" "), 4)) + " PED");
                    this.ammoSpent = (Convert.ToDouble(HelperConvertDouble1 + Convert.ToDouble(Helper[1].Remove(Helper[1].LastIndexOf(" "), 4))) - this.repairs) * 100;

                    //Loot value + MU
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[2].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[2].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[2].Remove(Helper[2].LastIndexOf(" "), 4)) + " PED");

                    //Total + MU
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[3].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[3].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[3].Remove(Helper[3].LastIndexOf(" "), 4)) + " PED");

                    //Enemies killed
                    HelperConvertString1 = Helper[5];
                    while (HelperConvertString1.Contains(","))
                    {
                        HelperConvertString1 = HelperConvertString1.Remove(HelperConvertString1.IndexOf(","), 1);
                    }
                    HelperConvert = Convert.ToString(this.balanceGrid.Rows[5].Cells[1].Value);
                    while (HelperConvert.Contains(","))
                    {
                        HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(","), 1);
                    }
                    this.balanceGrid.Rows[5].Cells[1].Value = (object)(Convert.ToInt32(HelperConvert) + Convert.ToInt32(HelperConvertString1));
                    this.mobsKilled = Convert.ToInt32(this.balanceGrid.Rows[5].Cells[1].Value);

                    //Average loot + MU
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[6].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[6].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[6].Remove(Helper[6].LastIndexOf(" "), 4)) + " PED");

                    //Loot Value
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[7].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[7].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[7].Remove(Helper[7].LastIndexOf(" "), 4)) + " PED");
                    HelperConvert = Convert.ToString(this.balanceGrid.Rows[7].Cells[1].Value);
                    HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), 4);
                    balanceGridHelpRow71 = Convert.ToDouble(HelperConvertDouble1);

                    //Only MU
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[8].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[8].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[8].Remove(Helper[8].LastIndexOf(" "), 4)) + " PED");

                    //Total
                    HelperConvertString1 = Convert.ToString(this.balanceGrid.Rows[10].Cells[1].Value);
                    HelperConvertDouble1 = Convert.ToDouble(HelperConvertString1.Remove(HelperConvertString1.LastIndexOf(" "), 4));
                    this.balanceGrid.Rows[10].Cells[1].Value = (object)(HelperConvertDouble1 + Convert.ToDouble(Helper[10].Remove(Helper[10].LastIndexOf(" "), 4)) + " PED");

                    Helper = textFieldParser.ReadFields();

                    //Shots
                    this.statsGrid.Rows[0].Cells[1].Value = (object)(Convert.ToDouble(this.statsGrid.Rows[0].Cells[1].Value) + Convert.ToDouble(Helper[0]));
                    this.totalAttacks = Convert.ToDouble(this.statsGrid.Rows[0].Cells[1].Value);

                    //Criticals
                    HelperConvert = Helper[1];
                    if (HelperConvert.IndexOf(" ") > 0)
                        HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));
                    HelperConvertString1 = Convert.ToString(this.statsGrid.Rows[1].Cells[1].Value).Remove(Convert.ToString(this.statsGrid.Rows[1].Cells[1].Value).IndexOf(" "), Convert.ToString(this.statsGrid.Rows[1].Cells[1].Value).Length - Convert.ToString(this.statsGrid.Rows[1].Cells[1].Value).IndexOf(" "));
                    this.crits = Convert.ToDouble(HelperConvert) + Convert.ToDouble(HelperConvertString1);
                    this.statsGrid.Rows[1].Cells[1].Value = (object)(this.crits.ToString("N0") + " (" + (this.crits * 100.0 / this.totalAttacks).ToString("F2") + " %)");

                    //Dmg done
                    HelperConvert = Helper[2];
                    if (HelperConvert.IndexOf(" ") > 0)
                        HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));
                    this.tDamage = Convert.ToDouble(HelperConvert) + Convert.ToDouble(this.statsGrid.Rows[2].Cells[1].Value);
                    this.statsGrid.Rows[2].Cells[1].Value = this.tDamage;

                    //Crit. DmgDone
                    this.tCritDamage = Convert.ToDouble(Helper[3]) + Convert.ToDouble(this.statsGrid.Rows[3].Cells[1].Value);
                    this.statsGrid.Rows[3].Cells[1].Value = this.tCritDamage;

                    //Missed attacks
                    this.dodgedAt = Convert.ToDouble(Helper[4]) + Convert.ToDouble(this.statsGrid.Rows[4].Cells[1].Value);
                    this.statsGrid.Rows[4].Cells[1].Value = this.dodgedAt;

                    //Accuracy
                    this.statsGrid.Rows[5].Cells[1].Value = (object)((100.0 - this.dodgedAt * 100.0 / this.totalAttacks).ToString("F2") + " %");

                    //Missed hits received
                    if (!Helper[6].Contains("PED"))
                    {
                        Helper[6] = Helper[6].Replace(",", "");
                        HelperConvert = Convert.ToString(this.evaded + Convert.ToInt32(Helper[6].Remove(Helper[6].IndexOf(" "), Helper[6].Length - Helper[6].IndexOf(" "))));
                        this.evaded = Convert.ToInt32(HelperConvert);

                        if (Convert.ToString(this.statsGrid.Rows[6].Cells[1].Value).Contains("PED"))
                            MessageBox.Show("This data contains WASTED PED info instead of evade, dodge etc. Evade, dodge etc will not be calculated correct!", "WARNING!!!");
                    }                    
                    else
                        MessageBox.Show("This data contains WASTED PED info instead of evade, dodge etc. Evade, dodge etc will not be calculated correct!", "WARNING!!!");
                    this.statsGrid.Rows[6].Cells[1].Value = (object)this.evaded.ToString("N0") + " (" + (this.evaded * 100.0 / this.atRecividos).ToString("F2") + " %)";

                    //Hits received
                    HelperConvert = Helper[7];                    
                    this.atRecividos = Convert.ToDouble(HelperConvert) + Convert.ToDouble(this.statsGrid.Rows[7].Cells[1].Value);
                    this.statsGrid.Rows[7].Cells[1].Value = this.atRecividos;

                    //Crit.hits received
                    HelperConvert = Helper[8];
                    if (HelperConvert.IndexOf(" ") > 0)
                        HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));
                    HelperConvertString1 = Convert.ToString(this.statsGrid.Rows[8].Cells[1].Value).Remove(Convert.ToString(this.statsGrid.Rows[8].Cells[1].Value).IndexOf(" "), Convert.ToString(this.statsGrid.Rows[8].Cells[1].Value).Length - Convert.ToString(this.statsGrid.Rows[8].Cells[1].Value).IndexOf(" "));
                    this.critRecividos = Convert.ToDouble(HelperConvert) + Convert.ToDouble(HelperConvertString1);
                    this.statsGrid.Rows[8].Cells[1].Value = this.critRecividos.ToString("N0") + " (" + (this.critRecividos /this.atRecividos * 100).ToString("F2") + " %)";

                    //Damage received
                    HelperConvert = Helper[9];
                    if (HelperConvert.IndexOf(" ") > 0)
                        HelperConvert = HelperConvert.Remove(HelperConvert.IndexOf(" "), HelperConvert.Length - HelperConvert.IndexOf(" "));
                    this.tDamageRec = Convert.ToDouble(HelperConvert) + Convert.ToDouble(this.statsGrid.Rows[9].Cells[1].Value);
                    this.statsGrid.Rows[9].Cells[1].Value = this.tDamageRec;

                    //Crit Dmg received
                    this.tCritDamageRec = Convert.ToDouble(Helper[10]) + Convert.ToDouble(this.statsGrid.Rows[10].Cells[1].Value);
                    this.statsGrid.Rows[10].Cells[1].Value = this.tCritDamageRec;

                    for (int index = 0; index < 10; ++index)
                    {
                        this.statsGrid.Rows[index].Cells[0].Selected = true;
                        this.statsGrid.Rows[index].Cells[0].Selected = false;
                        this.balanceGrid.Rows[index].Cells[0].Selected = true;
                        this.balanceGrid.Rows[index].Cells[0].Selected = false;
                    }

                    if (!Helper[11].Equals(null))
                        tReloadC = tReloadC + Convert.ToDouble(Helper[11]);

                    Helper = textFieldParser.ReadFields();

                    if (!Helper[0].Equals(""))
                    {
                        if (Helper[1].Equals(""))
                        {
                            tSecondHunt = tSecondHunt + Convert.ToInt32(Helper[0]);
                            Helper = textFieldParser.ReadFields();
                        }
                    }


                    if (!(Helper[0].Equals("")))
                    {
                        for (; !(Helper[0].Equals(""));)
                        {
                                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");                                
                                bool FlagEnhExist = false;

                                for (int RowCount = 0; RowCount < this.dGVEnh.RowCount; RowCount++)
                                {
                                    if (((string)this.dGVEnh.Rows[RowCount].Cells[1].Value) == Helper[1])
                                    {
                                        FlagEnhExist = true;
                                        this.dGVEnh.Rows[RowCount].Cells[0].Value = (Convert.ToInt32(dGVEnh.Rows[RowCount].Cells[0].Value) + Convert.ToInt32(Helper[0]));
                                        this.dGVEnh.Rows[RowCount].Cells[2].Value = (Convert.ToDouble(dGVEnh.Rows[RowCount].Cells[2].Value) + Convert.ToDouble(Helper[2]));
                                        this.dGVEnh.Rows[RowCount].Cells[3].Value = (Convert.ToDouble(dGVEnh.Rows[RowCount].Cells[3].Value) + (Convert.ToDouble(Helper[2]) * (Convert.ToDouble(this.dGVEnh.Rows[RowCount].Cells[4].Value) / 100) - Convert.ToDouble(Helper[2])));
                                        this.dGVEnh.Rows[0].Cells[0].Selected = false;
                                        break;
                                    }
                                }
                                if (!FlagEnhExist)
                                {
                                    int RowCount1 = this.dGVEnh.RowCount;
                                    this.dGVEnh.Rows.Add();
                                    this.dGVEnh.Rows[RowCount1].Cells[0].Value = Convert.ToInt32(Helper[0]);
                                    this.dGVEnh.Rows[RowCount1].Cells[1].Value = Convert.ToString(Helper[1]);
                                    this.dGVEnh.Rows[RowCount1].Cells[2].Value = Convert.ToDouble(Helper[2]);
                                    this.dGVEnh.Rows[RowCount1].Cells[4].Value = 100;
                                    this.dGVEnh.Rows[RowCount1].Cells[3].Value = Convert.ToDouble(Helper[2]) * (100 / Convert.ToDouble(this.dGVEnh.Rows[RowCount1].Cells[4].Value)) - Convert.ToDouble(Helper[2]);
                                    this.dGVEnh.Rows[0].Cells[0].Selected = false;
                                }
                            Helper = textFieldParser.ReadFields();
                        }
                    }

                    Helper = textFieldParser.ReadFields();

                    int statickmobskilled = 0;
                    if (GrafCountings.Count > 0)
                    statickmobskilled = GrafCountings[GrafCountings.Count - 1].MOBSKILLED;

                    if (!(Helper[0].Equals("")))
                    {
                        for (int i = 0; !(Helper[0].Equals("")); i++)
                        {
                            this.GrafCountings.Add(new GrafCounting(Convert.ToInt32(Helper[0]) + statickmobskilled, Convert.ToDouble(Helper[1]), Convert.ToDouble(Helper[2]), Convert.ToDouble(Helper[3])));
                            cartesianChart1count();
                            Helper = textFieldParser.ReadFields();
                        }
                    }

                    Helper = textFieldParser.ReadFields();

                    if (!(Helper[0].Equals("")))
                    {
                        for (; !(Helper[0].Equals(""));)
                        {
                            int rowCount = this.dGVTiring.RowCount;
                            this.dGVTiring.Rows.Add();
                            this.dGVTiring.Rows[rowCount].Cells[0].Value = (object)Convert.ToString(Helper[0]);
                            this.dGVTiring.Rows[rowCount].Cells[1].Value = (object)Convert.ToDouble(Helper[1]);
                            this.dGVTiring.Rows[rowCount].Cells[2].Value = (object)Convert.ToDouble(Helper[2]).ToString("F0");
                            this.dGVTiring.Rows[rowCount].Cells[3].Value = (object)Convert.ToDouble(Helper[3]);
                            this.dGVTiring.Rows[rowCount].Cells[4].Value = (object)Convert.ToString(Helper[4]);
                            this.dGVTiring.Rows[rowCount].Selected = false;
                            this.dGVTiring.Rows[0].Cells[0].Selected = true;
                            this.dGVTiring.Rows[0].Cells[0].Selected = false;
                            Helper = textFieldParser.ReadFields();
                        }
                    }

                    Helper = textFieldParser.ReadFields();

                    if (!(Helper[0].Equals("")))
                    {
                        for (; !(Helper[0].Equals(""));)
                        {

                            bool FlagItemExist = false;

                            for (int RowCount = 0; RowCount < this.dGVStatus.RowCount; RowCount++)
                            {
                                if (Convert.ToString(this.dGVStatus.Rows[RowCount].Cells[0].Value) == Helper[0])
                                {
                                    FlagItemExist = true;
                                    this.dGVStatus.Rows[RowCount].Cells[1].Value = Convert.ToInt32(this.dGVStatus.Rows[RowCount].Cells[1].Value) + Convert.ToInt32(Helper[1]);
                                    this.dGVStatus.Rows[RowCount].Cells[2].Value = Convert.ToDouble(this.dGVStatus.Rows[RowCount].Cells[2].Value) + Convert.ToDouble(Helper[2]);
                                    this.dGVStatus.Rows[RowCount].Cells[3].Value = Convert.ToDouble(this.dGVStatus.Rows[RowCount].Cells[3].Value) + Convert.ToDouble(Helper[3]);
                                    this.dGVStatus.Rows[0].Cells[0].Selected = false;
                                    break;
                                }
                            }
                            if (!FlagItemExist)
                            {
                                int RowCount1 = this.dGVStatus.RowCount;
                                this.dGVStatus.Rows.Add();
                                FlagItemExist = true;
                                this.dGVStatus.Rows[RowCount1].Cells[0].Value = Helper[0];
                                this.dGVStatus.Rows[RowCount1].Cells[1].Value = Convert.ToInt32(Helper[1]);
                                this.dGVStatus.Rows[RowCount1].Cells[2].Value = Convert.ToDouble(Helper[2]);
                                this.dGVStatus.Rows[RowCount1].Cells[3].Value = Convert.ToDouble(Helper[3]);
                                this.dGVStatus.Rows[0].Cells[0].Selected = false;
                            }
                            Helper = textFieldParser.ReadFields();
                        }
                    }

                    Helper = textFieldParser.ReadFields();

                    if (!(Helper[0].Equals("")) && !(Regex.IsMatch(Helper[0], @"^[0-9]")))
                    {
                        for (; !(Helper[0].Equals(""));)
                        {
                            bool FlagEnhExist = false;

                            for (int RowCount = 0; RowCount < this.dGVSkill.RowCount; RowCount++)
                            {
                                if (((string)this.dGVSkill.Rows[RowCount].Cells[0].Value) == Helper[0])
                                {
                                    listSkills.Add(new SkillCount(Convert.ToString(Helper[0]), Convert.ToDouble(Helper[1]), Convert.ToInt32(this.dGVSkill.Rows[RowCount].Cells[2].Value) + Convert.ToInt32(Helper[2])));
                                    FlagEnhExist = true;
                                    this.dGVSkill.Rows[RowCount].Cells[1].Value = Math.Round(Convert.ToDouble(dGVSkill.Rows[RowCount].Cells[1].Value) + Convert.ToDouble(Helper[1]), 4);
                                    this.dGVSkill.Rows[RowCount].Cells[2].Value = Convert.ToInt32(this.dGVSkill.Rows[RowCount].Cells[2].Value) + Convert.ToInt32(Helper[2]);                                   
                                    this.dGVSkill.Rows[0].Cells[0].Selected = false;
                                    break;
                                }
                            }
                            if (!FlagEnhExist)
                            {
                                listSkills.Add(new SkillCount(Convert.ToString(Helper[0]), Convert.ToDouble(Helper[1]), Convert.ToInt32(Helper[2])));
                                int RowCount1 = this.dGVSkill.RowCount;
                                this.dGVSkill.Rows.Add();
                                this.dGVSkill.Rows[RowCount1].Cells[0].Value = Convert.ToString(Helper[0]);
                                this.dGVSkill.Rows[RowCount1].Cells[1].Value = Math.Round(Convert.ToDouble(Helper[1]), 4);
                                this.dGVSkill.Rows[RowCount1].Cells[2].Value = Convert.ToInt32(Helper[2]);
                                this.dGVSkill.Rows[0].Cells[0].Selected = false;
                            }
                            Helper = textFieldParser.ReadFields();

                            double totalPoints = 0;
                            int totalSummons = 0;
                            for (int i = 0; i < this.dGVSkill.RowCount; i++)
                            {
                                totalPoints += Convert.ToDouble(this.dGVSkill.Rows[i].Cells[1].Value);
                                totalSummons += Convert.ToInt32(this.dGVSkill.Rows[i].Cells[2].Value);
                            }
                            dGVSkillTotalPoints.HeaderText = "TotalPoints: " + totalPoints;
                            dGVSkillSummons.HeaderText = "Summons: " + totalSummons;
                        }
                    }

                    for (; !textFieldParser.EndOfData;)
                    {
                        Helper = textFieldParser.ReadFields();
                        string line;
                        line = "0000-00-00 00:00:00 [System] [] You received " + Convert.ToString(Helper[1]) + " x (" + Convert.ToString(Helper[0]) + ") Value: " + Convert.ToString(Helper[4]) + " PED";
                        this.AddItems(this.listaItems, line, true);
                    }

                    double LootHelper;

                    if (!this.STT.checkBoxLootAmmo.Checked)
                        LootHelper = balanceGridHelpRow71;
                    else
                        LootHelper = this.ammoSpent * 0.01 + this.repairs;

                    for (int i = 0; i < this.dGV1.Rows.Count; i++)
                        this.dGV1.Rows[i].Cells[6].Value = (object)Math.Round((Convert.ToDouble(this.dGV1.Rows[i].Cells[4].Value) / LootHelper) * 100, 2);
                }
                CalculateProfit();

                TotalHuntTime.Text = ((new TimeSpan(0, 0, tSecondHunt)).ToString()).Replace(".", " ");

                if (mobsKilled > 0)
                    AVGTTK.Text = ((new TimeSpan(0, 0, tSecondHunt / this.mobsKilled)).ToString()).Replace(".", " ");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroor union: " + ex);
            }   
        }

        public void chengeToMiningModeOverlay(bool chi)
        {
            if (chi)
            {
                this.f3.label8.Text = "Climes";
                label8.Text = "AVG TBC:";
                label7.Text = "Total Mine Time:";
            }
            else
            {
                this.f3.label8.Text = "MobsKilled";
                label8.Text = "AVG TTK:";
                label7.Text = "Total Hunt Time:";
            }
        }

        //Selecting team member and loading its info, same as in TeamTotalCount()
        private void cB_SelectTeamMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dGVTeamMember.Rows.Clear();
                TeamTotalNaN.Text = "0";
                TeamTotalTT.Text = "0";
                string nick = cB_SelectTeamMember.SelectedItem.ToString();
                string playerLine = FullTeamInfo.Substring(FullTeamInfo.IndexOf(nick) + nick.Length + 3);

                playerLine = playerLine.Substring(0, playerLine.IndexOf(";") + 1);

                for (int RowCount = 0; playerLine != ""; RowCount++)
                {
                    double NanTT = 0;
                    bool NanTTflag = false;
                    string curItem;
                    string curAmount = playerLine.Remove(0, playerLine.IndexOf(" x ") + 3);
                    curItem = playerLine.Remove(playerLine.IndexOf(" x "), playerLine.Length - playerLine.IndexOf(" x "));
                    if (playerLine.IndexOf(",") > 0)
                    {
                        playerLine = playerLine.Remove(0, playerLine.IndexOf(",") + 2);
                        curAmount = curAmount.Remove(curAmount.IndexOf(","), curAmount.Length - curAmount.IndexOf(","));
                        if(curAmount.Contains("*"))
                        {
                            NanTT = Convert.ToDouble(curAmount.Remove(0, curAmount.IndexOf("*") + 1));
                            curAmount = curAmount.Remove(curAmount.IndexOf("*"));
                            NanTTflag = true;
                        }
                    }
                    else
                    {
                        playerLine = "";
                        curAmount = curAmount.Remove(curAmount.IndexOf(";"), curAmount.Length - curAmount.IndexOf(";"));
                        if (curAmount.Contains("*"))
                        {
                            NanTT = Convert.ToDouble(curAmount.Remove(0, curAmount.IndexOf("*") + 1));
                            curAmount = curAmount.Remove(curAmount.IndexOf("*"));
                            NanTTflag = true;
                        }
                    }
                    using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUmats.csv"))
                    {
                        textFieldParser.TextFieldType = FieldType.Delimited;
                        textFieldParser.SetDelimiters(",");
                        bool noItem = false;
                        while (!textFieldParser.EndOfData)
                        {
                            string[] strArray2 = textFieldParser.ReadFields();
                            foreach (string str4 in strArray2)
                            {

                                if (str4 == curItem)
                                {
                                    dGVTeamMember.Rows.Add();
                                    double ttPerUnit = double.Parse(strArray2[1], (IFormatProvider)this.ci);
                                    dGVTeamMember.Rows[RowCount].Cells[0].Value = Convert.ToInt32(curAmount);
                                    dGVTeamMember.Rows[RowCount].Cells[1].Value = curItem;
                                    if(!NanTTflag)
                                        dGVTeamMember.Rows[RowCount].Cells[2].Value = (Convert.ToDouble(curAmount) * ttPerUnit).ToString("F2");
                                    else
                                        dGVTeamMember.Rows[RowCount].Cells[2].Value = Convert.ToDouble(NanTT).ToString("F2");
                                    dGVTeamMember.Rows[0].Cells[0].Selected = false;
                                    noItem = true;
                                    break;
                                }
                            }
                        }
                        if (!noItem)
                        {
                            dGVTeamMember.Rows.Add();
                            dGVTeamMember.Rows[RowCount].Cells[0].Value = Convert.ToInt32(curAmount);
                            dGVTeamMember.Rows[RowCount].Cells[1].Value = curItem;
                            if (!NanTTflag)
                                dGVTeamMember.Rows[RowCount].Cells[2].Value = "NaN";
                            else
                                dGVTeamMember.Rows[RowCount].Cells[2].Value = Convert.ToDouble(NanTT).ToString("F2");
                            TeamTotalNaN.Text = Convert.ToString(Convert.ToInt32(TeamTotalNaN.Text) + 1);
                            dGVTeamMember.Rows[0].Cells[0].Selected = false;
                        }
                    }
                }

                double fullTTdGVTeamMember = 0;
                foreach (DataGridViewRow row in (IEnumerable)this.dGVTeamMember.Rows)
                {
                    if(!row.Cells[2].Value.Equals("NaN"))
                    fullTTdGVTeamMember += Convert.ToDouble(row.Cells[2].Value);
                }
                TeamTotalTT.Text = fullTTdGVTeamMember.ToString("F2");

                TeamTotalPrc.Text = (Convert.ToDouble(TeamTotalTT.Text) / fullTeamTT * 100).ToString("F2") + "%";
            }
            catch(Exception ex)
            {
                MessageBox.Show("cB_SelectTeamMember_SelectedIndexChanged :" + ex);
            }
        }


        private void totalTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EventArgs e = null;
            if ((totalTeam.SelectedTab == tt) && !FullTeamInfo.Equals(""))
                cB_SelectTeamMember_SelectedIndexChanged(1, e);
            if ((totalTeam.SelectedTab == TotalTeamdGV) && !FullTeamInfo.Equals(""))
                TeamTotalCount();
            //if (totalTeam.SelectedTab == Globals);
            //{
            //    
            //}
        }

        //Team reset button
        private void ResetTeamStat_Click(object sender, EventArgs e)
        {
            FullTeamInfo = "";
            cB_SelectTeamMember.Text = "";
            TeamTotalNaN.Text = "0";
            TeamTotalTT.Text = "0";
            fullTeamTT = 0;
            cB_SelectTeamMember.Items.Clear();
            dGVTeamMember.Rows.Clear();
            labelTotalTeamTT.Text = "0";
            dGVTeamTotal.Rows.Clear();
        }

        //Import all team info, prepares path
        private void ImportTeam_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                DialogResult num = MessageBox.Show("All current data will be lost, continue?", "WARNING!!!", MessageBoxButtons.YesNo);

                if (num == DialogResult.Yes)
                {
                    ResetTeamStat_Click(sender, e);
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;

                    using (TextFieldParser textFieldParser = new TextFieldParser(openFileDialog.FileName))
                    {
                        FullTeamInfo = textFieldParser.ReadToEnd();
                    }

                    TeamTotalCount();                    

                    string copyFullTeamInfo = FullTeamInfo.Replace(";\r\n", ";");
                    while (copyFullTeamInfo.Contains(";"))
                    {                        
                        cB_SelectTeamMember.Items.Add(copyFullTeamInfo.Remove(copyFullTeamInfo.IndexOf(" : ")));
                        copyFullTeamInfo = copyFullTeamInfo.Remove(0, copyFullTeamInfo.IndexOf(";") + 1);
                    }

                    cB_SelectTeamMember.SelectedIndex = 0;

                }
                else if (num == DialogResult.No)
                    return;                
            }
            catch (Exception ex) { MessageBox.Show("Exeption allert, data dont load correcly: " + ex.Message); }
        }

        //Export all team info, prepares path
        private void ExportTeam_Click(object sender, EventArgs e)
        {
            string DataTimeHelp = "Team " + Convert.ToString(DateTime.Now);
            DataTimeHelp = DataTimeHelp.Replace('/', '.');
            DataTimeHelp = DataTimeHelp.Replace(':', '.');
            Stream ExportPath;
            SaveFileDialog ExportDialog = new SaveFileDialog();

            ExportDialog.Filter = "All files (*.*)|*.*|Csv files (*.csv)|*.csv";
            ExportDialog.FilterIndex = 2;
            ExportDialog.FileName = DataTimeHelp;
            //ExportDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; // при сохранении открывает папку с прогой 
            ExportDialog.RestoreDirectory = true;
            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                if ((ExportPath = ExportDialog.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(ExportPath))
                    {
                        writer.Write(FullTeamInfo);
                    }                    
                    ExportPath.Close();
                    MessageBox.Show("All current data saved.", "Saved");
                }
            }
        }        

        //Changing item value of team member
        private void dGVTeamMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex == 2) && (e.RowIndex > -1))
                {
                    this.inputForm.inputInformationText.Text = "Write the PED value of this item and press OK.\r\nTo return base value dont write anything and press OK";
                    this.inputForm.mode = "itemsTeam";
                    this.inputForm.celda = this.dGVTeamMember.CurrentCell; // todo при лутинге сбивается индекс и ерор по сточкам
                    int num = (int)this.inputForm.ShowDialog();
                    TeamTotalCount();
                    cB_SelectTeamMember_SelectedIndexChanged(1, e);

                    if (this.STT.checkBoxBackupTeam.Checked)
                    {
                        using (StreamWriter writer = new StreamWriter(TeamBackupPath))
                        {
                            writer.Write(FullTeamInfo);
                        }

                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("dGVTeamMember_CellContentClick: " + ex);
            }
        }

        private void AutoSaveGlobals()
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(this.GlobalsPath, FileMode.Create, FileAccess.Write)))
            {
                writer.Write(textBoxGlobals.Text);
            }
        }

        //Loading globals at start, same as in analyseLine()
        private void AutoLoadGlobals()
        {
            if(File.Exists(this.GlobalsPath))
            { 
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");            
                using (TextFieldParser textFieldParser = new TextFieldParser(this.GlobalsPath))
                {
                    textBoxGlobals.Text = textFieldParser.ReadToEnd();
                }
                string item;
                string value;
                string LineForSwitch = "";
                int rows;
                string lineCopy = textBoxGlobals.Text;
                while (!lineCopy.Equals(""))
                {
                    string line = lineCopy.Remove(lineCopy.IndexOf("\r\n"));
                    if (lineCopy.Length > (lineCopy.IndexOf("\r\n") + 4))
                        lineCopy = lineCopy.Remove(0, lineCopy.IndexOf("\r\n") + 4);
                    else
                        lineCopy = "";
                    string lineSplit = line.Remove(0, line.IndexOf(this.STT.NickName.Text) + this.STT.NickName.Text.Length + 1);
                    if (lineSplit.StartsWith("is") || lineSplit.Contains("has found a rare item"))
                        LineForSwitch = "is";
                    else
                    {
                        if (lineSplit.Contains("killed a creature"))
                            LineForSwitch = "killed";
                        else if (lineSplit.Contains("constructed"))
                            LineForSwitch = "constructed";
                        else if (lineSplit.Contains("found"))
                            LineForSwitch = "found";
                    }

                    switch (LineForSwitch)
                    {
                        case "killed":
                            item = line.Remove(0, line.IndexOf("a creature ") + 12);
                            item = item.Remove(item.LastIndexOf(")"));
                            value = line.Remove(0, line.IndexOf("with a value of ") + 16);
                            value = value.Remove(value.IndexOf(" "));
                            rows = dGVGlobals.RowCount;
                            dGVGlobals.Rows.Add();

                            if (line.Contains("A record has been added to the Hall of Fame!"))
                                dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                            else
                                dGVGlobals.Rows[rows].Cells[0].Value = "(G)";
                            dGVGlobals.Rows[rows].Cells[1].Value = item;
                            dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);
                            break;

                        case "constructed":
                            item = line.Remove(0, line.IndexOf("constructed an item ") + 21);
                            item = item.Remove(item.LastIndexOf(")"));
                            value = line.Remove(0, line.IndexOf("worth") + 6);
                            value = value.Remove(value.IndexOf(" "));
                            rows = dGVGlobals.RowCount;
                            dGVGlobals.Rows.Add();

                            if (line.Contains("A record has been added to the Hall of Fame!"))
                                dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                            else
                                dGVGlobals.Rows[rows].Cells[0].Value = "(G)";
                            dGVGlobals.Rows[rows].Cells[1].Value = item;
                            dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);
                            break;

                        case "found":
                            item = line.Remove(0, line.IndexOf("a deposit ") + 11);
                            item = item.Remove(item.LastIndexOf(")"));
                            value = line.Remove(0, line.IndexOf("with a value of") + 16);
                            value = value.Remove(value.IndexOf(" "));
                            rows = dGVGlobals.RowCount;
                            dGVGlobals.Rows.Add();

                            if (line.Contains("A record has been added to the Hall of Fame!"))
                                dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                            else
                                dGVGlobals.Rows[rows].Cells[0].Value = "(G)";
                            dGVGlobals.Rows[rows].Cells[1].Value = item;
                            dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);
                            break;

                        case "is":
                            if (line.Contains("is the first colonist to reach"))
                            {
                                item = line.Remove(0, line.IndexOf("to reach tier") + 9);
                                item = item.Remove(item.IndexOf("!"));
                                value = "0";
                            }
                            else if (line.Contains("has found a rare item"))
                            {
                                item = line.Remove(0, line.IndexOf("(") + 1);
                                item = item.Remove(item.LastIndexOf(")"));
                                value = line.Remove(0, line.IndexOf("with a value of") + 16);
                                if (value.Contains("PEC!"))
                                {
                                    value = value.Remove(value.IndexOf(" "));
                                    value = Convert.ToString(Convert.ToDouble(value) * 0.01);
                                }
                                else
                                    value = value.Remove(value.IndexOf(" "));
                            }
                            else
                            {
                                item = line.Remove(0, line.IndexOf("to discover ") + 12);
                                item = item.Remove(item.IndexOf("!"));
                                value = "0";
                            }
                            rows = dGVGlobals.RowCount;
                            dGVGlobals.Rows.Add();
                            dGVGlobals.Rows[rows].Cells[0].Value = "(H)";
                            dGVGlobals.Rows[rows].Cells[1].Value = item;
                            dGVGlobals.Rows[rows].Cells[2].Value = Convert.ToDouble(value);
                            break;
                    }
                }

                GlobalsTT = 0;
                int G = 0, H = 0;
                for (int i = 0; i < dGVGlobals.RowCount; i++)
                {
                    GlobalsTT += Convert.ToDouble(dGVGlobals.Rows[i].Cells[2].Value);
                    if (Convert.ToString(dGVGlobals.Rows[i].Cells[0].Value) == "(G)")
                        G++;
                    else
                        H++;
                }
                dGVGlobalsVolume.HeaderText = "Value: " + GlobalsTT;
                dGVGlobalsObject.HeaderText = "Globals: " + G + "\r\nHofs: " + H;
            }
        }
        
        public void resetGlobals()
        {
            File.Delete(GlobalsPath);
            dGVGlobals.Rows.Clear();
            textBoxGlobals.Text = "";
            dGVGlobalsVolume.HeaderText = "Value";
            dGVGlobalsObject.HeaderText = "Objects";
        }

        private void dGV1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGV1.CurrentCell.Selected = false;
        }

        private void dGVEnh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGVEnh.CurrentCell.Selected = false;
        }

        private void dGVTiring_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGVTiring.CurrentCell.Selected = false;
        }

        private void dGVStatus_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGVStatus.CurrentCell.Selected = false;
        }

        private void dGVSkill_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGVSkill.CurrentCell.Selected = false;
        }

        private void dGVTeamMember_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGVTeamMember.CurrentCell.Selected = false;
        }

        private void dGVTeamTotal_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGVTeamTotal.CurrentCell.Selected = false;
        }

        private void dGVGlobals_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dGVGlobals.CurrentCell.Selected = false;
        }
    }
}