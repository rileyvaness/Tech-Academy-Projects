using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        //#1 Abstract class Person with two properties.
     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //#2 method of sayName()
        public abstract void sayName(string FirstName, string LastName);
       
        
        
       
       
    }
}
