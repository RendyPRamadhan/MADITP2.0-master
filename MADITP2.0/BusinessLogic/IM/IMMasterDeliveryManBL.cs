using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.IM
{
    class IMMasterDeliveryManBL
    {
        private string entity_id;
        private string branch_id;
        private string divison_id;
        private string delivery_man_id;
        private string delivery_man_name;
        private string short_name;
        private string sim_number;
        private string vehicle_police_number;
        private DateTime entry_last_update_date;
        private string user_id;

        public string Entity_id { get => entity_id; set => entity_id = value; }
        public string Branch_id { get => branch_id; set => branch_id = value; }
        public string Divison_id { get => divison_id; set => divison_id = value; }
        public string Delivery_man_id { get => delivery_man_id; set => delivery_man_id = value; }
        public string Delivery_man_name { get => delivery_man_name; set => delivery_man_name = value; }
        public string Short_name { get => short_name; set => short_name = value; }
        public string Sim_number { get => sim_number; set => sim_number = value; }
        public string Vehicle_police_number { get => vehicle_police_number; set => vehicle_police_number = value; }
        public string User_id { get => user_id; set => user_id = value; }
        public DateTime Entry_last_update_date { get => entry_last_update_date; set => entry_last_update_date = value; }
    }
}
