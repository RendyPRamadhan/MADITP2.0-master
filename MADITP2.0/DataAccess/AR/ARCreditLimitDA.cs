using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;

namespace MADITP2._0.DataAccess.AR
{
    class ARCreditLimitDA
    {
        private static clsGlobal Helper;

        private static String tglshort, year;
        public ARCreditLimitDA(clsGlobal _Helper)
        {
            DateTime tgl = DateTime.Now;
             tglshort = tgl.ToShortDateString();
             year = tglshort.Substring(tglshort.Length - 4, 4);
            Helper = _Helper;
        }

        public DataTable Read(EnumFilter enReadType, ARCreditLimitBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            //int PerPage = (int)EnumFetchData.DefaultLimit;
            //string Search = null;

            DataTable result = new DataTable();
            string Province = null;
            string sql = null;
            int offset = (Page - 1) * PerPage;
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{year}','','','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{year}','{Model.rep_branch}','{Model.rep_id}','{Model.division}','',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{year}','{Model.rep_branch}','{Model.rep_id}','{Model.division}','',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{year}','{Model.rep_branch}','{Model.rep_id}','{Model.division}','',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public DataSet Read_DS(EnumFilter enReadType, ARCreditLimitBL Model, string tcode, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            DataSet result = new DataSet();
            string Province = null;
            string sql = null;
            int offset = (Page - 1) * PerPage;
            var Result = new DataSet();


            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{year}','','','','c',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{Model.periode_year}','{Model.rep_branch}','{Model.rep_id}','{Model.division}','{tcode}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{Model.periode_year}','{Model.rep_branch}','{Model.rep_id}','{Model.division}','{tcode}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery_DS($"EXEC [BOOK_DEV2].[dbo].[SP_AR_SELECT_CREDIT_LIMIT] '{Model.periode_year}','{Model.rep_branch}','{Model.rep_id}','{Model.division}','{tcode}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(ARCreditLimitBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@clh_periode_year", VALUE= Model.periode_year },
                    new SqlParameterHelper(){PARAMETR_NAME = "@clh_rep_branch", VALUE= Model.rep_branch },
                    new SqlParameterHelper(){PARAMETR_NAME = "@clh_rep_id", VALUE= Model.rep_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@clh_group_product", VALUE= Model.division },
                    new SqlParameterHelper(){PARAMETR_NAME = "@clh_credit_limit",  VALUE= Model.credit_limit },
                   
                    //new SqlParameterHelper(){PARAMETR_NAME = "@UserID", VALUE= clsLogin.USERID },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_AR_CMD_CREDIT LIMIT]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetList_branch(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "select bc_branch_id, bc_branch from VW_LIST_BRANCH WHERE bc_branch_id <> '0' ORDER BY bc_branch_id ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "select bc_branch_id, bc_branch from VW_LIST_BRANCH WHERE bc_branch_id <> '' ORDER BY bc_branch_id ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_division(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "select division_id, division_desc from VW_LIST_SO_CREDIT_LIMIT_DIVISION WHERE division_id <> '0' ORDER BY division_id ASC"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "select division_id, division_desc from VW_LIST_SO_CREDIT_LIMIT_DIVISION WHERE division_id <> '' ORDER BY division_id ASC"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_Rep(string Event, string BranchID, string DivID)
        {
            string sql = "";
            if(BranchID != "" && DivID != "")
            { 
                sql = "select rep_id, name, branch_id, division_id  from VW_LIST_SO_REP_MASTER where rep_id <> '' AND branch_id = " +
                    BranchID + " AND division_id = " + DivID + " ORDER BY name ASC"; 
            }
            else if (BranchID != "" && DivID == "")
            {
                sql = "select rep_id, name, branch_id, division_id  from VW_LIST_SO_REP_MASTER where rep_id <> '' AND branch_id = " +
                    BranchID +  " ORDER BY name ASC";
            }
            else if (BranchID == "" && DivID != "")
            {
                sql = "select rep_id, name, branch_id, division_id  from VW_LIST_SO_REP_MASTER where rep_id <> '' AND division_id = " +
                    DivID + " ORDER BY name ASC";
            }
            else if (BranchID == "" && DivID == "")
            {
                sql = "select rep_id, name, branch_id, division_id  from VW_LIST_SO_REP_MASTER where rep_id <> ''  ORDER BY name ASC";
            }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }
    }
}
