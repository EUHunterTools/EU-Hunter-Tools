using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WpfApp1;

namespace WindowsFormsApp1
{
    public partial class FormInput : Form
    {
        private double repairsValue;
        public string mode = "";
       

        public FormInput(FormMain parent)
        {
            this.InitializeComponent();
            this.f1 = parent;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
        }

        //Checking imputing value
        private void inputValueText_TextChanged(object sender, EventArgs e)
        {
            double result;
            double.TryParse(this.inputValueText.Text, out result);
            if (result < -99999999.0 && result > 99999999.0 && this.inputValueText.Text != "")
            {
                this.inputValueText.Text = "";
                this.repairsValue = 0;
            }
            else
                this.repairsValue = result;
        }

        //Checking imputing symbols
        private void inputValueText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (char.IsDigit(keyChar) || keyChar == '\b' || keyChar == '.' || keyChar == '-')
                return;
            e.Handled = true;
        }

        //Changing values in dGV and balanceGrid
        private void inputAcceptButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.mode);

            //Extra expenses
            if (this.mode == "balance")
            {

                this.f1.repairs = this.f1.repairs + this.repairsValue;
                this.f1.balanceGrid.Rows[0].Cells[1].Value = (object)(this.f1.repairs.ToString() + " PED");
            }            
            else if (this.mode == "itemsMU")//dGV1 tt value
            {
                foreach (Items listaItem in this.f1.listaItems)
                {
                    if (listaItem.NOMBRE == this.f1.dGV1.Rows[this.celda.RowIndex].Cells[this.celda.ColumnIndex - 2].Value.ToString())
                    {
                        listaItem.PRECIO = this.repairsValue;
                        this.f1.dGV1.Rows[this.celda.RowIndex].Cells[this.celda.ColumnIndex].Value = (object)this.repairsValue;
                    }
                }
            }
            else if (this.mode == "itemsTeam")//dGVTeamMember tt value
            {
                if (this.celda.RowIndex != -1)
                {
                    if (!inputValueText.Text.Equals(""))
                    {
                        this.f1.dGVTeamMember.Rows[this.celda.RowIndex].Cells[2].Value = repairsValue;
                        bool flagRN = false;
                        string playerLine = this.f1.FullTeamInfo.Substring(this.f1.FullTeamInfo.IndexOf(Convert.ToString(this.f1.cB_SelectTeamMember.SelectedItem)));
                        playerLine = playerLine.Substring(0, playerLine.IndexOf(";") + 1);
                        if (this.f1.FullTeamInfo.Contains(playerLine + "\r\n"))
                        {
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo.Replace(playerLine + "\r\n", "");
                        }
                        else
                        {
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo.Replace(playerLine, "");
                            flagRN = true;
                        }

                        string helperName = Convert.ToString(this.f1.dGVTeamMember.Rows[this.celda.RowIndex].Cells[1].Value);
                        string helperNewLine = playerLine.Remove(0, playerLine.IndexOf(helperName));

                        if (helperNewLine.Contains(","))
                            helperNewLine = helperNewLine.Remove(helperNewLine.IndexOf(","));
                        else
                            helperNewLine = helperNewLine.Remove(helperNewLine.IndexOf(";"));



                        string helperCopy = helperNewLine;
                        if (helperNewLine.Contains("*"))
                            helperNewLine = helperNewLine.Remove(helperNewLine.IndexOf('*'));
                        helperNewLine = helperNewLine + "*" + this.f1.dGVTeamMember.Rows[this.celda.RowIndex].Cells[2].Value;
                        playerLine = playerLine.Replace(helperCopy, helperNewLine);

                        if (flagRN)
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo + playerLine;
                        else
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo + "\r\n" + playerLine;
                    }
                    else
                    {
                        bool flagRN = false;
                        string playerLine = this.f1.FullTeamInfo.Substring(this.f1.FullTeamInfo.IndexOf(Convert.ToString(this.f1.cB_SelectTeamMember.SelectedItem)));
                        playerLine = playerLine.Substring(0, playerLine.IndexOf(";") + 1);

                        if (this.f1.FullTeamInfo.Contains(playerLine + "\r\n"))
                        {
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo.Replace(playerLine + "\r\n", "");
                        }
                        else
                        {
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo.Replace(playerLine, "");
                            flagRN = true;
                        }

                        string helperName = Convert.ToString(this.f1.dGVTeamMember.Rows[this.celda.RowIndex].Cells[1].Value);
                        string helperNewLine = playerLine.Remove(0, playerLine.IndexOf(helperName));

                        if (helperNewLine.Contains(","))
                            helperNewLine = helperNewLine.Remove(helperNewLine.IndexOf(","));
                        else
                            helperNewLine = helperNewLine.Remove(helperNewLine.IndexOf(";"));



                        string helperCopy = helperNewLine;
                        if (helperNewLine.Contains("*"))
                            helperNewLine = helperNewLine.Remove(helperNewLine.IndexOf('*'));
                        playerLine = playerLine.Replace(helperCopy, helperNewLine);

                        if (flagRN)
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo + playerLine;
                        else
                            this.f1.FullTeamInfo = this.f1.FullTeamInfo + "\r\n" + playerLine;
                    }
                }
                else
                {
                    MessageBox.Show("Dont loot items while change values window active!");
                }
            }

            else if (this.mode == "mu") //dGV1 MU
            {
                foreach (Items listaItem in this.f1.listaItems)
                {
                    if (listaItem.NOMBRE == this.f1.dGV1.Rows[this.celda.RowIndex].Cells[1].Value.ToString())
                    {
                        if (listaItem.PRECIO == 0)
                            listaItem.PRECIO = Convert.ToDouble(this.f1.dGV1.Rows[this.celda.RowIndex].Cells[2].Value);
                        listaItem.CANTIDAD = Convert.ToDouble(this.f1.dGV1.Rows[this.celda.RowIndex].Cells[0].Value);
                        listaItem.MU = this.repairsValue;
                        this.f1.dGV1.Rows[this.celda.RowIndex].Cells[5].Value = (object)this.repairsValue;
                        this.f1.dGV1.Rows[this.celda.RowIndex].Cells[3].Value = (object)(listaItem.CANTIDAD * listaItem.PRECIO * (listaItem.MU / 100.0));
                    }
                }
            }
            else if (this.mode == "muEnh") //Enhancers MU
            {             
                        double CANTIDAD = Convert.ToDouble(this.f1.dGVEnh.Rows[this.celda.RowIndex].Cells[2].Value);
                        double MU = this.repairsValue;
                        this.f1.dGVEnh.Rows[this.celda.RowIndex].Cells[4].Value = (object)this.repairsValue;
                        this.f1.dGVEnh.Rows[this.celda.RowIndex].Cells[3].Value = (object)(CANTIDAD * (MU / 100.0) - CANTIDAD);
           
            }
            this.f1.CalculateProfit();
            this.Hide();
        }

        private void inputInformationText_Click(object sender, EventArgs e)
        {

        }
    }
}
