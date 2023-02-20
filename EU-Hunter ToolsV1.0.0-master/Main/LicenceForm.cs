//unused

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Management;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace WpfApp1
//{
//    public partial class LicenceForm : Form
//    {
//        private string ProcID;        
//        public int DateCount;
//        private FormMain FM;
//        public string KeyTXT;
//        //public List<Key> key = new List<Key>();
//        private string KeyPath = AppDomain.CurrentDomain.BaseDirectory + "\\Addons\\EUHunterToolsKey.txt";
//        public LicenceForm()
//        {

//            try
//            {
//                InitializeComponent();                
//                ObjectQuery winQuery = new ObjectQuery("SELECT * FROM CIM_Processor");
//                ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);
//                bool FlagIDCapture = false;
//                string paramName = "";
//                foreach (ManagementObject item in searcher.Get())
//                {

//                    foreach (PropertyData pr in item.Properties)
//                    {
//                        paramName = pr.Name;
//                        Console.Write(paramName + " ");
//                        Console.WriteLine(item[paramName]);

//                        if (pr.Name == "Name")
//                        {
//                            string enc = string.Join("", Encoding.ASCII.GetBytes(Convert.ToString(pr.Value)).Select(x => $"{x:000}"));
//                            //byte[] ByteHelp = Convert.FromBase64String(Convert.ToString(pr.Value)); 
//                            ProcID = enc.Substring(enc.Length - 20);
//                            textBoxID.Text = ProcID;
//                            FlagIDCapture = true;
//                        }


//                    }
                    
//                }
               
//                if (FlagIDCapture == false)
//                    MessageBox.Show("Some problems with idefing your CPU id, contact K0lb for help",
//            "ERROR", MessageBoxButtons.OK);

                

//                //if (File.Exists(KeyPath))
//                //{
//                //    using (StreamReader streamReader = new StreamReader(this.KeyPath))
//                //    {
//                //        KeyTXT = streamReader.ReadLine();
//                //        streamReader.Close();
//                //        bool FlagCheck = CheckUse();                        
//                //    }
//                //}

//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Critical error! Ask K0lb why his fk program not working :^( \nLicenceForm(): Some problems with idefing your CPU id, contact K0lb for help" + ex, "Warning!", MessageBoxButtons.OK);// Я не ебу почему у Серга не работает блять, кривуб блять винду по ходу ему не стоило скачивать с левых сайтов
//                Dispose();
//                return;
//            }
           
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {


//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {          

//                KeyTXT = textBoxKey.Text;
//                using (StreamWriter streamWriter = new StreamWriter(this.KeyPath))
//                {
//                    streamWriter.WriteLine(textBoxKey.Text);
//                    streamWriter.Close();
//                }          

//           CheckUse();
            
//        }

        

//        public void CheckUse()
//        {
//            try
//            {

//                if (File.Exists(KeyPath))
//                {
//                    using (StreamReader streamReader = new StreamReader(this.KeyPath))
//                    {
//                        KeyTXT = streamReader.ReadLine();
//                        streamReader.Close();
//                        this.Hide();
//                    }
//                }
//                else
//                {
//                    this.Opacity = 100;
//                    return;
//                }

//                ProcID = textBoxID.Text;                
//                SKGL.Validate validate = new SKGL.Validate();
//                validate.secretPhase = 123 + ProcID;
//                validate.Key = KeyTXT;
//                if (validate.DaysLeft > 0)
//                {
//                    this.Hide();
//                    if (validate.DaysLeft < 3)
//                        MessageBox.Show("Days left:" + validate.DaysLeft, "Warning!", MessageBoxButtons.OK);
//                    this.FM = new FormMain(this);
//                    FM.ShowDialog();
//                    this.Dispose();
//                    return;
//                }
//                else
//                {
//                    this.Show();
//                    this.Opacity = 100;
//                    return;
//                }
//            }
//            catch(Exception ex)
//            {
//                MessageBox.Show("Critical error! Ask K0lb why his fk program not working and he didnt put try{}catch{}thing :^(  \nCheckUse(): " + ex, "Warning!", MessageBoxButtons.OK);
//                Dispose();
//                return;
//            }

//        }

//        private void LicenceForm_Shown(object sender, EventArgs e)
//        {
//            if (!File.Exists(KeyPath))
//                this.Opacity = 100;
            
//                CheckUse();
            
//        }

//        private void LicenceForm_Load(object sender, EventArgs e)
//        {
          
//        }
//    }
//    //public class Key
//    //{
//    //    public int KEY { get; set; }

//    //    public Key(int _key)
//    //    {
//    //        KEY = _key;
//    //    }

//    //}
//}
