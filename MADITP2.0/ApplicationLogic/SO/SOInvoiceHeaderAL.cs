using MADITP2._0.DataAccess.SO;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.ApplicationLogic.SO
{
    class SOInvoiceHeaderAL
    {
        private clsGlobal Helper;
        private string reason;
        private SOInvoiceHeaderDA Accessor;

        public SOInvoiceHeaderAL(clsGlobal helper)
        {
            Helper = helper;
            Accessor = new SOInvoiceHeaderDA(Helper);
        }

        public bool CreateNewInvoice(string Division, string KpNumber, DateTime InvoiceDate, string User)
        {
            if (string.IsNullOrEmpty(Division))
            {
                Reason = "Division is required to generate invoice";
                return false;
            }

            if (string.IsNullOrEmpty(KpNumber))
            {
                Reason = "KP Number is required to generate invoice";
                return false;
            }

            if (InvoiceDate == DateTime.MinValue)
            {
                Reason = "Invoice Date is required to generate invoice";
                return false;
            }

            if (string.IsNullOrEmpty(User))
            {
                Reason = "User ID not found!";
                return false;
            }

            bool Info = Accessor.CreateNewInvoice(Division, KpNumber, InvoiceDate, User);
            if(!Info)
            {
                Reason = Accessor.Reason;
            }

            return Info;
        }

        public string Reason { get => reason; set => reason = value; }

        public DataTable CheckInvoiceInterfacing(string KpNumber)
        {
            return Accessor.CheckInvoiceInterfacing(KpNumber);
        }

        public DataTableCollection CheckARBalance(string InvoiceNumber, string InvoiceType)
        {
            return Accessor.CheckARBalance(InvoiceNumber, InvoiceType);
        }

        public DataTableCollection ProcessARInterface(
            string InvoiceNumber, string KpNumber, 
            string User, DateTime InvoiceDate, 
            string Entity, string Branch, 
            string Division, string CustomerID, 
            double InvAmt)
        {
            string SqlStr = "UPDATE AR_BALANCE";
            if(InvAmt > 0)
            {
                SqlStr = SqlStr + $" ab_invoice_ = isnull(ab_invoice_{InvoiceDate.ToString("MM")},0) " +
                    "+ " + InvAmt;
            } 
            else
            {
                SqlStr = SqlStr + $" ab_return_ = isnull(ab_return_{InvoiceDate.ToString("MM")},0) " +
                    "+ " + InvAmt;
            }
            SqlStr = SqlStr + $" where ";

            return Accessor.ProcessARInterface(
                InvoiceNumber, KpNumber, 
                User, InvoiceDate.ToString("yyyy"), 
                Entity, Branch, 
                Division, CustomerID, 
                SqlStr);
        }
    }
}
