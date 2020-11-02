using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    public class CBMasterCashBankBL
    {
        private string BM_BANK_ID;
        private string BM_BANK;
        private string BM_NAME_KEY;
        private string BM_BANK_GROUP_ID;
        private string BM_BANK_TYPE;
        private string BM_DEFAULT_ENTITY;
        private string BM_BANK_ADDRESS1;
        private string BM_BANK_ADDRESS2;
        private string BM_BANK_ADDRESS3;
        private string BM_BANK_AREA_CODE;
        private string BM_BANK_CITY;
        private string BM_BANK_POSTAL_CODE;
        private string BM_BANK_PROVINCE;
        private string BM_BANK_PHONE;
        private string BM_BANK_FAX;
        private string BM_EMAIL_ADDRESS;
        private string BM_CONTACT_PERSON1;
        private string BM_TITLE1;
        private string BM_CONTACT_PERSON2;
        private string BM_TITLE2;
        private string BM_GL_ENTITY;
        private string BM_ACTIVE_FLAG;

       
        public string bm_bank_id { get => BM_BANK_ID; set => BM_BANK_ID = value; }
        public string bm_bank { get => BM_BANK; set => BM_BANK = value; }
        public string bm_name_key { get => BM_NAME_KEY; set => BM_NAME_KEY = value; }
        public string bm_bank_group_id { get => BM_BANK_GROUP_ID; set => BM_BANK_GROUP_ID = value; }
        public string bm_bank_type { get => BM_BANK_TYPE; set => BM_BANK_TYPE = value; }
        public string bm_default_entity { get => BM_DEFAULT_ENTITY; set => BM_DEFAULT_ENTITY = value; }
        public string bm_bank_address1 { get => BM_BANK_ADDRESS1; set => BM_BANK_ADDRESS1 = value; }
        public string bm_bank_address2 { get => BM_BANK_ADDRESS2; set => BM_BANK_ADDRESS2 = value; }
        public string bm_bank_address3 { get => BM_BANK_ADDRESS3; set => BM_BANK_ADDRESS3 = value; }
        public string bm_bank_area_code { get => BM_BANK_AREA_CODE; set => BM_BANK_AREA_CODE = value; }
        public string bm_bank_city { get => BM_BANK_CITY; set => BM_BANK_CITY = value; }
        public string bm_bank_postal_code { get => BM_BANK_POSTAL_CODE; set => BM_BANK_POSTAL_CODE = value; }
        public string bm_bank_province { get => BM_BANK_PROVINCE; set => BM_BANK_PROVINCE = value; }
        public string bm_bank_phone { get => BM_BANK_PHONE; set => BM_BANK_PHONE = value; }
        public string bm_bank_fax { get => BM_BANK_FAX; set => BM_BANK_FAX = value; }
        public string bm_email_address { get => BM_EMAIL_ADDRESS; set => BM_EMAIL_ADDRESS = value; }
        public string bm_contact_person1 { get => BM_CONTACT_PERSON1; set => BM_CONTACT_PERSON1 = value; }
        public string bm_title1 { get => BM_TITLE1; set => BM_TITLE1 = value; }
        public string bm_contact_person2 { get => BM_CONTACT_PERSON2; set => BM_CONTACT_PERSON2 = value; }
        public string bm_title2 { get => BM_TITLE2; set => BM_TITLE2 = value; }
        public string bm_gl_entity { get => BM_GL_ENTITY; set => BM_GL_ENTITY = value; }
        public string bm_active_flag { get => BM_ACTIVE_FLAG; set => BM_ACTIVE_FLAG = value; }


        private string BAM_FISCAL_YEAR;
        private string BAM_BANK_ID;
        private string BAM_BANK_SUB_ID;
        private string BAM_BANK_ACCOUNT_NO;
        private string BAM_BANK_ACCOUNT;
        private string BAM_BANK_ENTITY;
        private string BAM_BANK_BRANCH;
        private string BAM_BANK_DIVISION;
        private string BAM_BANK_DEPARTMENT;
        private string BAM_BANK_MAJOR1;
        private string BAM_BANK_MAJOR2;
        private string BAM_BANK_MINOR;
        private string BAM_BANK_ANALYSIS;
        private string BAM_BANK_FILLER;
        private string BAM_ALLOW_MANUAL_TXN_ENTRY;
        private string BAM_ALLOW_AP;
        private string BAM_ALLOW_AR;
        private string BAM_CASH_FLOW_STATEMENT_REQUIRED;
        private string BAM_CURRENCY_CODE;
        private string BAM_BEGINNING_BALANCE_YEAR;
        private string BAM_BANK_RECEIPT_TXN1;
        private string BAM_BANK_RECEIPT_TXN2;
        private string BAM_BANK_RECEIPT_TXN3;
        private string BAM_BANK_RECEIPT_TXN4;
        private string BAM_BANK_RECEIPT_TXN5;
        private string BAM_BANK_RECEIPT_TXN6;
        private string BAM_BANK_RECEIPT_TXN7;
        private string BAM_BANK_RECEIPT_TXN8;
        private string BAM_BANK_RECEIPT_TXN9;
        private string BAM_BANK_RECEIPT_TXN10;
        private string BAM_BANK_RECEIPT_TXN11;
        private string BAM_BANK_RECEIPT_TXN12;
        private string BAM_BANK_DISTRIBUTION1;
        private string BAM_BANK_DISTRIBUTION2;
        private string BAM_BANK_DISTRIBUTION3;
        private string BAM_BANK_DISTRIBUTION4;
        private string BAM_BANK_DISTRIBUTION5;
        private string BAM_BANK_DISTRIBUTION6;
        private string BAM_BANK_DISTRIBUTION7;
        private string BAM_BANK_DISTRIBUTION8;
        private string BAM_BANK_DISTRIBUTION9;
        private string BAM_BANK_DISTRIBUTION10;
        private string BAM_BANK_DISTRIBUTION11;
        private string BAM_BANK_DISTRIBUTION12;
        private string BAM_CURRENT_BALANCE;
        private string BAM_ACTIVE_FLAG;

        public string bam_fiscal_year { get => BAM_FISCAL_YEAR; set => BAM_FISCAL_YEAR = value; }
        public string bam_bank_id { get => BAM_BANK_ID; set => BAM_BANK_ID = value; }
        public string bam_bank_sub_id { get => BAM_BANK_SUB_ID; set => BAM_BANK_SUB_ID = value; }
        public string bam_bank_account_no { get => BAM_BANK_ACCOUNT_NO; set => BAM_BANK_ACCOUNT_NO = value; }
        public string bam_bank_account { get => BAM_BANK_ACCOUNT; set => BAM_BANK_ACCOUNT = value; }
        public string bam_bank_Entity { get => BAM_BANK_ENTITY; set => BAM_BANK_ENTITY = value; }
        public string bam_bank_Branch { get => BAM_BANK_BRANCH; set => BAM_BANK_BRANCH = value; }
        public string bam_bank_Division { get => BAM_BANK_DIVISION; set => BAM_BANK_DIVISION = value; }
        public string bam_bank_Department { get => BAM_BANK_DEPARTMENT; set => BAM_BANK_DEPARTMENT = value; }
        public string bam_bank_Major1 { get => BAM_BANK_MAJOR1; set => BAM_BANK_MAJOR1 = value; }
        public string bam_bank_Major2 { get => BAM_BANK_MAJOR2; set => BAM_BANK_MAJOR2 = value; }
        public string bam_bank_Minor { get => BAM_BANK_MINOR; set => BAM_BANK_MINOR = value; }
        public string bam_bank_Analysis { get => BAM_BANK_ANALYSIS; set => BAM_BANK_ANALYSIS = value; }
        public string bam_bank_filler { get => BAM_BANK_FILLER; set => BAM_BANK_FILLER = value; }
        public string bam_allow_manual_txn_entry { get => BAM_ALLOW_MANUAL_TXN_ENTRY; set => BAM_ALLOW_MANUAL_TXN_ENTRY = value; }
        public string bam_allow_ap { get => BAM_ALLOW_AP; set => BAM_ALLOW_AP = value; }
        public string bam_allow_ar { get => BAM_ALLOW_AR; set => BAM_ALLOW_AR = value; }
        public string bam_cash_flow_statement_required { get => BAM_CASH_FLOW_STATEMENT_REQUIRED; set => BAM_CASH_FLOW_STATEMENT_REQUIRED = value; }
        public string bam_currency_code { get => BAM_CURRENCY_CODE; set => BAM_CURRENCY_CODE = value; }
        public string bam_beginning_balance_year { get => BAM_BEGINNING_BALANCE_YEAR; set => BAM_BEGINNING_BALANCE_YEAR = value; }
        public string bam_bank_receipt_txn1 { get => BAM_BANK_RECEIPT_TXN1; set => BAM_BANK_RECEIPT_TXN1 = value; }
        public string bam_bank_receipt_txn2 { get => BAM_BANK_RECEIPT_TXN2; set => BAM_BANK_RECEIPT_TXN2 = value; }
        public string bam_bank_receipt_txn3 { get => BAM_BANK_RECEIPT_TXN3; set => BAM_BANK_RECEIPT_TXN3 = value; }
        public string bam_bank_receipt_txn4 { get => BAM_BANK_RECEIPT_TXN4; set => BAM_BANK_RECEIPT_TXN4 = value; }
        public string bam_bank_receipt_txn5 { get => BAM_BANK_RECEIPT_TXN5; set => BAM_BANK_RECEIPT_TXN5 = value; }
        public string bam_bank_receipt_txn6 { get => BAM_BANK_RECEIPT_TXN6; set => BAM_BANK_RECEIPT_TXN6 = value; }
        public string bam_bank_receipt_txn7 { get => BAM_BANK_RECEIPT_TXN7; set => BAM_BANK_RECEIPT_TXN7 = value; }
        public string bam_bank_receipt_txn8 { get => BAM_BANK_RECEIPT_TXN8; set => BAM_BANK_RECEIPT_TXN8 = value; }
        public string bam_bank_receipt_txn9 { get => BAM_BANK_RECEIPT_TXN9; set => BAM_BANK_RECEIPT_TXN9 = value; }
        public string bam_bank_receipt_txn10 { get => BAM_BANK_RECEIPT_TXN10; set => BAM_BANK_RECEIPT_TXN10 = value; }
        public string bam_bank_receipt_txn11 { get => BAM_BANK_RECEIPT_TXN11; set => BAM_BANK_RECEIPT_TXN11 = value; }
        public string bam_bank_receipt_txn12 { get => BAM_BANK_RECEIPT_TXN12; set => BAM_BANK_RECEIPT_TXN12 = value; }
        public string bam_bank_distribution1 { get => BAM_BANK_DISTRIBUTION1; set => BAM_BANK_DISTRIBUTION1 = value; }
        public string bam_bank_distribution2 { get => BAM_BANK_DISTRIBUTION2; set => BAM_BANK_DISTRIBUTION2 = value; }
        public string bam_bank_distribution3 { get => BAM_BANK_DISTRIBUTION3; set => BAM_BANK_DISTRIBUTION3 = value; }
        public string bam_bank_distribution4 { get => BAM_BANK_DISTRIBUTION4; set => BAM_BANK_DISTRIBUTION4 = value; }
        public string bam_bank_distribution5 { get => BAM_BANK_DISTRIBUTION5; set => BAM_BANK_DISTRIBUTION5 = value; }
        public string bam_bank_distribution6 { get => BAM_BANK_DISTRIBUTION6; set => BAM_BANK_DISTRIBUTION6 = value; }
        public string bam_bank_distribution7 { get => BAM_BANK_DISTRIBUTION7; set => BAM_BANK_DISTRIBUTION7 = value; }
        public string bam_bank_distribution8 { get => BAM_BANK_DISTRIBUTION8; set => BAM_BANK_DISTRIBUTION8 = value; }
        public string bam_bank_distribution9 { get => BAM_BANK_DISTRIBUTION9; set => BAM_BANK_DISTRIBUTION9 = value; }
        public string bam_bank_distribution10 { get => BAM_BANK_DISTRIBUTION10; set => BAM_BANK_DISTRIBUTION10 = value; }
        public string bam_bank_distribution11 { get => BAM_BANK_DISTRIBUTION11; set => BAM_BANK_DISTRIBUTION11 = value; }
        public string bam_bank_distribution12 { get => BAM_BANK_DISTRIBUTION12; set => BAM_BANK_DISTRIBUTION12 = value; }
        public string bam_current_balance { get => BAM_CURRENT_BALANCE; set => BAM_CURRENT_BALANCE = value; }
        public string bam_active_flag { get => BAM_ACTIVE_FLAG; set => BAM_ACTIVE_FLAG = value; }
    }
}
