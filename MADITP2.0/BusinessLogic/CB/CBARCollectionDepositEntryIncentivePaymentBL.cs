using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.CB
{
    class CBARCollectionDepositEntryIncentivePaymentBL
    {
        //Private mvarGLTax As New clsGLAccountDescription 'local copy
        //Private mvarGLCWH As New clsGLAccountDescription 'local copy

        public string varEntity { get; set; }
        public string varBranch { get; set; }
        public string varDivision { get; set; }
        public string varCommisionId { get; set; }
        public Double varValues { get; set; }
        public Double varValuesTax { get; set; }
        public Double varValuesCWH { get; set; }

        public CBARCollectionDepositEntryGLAccountDescription varGL = new CBARCollectionDepositEntryGLAccountDescription();
        public CBARCollectionDepositEntryGLAccountDescription varGLTax = new CBARCollectionDepositEntryGLAccountDescription();
        public CBARCollectionDepositEntryGLAccountDescription varGLCWH = new CBARCollectionDepositEntryGLAccountDescription();
    }
}
