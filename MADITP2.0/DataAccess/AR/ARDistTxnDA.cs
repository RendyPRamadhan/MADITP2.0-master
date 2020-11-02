using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.AR
{
    class ARDistTxnDA
    {
        private clsGlobal Helper;
        private string reason;

        public string Reason { get => reason; set => reason = value; }

        public ARDistTxnDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public bool Post(ARDistTxnBL Item)
        {
            return true;
        }
        
        public bool Put(string InvoiceNo, ARDistTxnBL Item)
        {
            return true;
        }
        
        public bool Delete(string InvoiceNo)
        {
            return true;
        }
        
        public List<ARDistTxnBL> Read(EnumFilter Filter, int Offset = 0, int Limit = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            DataTable dt = new DataTable();
            if (Search == null)
            {
                Search = string.Empty;
            }

            if (Filter == EnumFilter.GET_ALL)
            {
                Offset = -1;
                Limit = -1;
            }

            List<SqlParameterHelper> SqlParameters = new List<SqlParameterHelper>();
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = Offset },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Limit", VALUE = Limit },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search }
                };

                dt = Helper.ExecuteQuery($"SELECT * from FUNCTION_AR_DIST_TXN_GET_ALL(@Offset, @Perpage, @Search)", SqlParameters);
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            if (dt.Rows.Count == 0)
            {
                return new List<ARDistTxnBL>();
            }

            return Helper.ConvertDataTableToList<ARDistTxnBL>(dt);
        }

        public int CountRows(string Search = null)
        {
            DataTable dt = new DataTable();
            if (Search == null)
            {
                Search = string.Empty;
            }

            List<SqlParameterHelper> SqlParameters = new List<SqlParameterHelper>();
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = -1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Limit", VALUE = -1 },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search }
                };

                dt = Helper.ExecuteQuery($"SELECT count(*) as jumlah from FUNCTION_AR_DIST_TXN_GET_ALL(@Offset, @Perpage, @Search)", SqlParameters);
            }
            catch (Exception e)
            {
                Reason = e.Message.ToString();
            }

            if (dt.Rows.Count == 0)
            {
                return 0;
            }

            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }
    }
}
