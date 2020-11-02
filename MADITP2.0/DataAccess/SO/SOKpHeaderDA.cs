using MADITP2._0.ApplicationLogic.GS;
using MADITP2._0.ApplicationLogic.RC;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.DataAccess.SO
{
    class SOKpHeaderDA
    {
        private clsGlobal Helper;
        private string reason;
        private RCRepMasterAL RepMasterAccessor;
        private GSEntityAL Entity;
        private GSBranchAL Branch;

        /// <summary>
        /// Dependency RepMaster, Entity, dan Branch adalah optional
        /// dan hanya digunakan untuk method READ, dan Find (jika EagerLoading=true)
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="rma"></param>
        /// <param name="gea"></param>
        /// <param name="gba"></param>
        public SOKpHeaderDA(clsGlobal helper, RCRepMasterAL rma = null, GSEntityAL gea = null, GSBranchAL gba = null)
        {
            Helper = helper;

            RepMasterAccessor = rma;
            Entity = gea;
            Branch = gba;
        }

        public List<SOKPHeaderBL> Read(
            EnumFilter Filter, int Offset = 0, int Perpage = 25,
            string filterEntityID = "", string filterBranchID = "", 
            string filterSalesType = "", string filterInvoiceNumber = "",
            string filterKpNumber = "", string filterKpStatus = "", 
            string filterCodStatus = "", string filterVerificationStatus = "",
            string filterDeliveryStatus = "", string filterDpStatus = "", 
            string filterInvoiceStatus = "", string filterKpDateStart = "",
            string filterKpDateEnd = "", string filterDeliveryDateStart = "", 
            string filterDeliveryDateEnd = "")
        {
            if (Filter == EnumFilter.GET_ALL)
            {
                Offset = -1;
                Perpage = -1;
            }

            List<SOKPHeaderBL> Result = new List<SOKPHeaderBL>();
            try
            {
                DataTable dt = Helper.ExecuteQuery($"exec FUNCTION_SO_KP_HEADER_GET_ALL 'DATA', {Offset}, {Perpage}, '{filterEntityID}', '{filterBranchID}', '{filterSalesType}', '{filterInvoiceNumber}', '{filterKpNumber}', '{filterKpStatus}', '{filterCodStatus}', '{filterVerificationStatus}', '{filterDeliveryStatus}', '{filterDpStatus}', '{filterInvoiceStatus}', '{filterKpDateStart}', '{filterKpDateEnd}', '{filterDeliveryDateStart}', '{filterDeliveryDateEnd}'");

                if (dt.Rows.Count == 0)
                {
                    return Result;
                }

                Result = Helper.ConvertDataTableToList<SOKPHeaderBL>(dt);
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return Result;
            }

            List<SOKPHeaderBL> Output = new List<SOKPHeaderBL>();
            Result.ForEach(delegate (SOKPHeaderBL kp) {
                kp.RepMaster = RepMasterAccessor.Find(kp.Skh_rep_id);
                kp.Entity = Entity.GetByID(kp.Skh_entity_id);
                kp.Branch = Branch.GetByID(kp.Skh_branch_id);

                Output.Add(kp);
            });

            return Output;
        }

        public SOKPHeaderBL Find(string KpNumber, bool EagerLoding = false)
        {
            SOKPHeaderBL Result;

            try
            {
                DataTable dt = Helper.ExecuteQuery($"exec FUNCTION_SO_KP_HEADER_GET, {KpNumber}");
                if (dt.Rows.Count == 0)
                {
                    Reason = "KP Number not found";
                    return null;
                }

                Result = Helper.ConvertDataTableToModel<SOKPHeaderBL>(dt);
                if (EagerLoding)
                {
                    Result.RepMaster = RepMasterAccessor.Find(Result.Skh_rep_id);
                    Result.Entity = Entity.GetByID(Result.Skh_entity_id);
                    Result.Branch = Branch.GetByID(Result.Skh_branch_id);
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return null;
        }

        public int CountRows(string filterEntityID = "", string filterBranchID = "",
            string filterSalesType = "", string filterInvoiceNumber = "",
            string filterKpNumber = "", string filterKpStatus = "",
            string filterCodStatus = "", string filterVerificationStatus = "",
            string filterDeliveryStatus = "", string filterDpStatus = "",
            string filterInvoiceStatus = "", string filterKpDateStart = "",
            string filterKpDateEnd = "", string filterDeliveryDateStart = "",
            string filterDeliveryDateEnd = "")
        {
            DataTable dt;
            try
            {
                dt = Helper.ExecuteQuery($"exec FUNCTION_SO_KP_HEADER_GET_ALL 'COUNT_ROWS', -1, -1, '{filterEntityID}', '{filterBranchID}', '{filterSalesType}', '{filterInvoiceNumber}', '{filterKpNumber}', '{filterKpStatus}', '{filterCodStatus}', '{filterVerificationStatus}', '{filterDeliveryStatus}', '{filterDpStatus}', '{filterInvoiceStatus}', '{filterKpDateStart}', '{filterKpDateEnd}', '{filterDeliveryDateStart}', '{filterDeliveryDateEnd}'");
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

        public string Reason { get => reason; set => reason = value; }

        /// <summary>
        /// Module = NOPJK or PJK
        /// </summary>
        /// <param name="Module"></param>
        /// <returns></returns>
        public DataTable TaxReminder(string Module = "NOPJK")
        {
            string sqlReminder = $"SELECT " +
                $"seq_tax_id, gst_start_number, " +
                $"MAX(no_urut_faktur)last_number, " +
                $"gst_end_number " +
                $"from SO_FAKTUR_NUM " +
                $"left join GS_SEQUENCE_TAX on seq_tax_id = gst_tax_period_id " +
                $"where seq_tax_id is not null and gst_period_status = 'O' " +
                $"and LTRIM(RTRIM(gst_modul)) = '{Module}' " +
                $"group by seq_tax_id,gst_end_number,gst_start_number";

            return Helper.ExecDT(sqlReminder);
        }
    }
}
