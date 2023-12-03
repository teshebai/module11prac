using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace module11prac
{
    internal class Program
    {
        static void Main()
        {
            Employee employee1;
            employee1.Name = "John Doe";
            employee1.Vacancy = Vacancies.Manager;
            employee1.HireDate = new int[] { 2022, 11, 15 };
            employee1.Salary = 50000;

            Console.WriteLine("Employee 1:");
            Console.WriteLine(employee1.GetFullInfo());

        }
    }
}