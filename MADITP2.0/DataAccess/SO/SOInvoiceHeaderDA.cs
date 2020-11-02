using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.SO
{
    class SOInvoiceHeaderDA
    {
        private clsGlobal Helper;
        private string reason;

        public SOInvoiceHeaderDA(clsGlobal helper)
        {
            Helper = helper;
        }

        public string Reason { get => reason; set => reason = value; }

        public bool CreateNewInvoice(string Division, string KpNumber, DateTime InvoiceDate, string User)
        {
            try
            {
                List<SqlParameterHelper> sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Div", VALUE = Division },
                    new SqlParameterHelper(){PARAMETR_NAME = "@KpNumber", VALUE = KpNumber },
                    new SqlParameterHelper(){PARAMETR_NAME = "@InvDate", VALUE = InvoiceDate },
                    new SqlParameterHelper(){PARAMETR_NAME = "@User", VALUE = User },
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("sp_PROCESS_SO_INVOICE_NEW", sqlParameter);
                if (Helper.CastToString(result[0].Rows[0].ItemArray.ElementAt(0)) == "Error")
                {
                    Reason = "Please Update Your Sequence Codes";
                    return false;
                }
            }
            catch(Exception Err)
            {
                Console.WriteLine(Err.StackTrace);
                Console.WriteLine(Err.Message);
                Reason = Err.Message;
                return false;
            }

            /// check skh_log
            DataTable dt = Helper.ExecDT($"select top 1 skh_log from SO_KP_HEADER WHERE skh_so_kp_number = '{KpNumber}'");
            if (dt.Rows.Count == 0)
            {
                Reason = "KP Number not found";
                return false;
            }

            DataRow row = dt.Rows[0];
            if (Helper.CastToString(row["skh_log"]) == "")
            {
                Reason = "Process create invoice is failed! skh_log : " + row["skh_log"];
                return false;
            }

            return true;
        }

        public DataTable CheckInvoiceInterfacing(string KpNumber)
        {
            DataTable dt = Helper.ExecDT($"SELECT " +
                $"SO_INVOICE_TYPE.sit_interface_to_gl, " +
                $"SO_INVOICE_TYPE.sit_invoice_type, " +
                $"SO_INVOICE_TYPE.sit_line_type, " +
                $"sih_so_invoice_number, " +
                $"sih_so_invoice_date, " +
                $"sih_entity_id, " +
                $"sih_division_id, " +
                $"sih_branch_id, " +
                $"sih_customer_id, " +
                $"sih_total_inv_amount " +
                $"FROM SO_INVOICE_HEADER " +
                $"INNER JOIN SO_INVOICE_TYPE " +
                $"ON SO_INVOICE_HEADER.sih_invoice_type = SO_INVOICE_TYPE.sit_invoice_type " +
                $"AND sih_so_kp_number = '{Helper.CastToString(KpNumber)}'");

            return dt;
        }

        public DataTableCollection CheckARBalance(string InvoiceNumber, string InvoiceType)
        {
            List<SqlParameterHelper> SqlP = new List<SqlParameterHelper>()
            {
                new SqlParameterHelper(){ PARAMETR_NAME = "@xinvoiceno", VALUE = InvoiceNumber },
                new SqlParameterHelper(){ PARAMETR_NAME = "@xinvoice_type", VALUE = InvoiceType },
            };

            var dataTableCollection = Helper.ExecuteStoreProcedure("sp_CHECK_AR_BALANCE", SqlP);
            return dataTableCollection;
        }

        public DataTableCollection ProcessARInterface(string InvoiceNumber, string KpNumber, string User, string Year, string Entity, string Branch, string Division, string CustomerID, string Sqlstr)
        {
            List<SqlParameterHelper> SqlP = new List<SqlParameterHelper>()
            {
                new SqlParameterHelper(){ PARAMETR_NAME = "@InvNo", VALUE = InvoiceNumber },
                new SqlParameterHelper(){ PARAMETR_NAME = "@KpNumber", VALUE = KpNumber },
                new SqlParameterHelper(){ PARAMETR_NAME = "@User_id", VALUE = User },
                new SqlParameterHelper(){ PARAMETR_NAME = "@Year", VALUE = Year },
                new SqlParameterHelper(){ PARAMETR_NAME = "@Entity", VALUE = Entity },
                new SqlParameterHelper(){ PARAMETR_NAME = "@Branch", VALUE = Branch },
                new SqlParameterHelper(){ PARAMETR_NAME = "@Div", VALUE = Division },
                new SqlParameterHelper(){ PARAMETR_NAME = "@CustId", VALUE = CustomerID },
                new SqlParameterHelper(){ PARAMETR_NAME = "@sqlstr", VALUE = Sqlstr },
            };

            var dataTableCollection = Helper.ExecuteStoreProcedure("ip_PROCESS_AR_INTERFACE", SqlP);
            return dataTableCollection;
        }
    }
}
