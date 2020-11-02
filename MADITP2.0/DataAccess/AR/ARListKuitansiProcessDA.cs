using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace MADITP2._0.DataAccess.AR
{
    public class ARListKuitansiProcessDA
    {
        private static clsGlobal Helper;
        public ARListKuitansiProcessDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, ARListKuitansiProcessBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_AR_SELECT_LIST_KUITANSI_PROCESS] '{Model.entity}', '{Model.branch}', '{Model.division}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_AR_SELECT_LIST_KUITANSI_PROCESS] '{Model.entity}','{Model.branch}','{Model.division}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_AR_SELECT_LIST_KUITANSI_PROCESS] '{Model.entity}','{Model.branch}','{Model.division}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public void UpdateKWProcessFlag()
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>();
                //var result = Helper.ExecuteStoreProcedure("sp_AR_UPDATE_KW_PROCESS_FLAG", sqlParameter);
                //SP di book dev
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_AR_UPDATE_KW_PROCESS_FLAG]", sqlParameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerateKWLast(ARKwProcessFlagBL Model, DateTime LastDate, DateTime CurrentDate, DateTime LastPeriod, DateTime CurrentPeriod, string UserID,int FlagProcess, string MaxPeriod)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>()
                { 
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity", VALUE= Model.entity },
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch", VALUE= Model.branch },
                    new SqlParameterHelper(){PARAMETR_NAME = "@division", VALUE= Model.division },
                    new SqlParameterHelper(){PARAMETR_NAME = "@txndatefrom", VALUE= LastDate.ToString("yyyy-MM-dd") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@txndateto", VALUE= CurrentDate.ToString("yyyy-MM-dd") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lastperiod", VALUE= LastPeriod.ToString("yyyyMM") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@currentperiod", VALUE= CurrentPeriod.ToString("yyyyMM") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@userid", VALUE= UserID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@flag_proces", VALUE= FlagProcess },
                    new SqlParameterHelper(){PARAMETR_NAME = "@maxperiod", VALUE= MaxPeriod }

                };
                var result = Helper.ExecuteStoreProcedure("sp_AR_GENERATE_KW_LAST", sqlParameter);
                //SP di book dev
                //var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_AR_GENERATE_KW_LAST]", sqlParameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerateKW(ARKwProcessFlagBL Model, DateTime LastDate, DateTime CurrentDate, DateTime LastPeriod, DateTime CurrentPeriod, string UserID, int FlagProcess)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity", VALUE= Model.entity },
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch", VALUE= Model.branch },
                    new SqlParameterHelper(){PARAMETR_NAME = "@division", VALUE= Model.division },
                    new SqlParameterHelper(){PARAMETR_NAME = "@txndatefrom", VALUE= LastDate.ToString("yyyy-MM-dd") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@txndateto", VALUE= CurrentDate.ToString("yyyy-MM-dd") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@lastperiod", VALUE= LastPeriod.ToString("yyyyMM") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@currentperiod", VALUE= CurrentPeriod.ToString("yyyyMM") },
                    new SqlParameterHelper(){PARAMETR_NAME = "@userid", VALUE= UserID },
                    new SqlParameterHelper(){PARAMETR_NAME = "@flag_proces", VALUE= FlagProcess },

                };
                var result = Helper.ExecuteStoreProcedure("[sp_AR_GENERATE_KW", sqlParameter);
                //SP di book dev
                //var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_AR_GENERATE_KW]", sqlParameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable GetDivision()
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"SELECT dc_division_id, dc_division FROM DIVISION_CODES");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public DataTable ReadTdkTerprosesKW(EnumFilter enReadType, ARTdkTerprosesKwBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_TDK_TERPROSES_KW] '{Model.seq}',{Page},{PerPage},0,0");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Result;
        }

        public DataTable ReadARKuitansi(EnumFilter enReadType, ARListKuitansiProcessBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_AR_SELECT_KUITANSI] '{Model.entity}','{Model.branch}','{Model.division}',{Page},{PerPage},0,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_AR_SELECT_KUITANSI] '{Model.entity}','{Model.branch}','{Model.division}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Result;
        }

        public DataTable GenerateDataTidakTerprosesKW(ARTdkTerprosesKwBL Model, int FlagProcess, DateTime LastDate, DateTime CurrentDate)
        {
            try
            {
                var Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_AR_GENERATE_DATA_TBL_TDK_TERPROSES_KW] {FlagProcess},{Model.entity_id},'{Model.branch_id}','{Model.division_id}','{LastDate:yyyy-MM-dd}','{CurrentDate:yyyy-MM-dd}'");
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable GetAllKWProcessFlag(ARKwProcessFlagBL Model)
        {
            try
            {
                var Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_AR_SELECT_KW_PROCESS_FLAG] '{Model.entity}','{Model.branch}','{Model.division}',0,50,0,0");
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int PostTdkTerprosesKW(ARTdkTerprosesKwBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@so_number", VALUE= Model.so_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@item_number", VALUE= Model.item_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@seq_number", VALUE= Model.seq_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@customer_id", VALUE= Model.customer_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@entity_id", VALUE= Model.entity_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@branch_id", VALUE= Model.branch_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@division_id", VALUE= Model.division_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@item_description", VALUE= Model.item_description},
                    new SqlParameterHelper(){PARAMETR_NAME = "@invoice_header_flag", VALUE= Model.invoice_header_flag},
                    new SqlParameterHelper(){PARAMETR_NAME = "@artxn_type", VALUE= Model.artxn_type},
                    new SqlParameterHelper(){PARAMETR_NAME = "@txn_date", VALUE= Model.txn_date},
                    new SqlParameterHelper(){PARAMETR_NAME = "@term_of_payment", VALUE= Model.term_of_payment},
                    new SqlParameterHelper(){PARAMETR_NAME = "@date_of_visit", VALUE= Model.date_of_visit},
                    new SqlParameterHelper(){PARAMETR_NAME = "@date_of_due", VALUE= Model.date_of_due},
                    new SqlParameterHelper(){PARAMETR_NAME = "@due_date", VALUE= Model.due_date},
                    new SqlParameterHelper(){PARAMETR_NAME = "@original_invoice_amount", VALUE= Model.original_invoice_amount },
                    new SqlParameterHelper(){PARAMETR_NAME = "@dp_amount", VALUE= Model.dp_amount },
                    new SqlParameterHelper(){PARAMETR_NAME = "@cod_amount", VALUE= Model.cod_amount},
                    new SqlParameterHelper(){PARAMETR_NAME = "@item_amount", VALUE= Model.item_amount},
                    new SqlParameterHelper(){PARAMETR_NAME = "@total_amount_in_kw", VALUE= Model.total_amount_in_kw},
                    new SqlParameterHelper(){PARAMETR_NAME = "@total_amount_paid", VALUE= Model.total_amount_paid},
                    new SqlParameterHelper(){PARAMETR_NAME = "@outstanding_amount", VALUE= Model.outstanding_amount },
                    new SqlParameterHelper(){PARAMETR_NAME = "@number_of_instalments", VALUE= Model.number_of_instalments},
                    new SqlParameterHelper(){PARAMETR_NAME = "@last_kw_generated_number", VALUE= Model.last_kw_generated_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@last_kw_generated_date", VALUE= Model.last_kw_generated_date },
                    new SqlParameterHelper(){PARAMETR_NAME = "@billing_date", VALUE= Model.billing_date},
                    new SqlParameterHelper(){PARAMETR_NAME = "@period_start_of_instal", VALUE= Model.period_start_of_instal },
                    new SqlParameterHelper(){PARAMETR_NAME = "@year_start_of_instal", VALUE= Model.year_start_of_instal },
                    new SqlParameterHelper(){PARAMETR_NAME = "@instal_amount_per_month", VALUE= Model.instal_amount_per_month},
                    new SqlParameterHelper(){PARAMETR_NAME = "@instal_payment_type", VALUE= Model.instal_payment_type},
                    new SqlParameterHelper(){PARAMETR_NAME = "@instal_card_type", VALUE= Model.instal_card_type},
                    new SqlParameterHelper(){PARAMETR_NAME = "@instal_bank", VALUE= Model.instal_bank},
                    new SqlParameterHelper(){PARAMETR_NAME = "@collector_id", VALUE= Model.collector_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@rep_id", VALUE= Model.rep_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@area_code", VALUE= Model.area_code},
                    new SqlParameterHelper(){PARAMETR_NAME = "@verifikator_id", VALUE= Model.verifikator_id},
                    new SqlParameterHelper(){PARAMETR_NAME = "@seq", VALUE= Model.seq},
                    new SqlParameterHelper(){PARAMETR_NAME = "@alasan", VALUE= Model.alasan},
                    new SqlParameterHelper(){PARAMETR_NAME = "@svs_dateofbilling", VALUE= Model.dateofbilling},
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_AR_INSERT_TBL_TDK_TERPROSES_KW]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteTdkTerprosesKWBySequence(int Sequence)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() 
                {
                    new SqlParameterHelper(){PARAMETR_NAME = "@Sequence", VALUE= Sequence }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_AR_DELETE_TBL_TDK_TERPROSES_KW]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}