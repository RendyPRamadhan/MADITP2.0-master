using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.login
{
    class clsLogLoginBO
    {
        private clsLogin mlogin = new clsLogin();
        private string mket;
        private DateTime mlogdate;
        private string mlogsts;
        private string mip;
        private string mhost;
        private string mflag;
        private string mVersion;

        public clsLogin login
        {
            get { return mlogin; }
            set { this.mlogin = value; }
        }

        public string Keterangan
        {
            get { return mket; }
            set { this.mket = value; }
        }

        public DateTime LogDate
        {
            get { return mlogdate; }
            set { this.mlogdate = value; }
        }

        public string LogStatus
        {
            get { return mlogsts; }
            set { this.mlogsts = value; }
        }

        public string IP
        {
            get { return mip; }
            set { this.mip = value; }
        }

        public string Host
        {
            get { return mhost; }
            set { this.mhost = value; }
        }
        public string Flag
        {
            get { return mflag; }
            set { this.mflag = value; }
        }
        public string Version
        {
            get { return mVersion; }
            set { this.mVersion = value; }
        }

        public class BranchUser
        {
            private string aBranchID;
            private string aBranchDesc;
            public string BranchID
            {
                get { return aBranchID; }
                set { this.aBranchID = value; }
            }
            public string BracnhDesc
            {
                get { return aBranchDesc; }
                set { this.aBranchDesc = value; }
            }
        }
        public class EntityUser
        {
            private string aEntityID;
            private string aEntityDesc;
            public string EntityID
            {
                get { return aEntityID; }
                set { this.aEntityID = value; }
            }
            public string EntityDesc
            {
                get { return aEntityDesc; }
                set { this.aEntityDesc = value; }
            }
        }
    }

   
}
