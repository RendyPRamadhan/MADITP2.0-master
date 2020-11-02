using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace MADITP2._0.DataAccess.SO
{
    class SOMasterCustomerDA
    {
        private string reason;
        private clsGlobal Helper;

        public string Reason { get => reason; set => reason = value; }

        public SOMasterCustomerDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public bool Post(SOMasterCustomerBL Customer)
        {
            return true;
        }
        
        public bool Put(string CustomerId, SOMasterCustomerBL Customer)
        {
            return true;
        }

        public bool Delete(string CustomerId)
        {
            return true;
        }

        public SOMasterCustomerBL Find(string CustomerId)
        {
            SOMasterCustomerBL Result = new SOMasterCustomerBL();
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@CustomerId", VALUE = CustomerId },
                };

                DataTableCollection mResult = Helper.ExecuteStoreProcedure("FUNCTION_SO_CUSTOMER_MASTER_GET", sqlParameter);
                DataTable dt = mResult[0];

                if (dt.Rows.Count == 0)
                {
                    return Result;
                }

                Result = Helper.ConvertDataTableToModel<SOMasterCustomerBL>(dt);
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return Result;
            }

            return Result;
        }

        public List<SOMasterCustomerBL> Read(EnumFilter Filter, int Offset = 0, int Perpage = 25, 
            string Search = "", string Entity = "", string Branch = "", 
            string Division = "", string Gender = "")
        {
            if(Filter == EnumFilter.GET_ALL)
            {
                Offset = -1;
                Perpage = -1;
            }

            List<SOMasterCustomerBL> Result = new List<SOMasterCustomerBL>();
            try
            {
                DataTable dt = Helper.ExecuteQuery($"exec FUNCTION_SO_CUSTOMER_MASTER_GET_ALL 'DATA', {Offset}, {Perpage}, '{Search}', '{Entity}', '{Branch}', '{Division}', '{Gender}'");
                if(dt.Rows.Count == 0)
                {
                    return Result;
                }

                Result = Helper.ConvertDataTableToList<SOMasterCustomerBL>(dt);
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return Result;
            }

            return Result;
        }

        public int CountRows(string Search = "", string Entity = "", string Branch = "", 
            string Division = "", string Gender = "")
        {
            DataTable dt;
            try
            {
                dt = Helper.ExecuteQuery($"exec FUNCTION_SO_CUSTOMER_MASTER_GET_ALL 'COUNT_ROWS', -1, -1, '{Search}', '{Entity}', '{Branch}', '{Division}', '{Gender}'");
                if (dt.Rows.Count == 0)
                {
                    return 0;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return 0;
            }

            return Helper.CastToInt(dt.Rows[0]["jumlah"]);
        }
    }
}
