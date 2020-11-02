using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.RC
{
    class RCRelativeBL
    {
        private int id;
        private string rep_Id;
        private string rel_Name;
        private string sta;
        private string addr_1;
        private string addr_2;
        private string addr_3;
        private string city;
        private string phone_Num;
        private string child_1_Name;
        private DateTime? dt_Of_Birth1;
        private string child_2_Name;
        private DateTime? dt_Of_Birth2;
        private string child_3_Name;
        private DateTime? dt_Of_Birth3;
        private string school_Child1;
        private string school_Child2;
        private string school_Child3;
        private string school_Add_Child1;
        private string school_Add_Child2;
        private string school_Add_Child3;

        public int Id { get => id; set => id = value; }
        public string Rep_Id { get => rep_Id; set => rep_Id = value; }
        public string Rel_Name { get => rel_Name; set => rel_Name = value; }
        public string Sta { get => sta; set => sta = value; }
        public string Addr_1 { get => addr_1; set => addr_1 = value; }
        public string Addr_2 { get => addr_2; set => addr_2 = value; }
        public string Addr_3 { get => addr_3; set => addr_3 = value; }
        public string City { get => city; set => city = value; }
        public string Phone_Num { get => phone_Num; set => phone_Num = value; }
        public string Child_1_Name { get => child_1_Name; set => child_1_Name = value; }
        public DateTime? Dt_Of_Birth1 { get => dt_Of_Birth1; set => dt_Of_Birth1 = value; }
        public string Child_2_Name { get => child_2_Name; set => child_2_Name = value; }
        public DateTime? Dt_Of_Birth2 { get => dt_Of_Birth2; set => dt_Of_Birth2 = value; }
        public string Child_3_Name { get => child_3_Name; set => child_3_Name = value; }
        public DateTime? Dt_Of_Birth3 { get => dt_Of_Birth3; set => dt_Of_Birth3 = value; }
        public string School_Child1 { get => school_Child1; set => school_Child1 = value; }
        public string School_Child2 { get => school_Child2; set => school_Child2 = value; }
        public string School_Child3 { get => school_Child3; set => school_Child3 = value; }
        public string School_Add_Child1 { get => school_Add_Child1; set => school_Add_Child1 = value; }
        public string School_Add_Child2 { get => school_Add_Child2; set => school_Add_Child2 = value; }
        public string School_Add_Child3 { get => school_Add_Child3; set => school_Add_Child3 = value; }
    }

    class RCRelativeChildBL
    {
        private string childName;
        private DateTime? childBirthDate;
        private string childSchoolName;
        private string childSchoolAddress;

        public string ChildName { get => childName; set => childName = value; }
        public DateTime? ChildBirthDate { get => childBirthDate; set => childBirthDate = value; }
        public string ChildSchoolName { get => childSchoolName; set => childSchoolName = value; }
        public string ChildSchoolAddress { get => childSchoolAddress; set => childSchoolAddress = value; }
    }
}
