using System;

namespace WireBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();

            employeeRepository.Add(new Employee {FirstName = "Casper"});
            employeeRepository.Add(new Employee {FirstName = "Whitney"});
            employeeRepository.Add(new Employee {FirstName = "Jacob"});

            employeeRepository.Save();

            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization {Name = "PluralSight"});
            organizationRepository.Add(new Organization {Name = "Globalmantics"});

            organizationRepository.Save();
            
            Console.ReadLine();
        }
    }
}
