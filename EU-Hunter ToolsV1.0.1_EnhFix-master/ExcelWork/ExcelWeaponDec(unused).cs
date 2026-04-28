//using Microsoft.Office.Interop.Excel; // ничего не работает, не хочет работать с excel фаилом зараза
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Excel = Microsoft.Office.Interop.Excel;

//namespace ExcelWork
//{
//    class ExcelWeaponDec : IDisposable
//    {
//        private Application _excel;
//        private Workbook _workbook;
//        private string _filePath;
//        string[] AtachpList;

//        public ExcelWeaponDec()
//        {
//            _excel = new Excel.Application();
//        }

//        //internal List<string> OpenWeaponList(string filePathWeap)
//        //{
//        //    try
//        //    {
//        //        if (File.Exists(filePathWeap))
//        //        {
//        //            List<string> WeapList = new List<string>();
//        //            _workbook = _excel.Workbooks.Open(filePathWeap);
//        //            //WeapList[1] = ((Excel.Worksheet)_excel.ActiveSheet).Cells[1, "A"];
//        //            for (int i = 1; ((Excel.Worksheet)_excel.ActiveSheet).Cells[i, "A"].Value != null; i++)
//        //            {
//        //                WeapList[i] = ((Excel.Worksheet)_excel.ActiveSheet).Cells[i, "A"];

//        //            }

//        //        }
//        //        else
//        //        {
//        //            int num = (int)System.Windows.Forms.MessageBox.Show("Error, can't find Weapon.csv");
//        //        }

//        //        return null;
//        //    }
//        //    catch (Exception ex) { Console.WriteLine(ex.Message); }
//        //    return WeapList; // если что то пойдет не так
//        //}

//        internal bool OpenAttachList(string filePathAtach)
//        {
//            try
//            {
//                if (File.Exists(filePathAtach))
//                {
//                    _workbook = _excel.Workbooks.Open(filePathAtach);
//                }
//                else
//                {
//                    _workbook.Save();
//                    int num = (int)System.Windows.Forms.MessageBox.Show("Error, can't find Weapon.csv");
//                }

//                return true;
//            }
//            catch (Exception ex) { Console.WriteLine(ex.Message); }
//            return false; // если что то пойдет не так
//        }

//        public void Dispose()
//        {
            
//        }
//    }
//}
