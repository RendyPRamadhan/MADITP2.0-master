using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.Global;
using System.Linq.Expressions;
using Microsoft.SqlServer.Server;
using System.Globalization;
using System.Web.Configuration;
using System.Text.RegularExpressions;

namespace MADITP2._0.UserControls
{
    public partial class UCBankEntry : UserControl
    {
        clsAlert clsAlert;
        private bool _IsEditNumeric;
        private string _Char;

        public UCBankEntry()
        {
            InitializeComponent();
            clsAlert = new clsAlert();
        }

        private void UCBankEntry_Load(object sender, EventArgs e)
        {
            this.grd.Paint += new PaintEventHandler(grd_Paint);
            grd.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            addRowsGrd("00", "00", "00", "", "", "", "", "000", "", "", "", 0, 0, false, "", 0, 0, "");
            SettingForm();

            grd.RefreshEdit();
            grd.NotifyCurrentCellDirty(true);
        }

        private void SettingForm()
        {
            lblInformation.Text = string.Empty;
            lblCashCodeValue.Text = string.Empty;
            lblOutOfBalanceValueDebit.Text = string.Empty;

            txtMessage.BackColor = Color.FromArgb(255, 255, 192);

            grd.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            grd.Columns[2].DefaultCellStyle.Format = String.Format("N0");
            grd.Columns[2].ValueType = typeof(Double);
        }

        private void grd_Paint(object sender, PaintEventArgs e)
        {
            //Offsets to adjust the position of the merged Header.
            int heightOffset = -3;
            int widthOffset = 100;
            int xOffset = 6;
            int yOffset = 2;

            //Index of Header column from where the merging will start.
            int columnIndex = 1;

            //Number of Header columns to be merged.
            int columnCount = 8;

            //Get the position of the Header Cell.
            Rectangle headerCellRectangle = grd.GetCellDisplayRectangle(columnIndex, 0, true);

            //X coordinate of the merged Header Column.
            int xCord = headerCellRectangle.Location.X + xOffset;

            //Y coordinate of the merged Header Column.
            int yCord = headerCellRectangle.Location.Y - headerCellRectangle.Height + yOffset;

            //Calculate Width of merged Header Column by adding the widths of all Columns to be merged.
            //int mergedHeaderWidth = grd.Columns[columnIndex].Width + grd.Columns[columnIndex + columnCount - 1].Width + widthOffset;
            int mergedHeaderWidth = grd.Columns[columnIndex].Width + grd.Columns[columnIndex + columnCount].Width - widthOffset;

            //Generate the merged Header Column Rectangle.
            Rectangle mergedHeaderRect = new Rectangle(xCord, yCord, mergedHeaderWidth, headerCellRectangle.Height + heightOffset);

            //Draw the merged Header Column Rectangle.
            Color myColor = Color.FromArgb(8, 102, 60);
            SolidBrush myBrush = new SolidBrush(myColor);
            e.Graphics.FillRectangle(myBrush, mergedHeaderRect);

            //Draw the merged Header Column Text.
            e.Graphics.DrawString("G/L ACCOUNT", grd.ColumnHeadersDefaultCellStyle.Font, Brushes.White, xCord + 65, yCord + 3);
        }

        internal void clearRowsGrd()
        {
            grd.Rows.Clear();
        }

