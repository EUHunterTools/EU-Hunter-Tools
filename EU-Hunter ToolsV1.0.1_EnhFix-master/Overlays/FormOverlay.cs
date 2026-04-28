using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WpfApp1;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class FormOverlay : Form
    {
        private FormMain f1;

        private Settings STT;
        public const int WM_NCLBUTTONDOWN = 161;
        public const int HT_CAPTION = 2;
        public bool FlagDarkMode, FlagHalfMode = false;
        public int CaseBigMode = 1;
        public int CaseBigX;
        public int CaseBigY;
        public int OverlayLocX;
        public int OverlayLocY;
        public int ResoulutionX;


        public FormOverlay(FormMain parent)
        {
            this.InitializeComponent();
            this.f1 = parent;
            this.STT = new Settings(this);

            this.ControlBox = false;
            this.Text = string.Empty;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
        }        

        //X button
        public void button1_Click(object sender, EventArgs e)
        {            
            this.f1.isCompact = false;
            this.f1.CalculateProfit();
            this.f1.Show();
            this.Hide();
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            FormOverlay.ReleaseCapture();
            FormOverlay.SendMessage(this.Handle, 161, 2, 0);
        }        

        private void lootValueTxt2_Click(object sender, EventArgs e)
        {

        }

        private void FormOverlay_Move(object sender, EventArgs e)
        {
            OverlayLocY = this.Top;
            OverlayLocX = this.Left;
        }

        private void OverlayStartStop_Click(object sender, EventArgs e)
        {
            this.f1.startButton_Click_1(sender, e);

            if (this.f1._isRunning)
                StartStop.BackColor = Color.Green;
            else
                StartStop.BackColor = Color.Red;

        }

        //startStop back color set
        private void FormOverlay_Activated(object sender, EventArgs e)
        {

            if (!this.f1._isRunning)
                StartStop.BackColor = Color.Red;
            else
                StartStop.BackColor = Color.Green;

        }


        //Halfmode button
        private void button2_Click(object sender, EventArgs e)
        {
            if(FlagHalfMode)
            {
                this.MaximumSize = new System.Drawing.Size(180, ResoulutionX);
                this.MinimumSize = new System.Drawing.Size(180, ResoulutionX);
                this.ClientSize = new System.Drawing.Size(180, ResoulutionX);
                this.HalfMode.Size = new System.Drawing.Size(25, 33);
                this.button1.Size = new System.Drawing.Size(25, 25);
                this.button1.Location = new System.Drawing.Point(137, 6);
                FlagHalfMode = false;
                this.HalfMode.Location = new System.Drawing.Point(137, 62);
                this.StartStop.Location = new System.Drawing.Point(137, 34);
                this.StartStop.Size = new System.Drawing.Size(25, 25);

            }
            else
            {
                this.MaximumSize = new System.Drawing.Size(180, 84);
                this.MinimumSize = new System.Drawing.Size(180, 84);
                this.ClientSize = new System.Drawing.Size(180, 84);
                this.button1.Size = new System.Drawing.Size(25, 22);
                this.button1.Location = new System.Drawing.Point(137, 1);
                this.StartStop.Location = new System.Drawing.Point(137, 22);
                this.StartStop.Size = new System.Drawing.Size(25, 15);
                this.HalfMode.Location = new System.Drawing.Point(137, 34);
                FlagHalfMode = true;
            }            
        }

        private void timerScrolling_Tick(object sender, EventArgs e)
        {
            Scrolling();
        }

        //Scrolling current gears in bottom of overlay
        private void Scrolling()
        {

            if (ProfTextBox.Text.Length > 24)
            {
                string PTBHelper = ProfTextBox.Text.Substring(1) + ProfTextBox.Text.Substring(0, 1);                
                ProfTextBox.Text = PTBHelper;
            }
        }

        //Show or hide gear info in overlay
        public void checkGear()
        {
            if (this.f1.FormOverlayGealLineHelper)
            {
                ResoulutionX = 180;
            }
            else
                ResoulutionX = 157;
        }

        private void FormOverlay_Load(object sender, EventArgs e)
        {

        }

        //Speed of scroling gear in overlay
        public void checkScroll(int Speed)
        {
            if (Speed == 0)
            {
                timerScrolling.Stop();
                return;
            }
            timerScrolling.Stop();
            timerScrolling.Enabled = true;
            timerScrolling.Interval = Convert.ToInt16(Math.Round(200 / Convert.ToDouble(Speed), 0));
            timerScrolling.Enabled = true;
            timerScrolling.Start();
        }
        
    }
}
