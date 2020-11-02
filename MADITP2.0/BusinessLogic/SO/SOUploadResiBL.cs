using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOUploadResiBL
    {
        private string nokp;
        private string branch;
        private string warehouse;
        private string delivery_man;
        private string kp_date;
        private string no_inv;
        private string inv_date;
        private string shipment_num;
        private string actual_delivery_date;

        private string noseq;
        private string noshp;
        private string resi;
        private string ekspedisi;

        private string cust_name;
        private string branch_id;
        private string warehouse_id;
        private string delivery_man_id;



        public string NOKP { get => nokp; set => nokp = value; }
        public string BRANCH { get => branch; set => branch = value; }
        public string WAREHOUSE { get => warehouse; set => warehouse = value; }
        public string DELIVERYMAN { get => delivery_man; set => delivery_man = value; }

        public string KP_DATE { get => kp_date; set => kp_date = value; }
        public string NO_INV { get => no_inv; set => no_inv = value; }
        public string INV_DATE { get => inv_date; set => inv_date = value; }
        public string NOSEQ { get => noseq; set => noseq = value; }
        public string ACT_DELIV_DATE { get => actual_delivery_date; set => actual_delivery_date = value; }
        
        public string NOSHP { get => noshp; set => noshp = value; }
        public string RESI { get => resi; set => resi = value; }
        public string EKSPEDISI { get => ekspedisi; set => ekspedisi = value; }
        public string CUST_NAME { get => cust_name; set => cust_name = value; }
        public string BRANCH_ID { get => branch_id; set => branch_id = value; }
        public string WAREHOUSE_ID { get => warehouse_id; set => warehouse_id = value; }
        public string DELIVERYMAN_ID { get => delivery_man_id; set => delivery_man_id = value; }



    }
}
