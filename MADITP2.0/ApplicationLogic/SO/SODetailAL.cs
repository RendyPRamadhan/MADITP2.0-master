using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System.Data;
using System.Collections.Generic;
using Microsoft.Office.Interop;
using System;
using System.IO;
using System.Diagnostics;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SODetailAL
    {
        clsGlobal Helper = null;
        clsAlert Alert = null;
        SODetailDA Accessor;
        DataTable dataTable = new DataTable();

        public SODetailAL(clsGlobal helper, clsAlert alert)
        {
            Helper = helper;
            Alert = alert;
            Accessor = new SODetailDA(Helper, Alert);
        }

        public List<ComboBoxViewModel> GetEntity()
        {
            return Accessor.GetEntity();
        }

        public List<ComboBoxViewModel> GetBranch()
        {
            return Accessor.GetBranch();
        }

        public List<ComboBoxViewModel> GetDivision()
        {
            return Accessor.GetDivision();
        }

        public List<ComboBoxViewModel> GetOrderType()
        {
            return Accessor.GetOrderType();
        }

        public List<ComboBoxViewModel> GetWarehouse()
        {
            return Accessor.GetWarehouse();
        }

        public DataTable SearchData(SODetailBL Entity)
        {
            return Accessor.SearchData(Entity);
        }

        public DataTable ProductData(SODetailBL Entity)
        {
            return Accessor.ProductData(Entity);
        }

        public DataTable Report1(SODetailBL Entity)
        {
            /*dataTable.Columns.Add("NO KP", typeof(String));
            dataTable.Columns.Add("TANGGAL KP", typeof(String));
            dataTable.Columns.Add("STS DELIVERY", typeof(String));
            dataTable.Columns.Add("PRODUCT BONUS", typeof(String));
            dataTable.Columns.Add("BRANCH", typeof(String));
            dataTable.Columns.Add("KODE EPC", typeof(String));
            dataTable.Columns.Add("NAMA EPC", typeof(String));
            dataTable.Columns.Add("CUST ID", typeof(String));
            dataTable.Columns.Add("CUST NAME", typeof(String));
            dataTable.Columns.Add("HP", typeof(String));
            dataTable.Columns.Add("EMAIL", typeof(String));
            dataTable.Columns.Add("ADDRESS 1", typeof(String));
            dataTable.Columns.Add("ADDRESS 2", typeof(String));
            dataTable.Columns.Add("ADDRESS 3", typeof(String));
            dataTable.Columns.Add("RT", typeof(String));
            dataTable.Columns.Add("RW", typeof(String));
            dataTable.Columns.Add("KEL", typeof(String));
            dataTable.Columns.Add("KEC", typeof(String));
            dataTable.Columns.Add("KODE POS", typeof(String));
            dataTable.Columns.Add("CITY", typeof(String));
            dataTable.Columns.Add("PROVINSI", typeof(String));
            dataTable.Columns.Add("STATUS", typeof(String));
            dataTable = Accessor.Report1(Entity);*/
            return Accessor.Report1(Entity);
        }

        public void ExportExcel(DataTable tablelist, string excelFilename)
        {
            Microsoft.Office.Interop.Excel.Application objexcelapp = new Microsoft.Office.Interop.Excel.Application();
            objexcelapp.Application.Workbooks.Add(Type.Missing);
            objexcelapp.Columns.AutoFit();
            for (int i = 1; i < tablelist.Columns.Count + 1; i++)
            {
                Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)objexcelapp.Cells[1, i];
                xlRange.Font.Bold = -1;
                xlRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlRange.Borders.Weight = 1d;
                xlRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                objexcelapp.Cells[1, i] = tablelist.Columns[i - 1].ColumnName;
            }
            /*For storing Each row and column value to excel sheet*/
            for (int i = 0; i < tablelist.Rows.Count; i++)
            {
                for (int j = 0; j < tablelist.Columns.Count; j++)
                {
                    if (tablelist.Rows[i][j] != null)
                    {
                        Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)objexcelapp.Cells[i + 2, j + 1];
                        xlRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        xlRange.Borders.Weight = 1d;
                        objexcelapp.Cells[i + 2, j + 1] = tablelist.Rows[i][j].ToString();
                    }
                }
            }
            objexcelapp.Columns.AutoFit(); // Auto fix the columns size
            System.Windows.Forms.Application.DoEvents();
            if (Directory.Exists("C:\\CTR_Data\\")) // Folder dic
            {
                objexcelapp.ActiveWorkbook.SaveCopyAs("C:\\CTR_Data\\" + excelFilename + ".xlsx");
            }
            else
            {
                Directory.CreateDirectory("C:\\CTR_Data\\");
                objexcelapp.ActiveWorkbook.SaveCopyAs("C:\\CTR_Data\\" + excelFilename + ".xlsx");
            }
            objexcelapp.ActiveWorkbook.Saved = true;
            System.Windows.Forms.Application.DoEvents();
            foreach (Process proc in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
            {
                proc.Kill();
            }
        }
    }
}
