using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    class ARItemBL
    {
        private string mSo_Number;
        private string mItem_Number;
        private string mSeq_Number;
        private string mCustomer_Id;
        private string mEntity_Id;
        private string mBranch_Id;
        private string mDivision_Id;
        private string mItem_Description;
        private string mInvoice_Header_Flag;
        private string mArtxn_Type;
        private DateTime mTxn_Date;
        private int mTerm_Of_payment;
        private string mDate_Of_Visit;
        private string mDate_Of_Due;
        private DateTime mDue_Date;
        private int mOriginal_Invoice_Amount;
        private int mDp_Amount;
        private int mCod_Amount;
        private int mItem_Amount;
        private int mTotal_Amount_In_Kw;
        private int mTotal_Amount_Paid;
        private int mOutstanding_Amount;
        private int mNumber_Of_Instalments;
        private int mLast_Kw_Generated_Number;
        private DateTime mLast_Kw_Generated_Date;
        private string mBilling_Date;
        private string mPeriod_Start_Of_Instal;
        private string mYear_Start_Of_Instal;
        private int mInstal_Amount_Per_Month;
        private string mInstal_Payment_Type;
        private string mInstal_Card_Type;
        private string mInstal_Bank;
        private string mCollector_Id;
        private int mLast_Kw_Period;
        private string mRep_Id;
        private string mVerificator_Id;
        private int mWrite_Off_Amount;
        private DateTime mInvoice_Date;
        private DateTime mManual_Entry_Date;
        private DateTime mCreation_Date;
        private long mItem_Id;

        public string So_Number { get => mSo_Number; set => mSo_Number = value; }
        public string Item_Number { get => mItem_Number; set => mItem_Number = value; }
        public string Seq_Number { get => mSeq_Number; set => mSeq_Number = value; }
        public string Customer_Id { get => mCustomer_Id; set => mCustomer_Id = value; }
        public string Entity_Id { get => mEntity_Id; set => mEntity_Id = value; }
        public string Branch_Id { get => mBranch_Id; set => mBranch_Id = value; }
        public string Division_Id { get => mDivision_Id; set => mDivision_Id = value; }
        public string Item_Description { get => mItem_Description; set => mItem_Description = value; }
        public string Invoice_Header_flag { get => mInvoice_Header_Flag; set => mInvoice_Header_Flag = value; }
        public string Artxn_Type { get => mArtxn_Type; set => mArtxn_Type = value; }
        public DateTime Txn_Date { get => mTxn_Date; set => mTxn_Date = value; }
        public int Term_Of_payment { get => mTerm_Of_payment; set => mTerm_Of_payment = value; }
        public string Date_Of_visit { get => mDate_Of_Visit; set => mDate_Of_Visit = value; }
        public string Date_Of_due { get => mDate_Of_Due; set => mDate_Of_Due = value; }
        public DateTime Due_Date { get => mDue_Date; set => mDue_Date = value; }
        public int Original_Invoice_amount { get => mOriginal_Invoice_Amount; set => mOriginal_Invoice_Amount = value; }
        public int Dp_Amount { get => mDp_Amount; set => mDp_Amount = value; }
        public int Cod_Amount { get => mCod_Amount; set => mCod_Amount = value; }
        public int Item_Amount { get => mItem_Amount; set => mItem_Amount = value; }
        public int Total_Amount_in_kw { get => mTotal_Amount_In_Kw; set => mTotal_Amount_In_Kw = value; }
        public int Total_Amount_paid { get => mTotal_Amount_Paid; set => mTotal_Amount_Paid = value; }
        public int Outstanding_Amount { get => mOutstanding_Amount; set => mOutstanding_Amount = value; }
        public int Number_Of_instalments { get => mNumber_Of_Instalments; set => mNumber_Of_Instalments = value; }
        public int Last_Kw_generated_number { get => mLast_Kw_Generated_Number; set => mLast_Kw_Generated_Number = value; }
        public DateTime Last_Kw_generated_date { get => mLast_Kw_Generated_Date; set => mLast_Kw_Generated_Date = value; }
        public string Billing_Date { get => mBilling_Date; set => mBilling_Date = value; }
        public string Period_Start_of_instal { get => mPeriod_Start_Of_Instal; set => mPeriod_Start_Of_Instal = value; }
        public string Year_Start_of_instal { get => mYear_Start_Of_Instal; set => mYear_Start_Of_Instal = value; }
        public int Instal_Amount_per_month { get => mInstal_Amount_Per_Month; set => mInstal_Amount_Per_Month = value; }
        public string Instal_Payment_type { get => mInstal_Payment_Type; set => mInstal_Payment_Type = value; }
        public string Instal_Card_type { get => mInstal_Card_Type; set => mInstal_Card_Type = value; }
        public string Instal_Bank { get => mInstal_Bank; set => mInstal_Bank = value; }
        public string Collector_Id { get => mCollector_Id; set => mCollector_Id = value; }
        public int Last_Kw_period { get => mLast_Kw_Period; set => mLast_Kw_Period = value; }
        public string Rep_Id { get => mRep_Id; set => mRep_Id = value; }
        public string Verificator_Id { get => mVerificator_Id; set => mVerificator_Id = value; }
        public int Write_Off_amount { get => mWrite_Off_Amount; set => mWrite_Off_Amount = value; }
        public DateTime Invoice_Date { get => mInvoice_Date; set => mInvoice_Date = value; }
        public DateTime Manual_Entry_date { get => mManual_Entry_Date; set => mManual_Entry_Date = value; }
        public DateTime Creation_Date { get => mCreation_Date; set => mCreation_Date = value; }
        public long Item_Id { get => mItem_Id; set => mItem_Id = value; }
    }
}
