using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MADITP2._0.BusinessLogic.SO;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using MADITP2._0.login;

namespace MADITP2._0.DataAccess.SO
{
   
    class SOMasterProductDA
    {
        private static clsGlobal Helper;
        public SOMasterProductDA(clsGlobal _Helper)
        {
            Helper = _Helper;
        }
        public DataTable Read(EnumFilter enReadType, SOMasterProductBL Model, int Page = 0, int PerPage = (int)EnumFetchData.DefaultLimit, string Search = null)
        {
            //int PerPage = (int)EnumFetchData.DefaultLSOit;
            //string Search = null;

            DataTable result = new DataTable();
            string Province = null;
            string sql = null;
            int offset = (Page - 1) * PerPage;
            var Result = new DataTable();
            try
            {
                switch (enReadType)
                {
                    case EnumFilter.GET_ALL:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_PRODUCT_MASTER] '','','',0,0,0,0");
                        break;
                    case EnumFilter.GET_SEARCH_ID:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_PRODUCT_MASTER] '{Model.group_id}','{Model.subgroup_id}','{Model.product_id}','{Model.description}','{Model.product_type}','{Model.active_flag}','{Model.sap}',0,0,0,0");
                        break;
                    case EnumFilter.GET_WITH_PAGING:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_PRODUCT_MASTER] '{Model.group_id}','{Model.subgroup_id}','{Model.product_id}','{Model.description}','{Model.product_type}','{Model.active_flag}','{Model.sap}',{offset},{PerPage},1,0");
                        break;
                    case EnumFilter.GET_COUNT_ROWS:
                        Result = Helper.ExecuteQuery($"EXEC [BOOK_DEV2].[dbo].[SP_SO_SELECT_PRODUCT_MASTER] '{Model.group_id}','{Model.subgroup_id}','{Model.product_id}','{Model.description}','{Model.product_type}','{Model.active_flag}','{Model.sap}',{offset},{PerPage},0,1");
                        break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Result;
        }

