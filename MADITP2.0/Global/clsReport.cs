using MADITP2._0.businessLogic.GS;
using MADITP2._0.businessLogic.SO;
using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.BusinessLogic.GS;
using MADITP2._0.BusinessLogic.IM;
using MADITP2._0.BusinessLogic.SO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.Global
{
    class clsReport
    {
        private string _Query = "";

        public string REPORT_SO_MASTER_VERIFICATOR(string _VerID, string _VerName)
        {
            return _Query = $"[sp_SO_REPORT_VERIFICATOR_MASTER]'{ _VerID }', '{ _VerName }'";
        }

        public string REPORT_SO_VERIFICATION_SCHEDULE_ASSIGNMENT(SOVerificationProcessBL clsBL)
        {
            return _Query = $"[sp_SELECT_SO_VERIVICATOR_ASSIGNMENT]'{ clsBL.entity_id }', '{ clsBL.branch_id }', '{ clsBL.verificator_id }', '{ clsBL.so_kp_no }'";
        }

        public string REPORT_SO_VERIFICATION_STATUS_DELIVERY_CONFIRMATION(string _KPNo)
        {
            return _Query = $"SELECT * FROM vw_Q2_KONFIRMASI_DELIVERY WHERE vw_Q2_KONFIRMASI_DELIVERY.skh_so_kp_number in ({ _KPNo })";
        }

        public string REPORT_SO_VERIFICATION_STATUS(SOVerificationProcessBL clsBL, string _VerifierName, string _IsKPDate, string _IsAssignDate)
        {
            return _Query = $"[sp_SO_GET_REPORT_VERIFICATION_STATUS] '{ clsBL.so_kp_no }', '{ clsBL.entity_id }', '{ clsBL.branch_id }', '{ clsBL.division_id }', '{ _VerifierName }', '{ clsBL.verification_status }', '{ clsBL.dp_status }', '{ clsBL.type_of_activity }', '{ _IsKPDate }', '{ clsBL.so_kp_date_from }', '{ clsBL.so_kp_date_until }', '{ _IsAssignDate }', '{ clsBL.assignment_date }'";
        }

        public string REPORT_SO_SALES_ORDER_RELEASE(SOVerificationProcessBL clsBL, string _IsAssignDate)
        {
            return _Query = $"[sp_SO_GET_REPORT_SALES_ORDER_RELEASE] '{ clsBL.so_kp_no }', '{ clsBL.entity_id }', '{ clsBL.branch_id }', '{ clsBL.division_id }', '{ clsBL.verificator_id }', '{ clsBL.verification_status }', '{ clsBL.customer_name }', '{ _IsAssignDate }', '{ clsBL.assignment_date }'";
        }

        public string REPORT_IM_WAREHOUSE_TRANSFER_OUT(IMWarehouseTransferOutBL clsBL)
        {
            return _Query = $"SELECT * FROM VW_STOCK_REPORT_TRANSFER WHERE TRIM(VW_STOCK_REPORT_TRANSFER.st_txn_reference) = '{ clsBL.st_txn_reference }' and TRIM(VW_STOCK_REPORT_TRANSFER.st_warehouse_id) = '{ clsBL.st_warehouse_id }'";
        }
        public string REPORT_GS_ENTITY(GSEntityBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_GS_SELECT_ENTITY] '{Model.entity_id}','{Model.entity}',0,0,0,0";
        }
        public string REPORT_GS_BRANCH(GSBranchBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_GS_SELECT_BRANCH] '{Model.branch_id}','{Model.initial}','{Model.branch}',0,0,0,0";
        }
        public string REPORT_GS_FISCAL_CALENDAR(GSFiscalCalendarBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_GS_SELECT_FISCAL_CALENDAR] '{Model.group_id}','{Model.fiscal_year}','{Model.entity_id}',0,0,0,0";
        }
        public string REPORT_GS_SEQUENCE_NUMBER_EDITOR(GSSequenceNumberEditorBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_GS_SELECT_SEQUENCE_NUMBER_EDITOR] '{Model.id}',0,0,0,0";
        }
        public string REPORT_GS_MODULE(GSModuleBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_GS_SELECT_MODULE] '{Model.module_id}','{Model.description}',0,0,0,0";
        }
        public string REPORT_SO_TELEMARKETING_PARAMETER(SOTelemarketingParameterBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_PARAMETER] '{Model.id}','{Model.parameter_id}','{Model.parameter_code}','{Model.parameter_category}',0,0,0,0";
        }
        public string REPORT_SO_TELEMARKETING_QUESTION_MASTER(SOTelemarketingQuestionMasterBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_SO_SELECT_TELEMARKETING_QUESTION_MASTER] '{Model.id}','{Model.question_id}','{Model.question_code}','{Model.question_type}','{Model.question_flag}',0,0,0,0";
        }
        public string REPORT_AR_LIST_KUITANSI_SLIP_PROCESS_ALL(ARListKuitansiProcessBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_AR_SELECT_LIST_KUITANSI_PROCESS] '{Model.entity}', '{Model.branch}', '{Model.division}',0,0,0,0";
        }
        public string REPORT_AR_KW_TIDAK_PROCESS(ARTdkTerprosesKwBL Model)
        {
            return _Query = $"[BOOK_DEV].[dbo].[SP_GS_SELECT_TDK_TERPROSES_KW] '{Model.seq}',0,0,0,0";
        }
        public string REPORT_AR_LIST_KUITANSI_SLIP_UNPROCESS_ALL(ARListKuitansiSlipUnprocessAllBL Model)
        {
            return _Query = $"[dbo].[SP_AR_SELECT_LIST_KUITANSI_SLIP_UNPROCESS_ALL] '{Model.seq_number}','{Model.entity_id}','{Model.branch_id}','{Model.division_id}','{Model.invoice}','{Model.kp}',0,0,0,0";
        }
        public string REPORT_AR_PRINT_SLIP_KUITANSI_PROCESS(ARPrintSlipKuitansiProcessBL Model)
        {
            return _Query = $"[dbo].[SP_AR_SELECT_PRINT_KUITANSI_PROCESS] '{Model.ak_entity_id}','{Model.ak_branch_id}','{Model.ak_division_id}','{Model.cm_collector_name}','{Model.ak_item_number}','{Model.ak_processing_date_from}','{Model.ak_processing_date_to}',0,0,0,0";
        }
        public string REPORT_AR_REPRINT_SLIP_KUITANSI_PROCESS(ARReprintSlipKuitansiProcessBL Model)
        {
            return _Query = $"[dbo].[SP_AR_SELECT_REPRINT_KUITANSI_PROCESS] '{Model.ak_entity_id}','{Model.ak_branch_id}','{Model.ak_division_id}','{Model.cm_collector_name}','{Model.ak_item_number}','{Model.ak_processing_date_from}','{Model.ak_processing_date_to}',0,0,0,0";
        }
    }
}
