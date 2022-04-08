using System;
using System.Collections.Generic;

namespace DelegateTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Fullname = "Hikmet", Salary =  33 };
            Employee employee2 = new Employee { Fullname = "Sabir", Salary = 120 };
            Employee employee3 = new Employee { Fullname = "Huseyn", Salary = 123 };

            Company company = new Company();
            company.Emplo

            List<Employee> result = company.FindAll(x=>x.Salary>100);
            Employee employeeNeed = company.Find(x=>x.Fullname=="Hikmet");
            bool check = company.Exists(x=>x.Salary<1000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("====================");
            Console.WriteLine(employeeNeed.Fullname + " " + employee1.Salary);
            Console.WriteLine("====================");
            Console.WriteLine(check);
        }
    }
}
