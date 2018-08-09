using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    //#3 Create an employee clas and have it inherit from Person class. 
    //Give it a Id type with data set Int.
    class Employee : Person
    {
        public int Id { get; set; }
    }
}
