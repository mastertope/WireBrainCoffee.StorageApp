using System;

namespace WireBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployee(employeeRepository);
            GetEmployeeById(employeeRepository);            

            var organizationRepository = new GenericRepository<Organization>();
            AddOrganization(organizationRepository);            

            Console.ReadLine();
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            System.Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
        }

        private static void AddEmployee(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Casper" });
            employeeRepository.Add(new Employee { FirstName = "Whitney" });
            employeeRepository.Add(new Employee { FirstName = "Jacob" });
            employeeRepository.Save();
        }

        private static void AddOrganization(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "PluralSight" });
            organizationRepository.Add(new Organization { Name = "Globalmantics" });
            organizationRepository.Save();
        }
    }
}
