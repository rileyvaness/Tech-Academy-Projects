using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        int user;
        string[] stringArray = new string[5];
        stringArray[0] = "Macbeth";
        stringArray[1] = "Pericles";
        stringArray[2] = "King Lear";
        stringArray[3] = "Antony and Cleopatra";
        stringArray[4] = "Troilus and Cressida";

        Console.WriteLine("As a season ticket holder, we value your loyalty to the International Shakespeare Festival. \nAs a result, we would like to offer you free tickets to a Shakespeare show!");
        Console.WriteLine("\n");
        Console.WriteLine("Please pick a number, 0 - 4, to see which Shakespeare play you will be attening:");
        user = Convert.ToInt32(Console.ReadLine());

        bool isShow = user == 0;


        do
        {
            switch (user)
            {
                case 0:
                    Console.WriteLine("You have selected MACBETH. \n To help prepare you for the show, here is a quote: \n \n  \"Double, double toil and trouble; Fire burn, and cauldron bubble.\"(Act IV, Scene I).");
                    isShow = true;
                    break;
                case 1:
                    Console.WriteLine("You have selected PERICLES. \n To help prepare you for the show, here is a quote: \n \n  \"For death remembered should be like a mirror \n Who tells us life’s but breath, to trust it error.\" (Act I, Scene I)");
                    isShow = true;
                    break;
                case 2:
                    Console.WriteLine("You have selected KING LEAR. \n To help prepare you for the show, here is a quote: \n \n  \"Thou shouldst not have been old till thou hadst been wise.\" (Act I, Scene V).");
                    isShow = true;
                    break;
                case 3:
                    Console.WriteLine("You have selected ANTONY AND CLEOPATRA. \n To help prepare you for the show, here is a quote: \n \n  \"My salad days, \n When I was green in judgement, cold in blood.\" (Act I, Scene V).");
                    isShow = true;
                    break;
                case 4:
                    Console.WriteLine("You have selected TROILUS AND CRESSIDA. \n To help prepare you for the show, here is a quote: \n \n  \"One touch of nature makes the whole world kin.\" (Act III, Scene III) ");
                    isShow = true;
                    break;

                default:
                    Console.WriteLine("Please choose a valid number: ");

                    user = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!isShow);
        Console.WriteLine("\n");










        int[] numArray = new int[] { 5, 2, 222, 23, 78 };
        Console.WriteLine("Select 0-4, to see how many tickets we will give you to this preformance:");
        user = Convert.ToInt32(Console.ReadLine());



        bool isTickets = true;
        do
        {
            if (isTickets)
            {
                Console.WriteLine("You will recieve: " + numArray[user] +" tickets to the performance.");
                isTickets = true;
                break;

            }
            else
            {
                Console.WriteLine("The variable is set to false.");

            }
            }
            while (!isTickets) ;



            Console.WriteLine("\n");
            Console.WriteLine("Select a number 0-5, to see which theatre you will attend the perforemance at: ");
            List<string> stringList = new List<string>();
            stringList.Add("The Globe Theatre"); stringList.Add("The Swan Theatre"); stringList.Add("The Festival Theatre"); stringList.Add("The New Burbage Theatre"); stringList.Add("The Rose Theatre"); stringList.Add("The Shakespeare Center");
            user = Convert.ToInt32(Console.ReadLine());

        bool isTheatre = user == 0;
        do
        {
            switch (user)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:

                    Console.WriteLine("The theatre you chose was: " + stringList[user] + ".");
                    isTheatre = true;
                    break;


                default:
                    Console.WriteLine("Please enter a valid number.");
                    user = Convert.ToInt32(Console.ReadLine());
                    break;

            }
        }

        while (!isTheatre);

        Console.WriteLine("\n \n");
        Console.WriteLine("Once again, thank you for your ongoing support. \n We hope you enjoy watching " + stringArray[user] + ", at " + stringList[user]);
        Console.ReadLine();
    }
}   