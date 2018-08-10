using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    //#1 Make the Employee class take a generic type parameter. I named it hamlet
    public class Employee<hamlet> : Person
    {
        //#2 Add property called things and have it's data type match 
        //the generic type on the class.
        public List<hamlet> Things { get; set; }
    }

 