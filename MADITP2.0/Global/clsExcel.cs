using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.BusinessLogic.RC;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.businessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.businessLogic.SO;
using System.Web.Services.Description;
using MADITP2._0.businessLogic.GS;
using MADITP2._0.BusinessLogic.CB;


namespace MADITP2._0.Global
{
    class clsExcel
    {

        internal void ExportToExcel(string path, DataTable data, EnumExcel enumExcel)
        {
            if (path != "" || enumExcel.ToString() != "")
            {
                string[] result = new string[1000];
                int colCount = 0;
                string filename = "";
                switch (enumExcel)
                {
                    case EnumExcel.REPORT_LEVEL_EPC:
                        colCount = (typeof(RCLevelEPCBO).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(RCLevelEPCBO).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_MASTER_VERIFICATOR:
                        colCount = (typeof(SOVerificatorMasterBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(SOVerificatorMasterBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_VERIFICATOR_SCHEDULE_ASSIGNMENT:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_VERIFICATION_STATUS_DELIVERY_CONFIRMATION:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_VERIFICATION_STATUS:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_SALES_ORDER_RELEASE:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_WAREHOUSE_TRANSFER_OUT:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_ENTITY:
                        colCount = (typeof(GSEntityBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(GSEntityBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_BRANCH:
                        colCount = (typeof(GSBranchBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(GSBranchBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_FISCAL_CALENDAR:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_SEQUENCE_NUMBER_EDITOR:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_MODULE:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_TELEMARKETING_PARAMETER:
                        var FileNameReportTelemarketingParam = $"{enumExcel}_CALL_STATUS_SETTING";
                        foreach (DataColumn item in data.Columns)
                        {
                            if (item.ColumnName.Contains("Target"))
                            {
                                FileNameReportTelemarketingParam = $"{enumExcel}_TARGET_CALL";
                                break;
                            }
                        }
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{FileNameReportTelemarketingParam + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_TELEMARKETING_QUESTION_MASTER:
                        var FileNameReportTelemarketingQuestion = $"{enumExcel}_QUESTION_LIST";
                        foreach (DataColumn item in data.Columns)
                        {
                            if (item.ColumnName.Contains("Answer"))
                            {
                                FileNameReportTelemarketingQuestion = $"{enumExcel}_FAQ";
                                break;
                            }
                        }
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{FileNameReportTelemarketingQuestion + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_LIST_KUITANSI_SLIP_PROCESS:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_LIST_KUITANSI_SLIP_UNPROCESS_ALL:
                        colCount = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray().Count();
                        result = (from dc in data.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_CASH_BANK_TYPE:
                        colCount = (typeof(CBCashBankTypeBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(CBCashBankTypeBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_CASH_CODE:
                        colCount = (typeof(CBMasterCashCodeBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(CBMasterCashCodeBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_VOUCHER_TYPE:
                        colCount = (typeof(CBVoucherTypeBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(CBVoucherTypeBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_CURRENCY_CODE:
                        colCount = (typeof(CBMasterCurrencyCodeBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        colCount = colCount - 1; //Karena ada penambahan 1 variable diluar keperluan report
                        result = typeof(CBMasterCurrencyCodeBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_BANK_GROUP:
                        colCount = (typeof(CBMasterBankGroupBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(CBMasterBankGroupBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_COLLECTOR_MASTER:
                        colCount = (typeof(ARMasterCollectorBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        colCount = colCount - 3;
                        result = typeof(ARMasterCollectorBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_MASTER_SU_HONGKONG:
                        colCount = (typeof(SOUnitHongkongBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(SOUnitHongkongBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_MASTER_CATEGORY_PRODUCT:
                        colCount = (typeof(SOMasterCategoryProductBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(SOMasterCategoryProductBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_MASTER_BRAND:
                        colCount = (typeof(SOMasterBrandBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        result = typeof(SOMasterBrandBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_MASTER_SUBBRAND1:
                        colCount = (typeof(SOMasterSubBrand1BL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        colCount = colCount - 1;
                        result = typeof(SOMasterSubBrand1BL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_MASTER_SUBBRAND2:
                        colCount = (typeof(SOMasterSubBrand2BL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        colCount = colCount - 2;
                        result = typeof(SOMasterSubBrand2BL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_CREDIT_LIMIT:
                        colCount = (typeof(ARCreditLimitBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        colCount = colCount - 2;
                        result = typeof(ARCreditLimitBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;
                    case EnumExcel.REPORT_GENERAL_PARAMETER:
                        colCount = (typeof(CBGeneralParameterBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        colCount = colCount - 2;
                        result = typeof(CBGeneralParameterBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_CUGS:
                        colCount = (typeof(SOReportCOGSBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        colCount = colCount - 2;
                        result = typeof(SOReportCOGSBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;
                    case EnumExcel.REPORT_RESI:
                        colCount = (typeof(SOUploadResiBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        //colCount = colCount - 3;
                        result = typeof(SOUploadResiBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;
                    case EnumExcel.REPORT_JNT:
                        colCount = (typeof(SOUploadResiJNTBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        //colCount = colCount - 3;
                        result = typeof(SOUploadResiJNTBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;
                    case EnumExcel.REPORT_MASTER_PRODUCT:
                        colCount = (typeof(SOMasterProductBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        //colCount = colCount - 3;
                        result = typeof(SOMasterProductBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;

                    case EnumExcel.REPORT_UPLOAD_DATA_PCP:
                        colCount = (typeof(SOUploadResiPCPBL).GetProperties().Select(prop => prop.Name).ToArray()).Count();
                        //colCount = colCount - 3;
                        result = typeof(SOUploadResiPCPBL).GetProperties().Select(prop => prop.Name).ToArray();
                        filename = $"Export{enumExcel + "_" + DateTime.Now.ToString("yyyyMMdd")}.xlsx";
                        break;
                }

                path = Path.Combine(path, filename);
                var row = 1;

                var app = new Excel.Application();
                Excel.Workbook workbook;
                workbook = app.Workbooks.Add();
                Excel.Worksheet sheets = workbook.Sheets[1];

                Excel.Range range;
                try
                {
                    sheets.Range[sheets.Cells[row, 1], sheets.Cells[row, colCount]].Value = result;
                    range = sheets.Range[sheets.Cells[row, 1], sheets.Cells[row, colCount]];
                    FormattingExcelCells(range, "#0DDEDA", System.Drawing.Color.Black, true);
                    foreach (DataRow item in data.Rows)
                    {
                        row += 1;
                        for (int i = 0; i < colCount; i++)
                        {

                            sheets.Cells[row, i + 1].Value = item[i];

                        }
                        if (row % 2 == 0)
                        {
                            range = sheets.Range[sheets.Cells[row, 1], sheets.Cells[row, colCount]];
                            FormattingExcelCells(range, "#CCCCFF", System.Drawing.Color.Black, false);
                        }
                    }
                    range = sheets.Range[sheets.Cells[1, 1], sheets.Cells[1, colCount]];
                    range.EntireColumn.AutoFit();
                    workbook.SaveAs(path);
                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    Marshal.ReleaseComObject(sheets);
                    workbook.Close();
                    app.Quit();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
        }



        private static void FormattingExcelCells(Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }
    }
}