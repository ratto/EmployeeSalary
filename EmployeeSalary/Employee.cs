using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeeSalary {
    class Employee {
        private String _name;
        private double _salary;
        public int Id { get; set; }

        public Employee(int id, String name, double salary) {
            Id = id;
            _name = name;
            _salary = salary;
        }

        public void SalaryIncrease(double increase) {
            _salary = _salary + _salary * (increase / 100);
        }

        public override string ToString() {
            return Id
                + ", "
                + _name
                + ", "
                + _salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
