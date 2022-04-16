using System;
using System.Collections.Generic;

namespace DelegateTask2
{
    class Program
    {
      static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Salary = 1000
            };
            Employee employee2 = new Employee
            {
                Salary = 1500
            };
            Employee employee3 = new Employee
            {
                Salary = 2500
            };
            Employee employee4 = new Employee
            {
                Salary = 800
            };

            Company company = new Company();
            company.Employees.Add(employee1);
            company.Employees.Add(employee2);
            company.Employees.Add(employee3);
            company.Employees.Add(employee4);

            Console.WriteLine(company.Exists(x=>x.Salary>4000));

            Console.WriteLine(company.Employees.Exists(x=>x.Salary>4000));

            foreach (var item in company.Employees.FindAll(x=>x.Salary>1000))
            {
                Console.WriteLine(item.Salary);
            }
    }
}
