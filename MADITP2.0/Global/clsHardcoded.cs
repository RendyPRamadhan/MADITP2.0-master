using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.Global
{
    class clsHardcoded
    {
        clsGlobal Helper = null;
        clsAlert clsAlert;

        public clsHardcoded()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                Helper = new clsGlobal();
                clsAlert = new clsAlert();
            }
        }

        public clsHardcoded(clsGlobal helper)
        {
            Helper = helper;
        }

        public List<ComboBoxViewModel> GetHardCodedPaymentType(bool _isAll)
        {
            var result = new List<ComboBoxViewModel>();
            try
            {
                result = new List<ComboBoxViewModel>()
                {
                    new ComboBoxViewModel { DisplayMember = "CASH", ValueMember = "CASH" },
                    new ComboBoxViewModel { DisplayMember = "CHEQUE", ValueMember = "CHEQUE" },
                    new ComboBoxViewModel { DisplayMember = "GIRO", ValueMember = "GIRO" },
                    new ComboBoxViewModel { DisplayMember = "CREDIT CARD", ValueMember = "CCARD" },
                    new ComboBoxViewModel { DisplayMember = "VISA ORDER", ValueMember = "VO" },  
                    new ComboBoxViewModel { DisplayMember = "TRANSFER", ValueMember = "TO" },
                    new ComboBoxViewModel { DisplayMember = "EDC", ValueMember = "EDC" },
                    new ComboBoxViewModel { DisplayMember = "TO", ValueMember = "TO" }
                };

                if (_isAll == true)
                {
                    result.Insert(0, new ComboBoxViewModel() { DisplayMember = "ALL", ValueMember = "ALL" });
                }
            }
            catch (Exception e)
            {
                clsAlert.PushAlert(e.Message.ToString(), clsAlert.Type.Error);
            }
            return result;
        }

        public List<ComboBoxViewModel> GetListKpStatus(bool IsAll = true)
        {
            List<ComboBoxViewModel> ListKpStatus = new List<ComboBoxViewModel>();
            if(IsAll)
            {
                ListKpStatus.Add(new ComboBoxViewModel()
                {
                    DisplayMember = "ALL",
                    ValueMember = "",
                });
            }
            
            ListKpStatus.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Active/In Entry",
                ValueMember = "A",
            });

            ListKpStatus.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Suspend",
                ValueMember = "S",
            });

            ListKpStatus.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Release",
                ValueMember = "R",
            });

            ListKpStatus.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Cancel",
                ValueMember = "C",
            });

            ListKpStatus.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Verified",
                ValueMember = "V",
            });

            return ListKpStatus;
        }

        public List<ComboBoxViewModel> GetListInvoiceStatus(bool IsAll = true)
        {
            List<ComboBoxViewModel> Lists = new List<ComboBoxViewModel>()
            {
                new ComboBoxViewModel(){ ValueMember="S", DisplayMember="Suspend"},
                new ComboBoxViewModel(){ ValueMember="X", DisplayMember="Processed"},
                new ComboBoxViewModel(){ ValueMember="P", DisplayMember="Printed"},
                new ComboBoxViewModel(){ ValueMember="C", DisplayMember="Cancel"},
                new ComboBoxViewModel(){ ValueMember="R", DisplayMember="Return"},
            };

            if (IsAll)
            {
                Lists.Insert(0, new ComboBoxViewModel()
                {
                    DisplayMember = "ALL",
                    ValueMember = "",
                });
            }

            return Lists;
        }

        public List<ComboBoxViewModel> GetListDeliveryStatus(bool IsAll = true) 
        {
            List<ComboBoxViewModel> Lists = new List<ComboBoxViewModel>();
            if (IsAll)
            {
                Lists.Add(new ComboBoxViewModel()
                {
                    DisplayMember = "ALL",
                    ValueMember = "",
                });
            }

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Suspend",
                ValueMember = "S",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Time Schedule",
                ValueMember = "T",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Partial Shipment",
                ValueMember = "P",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Delivered",
                ValueMember = "D",
            });

            return Lists;
        }

        public List<ComboBoxViewModel> GetListVerificationStatus(bool IsAll = true)
        {
            List<ComboBoxViewModel> Lists = new List<ComboBoxViewModel>();
            if (IsAll)
            {
                Lists.Add(new ComboBoxViewModel()
                {
                    DisplayMember = "ALL",
                    ValueMember = "",
                });
            }

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Suspend",
                ValueMember = "S",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "In Process",
                ValueMember = "I",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Release",
                ValueMember = "R",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Cancle",
                ValueMember = "C",
            });

            return Lists;
        }

        public List<ComboBoxViewModel> GetListDPStatus(bool IsAll = true)
        {
            List<ComboBoxViewModel> Lists = new List<ComboBoxViewModel>();

            if (IsAll)
            {
                Lists.Add(new ComboBoxViewModel()
                {
                    DisplayMember = "ALL",
                    ValueMember = "",
                });
            }

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "None",
                ValueMember = "N",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Suspend",
                ValueMember = "S",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Registered",
                ValueMember = "R",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Deposited",
                ValueMember = "D",
            });

            return Lists;
        }

        public List<ComboBoxViewModel> GetListCODStatus(bool IsAll = true)
        {
            List<ComboBoxViewModel> Lists = new List<ComboBoxViewModel>();
            if (IsAll)
            {
                Lists.Add(new ComboBoxViewModel()
                {
                    DisplayMember = "ALL",
                    ValueMember = "",
                });
            }

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "None",
                ValueMember = "N",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Suspend",
                ValueMember = "S",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Registered",
                ValueMember = "R",
            });

            Lists.Add(new ComboBoxViewModel()
            {
                DisplayMember = "Deposited",
                ValueMember = "D",
            });

            return Lists;
        }


        public string GetKpStatus(string StatusCode)
        {
            var dict = new Dictionary<string, string>
            {
                {"A", "Active/In Entry"},
                {"S", "Suspend"},
                {"R", "Release"},
                {"C", "Cancel"},
                {"V", "Verified"},
            };

            try{
                return dict[StatusCode.Trim()];
            } catch (Exception e)
            {
                return "";
            }
        }

        public string GetInvoiceStatus(string StatusCode)
        {
            var dict = new Dictionary<string, string>
            {
                {"S", "Suspend"},
                {"X", "Processed"},
                {"P", "Printed"},
                {"C", "Cancel"},
                {"R", "Return"},
            };

            try
            {
                return dict[StatusCode.Trim()];
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetDPStatus(string StatusCode)
        {
            var dict = new Dictionary<string, string>
            {
                {"N", "None"},
                {"S", "Suspend"},
                {"R", "Registered"},
                {"D", "Deposited"},
            };

            try
            {
                return dict[StatusCode.Trim()];
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetCODStatus(string StatusCode)
        {
            var dict = new Dictionary<string, string>
            {
                {"N", "None"},
                {"S", "Suspend"},
                {"R", "Registered"},
                {"D", "Deposited"},
            };

            try
            {
                return dict[StatusCode.Trim()];
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}
