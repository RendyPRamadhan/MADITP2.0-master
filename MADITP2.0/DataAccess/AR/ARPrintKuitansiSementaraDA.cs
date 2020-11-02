using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Global;
using System;
using System.ComponentModel;
using System.Data;

namespace MADITP2._0.DataAccess.AR
{
    public class ARPrintKuitansiSementaraDA
    {
        private static clsGlobal Helper;
        public ARPrintKuitansiSementaraDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(ARPrintKuitansiSementaraBL Model)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"EXEC [dbo].[SP_AR_SELECT_PRINT_KUITANSI_SEMENTARA] '{Model.no_invoice}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
    }
}