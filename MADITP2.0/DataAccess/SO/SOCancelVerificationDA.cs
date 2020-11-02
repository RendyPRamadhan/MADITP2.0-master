using MADITP2._0.businessLogic.SO;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.SO
{
    class SOCancelVerificationDA
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public SOCancelVerificationDA(clsGlobal helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
                clsAlert = new clsAlert();
            }
        }

        public DataTable GetStatusKPNo(string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_STATUS_KP_NO_CANCEL_VERIFICATION]('{ _KPNo }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public DataTable GetKPNoDetail(string _KPNo)
        {
            var result = new DataTable();
            try
            {
                result = Helper.ExecuteQuery($"SELECT * FROM [FUNCTION_SO_GET_KP_NO_DETAIL_CANCEL_VERIFICATION]('{ _KPNo }')");
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public bool Delete(SOVerificationProcessBL clsBO)
        {
            bool _isSucess = false;
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@KPNo", VALUE = clsBO.so_kp_no },
                    new SqlParameterHelper(){PARAMETR_NAME = "@VerificatorID", VALUE = clsBO.verificator_id },
                };
                var result = Helper.ExecuteStoreProcedure("[dbo].[sp_DELETE_SO_VERIFICATION_ASSIGN_CANCEL]", sqlParameter);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 1)
                {
                    _isSucess = true;
                }
            }
            catch (Exception)
            {
                _isSucess = false;
            }

            return _isSucess;
        }
    }
}
