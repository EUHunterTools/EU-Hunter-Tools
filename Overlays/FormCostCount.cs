using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WpfApp1;

namespace WindowsFormsApp1
{

    public partial class CostCount : Form 
    {
        private FormMain f1;
#pragma warning disable CS0169 // Поле "CostCount.f3" никогда не используется.
        private FormOverlay f3;
#pragma warning restore CS0169 // Поле "CostCount.f3" никогда не используется.
        public List<Tools> Tools = new List<Tools>();
        public List<Lasers> Lasers = new List<Lasers>();
        public List<Scopes> Scopes = new List<Scopes>();
        public List<Weapons> Weapons = new List<Weapons>();
        public List<Amps> Amps = new List<Amps>();
        public List<CostCountProf> ProfList = new List<CostCountProf>();
        private string ProfPath = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsProfiles.txt";
        //public int TotalProfNum = 4;
        public int CurentProf = 1;
        public double AmmoPerShot;
        public double AttackPerMin;
        public int WeaponIndex;
        public int AmpIndex;
        public int ScopeIndex;
        public int Laser1Index;
        public int Laser2Index;
        public double ReloadNum;
        public int DMGEnhCount;
        public bool UseEFlag;
        public int ToolIndex;
        public double RelSpeed = 1;
        private bool ButtonUse = false;
        private bool FlagUsingCostSpeedBox = false;

        //Thats my shame code, if you want to change something here, better and faster will be just remade all here
        //or just PM me in discord
        public CostCount(FormMain parent)
        {
            this.f1 = parent;
            this.InitializeComponent();
#pragma warning disable CS0219 // Переменной "test" присвоено значение, но оно ни разу не использовано.
            int test = 0;
#pragma warning restore CS0219 // Переменной "test" присвоено значение, но оно ни разу не использовано.
            try ///todo try catch переделать все блять как можно так писать код пиздец
            {
                if (!File.Exists(ProfPath))
                {
                    this.ProfList.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        this.ProfList.Add(new CostCountProf(0, 0, 0, 0, 0, 0, 0, 0, 0, false, 0));                        
                    }
                }
                else
                {
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(this.ProfPath))// я знаю что плохо, тут костыль на костыле уже, еще один костыль да
                        {
                            this.ProfList = ((ProfConfig)new BinaryFormatter().Deserialize((Stream)new MemoryStream(Convert.FromBase64String(streamReader.ReadToEnd())))).ProfList;                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading: " + (object)ex);
                    }
                }
               

                using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\Weapon.csv"))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(";");
                    while (!textFieldParser.EndOfData)
                    {
                        string[] strArray2 = textFieldParser.ReadFields();
                        string[] CHI = new string[17];

                        for (int i = 0; i < 17; i++)
                        {
                            CHI[i] = strArray2[i];
                        }
                        Weapons.Add(new Weapons(CHI[0], CHI[1], CHI[2], CHI[3], CHI[4], CHI[5], CHI[6], CHI[7], CHI[8], CHI[9], CHI[10], CHI[11], CHI[12], CHI[13], CHI[14], CHI[15], CHI[16]));
                        this.comboBoxWeaponList.Items.Add(CHI[0]);
                    }

                }

