using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _06.CompanyRoaster
{
    class Employee
    {
        public string name;
        public double salary;
        public string position;
        public string department;
        public string email = "n/a";
        public int age = -1;

        public Employee(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }
    }
}
