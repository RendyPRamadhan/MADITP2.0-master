using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    class ARTxnBL
    {
        private string mSo_Number;
        private string mItem_Number;
        private string mSeq_Number;
        private string mCustomer_Id;
        private string mEntity_Id;
        private string mBranch_Id;
        private string mDivision_Id;
        private string mAr_Txn_Type;
        private DateTime mTxn_Date;
        private DateTime mDue_Date;
        private int mTxn_Amount;
        private string mReference;
        private string mBank_Id;
        private string mBack_Account;
        private string mCheck_Number;
        private string mVoucher_Type;
        private int mVoucher_No;
        private string mVoucher_Ref;
        private DateTime mCreation_Date;
        private string mUser_Id;
        private long mTxn_Id;

        public string So_Number { get => mSo_Number; set => mSo_Number = value; }
        public string Item_Number { get => mItem_Number; set => mItem_Number = value; }
        public string Seq_Number { get => mSeq_Number; set => mSeq_Number = value; }
        public string Customer_Id { get => mCustomer_Id; set => mCustomer_Id = value; }
        public string Entity_Id { get => mEntity_Id; set => mEntity_Id = value; }
        public string Branch_Id { get => mBranch_Id; set => mBranch_Id = value; }
        public string Division_Id { get => mDivision_Id; set => mDivision_Id = value; }
        public string Ar_Txn_type { get => mAr_Txn_Type; set => mAr_Txn_Type = value; }
        public DateTime Txn_Date { get => mTxn_Date; set => mTxn_Date = value; }
        public DateTime Due_Date { get => mDue_Date; set => mDue_Date = value; }
        public int Txn_Amount { get => mTxn_Amount; set => mTxn_Amount = value; }
        public string Reference { get => mReference; set => mReference = value; }
        public string Bank_Id { get => mBank_Id; set => mBank_Id = value; }
        public string Back_Account { get => mBack_Account; set => mBack_Account = value; }
        public string Check_Number { get => mCheck_Number; set => mCheck_Number = value; }
        public string Voucher_Type { get => mVoucher_Type; set => mVoucher_Type = value; }
        public int Voucher_No { get => mVoucher_No; set => mVoucher_No = value; }
        public string Voucher_Ref { get => mVoucher_Ref; set => mVoucher_Ref = value; }
        public DateTime Creation_Date { get => mCreation_Date; set => mCreation_Date = value; }
        public string User_Id { get => mUser_Id; set => mUser_Id = value; }
        public long Txn_Id { get => mTxn_Id; set => mTxn_Id = value; }
    }
}