        internal void addRowsGrd(string _branch, string _Division, string _Department, string _Major1, string _Major2, string _Minor, string _Analysis, string _Filler, string _AddressBook, string _Description, string _DCA, double _Debit, double _Credit, bool _Delete, string _DCARes, double _DebitRes, double _CreditRes, string _CashCode)
        {
            string _strNo = "";
            int _No = grd.Rows.Count + 1;
            bool _isAdd = false;

            if (Convert.ToString(_No).Length == 1)
            {
                _strNo = "00" + Convert.ToString(_No);
                _isAdd = true;
            }
            else if (Convert.ToString(_No).Length == 2)
            {
                _strNo = "0" + Convert.ToString(_No);
                _isAdd = true;
            }
            if (Convert.ToString(_No).Length == 3)
            {
                _strNo = Convert.ToString(_No);
                _isAdd = true;
            }
            else if (Convert.ToString(_No).Length > 3)
            {
                _isAdd = false;
            }

            if (_isAdd == true)
            {
                grd.Rows.Add(_strNo, _branch, _Division, _Department, _Major1, _Major2, _Minor, _Analysis, _Filler, _AddressBook, _Description, _DCA, _Debit, _Credit, _Delete, _DCARes, _DebitRes, _CreditRes, _CashCode);

                int _Index = grd.Rows.Count - 1;

                //SET CELL DEBIT
                if (Convert.ToDouble(grd.Rows[_Index].Cells["Debit"].Value) == 0)
                {
                    grd.Rows[_Index].Cells["Debit"].ReadOnly = true;
                    grd.Rows[_Index].Cells["Debit"].Style.BackColor = Color.FromArgb(236, 233, 216);
                }
                else
                {
                    grd.Rows[_Index].Cells["Debit"].ReadOnly = false;
                    if(_Index % 2 == 0)
                    {
                        grd.Rows[_Index].Cells["Debit"].Style.BackColor = Color.FromArgb(217, 227, 222);
                    }
                    else
                    {
                        grd.Rows[_Index].Cells["Debit"].Style.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }

                //SET CELL CREDIT
                if (Convert.ToDouble(grd.Rows[_Index].Cells["Credit"].Value) == 0)
                {
                    grd.Rows[_Index].Cells["Credit"].ReadOnly = true;
                    grd.Rows[_Index].Cells["Credit"].Style.BackColor = Color.FromArgb(236, 233, 216);
                }
                else
                {
                    grd.Rows[_Index].Cells["Credit"].ReadOnly = false;
                    if (_Index % 2 == 0)
                    {
                        grd.Rows[_Index].Cells["Credit"].Style.BackColor = Color.FromArgb(217, 227, 222);
                    }
                    else
                    {
                        grd.Rows[_Index].Cells["Credit"].Style.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }

            }
            else
            {
                clsAlert.PushAlert("No Maximum 3 Digit!", clsAlert.Type.Error);
            }
        }

        private void grd_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnValue_KeyPress);    
            if(grd.CurrentCell.ColumnIndex > 0 && grd.CurrentCell.ColumnIndex < 9)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnValue_KeyPress);
                }
            }
            else if (grd.CurrentCell.ColumnIndex == 11)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnValue_KeyPress);
                }
            }
            else if (grd.CurrentCell.ColumnIndex == 12 || grd.CurrentCell.ColumnIndex == 13)
            {
                //e.Control.PreviewKeyDown -= new PreviewKeyDownEventHandler(grd_PreviewKeyDown);

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    //tb.PreviewKeyDown += new PreviewKeyDownEventHandler(grd_PreviewKeyDown);
                    tb.KeyPress += new KeyPressEventHandler(ColumnValue_KeyPress);
                }
            }
        }

        //FOR ADD NEW ROW EVENT ENTER
        //void grd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (grd.CurrentCell.ColumnIndex == 12 || grd.CurrentCell.ColumnIndex == 13)
        //    {
        //        if (e.KeyData == Keys.Enter)
        //        {
        //            addRowsGrd("00", "00", "00", "", "", "", "", "000", "", "", "", 0, 0, false, "", 0, 0, "");
        //        }
        //    }
        //}

        private bool CheckInput(string _CharInput)
        {
            //FOR ALPHABETH
            var pattern = @"([a-zA-Z0-9\b])+";
            bool _isPassed = false;

            var regexChar = new Regex(pattern);
            var match = regexChar.Match(_CharInput);

            _isPassed = (match.Success) ? true : false;

            return _isPassed;

        }

        private void ColumnValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            int _RowIndex = grd.CurrentCell.RowIndex;
            bool _isPassed = false;

            if (grd.CurrentCell.ColumnIndex > 0 && grd.CurrentCell.ColumnIndex < 9)
            {
                if(CheckInput(e.KeyChar.ToString()) == true)
                {
                    if(e.KeyChar.ToString() != "\b")
                    {
                        _Char = _Char + e.KeyChar.ToString().ToUpper();

                        if (grd.CurrentCell.ColumnIndex == 1)
                        {
                            if (_Char.Length == 2)
                            {
                                _isPassed = true;
                            }
                        }
                        else if (grd.CurrentCell.ColumnIndex == 2)
                        {
                            if (_Char.Length == 2)
                            {
                                _isPassed = true;
                            }
                        }
                        else if (grd.CurrentCell.ColumnIndex == 3)
                        {
                            if (_Char.Length == 2)
                            {
                                _isPassed = true;
                            }
                        }
                        else if (grd.CurrentCell.ColumnIndex == 4)
                        {
                            if (_Char.Length == 1)
                            {
                                _isPassed = true;
                            }
                        }
                        else if (grd.CurrentCell.ColumnIndex == 5)
                        {
                            if (_Char.Length == 4)
                            {
                                _isPassed = true;
                            }
                        }
                        else if (grd.CurrentCell.ColumnIndex == 6)
                        {
                            if (_Char.Length == 2)
                            {
                                _isPassed = true;
                            }
                        }
                        else if (grd.CurrentCell.ColumnIndex == 7)
                        {
                            if (_Char.Length == 2)
                            {
                                _isPassed = true;
                            }
                        }
                        else if (grd.CurrentCell.ColumnIndex == 8)
                        {
                            if (_Char.Length == 3)
                            {
                                _isPassed = true;

                                //PROSES VALIDASI ACCOUNT NO
                            }
                        }

                        if (_isPassed == true)
                        {
                            grd.CurrentCell = grd[grd.CurrentCell.ColumnIndex + 1, grd.CurrentCell.RowIndex];
                            grd.Rows[grd.CurrentCell.RowIndex].Cells[grd.CurrentCell.ColumnIndex - 1].Value = _Char;
                            _Char = string.Empty;
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (grd.CurrentCell.ColumnIndex == 11)
            {
                if (e.KeyChar == 'D' || e.KeyChar == 'd' || e.KeyChar == 'C' || e.KeyChar == 'c' || e.KeyChar == 'A' || e.KeyChar == 'a' || e.KeyChar == '\b')
                {
                    //MOVE FOCUS TO UPDATE CELL DC
                    grd.CurrentCell = grd.Rows[_RowIndex].Cells["No"];

                    if (e.KeyChar == 'D' || e.KeyChar == 'd')
                    {
                        if (grd.Rows[_RowIndex].Cells["DC"].Value.ToString() == "C")
                        {
                            grd.Rows[_RowIndex].Cells["DC"].Value = "D";

                            grd.Rows[_RowIndex].Cells["Debit"].Value = 0;
                            grd.Rows[_RowIndex].Cells["Debit"].ReadOnly = false;

                            grd.Rows[_RowIndex].Cells["Credit"].Value = 0;
                            grd.Rows[_RowIndex].Cells["Credit"].ReadOnly = true;
                        }
                    }
                    else if (e.KeyChar == 'C' || e.KeyChar == 'c')
                    {
                        if (grd.Rows[_RowIndex].Cells["DC"].Value.ToString() == "D")
                        {
                            grd.Rows[_RowIndex].Cells["DC"].Value = "C";

                            grd.Rows[_RowIndex].Cells["Debit"].Value = 0;
                            grd.Rows[_RowIndex].Cells["Debit"].ReadOnly = true;

                            grd.Rows[_RowIndex].Cells["Credit"].Value = 0;
                            grd.Rows[_RowIndex].Cells["Credit"].ReadOnly = false;
                            grd.Rows[_RowIndex].Cells["Credit"].ReadOnly = false;
                        }
                    }
                    else if (e.KeyChar == 'A' || e.KeyChar == 'a')
                    {
                        if (grd.Rows[_RowIndex].Cells["DCRes"].Value.ToString() == "D")
                        {
                            grd.Rows[_RowIndex].Cells["DC"].Value = grd.Rows[_RowIndex].Cells["DCRes"].Value;
                            grd.Rows[_RowIndex].Cells["Debit"].Value = grd.Rows[_RowIndex].Cells["DebitRes"].Value;
                            grd.Rows[_RowIndex].Cells["Debit"].ReadOnly = false;

                            grd.Rows[_RowIndex].Cells["Credit"].Value = 0;
                            grd.Rows[_RowIndex].Cells["Credit"].ReadOnly = true;
                        }
                        else
                        {
                            grd.Rows[_RowIndex].Cells["DC"].Value = grd.Rows[_RowIndex].Cells["DCRes"].Value;
                            grd.Rows[_RowIndex].Cells["Credit"].Value = grd.Rows[_RowIndex].Cells["CreditRes"].Value;
                            grd.Rows[_RowIndex].Cells["Credit"].ReadOnly = false;

                            grd.Rows[_RowIndex].Cells["Debit"].Value = 0;
                            grd.Rows[_RowIndex].Cells["Debit"].ReadOnly = true;
                        }
                    }

                    //SET BACKGROUND COLOR
                    if (grd.Rows[_RowIndex].Cells["Debit"].ReadOnly == true)
                    {
                        grd.Rows[_RowIndex].Cells["Debit"].Style.BackColor = Color.FromArgb(236, 233, 216);

                        if (_RowIndex % 2 == 0)
                        {
                            grd.Rows[_RowIndex].Cells["Credit"].Style.BackColor = Color.FromArgb(217, 227, 222);
                        }
                        else
                        {
                            grd.Rows[_RowIndex].Cells["Credit"].Style.BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }

                    if (grd.Rows[_RowIndex].Cells["Credit"].ReadOnly == true)
                    {
                        grd.Rows[_RowIndex].Cells["Credit"].Style.BackColor = Color.FromArgb(236, 233, 216);

                        if (_RowIndex % 2 == 0)
                        {
                            grd.Rows[_RowIndex].Cells["Debit"].Style.BackColor = Color.FromArgb(217, 227, 222);
                        }
                        else
                        {
                            grd.Rows[_RowIndex].Cells["Debit"].Style.BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }

                    txtTotalDebit.Text = string.Format("{0:#,##0}", GetTotal("DEBIT"));
                    txtTotalKredit.Text = string.Format("{0:#,##0}", GetTotal("CREDIT"));
                    setColorTextBoxDC();
                    setOutOfBalance();
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (grd.CurrentCell.ColumnIndex == 12 || grd.CurrentCell.ColumnIndex == 13)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (grd.CurrentCell.ColumnIndex)
            {
                case 0:
                    {
                        lblInformation.Text = "Branch";
                        break;
                    }
                case 1:
                    {
                        lblInformation.Text = "Branch";
                        break;
                    }
                case 2:
                    {
                        lblInformation.Text = "Division";
                        break;
                    }
                case 3:
                    {
                        lblInformation.Text = "Department";
                        break;
                    }
                case 4:
                    {
                        lblInformation.Text = "Major 1";
                        break;
                    }
                case 5:
                    {
                        lblInformation.Text = "Major 2";
                        break;
                    }
                case 6:
                    {
                        lblInformation.Text = "Minor";
                        break;
                    }
                case 7:
                    {
                        lblInformation.Text = "Analysis";
                        break;
                    }
                case 8:
                    {
                        lblInformation.Text = "Filer";
                        break;
                    }
                case 9:
                    {
                        lblInformation.Text = "Sub Ledger / Address Book";
                        break;
                    }
                case 10:
                    {
                        lblInformation.Text = "Description";
                        break;
                    }
                case 11:
                    {
                        lblInformation.Text = "D/C/A";
                        break;
                    }
                case 12:
                    {
                        lblInformation.Text = "Debit";
                        break;
                    }
                case 13:
                    {
                        lblInformation.Text = "Credit";
                        break;
                    }
                case 14:
                    {
                        lblInformation.Text = "Delete";
                        break;
                    }
            }
        }

        private double GetTotal(string _Type)
        {
            double _Total = 0;

            if (grd.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr in grd.Rows)
                {
                    if (_Type.ToUpper() == "DEBIT")
                    {
                        _Total = _Total + Convert.ToDouble(dr.Cells["Debit"].Value);
                    }
                    else
                    {
                        _Total = _Total + Convert.ToDouble(dr.Cells["Credit"].Value);
                    }
                }
            }

            return _Total;
        }

        private void setOutOfBalance()
        {
            if(Convert.ToDouble(txtTotalDebit.Text.Trim()) > Convert.ToDouble(txtTotalKredit.Text.Trim()))
            {
                lblOutOfBalanceValueCredit.Text = string.Format("{0:#,##0}", Convert.ToDouble(txtTotalDebit.Text.Trim()) - Convert.ToDouble(txtTotalKredit.Text.Trim()));
                lblOutOfBalanceValueDebit.Text = string.Empty;
            }
            else if (Convert.ToDouble(txtTotalDebit.Text.Trim()) < Convert.ToDouble(txtTotalKredit.Text.Trim()))
            {
                lblOutOfBalanceValueCredit.Text = string.Empty;
                lblOutOfBalanceValueDebit.Text = string.Format("{0:#,##0}", (Convert.ToDouble(txtTotalKredit.Text.Trim()) - Convert.ToDouble(txtTotalDebit.Text.Trim())));
            }
            else
            {
                lblOutOfBalanceValueCredit.Text = string.Empty;
                lblOutOfBalanceValueDebit.Text = string.Empty;
            }
        }

        private void setColorTextBoxDC()
        {
            if (Convert.ToDouble(txtTotalDebit.Text.Trim()) == Convert.ToDouble(txtTotalKredit.Text.Trim()))
            {
                txtTotalDebit.BackColor = Color.FromArgb(128, 255, 128);
                txtTotalKredit.BackColor = Color.FromArgb(128, 255, 128);
            }
            else
            {
                txtTotalDebit.BackColor = Color.FromArgb(255, 128, 128);
                txtTotalKredit.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void grd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtTotalDebit.Text = string.Format("{0:#,##0}", GetTotal("DEBIT"));
            txtTotalKredit.Text = string.Format("{0:#,##0}", GetTotal("CREDIT"));
            setOutOfBalance();
            setColorTextBoxDC();
        }

        private void grd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grd.CurrentCell.ColumnIndex == 12 || grd.CurrentCell.ColumnIndex == 13)
            {
                if (grd.CurrentCell.ColumnIndex == 12)
                {
                    if (grd.Rows[e.RowIndex].Cells["Debit"].Value.ToString() == "")
                    {
                        grd.Rows[e.RowIndex].Cells["Debit"].Value = 0;
                    }

                    grd.Rows[e.RowIndex].Cells["Debit"].Value = string.Format("{0:#,##0}", Convert.ToDouble(grd.Rows[e.RowIndex].Cells["Debit"].Value));
                    txtTotalDebit.Text = string.Format("{0:#,##0}", GetTotal("DEBIT"));
                }
                else if (grd.CurrentCell.ColumnIndex == 13)
                {
                    if (grd.Rows[e.RowIndex].Cells["Credit"].Value.ToString() == "")
                    {
                        grd.Rows[e.RowIndex].Cells["Credit"].Value = 0;
                    }

                    grd.Rows[e.RowIndex].Cells["Credit"].Value = string.Format("{0:#,##0}", Convert.ToDouble(grd.Rows[e.RowIndex].Cells["Credit"].Value));
                    txtTotalKredit.Text = string.Format("{0:#,##0}", GetTotal("CREDIT"));
                }

                setOutOfBalance();
                setColorTextBoxDC();
                _IsEditNumeric = false;
            }           
        }

        private void grd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(_IsEditNumeric == false)
            {
                grd.Columns["Debit"].DefaultCellStyle.Format = "N0";
                grd.Columns["Credit"].DefaultCellStyle.Format = "N0";
            }
        }

        private void grd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {         
            if(grd.CurrentCell.ColumnIndex == 12 || grd.CurrentCell.ColumnIndex == 13)
            {
                if (grd.CurrentCell.ColumnIndex == 12)
                {
                    grd.Rows[e.RowIndex].Cells["Debit"].Value = grd.Rows[e.RowIndex].Cells["Debit"].Value.ToString().Replace(",", "");
                }
                else if (grd.CurrentCell.ColumnIndex == 13)
                {
                    grd.Rows[e.RowIndex].Cells["Credit"].Value = grd.Rows[e.RowIndex].Cells["Credit"].Value.ToString().Replace(",", "");
                }

                grd.RefreshEdit();
                grd.NotifyCurrentCellDirty(true);
                _IsEditNumeric = true;
            }         
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd.CurrentCell.ColumnIndex == 14)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grd.Rows[e.RowIndex].Cells["Delete"];
                if (Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.FalseValue))
                {
                    if(grd.Rows[e.RowIndex].Cells["DC"].Value.ToString() == "D")
                    {
                        grd.Rows[e.RowIndex].Cells["Debit"].Value = "0";
                        grd.Rows[e.RowIndex].Cells["Debit"].ReadOnly = true;
                    }
                    else if (grd.Rows[e.RowIndex].Cells["DC"].Value.ToString() == "C")
                    {
                        grd.Rows[e.RowIndex].Cells["Credit"].Value = "0";
                        grd.Rows[e.RowIndex].Cells["Credit"].ReadOnly = true;
                    }

                    grd.Rows[e.RowIndex].Cells["DC"].ReadOnly = true;
                }
                else if(Convert.ToBoolean(chk.Value) == Convert.ToBoolean(chk.TrueValue))
                {
                    if (grd.Rows[e.RowIndex].Cells["DC"].Value.ToString() == "D")
                    {
                        grd.Rows[e.RowIndex].Cells["Debit"].Value = "0";
                        grd.Rows[e.RowIndex].Cells["Debit"].ReadOnly = false;
                    }
                    else if (grd.Rows[e.RowIndex].Cells["DC"].Value.ToString() == "C")
                    {
                        grd.Rows[e.RowIndex].Cells["Credit"].Value = "0";
                        grd.Rows[e.RowIndex].Cells["Credit"].ReadOnly = false;
                    }

                    grd.Rows[e.RowIndex].Cells["DC"].ReadOnly = false;
                }

                txtTotalDebit.Text = string.Format("{0:#,##0}", GetTotal("DEBIT"));
                txtTotalKredit.Text = string.Format("{0:#,##0}", GetTotal("CREDIT"));
                setOutOfBalance();
                setColorTextBoxDC();
            }
        }
    }
}
