using MADITP2._0.businessLogic.RC;
using MADITP2._0.Enums;
using MADITP2._0.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MADITP2._0.DataAccess.RC
{
    class RCMasterODTDA
    {
        private clsGlobal Helper = null;
        private string reason;

        public string Reason { get => reason; set => reason = value; }

        public RCMasterODTDA(clsGlobal helper)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = helper;
            }
        }

        public int GetSequence()
        {
            string sql = "select max(ro_id) as max_ro_id from RC_OCT1";
            DataTable result = Helper.ExecDT(sql);
            if(result.Rows.Count == 0)
            {
                return 1;
            }

            return (int)result.Rows[0]["max_ro_id"] + 1;
        }

        public Boolean Post(RCMasterODTBL Entity)
        {
            try {
                List<SqlParameterHelper> sqlp = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_branch_id", VALUE = Entity.Branch_Id },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_division_id", VALUE = Entity.Division_Id },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_rep_id", VALUE = Entity.Rep_Id},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_rep_name", VALUE = Entity.Rep_Name},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_oct", VALUE = Entity.Tgl_Oct },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_nama_peserta", VALUE = Entity.Nama_Peserta },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_alamat", VALUE = Entity.Alamat },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_telp_peserta", VALUE = Entity.Telp_Peserta },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus", VALUE = Entity.Lulus },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_keterangan", VALUE = Entity.Keterangan },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_user_date", VALUE = Entity.User_Date },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_user_entry", VALUE = Entity.User_Entry },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_active", VALUE = Entity.Active },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_trainer", VALUE = Entity.Trainer },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_oct_type", VALUE = Entity.Oct_Type },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus_bop", VALUE = Entity.Lulus_Bop },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_bop", VALUE = Entity.Tgl_Bop },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus_ppq", VALUE = Entity.Lulus_Ppq },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_ppq", VALUE = Entity.Tgl_Ppq},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus_intervw", VALUE = Entity.Lulus_Intervw },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_intervw", VALUE = Entity.Tgl_Intervw },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_intervw_by", VALUE = Entity.Intervw_By },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_oct_rep_id", VALUE = Entity.Oct_Rep_Id},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_oct_hanphone_peserta", VALUE = Entity.Oct_Hanphone_Peserta},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_status_pernikahan", VALUE = Entity.Status_Pernikahan },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_agama", VALUE = Entity.Agama },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_jenis_kelamin", VALUE = Entity.Jenis_Kelamin },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tempat_lahir", VALUE = Entity.Tempat_Lahir },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tanggal_lahir", VALUE = Entity.Tanggal_Lahir },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_kota_domisili", VALUE = Entity.Kota_Domisili },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_kode_pos", VALUE = Entity.Kode_Pos },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_hidden_row", VALUE = Entity.Hidden_Row },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_principal", VALUE = Entity.RoPrincipal},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_identitas_OCT", VALUE = Entity.Identitas_Oct },
                    new SqlParameterHelper() { PARAMETR_NAME = "@kd_manager_id", VALUE = Entity.Manager_Id },
                    new SqlParameterHelper() { PARAMETR_NAME = "@nm_manager_id", VALUE = Entity.Manager_Name },
                    new SqlParameterHelper() { PARAMETR_NAME = "@Principal", VALUE = Entity.Principal },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_active_flag", VALUE = Entity.Active_Flag },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_is_odt", VALUE = Entity.Is_Odt },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_toko_online", VALUE = Entity.Toko_Online },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_id", VALUE = GetSequence() }
                };
                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_INSERT_RC_MASTER_ODT", sqlp);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Insert failed!";
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show(e.Message.ToString());
                return false;
            }

            return true;
        }

        public bool Put(int ro_id, RCMasterODTBL Entity)
        {
            try
            {
                List<SqlParameterHelper> sqlp = new List<SqlParameterHelper>()
                {
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_branch_id", VALUE = Entity.Branch_Id },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_division_id", VALUE = Entity.Division_Id },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_rep_id", VALUE = Entity.Rep_Id},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_rep_name", VALUE = Entity.Rep_Name},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_oct", VALUE = Entity.Tgl_Oct },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_nama_peserta", VALUE = Entity.Nama_Peserta },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_alamat", VALUE = Entity.Alamat },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_telp_peserta", VALUE = Entity.Telp_Peserta },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus", VALUE = Entity.Lulus },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_keterangan", VALUE = Entity.Keterangan },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_user_date", VALUE = Entity.User_Date },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_user_entry", VALUE = Entity.User_Entry },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_active", VALUE = Entity.Active },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_trainer", VALUE = Entity.Trainer },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_oct_type", VALUE = Entity.Oct_Type },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus_bop", VALUE = Entity.Lulus_Bop },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_bop", VALUE = Entity.Tgl_Bop },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus_ppq", VALUE = Entity.Lulus_Ppq },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_ppq", VALUE = Entity.Tgl_Ppq},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_lulus_intervw", VALUE = Entity.Lulus_Intervw },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tgl_intervw", VALUE = Entity.Tgl_Intervw },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_intervw_by", VALUE = Entity.Intervw_By },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_oct_rep_id", VALUE = Entity.Oct_Rep_Id},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_oct_hanphone_peserta", VALUE = Entity.Oct_Hanphone_Peserta},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_status_pernikahan", VALUE = Entity.Status_Pernikahan },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_agama", VALUE = Entity.Agama },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_jenis_kelamin", VALUE = Entity.Jenis_Kelamin },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tempat_lahir", VALUE = Entity.Tempat_Lahir },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_tanggal_lahir", VALUE = Entity.Tanggal_Lahir },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_kota_domisili", VALUE = Entity.Kota_Domisili },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_kode_pos", VALUE = Entity.Kode_Pos },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_hidden_row", VALUE = Entity.Hidden_Row },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_principal", VALUE = Entity.RoPrincipal},
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_identitas_OCT", VALUE = Entity.Identitas_Oct },
                    new SqlParameterHelper() { PARAMETR_NAME = "@kd_manager_id", VALUE = Entity.Manager_Id },
                    new SqlParameterHelper() { PARAMETR_NAME = "@nm_manager_id", VALUE = Entity.Manager_Name },
                    new SqlParameterHelper() { PARAMETR_NAME = "@Principal", VALUE = Entity.Principal },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_active_flag", VALUE = Entity.Active_Flag },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_is_odt", VALUE = Entity.Is_Odt },
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_toko_online", VALUE = Entity.Toko_Online },

                    ///criteria expresion
                    new SqlParameterHelper() { PARAMETR_NAME = "@ro_id", VALUE = ro_id}
                };

                DataTableCollection result = Helper.ExecuteStoreProcedure("FUNCTION_UPDATE_RC_MASTER_ODT", sqlp);
                if ((int)result[0].Rows[0].ItemArray.ElementAt(0) == 0)
                {
                    Reason = "Update failed!";
                    return false;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
                Reason = es.Message.ToString();
                return false;
            }

            return true;
        }

        public Boolean Delete(int ro_id)
        {
            Helper.BeginTrans();
            try
            {
                string sql = "delete from RC_OCT1 where ro_id = '" + ro_id + "'";
                Helper.ExecuteTrans(sql);
                Helper.CommitTrans();
            }
            catch (SystemException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }

            return true;
        }

        public List<RCMasterODTBL> Read(EnumFilter filter, int Offset = 0, int fetchLimit = (int) EnumFetchData.DefaultLimit, string Search = null, string ActiveFlag = "ALL")
        {
            if (null == Search)
            {
                Search = "";
            }

            List<SqlParameterHelper> sqlParams = new List<SqlParameterHelper>() { };
            DataTable result = new DataTable();
            try
            {
                string sql = "select * from FUNCTION_RC_MASTER_ODT_GET_ALL(@Offset, @Limit, @Search, @ActiveFlag)";
                switch (filter)
                {
                    case EnumFilter.GET_ALL:
                        sqlParams = new List<SqlParameterHelper>() {
                            new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = -1},
                            new SqlParameterHelper(){PARAMETR_NAME = "@Limit", VALUE = -1},
                            new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search},
                            new SqlParameterHelper(){PARAMETR_NAME = "@ActiveFlag", VALUE = ActiveFlag},
                        };
                        break;

                    case EnumFilter.GET_WITH_PAGING:
                        sqlParams = new List<SqlParameterHelper>() {
                            new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = Offset},
                            new SqlParameterHelper(){PARAMETR_NAME = "@Limit", VALUE = fetchLimit},
                            new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search},
                            new SqlParameterHelper(){PARAMETR_NAME = "@ActiveFlag", VALUE = ActiveFlag},
                        };
                        break;
                }

                result = Helper.ExecuteQuery(sql, sqlParams);
            }
            catch(SystemException e)
            {
                Reason = e.Message.ToString();
                Console.WriteLine(e.StackTrace);
            }

            return Helper.ConvertDataTableToList<RCMasterODTBL>(result);
        }

        public int CountRows(string Search = "", string ActiveFlag = "ALL")
        {
            if(null == Search)
            {
                Search = "";
            }

            string sql = "select count(Id) as jumlah from FUNCTION_RC_MASTER_ODT_GET_ALL(@Offset, @Limit, @Search, @ActiveFlag)";
            var result = Helper.ExecuteQuery(sql, new List<SqlParameterHelper>() {
                new SqlParameterHelper(){PARAMETR_NAME = "@Offset", VALUE = -1},
                new SqlParameterHelper(){PARAMETR_NAME = "@Limit", VALUE = -1},
                new SqlParameterHelper(){PARAMETR_NAME = "@Search", VALUE = Search},
                new SqlParameterHelper(){PARAMETR_NAME = "@ActiveFlag", VALUE = ActiveFlag},
            });

            return Helper.CastToInt(result.Rows[0]["jumlah"]);
        }

        public DataTable GetRecruiter(string rm_rep_id)
        {
            string sql = "select a.rm_rep_id, a.rm_name, a.rm_manager_id, a.rm_nm_Manager from VW_RC_REP_MASTER_FOR_NEW_SCHEMA a " 
                + "where a.rm_rep_id = '" + rm_rep_id + "' and a.rm_active_flag = 'A';";
            DataTable dt = Helper.ExecDT(sql);
            return dt;
        }

        public RCMasterODTBL Find(int ro_id)
        {
            RCMasterODTBL Entity = null;
            string sql = $"select * from FUNCTION_RC_MASTER_ODT_GET({ro_id})";
            try
            {
                DataTable result = Helper.ExecDT(sql);
                if(result.Rows.Count == 0)
                {
                    Reason = "OCT Data not found";
                    return Entity;
                }

                Entity = Helper.ConvertDataTableToModel<RCMasterODTBL>(result);                
            }
            catch (SystemException e)
            {
                Reason = e.Message;
                Console.WriteLine(e.StackTrace);
            }

            return Entity;
        }
    }
}
