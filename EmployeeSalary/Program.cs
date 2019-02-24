using System;
using System.Globalization;
using System.Collections.Generic;

/*
 * An exercise using Lists, proposed by Udemy's teacher Dr. Nelio Alves 
 */

namespace EmployeeSalary {
    class Program {
        static void Main(string[] args) {
            int employeeNum, idIncrease;
            double increasePercent;
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            employeeNum = int.Parse(Console.ReadLine());

            for (int i = 0; employeeNum > i; i++) {
                int id;
                String name;
                double salary;
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            idIncrease = int.Parse(Console.ReadLine());

            // In here we test if the id reaaly exists on Employee's list
            if (employees.Find(x => x.Id == idIncrease) != null){
                Console.Write("Enter the percentage: ");
                increasePercent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                List<Employee> list = employees.FindAll(x => x.Id == idIncrease);
                foreach (Employee e in list) {
                    e.SalaryIncrease(increasePercent);
                }
            }
            else {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee x in employees) {
                Console.WriteLine(x);
            }
        }
    }
}
