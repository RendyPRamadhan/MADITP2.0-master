using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    class SOMasterCustomerBL
    {
        private string mCustomer_Id;
        private string mEntity_Id;
        private string mBranch_Id;
        private string mDivision_Id;
        private string mCustomer_Active_Flag;
        private string mCustomer_Type;
        private string mFirst_Rep_Id;
        private string mCustomer_Name;
        private string mShort_Name;
        private string mAddress1;
        private string mAddress2;
        private string mAddress3;
        private string mRt;
        private string mRw;
        private string mKelurahan;
        private string mZipcode;
        private string mArea_Code;
        private string mHome_Phone_Num;
        private string mMobile_Phone_Num;
        private string mEmail_Address;
        private string mSex;
        private int mMarital_Status;
        private DateTime mDate_Of_Birth;
        private int mReligious;
        private string mCitizen_Ship;
        private string mKtp_Num;
        private string mSim_Num;
        private int mLast_Formal_Education_Lev;
        private string mGraduated_Flag;
        private string mYear_Of_Graduated;
        private int mLanguage_Ability_1;
        private int mLanguage_Ability_2;
        private string mLast_Employer_Name;
        private string mLength_Of_Service;
        private string mEmployer_Address1;
        private string mEmployer_Address2;
        private string mEmployer_Address3;
        private string mEmployer_City;
        private string mEmployer_Province;
        private string mBilling_Address_Code;
        private string mCorrespondence_Address_Code;
        private string mDelivery_Address_Code;
        private string mRep_Id;
        private string mCustomer_Group;
        private string mFirst_Order_Num;
        private DateTime mFirst_Order_Date;
        private DateTime mFirst_Invoice_Date;
        private string mLast_Order_Num;
        private DateTime mLast_Order_Date;
        private DateTime mLast_Invoice_Date;
        private DateTime mEntry_Date;
        private string mEntry_By;
        private string mLast_Position;
        private string mEmployer_Phone;
        private string mCollector_Id;
        private string mDeliveryman_Man_Id;
        private DateTime mLastpayment;
        private string mClasification;
        private string mEmployer_Zip_Code;
        private DateTime mLast_Activity;
        private string mNew_Home_Phone;
        private string mNew_Hp;
        private string mNew_Off_Phone;
        private string mNew_Addr1;
        private string mNew_Addr2;
        private string mNew_Addr3;
        private string mBm;
        private string mLast_Act;
        private string mFlag_Tradein;
        private DateTime mTgl_Tradein;
        private string mCorres_Address_Sts;
        private string mBilling_Address_Sts;
        private string mVisa_Auto;
        private string mGrade;
        private string mNpwp;
        private int mWeb_Subdistrict_Id;
        private int mCity_Id;
        private string mRedundant_Id;
        private string mFlag_Redundant;
        private string mSchema_Epc;

        public string Customer_Id { get => mCustomer_Id; set => mCustomer_Id = value; }
        public string Entity_Id { get => mEntity_Id; set => mEntity_Id = value; }
        public string Branch_Id { get => mBranch_Id; set => mBranch_Id = value; }
        public string Division_Id { get => mDivision_Id; set => mDivision_Id = value; }
        public string Customer_Active_Flag { get => mCustomer_Active_Flag; set => mCustomer_Active_Flag = value; }
        public string Customer_Type { get => mCustomer_Type; set => mCustomer_Type = value; }
        public string First_Rep_Id { get => mFirst_Rep_Id; set => mFirst_Rep_Id = value; }
        public string Customer_Name { get => mCustomer_Name; set => mCustomer_Name = value; }
        public string Short_Name { get => mShort_Name; set => mShort_Name = value; }
        public string Address1 { get => mAddress1; set => mAddress1 = value; }
        public string Address2 { get => mAddress2; set => mAddress2 = value; }
        public string Address3 { get => mAddress3; set => mAddress3 = value; }
        public string Rt { get => mRt; set => mRt = value; }
        public string Rw { get => mRw; set => mRw = value; }
        public string Kelurahan { get => mKelurahan; set => mKelurahan = value; }
        public string Zipcode { get => mZipcode; set => mZipcode = value; }
        public string Area_Code { get => mArea_Code; set => mArea_Code = value; }
        public string Home_Phone_Num { get => mHome_Phone_Num; set => mHome_Phone_Num = value; }
        public string Mobile_Phone_Num { get => mMobile_Phone_Num; set => mMobile_Phone_Num = value; }
        public string Email_Address { get => mEmail_Address; set => mEmail_Address = value; }
        public string Sex { get => mSex; set => mSex = value; }
        public int Marital_Status { get => mMarital_Status; set => mMarital_Status = value; }
        public DateTime Date_Of_Birth { get => mDate_Of_Birth; set => mDate_Of_Birth = value; }
        public int Religious { get => mReligious; set => mReligious = value; }
        public string Citizen_Ship { get => mCitizen_Ship; set => mCitizen_Ship = value; }
        public string Ktp_Num { get => mKtp_Num; set => mKtp_Num = value; }
        public string Sim_Num { get => mSim_Num; set => mSim_Num = value; }
        public int Last_Formal_Education_Lev { get => mLast_Formal_Education_Lev; set => mLast_Formal_Education_Lev = value; }
        public string Graduated_Flag { get => mGraduated_Flag; set => mGraduated_Flag = value; }
        public string Year_Of_Graduated { get => mYear_Of_Graduated; set => mYear_Of_Graduated = value; }
        public int Language_Ability_1 { get => mLanguage_Ability_1; set => mLanguage_Ability_1 = value; }
        public int Language_Ability_2 { get => mLanguage_Ability_2; set => mLanguage_Ability_2 = value; }
        public string Last_Employer_Name { get => mLast_Employer_Name; set => mLast_Employer_Name = value; }
        public string Length_Of_Service { get => mLength_Of_Service; set => mLength_Of_Service = value; }
        public string Employer_Address1 { get => mEmployer_Address1; set => mEmployer_Address1 = value; }
        public string Employer_Address2 { get => mEmployer_Address2; set => mEmployer_Address2 = value; }
        public string Employer_Address3 { get => mEmployer_Address3; set => mEmployer_Address3 = value; }
        public string Employer_City { get => mEmployer_City; set => mEmployer_City = value; }
        public string Employer_Province { get => mEmployer_Province; set => mEmployer_Province = value; }
        public string Billing_Address_Code { get => mBilling_Address_Code; set => mBilling_Address_Code = value; }
        public string Correspondence_Address_Code { get => mCorrespondence_Address_Code; set => mCorrespondence_Address_Code = value; }
        public string Delivery_Address_Code { get => mDelivery_Address_Code; set => mDelivery_Address_Code = value; }
        public string Rep_Id { get => mRep_Id; set => mRep_Id = value; }
        public string Customer_Group { get => mCustomer_Group; set => mCustomer_Group = value; }
        public string First_Order_Num { get => mFirst_Order_Num; set => mFirst_Order_Num = value; }
        public DateTime First_Order_Date { get => mFirst_Order_Date; set => mFirst_Order_Date = value; }
        public DateTime First_Invoice_Date { get => mFirst_Invoice_Date; set => mFirst_Invoice_Date = value; }
        public string Last_Order_Num { get => mLast_Order_Num; set => mLast_Order_Num = value; }
        public DateTime Last_Order_Date { get => mLast_Order_Date; set => mLast_Order_Date = value; }
        public DateTime Last_Invoice_Date { get => mLast_Invoice_Date; set => mLast_Invoice_Date = value; }
        public DateTime Entry_Date { get => mEntry_Date; set => mEntry_Date = value; }
        public string Entry_By { get => mEntry_By; set => mEntry_By = value; }
        public string Last_Position { get => mLast_Position; set => mLast_Position = value; }
        public string Employer_Phone { get => mEmployer_Phone; set => mEmployer_Phone = value; }
        public string Collector_Id { get => mCollector_Id; set => mCollector_Id = value; }
        public string Deliveryman_Man_Id { get => mDeliveryman_Man_Id; set => mDeliveryman_Man_Id = value; }
        public DateTime Lastpayment { get => mLastpayment; set => mLastpayment = value; }
        public string Clasification { get => mClasification; set => mClasification = value; }
        public string Employer_Zip_Code { get => mEmployer_Zip_Code; set => mEmployer_Zip_Code = value; }
        public DateTime Last_Activity { get => mLast_Activity; set => mLast_Activity = value; }
        public string New_Home_Phone { get => mNew_Home_Phone; set => mNew_Home_Phone = value; }
        public string New_Hp { get => mNew_Hp; set => mNew_Hp = value; }
        public string New_Off_Phone { get => mNew_Off_Phone; set => mNew_Off_Phone = value; }
        public string New_Addr1 { get => mNew_Addr1; set => mNew_Addr1 = value; }
        public string New_Addr2 { get => mNew_Addr2; set => mNew_Addr2 = value; }
        public string New_Addr3 { get => mNew_Addr3; set => mNew_Addr3 = value; }
        public string Bm { get => mBm; set => mBm = value; }
        public string Last_Act { get => mLast_Act; set => mLast_Act = value; }
        public string Flag_Tradein { get => mFlag_Tradein; set => mFlag_Tradein = value; }
        public DateTime Tgl_Tradein { get => mTgl_Tradein; set => mTgl_Tradein = value; }
        public string Corres_Address_Sts { get => mCorres_Address_Sts; set => mCorres_Address_Sts = value; }
        public string Billing_Address_Sts { get => mBilling_Address_Sts; set => mBilling_Address_Sts = value; }
        public string Visa_Auto { get => mVisa_Auto; set => mVisa_Auto = value; }
        public string Grade { get => mGrade; set => mGrade = value; }
        public string Npwp { get => mNpwp; set => mNpwp = value; }
        public int Web_Subdistrict_Id { get => mWeb_Subdistrict_Id; set => mWeb_Subdistrict_Id = value; }
        public int City_Id { get => mCity_Id; set => mCity_Id = value; }
        public string Redundant_Id { get => mRedundant_Id; set => mRedundant_Id = value; }
        public string Flag_Redundant { get => mFlag_Redundant; set => mFlag_Redundant = value; }
        public string Schema_Epc { get => mSchema_Epc; set => mSchema_Epc = value; }
    }
}
