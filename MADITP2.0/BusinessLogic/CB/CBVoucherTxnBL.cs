using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    class CBVoucherTxnBL
    {
        private string mBank_Id;
        private string mBank_Sub_Id;
        private string mVoucher_Type;
        private int mVoucher_Seq;
        private string mBank_Txn_Type;
        private string mVoucher_Ref;
        private string mReceipt_Paid_Code;
        private string mReceipt_Paid_To_Name;
        private string mTxn_Description;
        private string mBank_Account_Number;
        private DateTime mTxn_Date;
        private string mGl_Entity;
        private string mGl_Branch;
        private string mGl_Division;
        private string mGl_Department;
        private string mGl_Major1;
        private string mGl_Major2;
        private string mGl_Minor;
        private string mGl_Analysis;
        private string mGl_Filler;
        private string mCheque_Giro_Number;
        private string mCheque_Giro_Reference;
        private DateTime mCheque_Giro_Date;
        private string mOriginal_Cheque_Currency;
        private double mOriginal_Cheque_Amount;
        private double mCurrent_Rate;
        private double mTxn_Base_Amount;
        private string mCash_Code;
        private int mNo_Of_Distribution_Line;
        private DateTime mEntry_Date;
        private string mUser_Id;
        private int mVoided_Voucher_Id;
        private DateTime mDate_Voided;
        private string mVoided_By;
        private string mGl_Interface_Status;
        private DateTime mGl_Effective_Date;
        private string mGl_Fiscal_Period;
        private string mGl_Fiscal_Year;
        private string mGl_Batch_Id;
        private string mGl_Journal_Id;
        private string mGl_Batch_Source;
        private string mGl_Journal_Type;
        private DateTime mDate_Interface;
        private string mInterfaced_By;
        private int mSettlement_Seq;

        public string Bank_Id { get => mBank_Id; set => mBank_Id = value; }
        public string Bank_Sub_id { get => mBank_Sub_Id; set => mBank_Sub_Id = value; }
        public string Voucher_Type { get => mVoucher_Type; set => mVoucher_Type = value; }
        public int Voucher_Seq { get => mVoucher_Seq; set => mVoucher_Seq = value; }
        public string Bank_Txn_Type { get => mBank_Txn_Type; set => mBank_Txn_Type = value; }
        public string Voucher_Ref { get => mVoucher_Ref; set => mVoucher_Ref = value; }
        public string Receipt_Paid_Code { get => mReceipt_Paid_Code; set => mReceipt_Paid_Code = value; }
        public string Receipt_Paid_To_Name { get => mReceipt_Paid_To_Name; set => mReceipt_Paid_To_Name = value; }
        public string Txn_Description { get => mTxn_Description; set => mTxn_Description = value; }
        public string Bank_Account_Number { get => mBank_Account_Number; set => mBank_Account_Number = value; }
        public DateTime Txn_Date { get => mTxn_Date; set => mTxn_Date = value; }
        public string Gl_Entity { get => mGl_Entity; set => mGl_Entity = value; }
        public string Gl_Branch { get => mGl_Branch; set => mGl_Branch = value; }
        public string Gl_Division { get => mGl_Division; set => mGl_Division = value; }
        public string Gl_Department { get => mGl_Department; set => mGl_Department = value; }
        public string Gl_Major1 { get => mGl_Major1; set => mGl_Major1 = value; }
        public string Gl_Major2 { get => mGl_Major2; set => mGl_Major2 = value; }
        public string Gl_Minor { get => mGl_Minor; set => mGl_Minor = value; }
        public string Gl_Analysis { get => mGl_Analysis; set => mGl_Analysis = value; }
        public string Gl_Filler { get => mGl_Filler; set => mGl_Filler = value; }
        public string Cheque_Giro_Number { get => mCheque_Giro_Number; set => mCheque_Giro_Number = value; }
        public string Cheque_Giro_Reference { get => mCheque_Giro_Reference; set => mCheque_Giro_Reference = value; }
        public DateTime Cheque_Giro_Date { get => mCheque_Giro_Date; set => mCheque_Giro_Date = value; }
        public string Original_Cheque_Currency { get => mOriginal_Cheque_Currency; set => mOriginal_Cheque_Currency = value; }
        public double Original_Cheque_Amount { get => mOriginal_Cheque_Amount; set => mOriginal_Cheque_Amount = value; }
        public double Current_Rate { get => mCurrent_Rate; set => mCurrent_Rate = value; }
        public double Txn_Base_amount { get => mTxn_Base_Amount; set => mTxn_Base_Amount = value; }
        public string Cash_Code { get => mCash_Code; set => mCash_Code = value; }
        public int No_Of_Distribution_Line { get => mNo_Of_Distribution_Line; set => mNo_Of_Distribution_Line = value; }
        public DateTime Entry_Date { get => mEntry_Date; set => mEntry_Date = value; }
        public string User_Id { get => mUser_Id; set => mUser_Id = value; }
        public int Voided_Voucher_Id { get => mVoided_Voucher_Id; set => mVoided_Voucher_Id = value; }
        public DateTime Date_Voided { get => mDate_Voided; set => mDate_Voided = value; }
        public string Voided_By { get => mVoided_By; set => mVoided_By = value; }
        public string Gl_Interface_Status { get => mGl_Interface_Status; set => mGl_Interface_Status = value; }
        public DateTime Gl_Effective_Date { get => mGl_Effective_Date; set => mGl_Effective_Date = value; }
        public string Gl_Fiscal_Period { get => mGl_Fiscal_Period; set => mGl_Fiscal_Period = value; }
        public string Gl_Fiscal_Year { get => mGl_Fiscal_Year; set => mGl_Fiscal_Year = value; }
        public string Gl_Batch_Id { get => mGl_Batch_Id; set => mGl_Batch_Id = value; }
        public string Gl_Journal_Id { get => mGl_Journal_Id; set => mGl_Journal_Id = value; }
        public string Gl_Batch_Source { get => mGl_Batch_Source; set => mGl_Batch_Source = value; }
        public string Gl_Journal_Type { get => mGl_Journal_Type; set => mGl_Journal_Type = value; }
        public DateTime Date_Interface { get => mDate_Interface; set => mDate_Interface = value; }
        public string Interfaced_By { get => mInterfaced_By; set => mInterfaced_By = value; }
        public int Settlement_Seq { get => mSettlement_Seq; set => mSettlement_Seq = value; }
    }
}
