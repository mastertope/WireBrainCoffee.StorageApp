using System;
using System.Collections.Generic;

namespace WireBrainCoffee.StorageApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}"; 
    }

}