using System;

namespace MADITP2._0.businessLogic.RC
{
    public class RCLevelEPCBO
    {
        private string m_position_id;
        private string m_group_id;

        public string position_id
        {
            get { return m_position_id; }
            set { this.m_position_id = value; }
        }

        public string group_id
        {
            get { return m_group_id; }
            set { this.m_group_id = value; }
        }

       
    }
}
