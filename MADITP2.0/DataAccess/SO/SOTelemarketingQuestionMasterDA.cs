using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace MADITP2._0.DataAccess.SO
{
    public class SOTelemarketingQuestionMasterDA
    {
        private static clsGlobal Helper;
        public SOTelemarketingQuestionMasterDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, SOTelemarketingQuestionMasterBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_QUESTION_MASTER] '{Model.id}','{Model.question_id}','{Model.question_code}','{Model.question_type}','{Model.question_flag}',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_QUESTION_MASTER] '{Model.id}','{Model.question_id}','{Model.question_code}','{Model.question_type}','{Model.question_flag}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_QUESTION_MASTER] '{Model.id}','{Model.question_id}','{Model.question_code}','{Model.question_type}','{Model.question_flag}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_QUESTION_MASTER] '{Model.id}','{Model.question_id}','{Model.question_code}','{Model.question_type}','{Model.question_flag}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }

        public int Post(SOTelemarketingQuestionMasterBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_segment", VALUE= Model.question_segment },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_code", VALUE= Model.question_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_type", VALUE= Model.question_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_id", VALUE= Model.question_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_no", VALUE= Model.question_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_desc", VALUE= Model.question_desc },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_item", VALUE= Model.question_item },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_flag", VALUE= Model.question_flag },
                    new SqlParameterHelper(){PARAMETR_NAME = "@create_by", VALUE= Model.create_by }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_SO_INSERT_TELEMARKETING_QUESTION_MASTER]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Put(SOTelemarketingQuestionMasterBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                       new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE= Model.id },
                       new SqlParameterHelper(){PARAMETR_NAME = "@question_segment", VALUE= Model.question_segment },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_code", VALUE= Model.question_code },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_type", VALUE= Model.question_type },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_id", VALUE= Model.question_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_no", VALUE= Model.question_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_desc", VALUE= Model.question_desc },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_item", VALUE= Model.question_item },
                    new SqlParameterHelper(){PARAMETR_NAME = "@question_flag", VALUE= Model.question_flag }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_SO_UPDATE_TELEMARKETING_QUESTION_MASTER]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(string id)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE= id }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_SO_DELETE_TELEMARKETING_QUESTION_MASTER]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GenerateNumberQuestionID(string QuestionID)
        {
            var Result = new DataTable();
            try
            {
                Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_SO_GENERATE_ID_TELEMARKETING_QUESTION_MASTER] '{QuestionID}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }
    }
}