using MADITP2._0.BusinessLogic.AR;
using MADITP2._0.DataAccess.AR;
using MADITP2._0.Global;
using System.Data;
using System.Linq;

namespace MADITP2._0.ApplicationLogic.AR
{
    public class ARPrintKuitansiSementaraAL
    {
        private static clsGlobal Helper;
        private static ARPrintKuitansiSementaraDA DataAccess;
        private static ARPrintKuitansiSementaraBL Model;
        private static DataTable Data;

        public ARPrintKuitansiSementaraAL(clsGlobal _Helper)
        {
            Helper = _Helper;
            DataAccess = new ARPrintKuitansiSementaraDA(Helper);
            Model = new ARPrintKuitansiSementaraBL();
            Data = new DataTable();
        }

        public ARPrintKuitansiSementaraBL GetData(ARPrintKuitansiSementaraBL Model)
        {
            Data = DataAccess.Read(Model);
            Model = Helper.ConvertDataTableToList<ARPrintKuitansiSementaraBL>(Data).FirstOrDefault();
            return Model;
        }
    }
}