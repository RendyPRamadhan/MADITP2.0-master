using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls.Expressions;
using System.Windows.Forms;
using MADITP2._0.userInterface;

namespace MADITP2._0.Global
{
    class clsEventButton
    {
        public enum EnumAction
        {
            NEW,
            EDIT,
            DELETE,
            PRINT,
            SEARCH,
            BROWSE,
            SAVE,
            CANCEL,
            DISPLAY,
            EXIT,
            VIEW,
            EXPORT,
            PROSES,
            NONE
        }

        public EnumAction getEventType(String _Key)
        {
            EnumAction enumAction = new EnumAction();
            switch (_Key)
            {
                case "F1":
                    enumAction = EnumAction.NEW;
                    break;
                case "F2":
                    enumAction = EnumAction.EDIT;
                    break;
                case "F3":
                    enumAction = EnumAction.DELETE;
                    break;
                case "F4":
                    enumAction = EnumAction.PRINT;
                    break;
                case "F5":
                    enumAction = EnumAction.EXPORT;
                    break;
                case "F6":
                    enumAction = EnumAction.SEARCH;
                    break;
                case "F7":
                    enumAction = EnumAction.BROWSE;
                    break;
                case "F8":
                    enumAction = EnumAction.PROSES;
                    break;
                case "F9":
                    enumAction = EnumAction.CANCEL;
                    break;
                case "F10":
                    enumAction = EnumAction.SAVE;
                    break;
                case "F11":
                    enumAction = EnumAction.DISPLAY;
                    break;
                case "F12":
                    enumAction = EnumAction.VIEW;
                    break;
                case "Escape":
                    enumAction = EnumAction.EXIT;
                    break;
                default:
                    enumAction = EnumAction.NONE;
                    break;
            }
            return enumAction;
        }
    }
}