                using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\Attachment.csv"))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(";");
                    while (!textFieldParser.EndOfData)
                    {
                        string[] strArray2 = textFieldParser.ReadFields();
                        string[] CHI = new string[14];

                        for (int i = 0; i < 14; i++)
                        {
                            CHI[i] = strArray2[i];
                        }
                        Amps.Add(new Amps(CHI[0], CHI[1], CHI[2], CHI[3], CHI[4], CHI[5], CHI[6], CHI[7], CHI[8], CHI[9], CHI[10], CHI[11], CHI[12], CHI[13]));
                        this.comboBoxAmpList.Items.Add(CHI[0]);
                    }
                }

                using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\Scope.csv"))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(";");
                    while (!textFieldParser.EndOfData)
                    {
                        string[] strArray2 = textFieldParser.ReadFields();
                        string[] CHI = new string[14];

                        for (int i = 0; i < 14; i++)
                        {
                            CHI[i] = strArray2[i];
                        }
                        Scopes.Add(new Scopes(CHI[0], CHI[1], CHI[2], CHI[3], CHI[4], CHI[5], CHI[6], CHI[7], CHI[8], CHI[9], CHI[10], CHI[11], CHI[12], CHI[13]));
                        this.comboBoxScope.Items.Add(CHI[0]);
                    }
                }
                using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\Sight.csv"))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(";");
                    while (!textFieldParser.EndOfData)
                    {
                        string[] strArray2 = textFieldParser.ReadFields();
                        string[] CHI = new string[14];

                        for (int i = 0; i < 14; i++)
                        {
                            CHI[i] = strArray2[i];
                        }
                        Lasers.Add(new Lasers(CHI[0], CHI[1], CHI[2], CHI[3], CHI[4], CHI[5], CHI[6], CHI[7], CHI[8], CHI[9], CHI[10], CHI[11], CHI[12], CHI[13]));
                        this.comboBoxLaser1.Items.Add(CHI[0]);
                        this.comboBoxLaser2.Items.Add(CHI[0]);
                    }

                }
                using (TextFieldParser textFieldParser = new TextFieldParser(AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\Tools.csv"))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(";");
                    while (!textFieldParser.EndOfData)
                    {
                        string[] strArray2 = textFieldParser.ReadFields();
                        string[] CHI = new string[16];


                        for (int i = 0; i < 15; i++)
                        {
                            CHI[i] = strArray2[i];
                        }
                        Tools.Add(new Tools(CHI[0], CHI[1], CHI[2], CHI[3], CHI[4], CHI[5], CHI[6], CHI[7], CHI[8], CHI[9], CHI[10], CHI[11], CHI[12], CHI[13], CHI[14], CHI[15]));
                        this.comboBoxTool.Items.Add(CHI[0]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading: " + ex);}
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ProfPath))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    MemoryStream memoryStream1 = new MemoryStream();
                    ProfConfig ProfConfigList = new ProfConfig();
                    ProfConfigList.ProfList = this.ProfList;
                    MemoryStream memoryStream2 = memoryStream1;
                    ProfConfig ProfConfigList2 = ProfConfigList;
                    binaryFormatter.Serialize((Stream)memoryStream2, (object)ProfConfigList2);
                    string base64String = Convert.ToBase64String(memoryStream1.ToArray());
                    streamWriter.Write(base64String);
                    streamWriter.Close();


                    switch (CurentProf)
                    {
                        case 1:
                            Prof1_Click(sender, e);
                            this.f1.AfterSetProf(Convert.ToInt32(ProfNum.Text));
                            break;

                        case 2:
                            Prof2_Click(sender, e);
                            this.f1.AfterSetProf(Convert.ToInt32(ProfNum.Text));
                            break;
                        case 3:
                            Prof3_Click_1(sender, e);
                            this.f1.AfterSetProf(Convert.ToInt32(ProfNum.Text));
                            break;
                        case 4:
                            Prof4_Click_1(sender, e);
                            this.f1.AfterSetProf(Convert.ToInt32(ProfNum.Text));
                            break;
                    }
                    //int num = (int)MessageBox.Show("Saved.");
                    return;
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error saving: " + (object)ex);
                return;
            }
        }
            

        private void WriteProf() ///todo переделать профайлы под любое количество оружия\инструментов, вместо кнопок список с названиями,(1: Ecotron|a101)
        {
        try {

        int i;
            switch (CurentProf)
            {
                case 1:
                    i = 0;
                        
                    WeaponIndex = ProfList[i].WEAPONINDEX;
                    AmpIndex = ProfList[i].AMPINDEX;
                    ScopeIndex = ProfList[i].SCOPEINDEX;
                    Laser1Index = ProfList[i].LASER1INDEX;
                    Laser2Index = ProfList[i].LASER2INDEX;
                    ReloadNum = ProfList[i].RELOADNUM;
                    DMGEnhCount = ProfList[i].DMGENHCOUNT;
                    UseEFlag = ProfList[i].USEEFLAG;
                    AmmoPerShot = ProfList[i].COSTUSEPROF;
                    AttackPerMin = ProfList[i].SPEEDUSEPROF;
                    textBoxCost.Text = Convert.ToString(AmmoPerShot);
                    TextBoxReload.Text = Convert.ToString(AttackPerMin);
                    FlagUsingEMode.Checked = UseEFlag;
                    break;

                case 2:
                    i = 1;
                        
                    WeaponIndex = ProfList[i].WEAPONINDEX;
                    AmpIndex = ProfList[i].AMPINDEX;
                    ScopeIndex = ProfList[i].SCOPEINDEX;
                    Laser1Index = ProfList[i].LASER1INDEX;
                    Laser2Index = ProfList[i].LASER2INDEX;
                    ReloadNum = ProfList[i].RELOADNUM;
                    DMGEnhCount = ProfList[i].DMGENHCOUNT;
                    UseEFlag = ProfList[i].USEEFLAG;
                    AmmoPerShot = ProfList[i].COSTUSEPROF;
                    AttackPerMin = ProfList[i].SPEEDUSEPROF;
                    textBoxCost.Text = Convert.ToString(AmmoPerShot);
                    TextBoxReload.Text = Convert.ToString(AttackPerMin);
                    FlagUsingEMode.Checked = UseEFlag;
                    break;

                case 3:
                    i = 2;
                        
                    WeaponIndex = ProfList[i].WEAPONINDEX;
                    AmpIndex = ProfList[i].AMPINDEX;
                    ScopeIndex = ProfList[i].SCOPEINDEX;
                    Laser1Index = ProfList[i].LASER1INDEX;
                    Laser2Index = ProfList[i].LASER2INDEX;
                    ReloadNum = ProfList[i].RELOADNUM;
                    DMGEnhCount = ProfList[i].DMGENHCOUNT;
                    UseEFlag = ProfList[i].USEEFLAG;
                    AmmoPerShot = ProfList[i].COSTUSEPROF;
                    AttackPerMin = ProfList[i].SPEEDUSEPROF;
                    textBoxCost.Text = Convert.ToString(AmmoPerShot);
                    TextBoxReload.Text = Convert.ToString(AttackPerMin);
                    FlagUsingEMode.Checked = UseEFlag;
                    break;

                case 4:
                    i = 3;
                        
                    WeaponIndex = ProfList[i].WEAPONINDEX;
                    AmpIndex = ProfList[i].AMPINDEX;
                    ScopeIndex = ProfList[i].SCOPEINDEX;
                    Laser1Index = ProfList[i].LASER1INDEX;
                    Laser2Index = ProfList[i].LASER2INDEX;
                    ReloadNum = ProfList[i].RELOADNUM;
                    DMGEnhCount = ProfList[i].DMGENHCOUNT;
                    UseEFlag = ProfList[i].USEEFLAG;
                    AmmoPerShot = ProfList[i].COSTUSEPROF;
                    AttackPerMin = ProfList[i].SPEEDUSEPROF;
                    textBoxCost.Text = Convert.ToString(AmmoPerShot);
                    TextBoxReload.Text = Convert.ToString(AttackPerMin);
                    FlagUsingEMode.Checked = UseEFlag;
                    break;

                default:
                    i = 0;
                        
                    WeaponIndex = ProfList[i].WEAPONINDEX;
                    AmpIndex = ProfList[i].AMPINDEX;
                    ScopeIndex = ProfList[i].SCOPEINDEX;
                    Laser1Index = ProfList[i].LASER1INDEX;
                    Laser2Index = ProfList[i].LASER2INDEX;
                    ReloadNum = ProfList[i].RELOADNUM;
                    DMGEnhCount = ProfList[i].DMGENHCOUNT;
                    UseEFlag = ProfList[i].USEEFLAG;
                    AmmoPerShot = ProfList[i].COSTUSEPROF;
                    AttackPerMin = ProfList[i].SPEEDUSEPROF;
                    textBoxCost.Text = Convert.ToString(AmmoPerShot);
                    TextBoxReload.Text = Convert.ToString(AttackPerMin);
                    FlagUsingEMode.Checked = UseEFlag;
                    break;
            }
                
        }
        catch(Exception ex) 
        { 
            MessageBox.Show("WriteProf():" + ex); 
        };

        }
        private void SwitchProf()
        {
            try
            {
                int i;
                switch (CurentProf)
                {
                    case 1:
                        i = 0;

                        ProfList[i].WEAPONINDEX = WeaponIndex;
                        ProfList[i].AMPINDEX = AmpIndex;
                        ProfList[i].SCOPEINDEX = ScopeIndex;
                        ProfList[i].LASER1INDEX = Laser1Index;
                        ProfList[i].LASER2INDEX = Laser2Index;
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].DMGENHCOUNT = DMGEnhCount;
                        ProfList[i].USEEFLAG = UseEFlag;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;
                        textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        TextBoxReload.Text = Convert.ToString(AttackPerMin);
                        FlagUsingEMode.Checked = UseEFlag;
                        break;

                    case 2:
                        i = 1;
                        
                        ProfList[i].WEAPONINDEX = WeaponIndex;
                        ProfList[i].AMPINDEX = AmpIndex;
                        ProfList[i].SCOPEINDEX = ScopeIndex;
                        ProfList[i].LASER1INDEX = Laser1Index;
                        ProfList[i].LASER2INDEX = Laser2Index;
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].DMGENHCOUNT = DMGEnhCount;
                        ProfList[i].USEEFLAG = UseEFlag;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;
                        textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        TextBoxReload.Text = Convert.ToString(AttackPerMin);
                        FlagUsingEMode.Checked = UseEFlag;
                        break;

                    case 3:
                        i = 2;
                        
                        ProfList[i].WEAPONINDEX = WeaponIndex;
                        ProfList[i].AMPINDEX = AmpIndex;
                        ProfList[i].SCOPEINDEX = ScopeIndex;
                        ProfList[i].LASER1INDEX = Laser1Index;
                        ProfList[i].LASER2INDEX = Laser2Index;
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].DMGENHCOUNT = DMGEnhCount;
                        ProfList[i].USEEFLAG = UseEFlag;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;
                        textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        TextBoxReload.Text = Convert.ToString(AttackPerMin);
                        FlagUsingEMode.Checked = UseEFlag;
                        break;

                    case 4:
                        i = 3;
                        
                        ProfList[i].WEAPONINDEX = WeaponIndex;
                        ProfList[i].AMPINDEX = AmpIndex;
                        ProfList[i].SCOPEINDEX = ScopeIndex;
                        ProfList[i].LASER1INDEX = Laser1Index;
                        ProfList[i].LASER2INDEX = Laser2Index;
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].DMGENHCOUNT = DMGEnhCount;
                        ProfList[i].USEEFLAG = UseEFlag;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;
                        textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        TextBoxReload.Text = Convert.ToString(AttackPerMin);
                        FlagUsingEMode.Checked = UseEFlag;
                        break;

                        //default:
                        //    CostUseProf1 = AmmoPerShot;
                        //    SpeedUseProf1 = AttackPerMin;
                        //    UseEflag[0] = FlagUsingEMode.Checked;
                        //    textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        //    TextBoxReload.Text = Convert.ToString(AttackPerMin);
                        //    break;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("SwitchProf():" + ex); };
        }
       
        
        //Changing profile
        public void ShowingItemsOnIndex()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                int ProfNum = CurentProf - 1;

                comboBoxWeaponList.SelectedIndex = ProfList[ProfNum].WEAPONINDEX;
                comboBoxDMGList.SelectedIndex = ProfList[ProfNum].DMGENHCOUNT;
                comboBoxAmpList.SelectedIndex = ProfList[ProfNum].AMPINDEX;
                comboBoxLaser1.SelectedIndex = ProfList[ProfNum].LASER1INDEX;
                comboBoxLaser2.SelectedIndex = ProfList[ProfNum].LASER2INDEX;
                comboBoxScope.SelectedIndex = ProfList[ProfNum].SCOPEINDEX;
                comboBoxTool.SelectedIndex = ProfList[ProfNum].TOOLINDEX;
                ReloadSpeed.Text = Convert.ToString(ProfList[ProfNum].RELOADNUM);
                textBoxCost.Text = Convert.ToString(AmmoPerShot);
                TextBoxReload.Text = Convert.ToString(AttackPerMin);

            }
            catch(Exception ex)
            {
                MessageBox.Show("ShowingItemsOnIndex():" + ex);
            }

        }

        public void CheckCost(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            WriteProf();


            if (comboBoxWeaponList.SelectedIndex < 0)
                return;
           
            if(!FlagUsingCostSpeedBox)
            if (comboBoxWeaponList.SelectedIndex >= 0)
            {

                    if (!(ReloadSpeed.Text == "")) //additional reload speed                    
                        if (Convert.ToInt32(ReloadSpeed.Text) >= 0)
                        {
                            if (!ButtonUse)
                            {
                                RelSpeed = 1 + (Convert.ToInt32(ReloadSpeed.Text) * 0.01);
                                ReloadNum = Convert.ToInt32(ReloadSpeed.Text);
                            }
                        }


                Weapons weapons = Weapons[comboBoxWeaponList.SelectedIndex]; //Decay of weapon
                    WeaponIndex = comboBoxWeaponList.SelectedIndex;
                    if (!ButtonUse)
                        AmmoPerShot = Convert.ToDouble(weapons.COST);

                    if (comboBoxDMGList.SelectedIndex >= 0)
                    {
                        if (!ButtonUse)
                        {
                            AmmoPerShot = AmmoPerShot + Convert.ToDouble(weapons.COST) * (comboBoxDMGList.SelectedIndex * 0.1);
                            DMGEnhCount = comboBoxDMGList.SelectedIndex;
                        }
                    }

                    if (!ButtonUse)
                    {
                        textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        AttackPerMin = Convert.ToDouble(weapons.ATTACKS) * RelSpeed;
                        TextBoxReload.Text = Convert.ToString(AttackPerMin);
                    }


                if (comboBoxAmpList.SelectedIndex >= 0)
                {
                    Amps amps = Amps[comboBoxAmpList.SelectedIndex];
                        AmpIndex = comboBoxAmpList.SelectedIndex;
                        if (!ButtonUse)
                        {
                            AmmoPerShot = AmmoPerShot + Convert.ToDouble(amps.COST);
                            textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        }
                }

                if (comboBoxLaser1.SelectedIndex >= 0)
                {
                    Lasers amps = Lasers[comboBoxLaser1.SelectedIndex];
                        Laser1Index = comboBoxLaser1.SelectedIndex;
                        if (!ButtonUse)
                        {
                            AmmoPerShot = AmmoPerShot + Convert.ToDouble(amps.COST);
                            textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        }
                }

                if (comboBoxLaser2.SelectedIndex >= 0)
                {
                    Lasers amps = Lasers[comboBoxLaser2.SelectedIndex];
                        Laser2Index = comboBoxLaser2.SelectedIndex;
                        if (!ButtonUse)
                        {
                            AmmoPerShot = AmmoPerShot + Convert.ToDouble(amps.COST);
                            textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        }
                }

                if (comboBoxScope.SelectedIndex >= 0)
                {
                    Scopes amps = Scopes[comboBoxScope.SelectedIndex];
                        ScopeIndex = comboBoxScope.SelectedIndex;
                        if (!ButtonUse)
                        {
                            AmmoPerShot = AmmoPerShot + Convert.ToDouble(amps.COST);
                            textBoxCost.Text = Convert.ToString(AmmoPerShot);
                        }
                }
                SwitchProf();

            }
                        
            //if (comboBoxWeaponList.SelectedIndex == 0)
            //{
            //    AmmoPerShot = 0;
            //    this.textBoxCost.Text = "0";
            //    RelSpeed = 0;
            //    this.ReloadSpeed.Text = "0";
            //}
        }


        private void comboBoxDMGList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCost(sender, e);
        }

        public void Prof1_Click(object sender, EventArgs e)
        {
            try
            {
                this.f1.CProf = 0;
                ClearComboBoxes();
                ButtonUse = true;
                CurentProf = 1;
                ProfNum.Text = Convert.ToString(CurentProf);
                CheckCost(sender, e);

                this.f1.ammoPerShot = ProfList[0].COSTUSEPROF * 100;
                this.f1.attacksPerMinute = ProfList[0].SPEEDUSEPROF;
                this.f1.ammoBurnTxt.Text = Convert.ToString(this.f1.ammoPerShot / 100);
                this.f1.textBox1.Text = Convert.ToString(this.f1.attacksPerMinute);
                if (ProfList[0].USEEFLAG)
                {
                    this.f1.ProfTextBox.Text = "1E";
                }
                else
                {
                    this.f1.ProfTextBox.Text = "1";
                }
                ShowingItemsOnIndex();
                ButtonUse = false;
                this.f1.AfterSetProf(Convert.ToInt32(CurentProf));
            }
            catch(Exception ex)
            { MessageBox.Show("Prof1_Click():" + ex); }
        }

        private void Prof2_Click(object sender, EventArgs e)
        {
            try
            {
                this.f1.CProf = 0;
                ClearComboBoxes();
                ButtonUse = true;
                CurentProf = 2;
                ProfNum.Text = Convert.ToString(CurentProf);
                CheckCost(sender, e);

                this.f1.ammoPerShot = ProfList[1].COSTUSEPROF * 100;
                this.f1.attacksPerMinute = ProfList[1].SPEEDUSEPROF;
                this.f1.ammoBurnTxt.Text = Convert.ToString(this.f1.ammoPerShot / 100);
                this.f1.textBox1.Text = Convert.ToString(this.f1.attacksPerMinute);
                if (ProfList[1].USEEFLAG)
                {
                    this.f1.ProfTextBox.Text = "2E";
                }
                else
                {
                    this.f1.ProfTextBox.Text = "2";
                }
                ShowingItemsOnIndex();
                ButtonUse = false;
                this.f1.AfterSetProf(Convert.ToInt32(CurentProf));
            }
            catch (Exception ex)
            { MessageBox.Show("Prof2_Click():" + ex); }
        }
        //private void Prof3_Click(object sender, EventArgs e)
        //{
        //    CurentProf = 3;
        //    ProfNum.Text = Convert.ToString(CurentProf);
        //}
        //private void Prof4_Click(object sender, EventArgs e)
        //{
        //    CurentProf = 4;
        //    ProfNum.Text = Convert.ToString(CurentProf);
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)//доп эффект перезарядки%
        {
            try
            { 
                if (TextBoxReload.Text != "")
                {
                    if (TextBoxReload.Text.IndexOf(".") == (TextBoxReload.Text.Length - 1))
                        return;
                    this.f1.CProf = 0;
                    double result;
                    double.TryParse(TextBoxReload.Text, out result);
                    AttackPerMin = result;
                    FlagUsingCostSpeedBox = true;
                    SwitchProf();
                    CheckCost(sender, e);
                    FlagUsingCostSpeedBox = false;
                    if (!ButtonUse)
                        this.f1.AfterSetProf(Convert.ToInt32(CurentProf));
                    this.f1.CalculateProfit();

                }

            }
            catch (Exception ex)            
            { MessageBox.Show("textBox2_TextChanged():" + ex); }
                

        }

        private void comboBoxLaser1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCost(sender, e);
        }

        private void comboBoxLaser2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCost(sender, e);
        }

        private void comboBoxScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCost(sender, e);
        }

        private void ReloadSpeed_TextChanged(object sender, EventArgs e)
        {
           CheckCost(sender, e);
        }

        private void comboBoxWeaponList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CheckCost(sender, e);
        }

        private void comboBoxAmpList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CheckCost(sender, e);
        }

        private void comboBoxTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTool.SelectedIndex >= 0)
            {                
                Tools tool = Tools[comboBoxTool.SelectedIndex];
                ToolIndex = comboBoxTool.SelectedIndex;
                if (!ButtonUse)
                {
                    AmmoPerShot = Convert.ToDouble(tool.COST);
                    textBoxCost.Text = Convert.ToString(AmmoPerShot);
                    AttackPerMin = 1;
                    TextBoxReload.Text = Convert.ToString(AttackPerMin);
                }

                int i;
                switch (CurentProf)
                {
                    case 1:
                        i = 0;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;                        
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].TOOLINDEX = ToolIndex;                       
                        //FlagUsingEMode.Checked = true;
                        ProfList[i].USEEFLAG = FlagUsingEMode.Checked;
                        break;

                    case 2:
                        i = 1;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].TOOLINDEX = ToolIndex;
                        //FlagUsingEMode.Checked = true;
                        ProfList[i].USEEFLAG = FlagUsingEMode.Checked;
                        break;

                    case 3:
                        i = 2;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].TOOLINDEX = ToolIndex;
                        //FlagUsingEMode.Checked = true;
                        ProfList[i].USEEFLAG = FlagUsingEMode.Checked;
                        break;

                    case 4:
                        i = 3;
                        ProfList[i].COSTUSEPROF = AmmoPerShot;
                        ProfList[i].SPEEDUSEPROF = AttackPerMin;
                        ProfList[i].RELOADNUM = ReloadNum;
                        ProfList[i].TOOLINDEX = ToolIndex;
                        //FlagUsingEMode.Checked = true;
                        ProfList[i].USEEFLAG = FlagUsingEMode.Checked;
                        break;

                    //default:
                    //    i = 0;
                    //    ProfList[i].COSTUSEPROF = AmmoPerShot;
                    //    ProfList[i].SPEEDUSEPROF = AttackPerMin;
                    //    ProfList[i].WEAPONINDEX = WeaponIndex;
                    //    ProfList[i].AMPINDEX = AmpIndex;
                    //    ProfList[i].SCOPEINDEX = ScopeIndex;
                    //    ProfList[i].LASER1INDEX = Laser1Index;
                    //    ProfList[i].LASER2INDEX = Laser2Index;
                    //    ProfList[i].RELOADNUM = ReloadNum;
                    //    ProfList[i].DMGENHCOUNT = DMGEnhCount;
                    //    FlagUsingEMode.Checked = true;
                    //    ProfList[i].USEEFLAG = FlagUsingEMode.Checked;
                    //    break;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Prof3_Click_1(object sender, EventArgs e)
        {
            this.f1.CProf = 0;
            ClearComboBoxes();
            ButtonUse = true;
            CurentProf = 3;
            ProfNum.Text = Convert.ToString(CurentProf);
            CheckCost(sender, e);

            this.f1.ammoPerShot = ProfList[2].COSTUSEPROF * 100;
            this.f1.attacksPerMinute = ProfList[2].SPEEDUSEPROF;
            this.f1.ammoBurnTxt.Text = Convert.ToString(this.f1.ammoPerShot / 100);
            this.f1.textBox1.Text = Convert.ToString(this.f1.attacksPerMinute);
            if (ProfList[2].USEEFLAG)
            {
                this.f1.ProfTextBox.Text = "3E";
            }
            else
            {
                this.f1.ProfTextBox.Text = "3";
            }
            ShowingItemsOnIndex();
            ButtonUse = false;
            this.f1.AfterSetProf(Convert.ToInt32(CurentProf));

        }

        private void Prof4_Click_1(object sender, EventArgs e)
        {
            this.f1.CProf = 0;
            ClearComboBoxes();
            ButtonUse = true;
            CurentProf = 4;
            ProfNum.Text = Convert.ToString(CurentProf);
            CheckCost(sender, e);

            this.f1.ammoPerShot = ProfList[3].COSTUSEPROF * 100;
            this.f1.attacksPerMinute = ProfList[3].SPEEDUSEPROF;
            this.f1.ammoBurnTxt.Text = Convert.ToString(this.f1.ammoPerShot / 100);
            this.f1.textBox1.Text = Convert.ToString(this.f1.attacksPerMinute);
            if (ProfList[3].USEEFLAG)
            {
                this.f1.ProfTextBox.Text = "4E";
            }
            else
            {
                this.f1.ProfTextBox.Text = "4";
            }
            ShowingItemsOnIndex();
            ButtonUse = false;
            this.f1.AfterSetProf(Convert.ToInt32(CurentProf));
        }

        private void FlagUsingEMode_CheckedChanged(object sender, EventArgs e)
        {
            switch (CurentProf)
            {
                case 1:
                    ProfList[0].USEEFLAG = FlagUsingEMode.Checked;
                    WriteProf();
                    break;

                case 2:
                    ProfList[1].USEEFLAG = FlagUsingEMode.Checked;
                    WriteProf();
                    break;

                case 3:
                    ProfList[2].USEEFLAG = FlagUsingEMode.Checked;
                    WriteProf();
                    break;

                case 4:
                    ProfList[3].USEEFLAG = FlagUsingEMode.Checked;
                    WriteProf();
                    break;

                    //default:
                    //    UseEflag[0] = FlagUsingEMode.Checked;
                    //    break;
            }
        }

        public void ClearComboBoxes()
        {

            comboBoxWeaponList.SelectedIndex = -1;
            comboBoxAmpList.SelectedIndex = -1;
            ReloadSpeed.Text = "0";
            comboBoxScope.SelectedIndex = -1;
            comboBoxLaser1.SelectedIndex = -1;
            comboBoxLaser2.SelectedIndex = -1;
            comboBoxDMGList.SelectedIndex = 0;
            //TextBoxReload.Text = "0";
            comboBoxTool.SelectedIndex = -1;
        
        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCost.Text != "")
                {
                    this.f1.CProf = 0;
                    if (textBoxCost.Text.IndexOf(".") == (textBoxCost.Text.Length - 1))
                        return;
                    double result;
                    double.TryParse(textBoxCost.Text, out result);
                    AmmoPerShot = result;
                    FlagUsingCostSpeedBox = true;
                    SwitchProf();
                    CheckCost(sender, e);
                    FlagUsingCostSpeedBox = false;
                    if(!ButtonUse)
                        this.f1.AfterSetProf(Convert.ToInt32(CurentProf));
                    this.f1.CalculateProfit();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("textBoxCost_TextChanged:" + ex);
                AmmoPerShot = 0;
                textBoxCost.Text = "";
            }
        }            
        
        private void CostCount_Load(object sender, EventArgs e)
        {
            //Prof1_Click(sender, e);
        }

        private void ReloadSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
           
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
