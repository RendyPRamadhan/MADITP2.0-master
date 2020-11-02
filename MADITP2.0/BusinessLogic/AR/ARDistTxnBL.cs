using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    class ARDistTxnBL
    {
        private string mEntity_Id;
        private string mBranch_Id;
        private string mDivision_Id;
        private string mDepartment_Id;
        private string mInvoice_Type;
        private string mInvoice_No;
        private int mInvoice_Seq_No;
        private string mCustomer_Id;
        private string mInvoice_Desc;
        private string mMajor_1;
        private string mMajor_2;
        private string mMinor;
        private string mAnalysis;
        private string mFiller;
        private int mAmount;
        private string mDr_Cr;
        private DateTime mTxn_Date;
        private string mGl_Interface_Status;
        private DateTime mGl_Effective_Date;
        private int mGl_Fiscal_Period;
        private string mGl_Fiscal_Year;
        private string mGl_Batch_Id;
        private string mGl_Journal_Id;
        private string mGl_Batch_Source;
        private string mGl_Journal_Type;
        private DateTime mDate_Interfaced;
        private string mInterfaced_By;
        private int mGl_Journal_Index;

        public string Entity_Id { get => mEntity_Id; set => mEntity_Id = value; }
        public string Branch_Id { get => mBranch_Id; set => mBranch_Id = value; }
        public string Division_Id { get => mDivision_Id; set => mDivision_Id = value; }
        public string Department_Id { get => mDepartment_Id; set => mDepartment_Id = value; }
        public string Invoice_Type { get => mInvoice_Type; set => mInvoice_Type = value; }
        public string Invoice_No { get => mInvoice_No; set => mInvoice_No = value; }
        public int Invoice_Seq_No { get => mInvoice_Seq_No; set => mInvoice_Seq_No = value; }
        public string Customer_Id { get => mCustomer_Id; set => mCustomer_Id = value; }
        public string Invoice_Desc { get => mInvoice_Desc; set => mInvoice_Desc = value; }
        public string Major_1 { get => mMajor_1; set => mMajor_1 = value; }
        public string Major_2 { get => mMajor_2; set => mMajor_2 = value; }
        public string Minor { get => mMinor; set => mMinor = value; }
        public string Analysis { get => mAnalysis; set => mAnalysis = value; }
        public string Filler { get => mFiller; set => mFiller = value; }
        public int Amount { get => mAmount; set => mAmount = value; }
        public string Dr_Cr { get => mDr_Cr; set => mDr_Cr = value; }
        public DateTime Txn_Date { get => mTxn_Date; set => mTxn_Date = value; }
        public string Gl_Interface_Status { get => mGl_Interface_Status; set => mGl_Interface_Status = value; }
        public DateTime Gl_Effective_Date { get => mGl_Effective_Date; set => mGl_Effective_Date = value; }
        public int Gl_Fiscal_Period { get => mGl_Fiscal_Period; set => mGl_Fiscal_Period = value; }
        public string Gl_Fiscal_Year { get => mGl_Fiscal_Year; set => mGl_Fiscal_Year = value; }
        public string Gl_Batch_Id { get => mGl_Batch_Id; set => mGl_Batch_Id = value; }
        public string Gl_Journal_Id { get => mGl_Journal_Id; set => mGl_Journal_Id = value; }
        public string Gl_Batch_Source { get => mGl_Batch_Source; set => mGl_Batch_Source = value; }
        public string Gl_Journal_Type { get => mGl_Journal_Type; set => mGl_Journal_Type = value; }
        public DateTime Date_Interfaced { get => mDate_Interfaced; set => mDate_Interfaced = value; }
        public string Interfaced_By { get => mInterfaced_By; set => mInterfaced_By = value; }
        public int Gl_Journal_Index { get => mGl_Journal_Index; set => mGl_Journal_Index = value; }
    }
}
