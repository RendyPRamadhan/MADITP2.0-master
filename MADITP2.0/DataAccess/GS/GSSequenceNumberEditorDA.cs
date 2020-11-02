using MADITP2._0.businessLogic.GS;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MADITP2._0.DataAccess.GS
{
    public class GSSequenceNumberEditorDA
    {
        private static clsGlobal Helper;
        public GSSequenceNumberEditorDA(clsGlobal _Helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = _Helper;
            }
        }

        public DataTable Read(EnumFilter enReadType, GSSequenceNumberEditorBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit)
        {
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_SEQUENCE_NUMBER_EDITOR] '',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_SEQUENCE_NUMBER_EDITOR] '{Model.id}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_SEQUENCE_NUMBER_EDITOR] '{Model.id}',{Page},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV].[dbo].[SP_GS_SELECT_SEQUENCE_NUMBER_EDITOR] '{Model.id}',{Page},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int Post(GSSequenceNumberEditorBL Model)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE= Model.id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@last_number", VALUE= Model.last_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@minimum", VALUE= Model.minimum },
                    new SqlParameterHelper(){PARAMETR_NAME = "@maximum", VALUE= Model.maximum }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_INSERT_SEQUENCE_NUMBER_EDITOR]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Put(GSSequenceNumberEditorBL Model, bool IsUpdateLastNumber)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE= Model.id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@last_number", VALUE= Model.last_number },
                    new SqlParameterHelper(){PARAMETR_NAME = "@minimum", VALUE= Model.minimum },
                    new SqlParameterHelper(){PARAMETR_NAME = "@maximum", VALUE= Model.maximum },
                    new SqlParameterHelper(){PARAMETR_NAME = "@is_update_last_number", VALUE= IsUpdateLastNumber }
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_UPDATE_SEQUENCE_NUMBER_EDITOR]", sqlParameter);
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
                    new SqlParameterHelper(){PARAMETR_NAME = "@id", VALUE= id },
                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV].[dbo].[SP_GS_DELETE_SEQUENCE_NUMBER_EDITOR]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
