using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPOTE_JAYVEE_IT105L_C11
{
    public class Warehouse1
    {
        public String property1 { get; set; }
        public String property2 { get; set; }
        public String property3 { get; set; }
        public String property4 { get; set; }

        public Warehouse1(string name, string city, string province, string buildingnumber)
        {
            property1 = name;
            property2 = city;
            property3 = province;
            property4 = buildingnumber;
        }


    }

    public class Employee1 : Warehouse1
    {
        public Employee1(string firstname, string lastname, string employeeid, string dailyrate) : base(firstname, lastname, employeeid, dailyrate)
        {
            property1 = firstname;
            property2 = lastname;
            property3 = employeeid;
            property4 = dailyrate;

        }
    }

    public class Itemslist : Warehouse1
    {
        public Itemslist(string brand, string Itemname, string SerialNumber, string Price) : base(brand, Itemname, SerialNumber, Price)
        {
            property1 = brand;
            property2 = Itemname;
            property3 = SerialNumber;
            property4 = Price;
        }
    }
}
