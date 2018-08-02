using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "\"The Comedy of Errors\"";
            string name1 = "\"Romeo and Juliet\"";
            string name2 = "\"Henry V\"";
            string country = "United States of America";
            string country1 = "Croatia";
            string country2 = "England";
            string theater = "The Globe theater";
            //Her I convert a string to uppercase
            theater = theater.ToUpper();
            //Here I concate three strings 

            
            string quote = "This year the International Shakespeare festival will present: \n \n \t" + name + ".......... " + country + "\n \t" + name1 + ".......... " + country1 + "\n \t" + name2 + ".......... " + country2;
          
           
           
            Console.WriteLine(quote);
            Console.WriteLine("\n \n \n \n");
            Console.WriteLine(theater);
            Console.WriteLine("\n");

            //Here I create a string builder and build a paragraph of text one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append(" Located in the heart of London.");
            sb.Append(" The Globe Theatre is a replica of the original Globe theatre, constructed in 1599.");
            sb.Append(" Unfortunately, it burned down in 1612, due to cannon fire during a preformance.");
            sb.Append(" Reconstructed in 1997, it has helped to cement a deep love for renaissance theatre.");
            sb.Append(" The International Shakespeare Festival was founded in 2000, with hopes of promoting peace and unity throughout the world.");
            sb.Append(" Often referred to as the \"Olympics of Theatre\" the Festival has played host to over 80 countries through out the world.");
            sb.Append(" We are looking forward to this new season and hope you will join us!");
            Console.WriteLine(sb);
            Console.ReadLine();
           
            
        }
    }
}
