using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Reflection.Example
{
    [CustomAttribute]
    public class Customer
    {
        private readonly Guid _guid;
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer()
        {

        }

        public Customer(string name)
        {
            Name = name;
        }
    }
}
