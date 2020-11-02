using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARPrintKuitansiSementaraBL
    {
        private string No_invoice;
        private string Customer_name;
        private string Customer_id;
        private string Company_address;
        private string Address1;
        private string Address2;
        private string Address3;
        private string Telephone;
        private string Fax;
        private string Jumlah;
        private string Keterangan;
        private string EntityID;
        private string BranchID;
        private string RepID;
        private string RepName;
        private string Email;
        private string BranchName;

        public string no_invoice { get => No_invoice; set => No_invoice = value; }
        public string customer_name { get => Customer_name; set => Customer_name = value; }
        public string customer_id { get => Customer_id; set => Customer_id = value; }
        public string company_address { get => Company_address; set => Company_address = value; }
        public string address1 { get => Address1; set => Address1 = value; }
        public string address2 { get => Address2; set => Address2 = value; }
        public string address3 { get => Address3; set => Address3 = value; }
        public string telephone { get => Telephone; set => Telephone = value; }
        public string fax { get => Fax; set => Fax = value; }
        public string jumlah { get => Jumlah; set => Jumlah = value; }
        public string keterangan { get => Keterangan; set => Keterangan = value; }
        public string entity_id { get => EntityID; set => EntityID = value; }
        public string branch_id { get => BranchID; set => BranchID = value; }
        public string rep_id { get => RepID; set => RepID = value; }
        public string rep_name { get => RepName; set => RepName = value; }
        public string email { get => Email; set => Email = value; }
        public string branch_name { get => BranchName; set => BranchName = value; }
    }
}
