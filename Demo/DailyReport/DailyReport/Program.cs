using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Press \"Enter\" to begin ");
            Console.ReadLine();

            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\" ");
            Console.ReadLine();
            bool needsHelp = true;
            string helpStatus = Convert.ToString(needsHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string experiences = Console.ReadLine();

            Console.WriteLine("Any feedback you'd like to provide?");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            int study = Convert.ToInt32(studyTime);

            Console.WriteLine("Thank you for your answers. An instructor will be will respond to you shortly. Have a great day!");
            Console.ReadLine();
            
           

        }
    }
}
