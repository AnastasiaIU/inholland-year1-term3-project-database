using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public abstract class Person
    {
        public string FirstName { get; set; }                                   
        public string LastName { get; set; }                                    
        public string PhoneNumber { get; set; }                                 
        public string FullName { get { return FirstName + " " + LastName; } }   //calculated property to combine FirstName and LastName
        protected Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
