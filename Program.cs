using System;

namespace WireBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();

            employeeRepository.Add(new Employee {FirstName = "Casper"});
            employeeRepository.Add(new Employee {FirstName = "Whitney"});
            employeeRepository.Add(new Employee {FirstName = "Jacob"});

            employeeRepository.Save();

            Console.ReadLine();
        }
    }
}
