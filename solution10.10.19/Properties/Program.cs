using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {

            //instaniate object
            Employee e = new Employee();

            e.Name = "Hellllllooooo";
            e.ID = 940049334;
            e.pay = 1235.50;

            e.PrintState();
        }
    }
}
