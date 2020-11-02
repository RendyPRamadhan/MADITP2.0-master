using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    class CBVoucherDistTxnBL
    {
        private string mBank_Id;
        private string mSub_Bank_Id;
        private string mVoucher_Type;
        private int mSeq_No;
        private int mIndex_No;
        private string mBank_Txn_Type;
        private string mVoucher_Ref;
        private string mReceipt_Paid_Codes;
        private string mReceipt_Paid_To_Name;
        private string mEntity;
        private string mBranch;
        private string mDivision;
        private string mDepartment;
        private string mMajor1;
        private string mMajor2;
        private string mMinor;
        private string mAnalysis;
        private string mFiller;
        private string mAdd_Book_Id;
        private string mTxn_Description;
        private string mTxn_Dr_Cr;
        private DateTime mTxn_Date;
        private double mTxn_Base_Ammount;
        private DateTime mEntry_Date;
        private string mGl_Interface_Status;
        private DateTime mGl_Effective_Date;
        private int mGl_Fiscal_Period;
        private string mGl_Fiscal_Year;
        private string mGl_Batch_Id;
        private string mGl_Journal_Id;
        private int mGl_Journal_Index;
        private string mGl_Batch_Source;
        private string mGl_Journal_Type;
        private DateTime mDate_Interfaced;
        private string mInterfaced_User;
        private string mCash_Id;
        private string mUpload_Flag;
        private DateTime mUpload_Date;
        private DateTime mPeriod_Week_From;
        private DateTime mPeriod_Week_To;

        public string Bank_Id { get => mBank_Id; set => mBank_Id = value; }
        public string Sub_Bank_Id { get => mSub_Bank_Id; set => mSub_Bank_Id = value; }
        public string Voucher_Type { get => mVoucher_Type; set => mVoucher_Type = value; }
        public int Seq_No { get => mSeq_No; set => mSeq_No = value; }
        public int Index_No { get => mIndex_No; set => mIndex_No = value; }
        public string Bank_Txn_Type { get => mBank_Txn_Type; set => mBank_Txn_Type = value; }
        public string Voucher_Ref { get => mVoucher_Ref; set => mVoucher_Ref = value; }
        public string Receipt_Paid_Codes { get => mReceipt_Paid_Codes; set => mReceipt_Paid_Codes = value; }
        public string Receipt_Paid_To_Name { get => mReceipt_Paid_To_Name; set => mReceipt_Paid_To_Name = value; }
        public string Entity { get => mEntity; set => mEntity = value; }
        public string Branch { get => mBranch; set => mBranch = value; }
        public string Division { get => mDivision; set => mDivision = value; }
        public string Department { get => mDepartment; set => mDepartment = value; }
        public string Major1 { get => mMajor1; set => mMajor1 = value; }
        public string Major2 { get => mMajor2; set => mMajor2 = value; }
        public string Minor { get => mMinor; set => mMinor = value; }
        public string Analysis { get => mAnalysis; set => mAnalysis = value; }
        public string Filler { get => mFiller; set => mFiller = value; }
        public string Add_Book_Id { get => mAdd_Book_Id; set => mAdd_Book_Id = value; }
        public string Txn_Description { get => mTxn_Description; set => mTxn_Description = value; }
        public string Txn_Dr_Cr { get => mTxn_Dr_Cr; set => mTxn_Dr_Cr = value; }
        public DateTime Txn_Date { get => mTxn_Date; set => mTxn_Date = value; }
        public double Txn_Base_Ammount { get => mTxn_Base_Ammount; set => mTxn_Base_Ammount = value; }
        public DateTime Entry_Date { get => mEntry_Date; set => mEntry_Date = value; }
        public string Gl_Interface_Status { get => mGl_Interface_Status; set => mGl_Interface_Status = value; }
        public DateTime Gl_Effective_Date { get => mGl_Effective_Date; set => mGl_Effective_Date = value; }
        public int Gl_Fiscal_Period { get => mGl_Fiscal_Period; set => mGl_Fiscal_Period = value; }
        public string Gl_Fiscal_Year { get => mGl_Fiscal_Year; set => mGl_Fiscal_Year = value; }
        public string Gl_Batch_Id { get => mGl_Batch_Id; set => mGl_Batch_Id = value; }
        public string Gl_Journal_Id { get => mGl_Journal_Id; set => mGl_Journal_Id = value; }
        public int Gl_Journal_Index { get => mGl_Journal_Index; set => mGl_Journal_Index = value; }
        public string Gl_Batch_Source { get => mGl_Batch_Source; set => mGl_Batch_Source = value; }
        public string Gl_Journal_Type { get => mGl_Journal_Type; set => mGl_Journal_Type = value; }
        public DateTime Date_Interfaced { get => mDate_Interfaced; set => mDate_Interfaced = value; }
        public string Interfaced_User { get => mInterfaced_User; set => mInterfaced_User = value; }
        public string Cash_Id { get => mCash_Id; set => mCash_Id = value; }
        public string Upload_Flag { get => mUpload_Flag; set => mUpload_Flag = value; }
        public DateTime Upload_Date { get => mUpload_Date; set => mUpload_Date = value; }
        public DateTime Period_Week_From { get => mPeriod_Week_From; set => mPeriod_Week_From = value; }
        public DateTime Period_Week_To { get => mPeriod_Week_To; set => mPeriod_Week_To = value; }
    }
}
