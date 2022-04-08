using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask2
{
    public class Company
    {
        public string Name { get; set; }
        List<Employee> Employees = new List<Employee>();

        public List<Employee> FindAll(Predicate<Employee> predicate)
        {
            List<Employee> NewEmployees = new List<Employee>();
            foreach (var item in Employees)
            {
                if (predicate(item))
                {
                    NewEmployees.Add(item);
                }
            }
            return NewEmployees;
        }

        public Employee Find(Predicate<Employee> predicate)
        {
            foreach (var item in Employees)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return null;
        }

        public bool Exists(Predicate<Employee> predicate)
        {
            foreach (var item in Employees)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
