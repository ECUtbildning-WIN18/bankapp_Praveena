using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Domain
{
    class Person
    {
        public string FirstName { get;}
        public string LastName { get;}
        private int SocialSecurityNumber { get; }
               
        public  Person(string firstname, string lastname,int socialsecuritynumber)
        {
          FirstName = firstname;
          LastName = lastname;
          SocialSecurityNumber = socialsecuritynumber;
                           
        }
    }
}
