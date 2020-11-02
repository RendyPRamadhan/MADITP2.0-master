using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.SO
{
    public class SOMasterProductBL
    {
        private string Group_id;
        private string SubGroup_id;
        private string Description;
        private string Product_id;
        private string Product_type;
        private string Active_flag;
        private string SAP;

        private string DivType; //atau Commission
        private string ProductNameKey;
        private string VendorID;
        private string TaxCode;
        private string DiscCode;
        private string UOMIvt;
        private string UOMSales;
        private string UOMPurch;
        private string UnitWeight;
        private string ControlFlag;
        private string TechConstrainFlag;
        private string DivType2;
        private string Weight;
        private string DivisiProduct;
        private string JenisProduct;
        private string ItemGroup;
        private string EditionLanguage;

        private string ConvSales;
        private string ConvPurch;
        private string ManufactureCode;
        private string NonStockItemFlag;
        private string NO_OF_ITEM;
        private string ProductDigital;
        private string Category;

        private string CREATION_DATE;
        private string LAST_UPDATE_DATE;
        private string USER_ID;
        private string PRODUCT_DIVISION;

        public string division_type { get => DivType; set => DivType = value; }
        public string group_id { get => Group_id; set => Group_id = value; }
        public string subgroup_id { get => SubGroup_id; set => SubGroup_id = value; }
        public string product_id { get => Product_id; set => Product_id = value; }
        public string description { get => Description; set => Description = value; }
        public string namekey { get => ProductNameKey; set => ProductNameKey = value; }
        public string vendor_code { get => VendorID; set => VendorID = value; }
        public string manufactur_code { get => ManufactureCode; set => ManufactureCode = value; }

        public string product_type { get => Product_type; set => Product_type = value; }
        public string edition_language { get => EditionLanguage; set => EditionLanguage = value; }
        public string item_group { get => ItemGroup; set => ItemGroup = value; }
        public string no_of_item { get => NO_OF_ITEM; set => NO_OF_ITEM = value; }
        public string tax_code { get => TaxCode; set => TaxCode = value; }

        public string discount_code { get => DiscCode; set => DiscCode = value; }
        public string uom_Inventory { get => UOMIvt; set => UOMIvt = value; }
        public string uom_sales { get => UOMSales; set => UOMSales = value; }
        public string uom_purchase { get => UOMPurch; set => UOMPurch = value; }

        public string conversion_sales { get => ConvSales; set => ConvSales = value; }
        public string conversion_Purchase { get => ConvPurch; set => ConvPurch = value; }
        public string unit_weight { get => UnitWeight; set => UnitWeight = value; }

        public string control_flag { get => ControlFlag; set => ControlFlag = value; }
        public string technical_constrain_flag { get => TechConstrainFlag; set => TechConstrainFlag = value; }
        public string non_stock_item_flag { get => NonStockItemFlag; set => NonStockItemFlag = value; }
        public string active_flag { get => Active_flag; set => Active_flag = value; }
        public string creation_date { get => CREATION_DATE; set => CREATION_DATE = value; }
        public string last_update_date { get => LAST_UPDATE_DATE; set => LAST_UPDATE_DATE = value; }
        public string user_id { get => USER_ID; set => USER_ID = value; }




        public string sap { get => SAP; set => SAP = value; }
        public string division_type2 { get => DivType2; set => DivType2 = value; }
        public string weight { get => Weight; set => Weight = value; }
        public string jenis_product { get => JenisProduct; set => JenisProduct = value; }
        public string digital { get => ProductDigital; set => ProductDigital = value; }
        public string category_id { get => Category; set => Category = value; }
        public string product_division { get => PRODUCT_DIVISION; set => PRODUCT_DIVISION = value; }
        
    }
}
