//better check how works Microsoft.Office.Interop.Excel to get more info

using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace ExcelWork
{
    
    class ExcelWork : IDisposable
    {
        private Application _excel;
        private Workbook _workbook;
        private string _filePath;
        int NextEmpty = 3;

        public ExcelWork()
        {
            _excel = new Excel.Application();
        }

        public void Dispose()
        {
            try
            {
                //if (!string.IsNullOrEmpty(_filePath))
                //{
                //    _workbook.SaveAs(_filePath);
                //    _filePath = null;
                //}
                //else
                //{
                //    _workbook.Save();
                //}
               // _workbook.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        internal bool Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    _workbook = _excel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    _workbook.SaveAs(filePath);
                    _filePath = filePath;
                    _workbook.Close();
                    _workbook = _excel.Workbooks.Open(filePath);
                    ((Excel.Worksheet)_excel.ActiveSheet).Cells[6, "A"] = (string)"Date";
                    ((Excel.Worksheet)_excel.ActiveSheet).Cells[6, "B"] = (string)"AmmoCost";
                    ((Excel.Worksheet)_excel.ActiveSheet).Cells[6, "C"] = (string)"LootValue";
                    ((Excel.Worksheet)_excel.ActiveSheet).Cells[6, "D"] = (string)"TotalPED";
                    ((Excel.Worksheet)_excel.ActiveSheet).Cells[6, "E"] = (string)"TT%";
                    ((Excel.Worksheet)_excel.ActiveSheet).Cells[6, "F"] = (string)"OnlyMU";
                    ((Excel.Worksheet)_excel.ActiveSheet).Cells[6, "G"] = (string)"TT%+MU";
                    _workbook.Save();
                    int num = (int)System.Windows.Forms.MessageBox.Show("Created new file!");

                }

                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                int num = (int)System.Windows.Forms.MessageBox.Show("Created new file and saved.");
            }
            else
            {
               _workbook.Save();
                int num = (int)System.Windows.Forms.MessageBox.Show("Saved.");
            }
        }

        internal bool Set(string column, int row, object data)
        {
            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;

                _workbook.Save();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }
        

        internal bool SetHuntData(object AmmoCost, object LootValue, object TotalPed, object TT, object MUonly, object TTMU)
        {
            try
            {

                NextEmpty = 7;

                while (((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "A"].Value != null)
                {
                     NextEmpty++;
                }
                
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "A"] = DateTime.Today;
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "B"] = AmmoCost;
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "C"] = LootValue;
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "D"] = TotalPed;
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "E"] = TT;
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "F"] = MUonly;
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[NextEmpty, "G"] = TTMU;
                _workbook.Save();
                int num = (int)System.Windows.Forms.MessageBox.Show("Saved.");
                return true;
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

     

        internal void Close()// лучше в функции делайть сейв т.к. иногда не работает 
        {
            _workbook.Close();
            //if (!string.IsNullOrEmpty(_filePath))
            //{
            //    _workbook.SaveAs(_filePath);
            //    _filePath = null;
            //    _workbook.Close();
            //}
            //else
            //{
            //    _workbook.Save();
            //    _workbook.Close();
            //}
        }
    }
}
