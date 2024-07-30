using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmployee
{
    class Employee
    {
        private int _id;
        private string _name;
        private double _salary;

        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public int getIdEmployee()
        {
            return _id;
        }

        public void increaseSalary(double percentage)
        {
            _salary += percentage * _salary / 100.0;
        }

        public override string ToString()
        {
            return $"Id: {_id}, Name: {_name}, Salary: {_salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
