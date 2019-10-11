using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.PrintState();
            Console.WriteLine();

            Employee e2 = new Employee("Hellllllooooo");
            e2.PrintState();
            Console.WriteLine();

            Employee e3 = new Employee("Hellllllooooo, 940049334, 1235.50");
            e3.PrintState();
        }
    }
}
