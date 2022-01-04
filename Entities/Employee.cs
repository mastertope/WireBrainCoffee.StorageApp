using System;
using System.Collections.Generic;

namespace WireBrainCoffee.StorageApp
{
    public class Employee : EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}"; 
    }
}