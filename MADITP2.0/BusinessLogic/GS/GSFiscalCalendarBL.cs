using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.businessLogic.GS
{
    public class GSFiscalCalendarBL
    {
        private string gfc_group_id;
        private string gfc_fiscal_year;
        private int gfc_period;
        private DateTime? gfc_begining_date;
        private DateTime? gfc_ending_date;
        private int gfc_no_of_days;
        private string gfc_period_status;
        private DateTime? gfc_actual_closed;
        private string gfc_entity_id;
        private string gfc_save_struktur;
        private string gfc_save_level;

        public string group_id { get => gfc_group_id; set => gfc_group_id = value; }
        public string fiscal_year { get => gfc_fiscal_year; set => gfc_fiscal_year = value; }
        public int period { get => gfc_period; set => gfc_period = value; }
        public DateTime? begining_date { get => gfc_begining_date; set => gfc_begining_date = value; }
        public DateTime? ending_date { get => gfc_ending_date; set => gfc_ending_date = value; }
        public int no_of_days { get => gfc_no_of_days; set => gfc_no_of_days = value; }
        public string period_status { get => gfc_period_status; set => gfc_period_status = value; }
        public DateTime? actual_closed { get => gfc_actual_closed; set => gfc_actual_closed = value; }
        public string entity_id { get => gfc_entity_id; set => gfc_entity_id = value; }
        public string save_struktur { get => gfc_save_struktur; set => gfc_save_struktur = value; }
        public string save_level { get => gfc_save_level; set => gfc_save_level = value; }
    }
}