        public int CMD(SOMasterProductBL Model, string SQLQuery)
        {
            try
            {
                var sqlParameter = new List<SqlParameterHelper>() {
                    new SqlParameterHelper(){PARAMETR_NAME = "@SQLQuery", VALUE= SQLQuery },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Group_id", VALUE= Model.group_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@SubGroup_id", VALUE= Model.subgroup_id },
                    new SqlParameterHelper(){PARAMETR_NAME = "@Description", VALUE= Model.description },
                     new SqlParameterHelper(){PARAMETR_NAME = "@Product_id", VALUE= Model.product_id },
                     new SqlParameterHelper(){PARAMETR_NAME = "@SAP", VALUE= Model.sap },
                      new SqlParameterHelper(){PARAMETR_NAME = "@Product_type", VALUE= Model.product_type },
                       new SqlParameterHelper(){PARAMETR_NAME = "@Active_flag", VALUE= Model.active_flag },
                       new SqlParameterHelper(){PARAMETR_NAME = "@ProductNameKey", VALUE= Model.namekey },
                       new SqlParameterHelper(){PARAMETR_NAME = "@VendorID", VALUE= Model.vendor_code },
                       new SqlParameterHelper(){PARAMETR_NAME = "@TaxCode", VALUE= Model.tax_code },
                       new SqlParameterHelper(){PARAMETR_NAME = "@DiscCode", VALUE= Model.discount_code },
                       new SqlParameterHelper(){PARAMETR_NAME = "@UOMIvt", VALUE= Model.uom_Inventory },
                       new SqlParameterHelper(){PARAMETR_NAME = "@UOMSales", VALUE= Model.uom_sales },
                       new SqlParameterHelper(){PARAMETR_NAME = "@UOMPurch", VALUE= Model.uom_purchase },
                       new SqlParameterHelper(){PARAMETR_NAME = "@UnitWeight", VALUE= Model.unit_weight },
                       new SqlParameterHelper(){PARAMETR_NAME = "@ControlFlag", VALUE= Model.control_flag },
                       new SqlParameterHelper(){PARAMETR_NAME = "@TechConstrainFlag", VALUE= Model.technical_constrain_flag },
                       new SqlParameterHelper(){PARAMETR_NAME = "@DivType2", VALUE= Model.division_type2 },
                        new SqlParameterHelper(){PARAMETR_NAME = "@DivType", VALUE= Model.division_type },
                       new SqlParameterHelper(){PARAMETR_NAME = "@Weight", VALUE= Model.weight },
                       new SqlParameterHelper(){PARAMETR_NAME = "@DivisiProduct", VALUE= Model.product_division },
                       new SqlParameterHelper(){PARAMETR_NAME = "@JenisProduct", VALUE= Model.jenis_product },
                       new SqlParameterHelper(){PARAMETR_NAME = "@ItemGroup", VALUE= Model.item_group },
                       new SqlParameterHelper(){PARAMETR_NAME = "@EditionLanguage", VALUE= Model.edition_language },
                       new SqlParameterHelper(){PARAMETR_NAME = "@ConvSales", VALUE= Model.conversion_sales },
                       new SqlParameterHelper(){PARAMETR_NAME = "@ConvPurch", VALUE= Model.conversion_Purchase },
                       new SqlParameterHelper(){PARAMETR_NAME = "@ManufactureCode", VALUE= Model.manufactur_code },
                        new SqlParameterHelper(){PARAMETR_NAME = "@NonStockItemFlag", VALUE= Model.non_stock_item_flag },
                         new SqlParameterHelper(){PARAMETR_NAME = "@ProductDigital", VALUE= Model.digital },
                          new SqlParameterHelper(){PARAMETR_NAME = "@Category", VALUE= Model.category_id },
                         new SqlParameterHelper(){PARAMETR_NAME = "@User", VALUE= clsLogin.USERID },


                };
                var result = Helper.ExecuteStoreProcedure("[BOOK_DEV2].[dbo].[SP_SO_CMD_PRODUCT_MASTER]", sqlParameter);
                return (int)result[0].Rows[0].ItemArray.ElementAt(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable GetList_ProductGroup(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            {  sql = "SELECT  gp_product_group_id, gp_group_description FROM VW_LIST_PRODUCT_GROUP"; }
            else if(Event == clsEventButton.EnumAction.SEARCH.ToString())
            {  sql = "SELECT [gp_product_group_id], CASE WHEN[gp_product_group_id] = '' THEN '(ALL)' ELSE [gp_group_description] END AS gp_group_description FROM [VW_LIST_PRODUCT_GROUP]"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_ProductSubGroup(string Event, string Product_GroupID)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT product_group_id,product_subgroup_id, product_subgroup_description "+
                    "FROM [VW_LIST_PRODUCT_SUBGROUP] WHERE product_group_id = '' or product_group_id = '" + Product_GroupID + "'";
            }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT product_group_id,product_subgroup_id,  CASE WHEN[product_subgroup_id] = '' THEN '(ALL)' ELSE [product_subgroup_description] END AS product_subgroup_description " +
                    "FROM [VW_LIST_PRODUCT_SUBGROUP] WHERE product_group_id = '' or product_group_id = '" + Product_GroupID + "'"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_ProductType(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT  product_type_id, product_type FROM VW_LIST_PRODUCT_TYPE"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT [product_type_id], CASE WHEN[product_type_id] = '' THEN '(ALL)' ELSE [product_type] END AS product_type FROM [VW_LIST_PRODUCT_TYPE]"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_ProductStatus(string Event)
        {
            string sql = "";
            if (Event == clsEventButton.EnumAction.DISPLAY.ToString())
            { sql = "SELECT  status_type_id, status_type FROM VW_LIST_PRODUCT_STATUS"; }
            else if (Event == clsEventButton.EnumAction.SEARCH.ToString())
            { sql = "SELECT [status_type_id], CASE WHEN[status_type_id] = '' THEN '(ALL)' ELSE [status_type] END AS status_type FROM [VW_LIST_PRODUCT_STATUS]"; }

            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_JenisProduct(string Event)
        {
            string sql = "";
            sql = "SELECT '' AS pm_jenis_product, '' AS Descr UNION " +
                   " SELECT  DIV_PRD AS pm_jenis_product, Descr FROM vw_JENIS_PRODUCTS"; 
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_DivisiProduct(string Event)
        {
            string sql = "";
            sql = " SELECT DIV_PRD AS pm_product_division FROM vw_DIVISI_PRODUCTS";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_CommissionType(string Event) //GetList_DivisionType
        {
            string sql = "";
            sql = " SELECT [commission_type_id] ,[commission_type] FROM [VW_LIST_PRODUCT_COMMISSION_TYPE]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }
        public DataTable GetList_DivisionType2(string Event)
        {
            string sql = "";
            sql = " SELECT [commission_type_id] as pm_division_type2,[commission_type] FROM [VW_LIST_PRODUCT_COMMISSION_TYPE]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_DiscountProduct(string Event)
        {
            string sql = "";
            sql = " SELECT [d_discount_id], [d_discount] FROM [VW_LIST_PRODUCT_DISCOUNT]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }


        public DataTable GetList_Tax(string Event)
        {
            string sql = "";
            sql = " SELECT [t_tax_id],[t_tax] FROM [VW_LIST_PRODUCT_TAX]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_Vendor (string Event)
        {
            string sql = "";
            sql = " SELECT [v_vendor_id],[v_vendor] FROM [VW_LIST_PRODUCT_VENDOR]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_UOM(string Event)
        {
            string sql = "";
            sql = " SELECT [umc_uom_code],[umc_uom_description],[umc_remarks] FROM [VW_LIST_PRODUCT_UOM]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_ControlFlag(string Event)
        {
            string sql = "";
            sql = " SELECT pm_wh_control_flag FROM [VW_LIST_PRODUCT_CONTROLFLAG]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_ConstrainFlag(string Event)
        {
            string sql = "";
            sql = " SELECT pm_technical_constrain_flag FROM [VW_LIST_PRODUCT_CONSTRAINFLAG]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }

        public DataTable GetList_UnitHongkong(string Event)
        {
            string sql = "";
            sql = " SELECT hks_division_id, hks_product_id, hks_buku FROM [VIEW_LIST_PRODUCT_UNITHONGKONG]";
            DataTable result = Helper.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
            {
                return result;
            }

            return result;
        }
    }
}
