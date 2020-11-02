using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.AR
{
    public class ARListKuitansiSlipUnprocessAllBL
    {
        private bool Is_selected;
        private string ai_entity_id;
        private string ai_branch_id;
        private string ai_division_id;
        private string ai_customer_id;
        private string Kp;
        private string Invoice;
        private string Total_out;
        private string Instalments;
        private string Lastkw;
        private string Instalments_per_amount;
        private string Due_date;
        private string Inv_date;
        private string Kw_date;
        private string Seq_number;
        private string Type;
        private string Dateofbilling;
        private string Invoice_date;
        private string Kw_period;

        public bool is_selected { get => Is_selected; set => Is_selected = value; }
        public string entity_id { get => ai_entity_id; set => ai_entity_id = value; }
        public string branch_id { get => ai_branch_id; set => ai_branch_id = value; }
        public string division_id { get => ai_division_id; set => ai_division_id = value; }
        public string customer_id { get => ai_customer_id; set => ai_customer_id = value; }
        public string kp { get => Kp; set => Kp = value; }
        public string invoice { get => Invoice; set => Invoice = value; }
        public string total_out { get => Total_out; set => Total_out = value; }
        public string instalments { get => Instalments; set => Instalments = value; }
        public string lastkw { get => Lastkw; set => Lastkw = value; }
        public string instalments_per_amount { get => Instalments_per_amount; set => Instalments_per_amount = value; }
        public string due_date { get => Due_date; set => Due_date = value; }
        public string inv_date { get => Inv_date; set => Inv_date = value; }
        public string kw_date { get => Kw_date; set => Kw_date = value; }
        public string seq_number { get => Seq_number; set => Seq_number = value; }
        public string type { get => Type; set => Type = value; }
        public string dateofbilling { get => Dateofbilling; set => Dateofbilling = value; }
        public string invoice_date { get => Invoice_date; set => Invoice_date = value; }
        public string kw_period { get => Kw_period; set => Kw_period = value; }
    }
}
