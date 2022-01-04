using WireBrainCoffee.StorageApp;
using System.Collections.Generic;
using System;

namespace WireBrainCoffee
{
    public class EmployeeRepository
    {
        private readonly List<Employee> _employees = new();
        public void Add (Employee employee)
        {
            _employees.Add(employee);
        }

        public void Save()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}