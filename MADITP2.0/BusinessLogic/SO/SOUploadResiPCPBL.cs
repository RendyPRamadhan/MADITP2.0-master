using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOUploadResiPCPBL
    {
        private string warehouse_id;
        private string period;

        private string Awb_No;
        private string Ref_No;
        private string Account_Id;
        private string Input_Date;
        private string ShipType_Id;
        private string Payment;
        private string Province_Id;
        private string City_Id;
        private string Origin_Id;
        private string Destination_Id;
        private string Service_Id;
        private string Content_Id;
        private string Goods_Id;
        private string Coli;
        private string Actual_Weight;
        private string Gross_Weight;
        private string Special_Instructions;
        private string Goods_Value;
        private string Use_UseInsurance;
        private string Handling_Id;
        private string Remark_Surcharge;
        private string Shipper_Name;
        private string Shipper_Address1;
        private string Shipper_Address2;
        private string Shipper_Address3;
        private string Shipper_Telphone1;
        private string Shipper_Telphone2;
        private string Shipper_Email;
        private string Shipper_Fax_No;

        private string Shipper_Contact;
        private string Shipper_Zip_Code;
        private string Receiver_Name;
        private string Receiver_Address1;
        private string Receiver_Address2;
        private string Receiver_Address3;
        private string Receiver_Telphone1;
        private string Receiver_Telphone2;
        private string Receiver_Email;
        private string Receiver_Fax_No;
        private string Receiver_Contact;
        private string Receiver_Zip_Code;
        private string Courier_Id;
        private string Helper_Id;
        private string Pickup_Date;
        private string TimePickupId;
        private string Pickup_Description;

        public string AWB_NO { get => Awb_No; set => Awb_No = value; }
        public string REF_NO { get => Ref_No; set => Ref_No = value; }

        public string ACCOUNT_ID { get => Account_Id; set => Account_Id = value; }
        public string INPUT_DATE { get => Input_Date; set => Input_Date = value; }
        public string SHIPTYPE_ID { get => ShipType_Id; set => ShipType_Id = value; }
        public string PAYMENT { get => Payment; set => Payment = value; }
        public string PROVINCE_ID { get => Province_Id; set => Province_Id = value; }
        public string CITY_ID { get => City_Id; set => City_Id = value; }
        public string ORIGIN_ID { get => Origin_Id; set => Origin_Id = value; }
        public string DESTINATION_ID { get => Destination_Id; set => Destination_Id = value; }
        public string SERVICE_ID { get => Service_Id; set => Service_Id = value; }
        public string CONTENT_ID { get => Content_Id; set => Content_Id = value; }
        public string GOODS_ID { get => Goods_Id; set => Goods_Id = value; }
        public string COLI { get => Coli; set => Coli = value; }
        public string ACTUAL_WEIGHT { get => Actual_Weight; set => Actual_Weight = value; }
        public string GROSS_WEIGHT { get => Gross_Weight; set => Gross_Weight = value; }
        public string SPECIAL_INSTRUCTIONS { get => Special_Instructions; set => Special_Instructions = value; }
        public string GOODS_VALUE { get => Goods_Value; set => Goods_Value = value; }
        public string USE_USEINSURANCE { get => Use_UseInsurance; set => Use_UseInsurance = value; }
        public string HANDLING_ID { get => Handling_Id; set => Handling_Id = value; }
        public string REMARK_SURCHARGE { get => Remark_Surcharge; set => Remark_Surcharge = value; }
        public string SHIPPER_NAME { get => Shipper_Name; set => Shipper_Name = value; }
        public string SHIPPER_ADDRESS1 { get => Shipper_Address1; set => Shipper_Address1 = value; }
        public string SHIPPER_ADDRESS2 { get => Shipper_Address2; set => Shipper_Address2 = value; }
        public string SHIPPER_ADDRESS3 { get => Shipper_Address3; set => Shipper_Address3 = value; }
        public string SHIPPER_TELPHONE1 { get => Shipper_Telphone1; set => Shipper_Telphone1 = value; }
        public string SHIPPER_TELPHONE2 { get => Shipper_Telphone2; set => Shipper_Telphone2 = value; }
        public string SHIPPER_EMAIL { get => Shipper_Email; set => Shipper_Email = value; }
        public string SHIPPER_FAX_NO { get => Shipper_Fax_No; set => Shipper_Fax_No = value; }
        public string SHIPPER_CONTACT { get => Shipper_Contact; set => Shipper_Contact = value; }
        public string SHIPPER_ZIP_CODE { get => Shipper_Zip_Code; set => Shipper_Zip_Code = value; }
        public string RECEIVER_NAME { get => Receiver_Name; set => Receiver_Name = value; }
        public string RECEIVER_ADDRESS1 { get => Receiver_Address1; set => Receiver_Address1 = value; }
        public string RECEIVER_ADDRESS2 { get => Receiver_Address2; set => Receiver_Address2 = value; }
        public string ReceIver_Address3 { get => Receiver_Address3; set => Receiver_Address3 = value; }
        public string RECEIVER_TELPHONE1 { get => Receiver_Telphone1; set => Receiver_Telphone1 = value; }
        public string RECEIVER_TELPHONE2 { get => Receiver_Telphone2; set => Receiver_Telphone2 = value; }
        public string RECEIVER_EMAIL { get => Receiver_Email; set => Receiver_Email = value; }
        public string RECEIVER_FAX_NO { get => Receiver_Fax_No; set => Receiver_Fax_No = value; }
        public string RECEIVER_CONTACT { get => Receiver_Contact; set => Receiver_Contact = value; }
        public string RECEIVER_ZIP_CODE { get => Receiver_Zip_Code; set => Receiver_Zip_Code = value; }
        public string COURIER_ID { get => Courier_Id; set => Courier_Id = value; }
        public string HELPER_ID { get => Helper_Id; set => Helper_Id = value; }
        public string PICKUP_DATE { get => Pickup_Date; set => Pickup_Date = value; }
        public string TIMEPICKUPID { get => TimePickupId; set => TimePickupId = value; }
        public string PICKUP_DESCRIPTION { get => Pickup_Description; set => Pickup_Description = value; }

        public string WAREHOUSE_ID { get => warehouse_id; set => warehouse_id = value; }
        public string PERIOD { get => period; set => period = value; }

    }
}
