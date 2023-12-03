using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Employee
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] HireDate;
        public int Salary;

        public string GetFullInfo()
        {
            string hireDateString = $"{HireDate[0]}-{HireDate[1]}-{HireDate[2]}";
            return $"Name: {Name}, Vacancy: {Vacancy}, Hire Date: {hireDateString}, Salary: {Salary}";
        }
    }
}

