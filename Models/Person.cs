using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Models
{
    internal class Person
    {
        public Person(string name, string surname, string address, int salary)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Salary = salary;

        }
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        
    }
}
