using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOInvoiceHeaderBL
    {
        private string mInvoice_Number;
        private DateTime mInvoice_Date;
        private string mKp_Number;
        private DateTime mKp_Date;
        private string mEntity_Id;
        private string mBranch_Id;
        private string mDivision_Id;
        private string mRep_Id;
        private string mRecruiter_Id;
        private string mMgr_Rep_Id;
        private string mOrder_Type;
        private string mInvoice_Type;
        private string mCustomer_Id;
        private string mCustomer_Name;
        private string mCustomer_Address1;
        private string mCustomer_Address2;
        private string mCustomer_Address3;
        private string mRt;
        private string mRw;
        private string mKelurahan;
        private string mKecamatan;
        private string mZipcode;
        private string mCity;
        private string mProvince;
        private string mArea_Code;
        private string mSales_Type;
        private string mPayment_Type;
        private string mPrice_List_Id;
        private string mDiscount_Id;
        private string mInvoice_Print_Status;
        private int mNo_Invoice_Copy_Printed;
        private string mInterface_To_Ar;
        private string mSales_Gl_Txn;
        private DateTime mLast_Update;
        private string mIndividual_Commission;
        private string mNo_Commission_Slip;
        private DateTime mCommission_Process_Date;
        private int mCommission_Gross_Amount;
        private int mCommission_Cwh;
        private int mCommission_Tax;
        private int mCommission_Lain;
        private string mInvoice_Desc;
        private int mNo_Detail_Lines;
        private int mTotal_Item_Set_Qty;
        private int mTotal_Su;
        private int mTotal_Bv;
        private int mTotal_Pv;
        private int mTotal_Point_1;
        private int mTotal_Point_2;
        private int mUnit_Price;
        private int mTotal_Gross_Sales;
        private int mTotal_Disc_Amount;
        private int mTotal_Line_Amount;
        private int mTotal_Bonus_Discount;
        private int mTotal_Taxable_Amount;
        private int mInv_Disc;
        private int mInv_Disc_Amount;
        private int mOther_Disc_Amount;
        private int mTotal_Inv_Amount;
        private int mTotal_Taxable_Inv;
        private int mTotal_Ppn_Amount;
        private int mTax_Ppn_Gov;
        private int mTax_Ppn_Amount;
        private int mTotal_Cost;
        private int mCard_Charge;
        private int mStamp_Charge;
        private int mDelivery_Charge;
        private int mOther_Charge;
        private int mDp_Amount;
        private string mDp_Payment_Type;
        private string mDp_Cheque_Giro_No;
        private string mDp_Card_Type;
        private string mDp_Bank;
        private DateTime mCheque_Giro_Due_Date;
        private int mCod_Amount;
        private string mCod_Payment_Type;
        private string mCod_Cheque_Giro_Num;
        private string mCod_Card_Type;
        private string mCod_Bank;
        private DateTime mCod_Cheque_Giro_Due_Date;
        private int mNo_Of_Instalments;
        private DateTime mBilling_Date;
        private string mPeriod_Starting_Of_Instalment;
        private string mYear_Starting_Of_Instalment;
        private int mInstalment_Amount_Per_Month;
        private string mInstalment_Payment_Type;
        private string mInstalment_Card_Type;
        private string mInstalment_Bank;
        private DateTime mInstalment_Cheque_Giro_Due_Date;
        private string mDefault_Collector_Id;
        private string mVisit_Date;
        private string mDeliver_From_Warehouse_Id;
        private int mLast_Shipment_Num;
        private DateTime mRequest_Delivery_Date;
        private string mInvoice_Status;
        private string mCancel_Reason;
        private string mCancel_By;
        private DateTime mCancel_Date;
        private int mTax_Ppn_Bm;
        private string mReturn_No;
        private int mTot_Su_Cash;
        private string mJournal_Gross_Sales;
        private string mJournal_Bonus;
        private string mJournal_Disc1;
        private string mJournal_Other_Disc;
        private string mStatus_Of_Delivery;
        private string mJenis_Set;
        private string mNo_Commission_Sv_Slip;
        private DateTime mCommission_Sv_Process_Date;
        private int mCommission_Sv_Gross_Amount;
        private int mCommission_Sv_Tax;
        private string mTax_Siq;
        private string mTax_No_Perusahaan;
        private string mTax_No_Invoice;
        private string mTax_Retur_Invoice;
        private int mExtra_Incentive;
        private string mGrouping_Prd_Id;
        private int mSet_Group_Cash_Value;
        private int mSet_Group_Comm_Value;
        private int mTotal_Allocation_Group_Value;
        private int mTot_Dpp;
        private int mTot_Ppn;
        private int mTot_Tirapoin;
        private string mUpload_Flag;
        private DateTime mUpload_Date;
        private DateTime mPeriod_Week_From;
        private DateTime mPeriod_Week_To;
        private string mIs_Ecommerce;
        private string mEcommerce_Id;
        private int mTotal_Point_3;
        private int mCommission_Du;
        private string mShp_Sap_Mp;
        private string mOdt_Src;
        private int mOrder_Source;
        private string mKp_Replacement;
        private string mKp_Type;
        private string mStatus_Of_Verification;
        private string mSender;
        private string mPayment_Type_List;
        private string mFlag_Dm;
        private string mFlag_Office;
        private string mFlag_Prd_Ba;
        private int mCommission_Cwh_Ba;
        private string mIs_Epc_Dm;
        private string mStatus_Shipment;
        private int mTotal_Point_4;
        private int mCommission_Fu;

        public string Invoice_Number { get => mInvoice_Number; set => mInvoice_Number = value; }
        public DateTime Invoice_Date { get => mInvoice_Date; set => mInvoice_Date = value; }
        public string Kp_Number { get => mKp_Number; set => mKp_Number = value; }
        public DateTime Kp_Date { get => mKp_Date; set => mKp_Date = value; }
        public string Entity_Id { get => mEntity_Id; set => mEntity_Id = value; }
        public string Branch_Id { get => mBranch_Id; set => mBranch_Id = value; }
        public string Division_Id { get => mDivision_Id; set => mDivision_Id = value; }
        public string Rep_Id { get => mRep_Id; set => mRep_Id = value; }
        public string Recruiter_Id { get => mRecruiter_Id; set => mRecruiter_Id = value; }
        public string Mgr_Rep_Id { get => mMgr_Rep_Id; set => mMgr_Rep_Id = value; }
        public string Order_Type { get => mOrder_Type; set => mOrder_Type = value; }
        public string Invoice_Type { get => mInvoice_Type; set => mInvoice_Type = value; }
        public string Customer_Id { get => mCustomer_Id; set => mCustomer_Id = value; }
        public string Customer_Name { get => mCustomer_Name; set => mCustomer_Name = value; }
        public string Customer_Address1 { get => mCustomer_Address1; set => mCustomer_Address1 = value; }
        public string Customer_Address2 { get => mCustomer_Address2; set => mCustomer_Address2 = value; }
        public string Customer_Address3 { get => mCustomer_Address3; set => mCustomer_Address3 = value; }
        public string Rt { get => mRt; set => mRt = value; }
        public string Rw { get => mRw; set => mRw = value; }
        public string Kelurahan { get => mKelurahan; set => mKelurahan = value; }
        public string Kecamatan { get => mKecamatan; set => mKecamatan = value; }
        public string Zipcode { get => mZipcode; set => mZipcode = value; }
        public string City { get => mCity; set => mCity = value; }
        public string Province { get => mProvince; set => mProvince = value; }
        public string Area_Code { get => mArea_Code; set => mArea_Code = value; }
        public string Sales_Type { get => mSales_Type; set => mSales_Type = value; }
        public string Payment_Type { get => mPayment_Type; set => mPayment_Type = value; }
        public string Price_List_Id { get => mPrice_List_Id; set => mPrice_List_Id = value; }
        public string Discount_Id { get => mDiscount_Id; set => mDiscount_Id = value; }
        public string Invoice_Print_Status { get => mInvoice_Print_Status; set => mInvoice_Print_Status = value; }
        public int No_Invoice_Copy_Printed { get => mNo_Invoice_Copy_Printed; set => mNo_Invoice_Copy_Printed = value; }
        public string Interface_To_Ar { get => mInterface_To_Ar; set => mInterface_To_Ar = value; }
        public string Sales_Gl_Txn { get => mSales_Gl_Txn; set => mSales_Gl_Txn = value; }
        public DateTime Last_Update { get => mLast_Update; set => mLast_Update = value; }
        public string Individual_Commission { get => mIndividual_Commission; set => mIndividual_Commission = value; }
        public string No_Commission_Slip { get => mNo_Commission_Slip; set => mNo_Commission_Slip = value; }
        public DateTime Commission_Process_Date { get => mCommission_Process_Date; set => mCommission_Process_Date = value; }
        public int Commission_Gross_Amount { get => mCommission_Gross_Amount; set => mCommission_Gross_Amount = value; }
        public int Commission_Cwh { get => mCommission_Cwh; set => mCommission_Cwh = value; }
        public int Commission_Tax { get => mCommission_Tax; set => mCommission_Tax = value; }
        public int Commission_Lain { get => mCommission_Lain; set => mCommission_Lain = value; }
        public string Invoice_Desc { get => mInvoice_Desc; set => mInvoice_Desc = value; }
        public int No_Detail_Lines { get => mNo_Detail_Lines; set => mNo_Detail_Lines = value; }
        public int Total_Item_Set_Qty { get => mTotal_Item_Set_Qty; set => mTotal_Item_Set_Qty = value; }
        public int Total_Su { get => mTotal_Su; set => mTotal_Su = value; }
        public int Total_Bv { get => mTotal_Bv; set => mTotal_Bv = value; }
        public int Total_Pv { get => mTotal_Pv; set => mTotal_Pv = value; }
        public int Total_Point_1 { get => mTotal_Point_1; set => mTotal_Point_1 = value; }
        public int Total_Point_2 { get => mTotal_Point_2; set => mTotal_Point_2 = value; }
        public int Unit_Price { get => mUnit_Price; set => mUnit_Price = value; }
        public int Total_Gross_Sales { get => mTotal_Gross_Sales; set => mTotal_Gross_Sales = value; }
        public int Total_Disc_Amount { get => mTotal_Disc_Amount; set => mTotal_Disc_Amount = value; }
        public int Total_Line_Amount { get => mTotal_Line_Amount; set => mTotal_Line_Amount = value; }
        public int Total_Bonus_Discount { get => mTotal_Bonus_Discount; set => mTotal_Bonus_Discount = value; }
        public int Total_Taxable_Amount { get => mTotal_Taxable_Amount; set => mTotal_Taxable_Amount = value; }
        public int Inv_Disc { get => mInv_Disc; set => mInv_Disc = value; }
        public int Inv_Disc_Amount { get => mInv_Disc_Amount; set => mInv_Disc_Amount = value; }
        public int Other_Disc_Amount { get => mOther_Disc_Amount; set => mOther_Disc_Amount = value; }
        public int Total_Inv_Amount { get => mTotal_Inv_Amount; set => mTotal_Inv_Amount = value; }
        public int Total_Taxable_Inv { get => mTotal_Taxable_Inv; set => mTotal_Taxable_Inv = value; }
        public int Total_Ppn_Amount { get => mTotal_Ppn_Amount; set => mTotal_Ppn_Amount = value; }
        public int Tax_Ppn_Gov { get => mTax_Ppn_Gov; set => mTax_Ppn_Gov = value; }
        public int Tax_Ppn_Amount { get => mTax_Ppn_Amount; set => mTax_Ppn_Amount = value; }
        public int Total_Cost { get => mTotal_Cost; set => mTotal_Cost = value; }
        public int Card_Charge { get => mCard_Charge; set => mCard_Charge = value; }
        public int Stamp_Charge { get => mStamp_Charge; set => mStamp_Charge = value; }
        public int Delivery_Charge { get => mDelivery_Charge; set => mDelivery_Charge = value; }
        public int Other_Charge { get => mOther_Charge; set => mOther_Charge = value; }
        public int Dp_Amount { get => mDp_Amount; set => mDp_Amount = value; }
        public string Dp_Payment_Type { get => mDp_Payment_Type; set => mDp_Payment_Type = value; }
        public string Dp_Cheque_Giro_No { get => mDp_Cheque_Giro_No; set => mDp_Cheque_Giro_No = value; }
        public string Dp_Card_Type { get => mDp_Card_Type; set => mDp_Card_Type = value; }
        public string Dp_Bank { get => mDp_Bank; set => mDp_Bank = value; }
        public DateTime Cheque_Giro_Due_Date { get => mCheque_Giro_Due_Date; set => mCheque_Giro_Due_Date = value; }
        public int Cod_Amount { get => mCod_Amount; set => mCod_Amount = value; }
        public string Cod_Payment_Type { get => mCod_Payment_Type; set => mCod_Payment_Type = value; }
        public string Cod_Cheque_Giro_Num { get => mCod_Cheque_Giro_Num; set => mCod_Cheque_Giro_Num = value; }
        public string Cod_Card_Type { get => mCod_Card_Type; set => mCod_Card_Type = value; }
        public string Cod_Bank { get => mCod_Bank; set => mCod_Bank = value; }
        public DateTime Cod_Cheque_Giro_Due_Date { get => mCod_Cheque_Giro_Due_Date; set => mCod_Cheque_Giro_Due_Date = value; }
        public int No_Of_Instalments { get => mNo_Of_Instalments; set => mNo_Of_Instalments = value; }
        public DateTime Billing_Date { get => mBilling_Date; set => mBilling_Date = value; }
        public string Period_Starting_Of_Instalment { get => mPeriod_Starting_Of_Instalment; set => mPeriod_Starting_Of_Instalment = value; }
        public string Year_Starting_Of_Instalment { get => mYear_Starting_Of_Instalment; set => mYear_Starting_Of_Instalment = value; }
        public int Instalment_Amount_Per_Month { get => mInstalment_Amount_Per_Month; set => mInstalment_Amount_Per_Month = value; }
        public string Instalment_Payment_Type { get => mInstalment_Payment_Type; set => mInstalment_Payment_Type = value; }
        public string Instalment_Card_Type { get => mInstalment_Card_Type; set => mInstalment_Card_Type = value; }
        public string Instalment_Bank { get => mInstalment_Bank; set => mInstalment_Bank = value; }
        public DateTime Instalment_Cheque_Giro_Due_Date { get => mInstalment_Cheque_Giro_Due_Date; set => mInstalment_Cheque_Giro_Due_Date = value; }
        public string Default_Collector_Id { get => mDefault_Collector_Id; set => mDefault_Collector_Id = value; }
        public string Visit_Date { get => mVisit_Date; set => mVisit_Date = value; }
        public string Deliver_From_Warehouse_Id { get => mDeliver_From_Warehouse_Id; set => mDeliver_From_Warehouse_Id = value; }
        public int Last_Shipment_Num { get => mLast_Shipment_Num; set => mLast_Shipment_Num = value; }
        public DateTime Request_Delivery_Date { get => mRequest_Delivery_Date; set => mRequest_Delivery_Date = value; }
        public string Invoice_Status { get => mInvoice_Status; set => mInvoice_Status = value; }
        public string Cancel_Reason { get => mCancel_Reason; set => mCancel_Reason = value; }
        public string Cancel_By { get => mCancel_By; set => mCancel_By = value; }
        public DateTime Cancel_Date { get => mCancel_Date; set => mCancel_Date = value; }
        public int Tax_Ppn_Bm { get => mTax_Ppn_Bm; set => mTax_Ppn_Bm = value; }
        public string Return_No { get => mReturn_No; set => mReturn_No = value; }
        public int Tot_Su_Cash { get => mTot_Su_Cash; set => mTot_Su_Cash = value; }
        public string Journal_Gross_Sales { get => mJournal_Gross_Sales; set => mJournal_Gross_Sales = value; }
        public string Journal_Bonus { get => mJournal_Bonus; set => mJournal_Bonus = value; }
        public string Journal_Disc1 { get => mJournal_Disc1; set => mJournal_Disc1 = value; }
        public string Journal_Other_Disc { get => mJournal_Other_Disc; set => mJournal_Other_Disc = value; }
        public string Status_Of_Delivery { get => mStatus_Of_Delivery; set => mStatus_Of_Delivery = value; }
        public string Jenis_Set { get => mJenis_Set; set => mJenis_Set = value; }
        public string No_Commission_Sv_Slip { get => mNo_Commission_Sv_Slip; set => mNo_Commission_Sv_Slip = value; }
        public DateTime Commission_Sv_Process_Date { get => mCommission_Sv_Process_Date; set => mCommission_Sv_Process_Date = value; }
        public int Commission_Sv_Gross_Amount { get => mCommission_Sv_Gross_Amount; set => mCommission_Sv_Gross_Amount = value; }
        public int Commission_Sv_Tax { get => mCommission_Sv_Tax; set => mCommission_Sv_Tax = value; }
        public string Tax_Siq { get => mTax_Siq; set => mTax_Siq = value; }
        public string Tax_No_Perusahaan { get => mTax_No_Perusahaan; set => mTax_No_Perusahaan = value; }
        public string Tax_No_Invoice { get => mTax_No_Invoice; set => mTax_No_Invoice = value; }
        public string Tax_Retur_Invoice { get => mTax_Retur_Invoice; set => mTax_Retur_Invoice = value; }
        public int Extra_Incentive { get => mExtra_Incentive; set => mExtra_Incentive = value; }
        public string Grouping_Prd_Id { get => mGrouping_Prd_Id; set => mGrouping_Prd_Id = value; }
        public int Set_Group_Cash_Value { get => mSet_Group_Cash_Value; set => mSet_Group_Cash_Value = value; }
        public int Set_Group_Comm_Value { get => mSet_Group_Comm_Value; set => mSet_Group_Comm_Value = value; }
        public int Total_Allocation_Group_Value { get => mTotal_Allocation_Group_Value; set => mTotal_Allocation_Group_Value = value; }
        public int Tot_Dpp { get => mTot_Dpp; set => mTot_Dpp = value; }
        public int Tot_Ppn { get => mTot_Ppn; set => mTot_Ppn = value; }
        public int Tot_Tirapoin { get => mTot_Tirapoin; set => mTot_Tirapoin = value; }
        public string Upload_Flag { get => mUpload_Flag; set => mUpload_Flag = value; }
        public DateTime Upload_Date { get => mUpload_Date; set => mUpload_Date = value; }
        public DateTime Period_Week_From { get => mPeriod_Week_From; set => mPeriod_Week_From = value; }
        public DateTime Period_Week_To { get => mPeriod_Week_To; set => mPeriod_Week_To = value; }
        public string Is_Ecommerce { get => mIs_Ecommerce; set => mIs_Ecommerce = value; }
        public string Ecommerce_Id { get => mEcommerce_Id; set => mEcommerce_Id = value; }
        public int Total_Point_3 { get => mTotal_Point_3; set => mTotal_Point_3 = value; }
        public int Commission_Du { get => mCommission_Du; set => mCommission_Du = value; }
        public string Shp_Sap_Mp { get => mShp_Sap_Mp; set => mShp_Sap_Mp = value; }
        public string Odt_Src { get => mOdt_Src; set => mOdt_Src = value; }
        public int Order_Source { get => mOrder_Source; set => mOrder_Source = value; }
        public string Kp_Replacement { get => mKp_Replacement; set => mKp_Replacement = value; }
        public string Kp_Type { get => mKp_Type; set => mKp_Type = value; }
        public string Status_Of_Verification { get => mStatus_Of_Verification; set => mStatus_Of_Verification = value; }
        public string Sender { get => mSender; set => mSender = value; }
        public string Payment_Type_List { get => mPayment_Type_List; set => mPayment_Type_List = value; }
        public string Flag_Dm { get => mFlag_Dm; set => mFlag_Dm = value; }
        public string Flag_Office { get => mFlag_Office; set => mFlag_Office = value; }
        public string Flag_Prd_Ba { get => mFlag_Prd_Ba; set => mFlag_Prd_Ba = value; }
        public int Commission_Cwh_Ba { get => mCommission_Cwh_Ba; set => mCommission_Cwh_Ba = value; }
        public string Is_Epc_Dm { get => mIs_Epc_Dm; set => mIs_Epc_Dm = value; }
        public string Status_Shipment { get => mStatus_Shipment; set => mStatus_Shipment = value; }
        public int Total_Point_4 { get => mTotal_Point_4; set => mTotal_Point_4 = value; }
        public int Commission_Fu { get => mCommission_Fu; set => mCommission_Fu = value; }
    }
}
