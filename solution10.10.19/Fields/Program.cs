using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the object
            Employee e = new Employee();

            //print default state
            e.PrintState();
            Console.WriteLine();

            e.Setname("Hellllllooooo");
            e.SetEmpID(940049334);
            e.setCurrPay(1235.50);

            e.PrintState();
            Console.WriteLine();
            Console.WriteLine("Name: {0}", e.GetName());
        }
    }
}
