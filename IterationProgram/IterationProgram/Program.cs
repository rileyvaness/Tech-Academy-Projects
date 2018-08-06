using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {



        // #1 One dimensional Array of strings, that will display input
        // from user.
        string[] shows = new string[] { "The Globe Theatre", "The Rose Theatre", "The Swan Theatre" };

        Console.WriteLine("Please type in a show and we will add it to the list of Theatres: ");

        string input = Console.ReadLine();



        for (int i = 0; i < shows.Length; i++)

        {

            shows[i] = shows[i] + ".........." + input;

            Console.WriteLine(shows[i]);

        }
        Console.ReadLine();
        //Console.ReadLine();

        //# 2 infinite loop
        //Console.WriteLine("King Lear with an infinite loop: ");
        //int Lear = 5;
        //    while(Lear > 0
        //{
        //    Console.WriteLine("Blow, winds, and crack your cheeks! rage! blow!");
        //}

        //  #3 Fixed infinite loop. 
        Console.WriteLine("King Lear with a fixed infinite loop: ");
        int Lear = 5;
        while (Lear > 0)
        {

            Console.WriteLine("Blow, winds, and crack your cheeks! rage! blow!");
            Lear--;
        }
        Console.ReadLine();

        //#4 Create a loop where the comparison used to determine 
        //wether to continue iterating the loop is a "<" operator.

        int sonnetsWritten = 0;
        while (sonnetsWritten < 10)
        {
            sonnetsWritten++;
            Console.WriteLine("I have written {0} sonnet(s)", sonnetsWritten);

        }
        Console.WriteLine("I can't think of anymore sonnet ideas...");
        Console.ReadLine();

        //#5 Create a loop where the comparison used to determine 
        //whether to continue iterating the loop is a “<=” operator.
        // Here I made a simple program that subtracts money from the user's 
        //total money everytime they see a play. It writes out a lits of how
        //many plays one could watch with the amount of cash they have on hand
        //and cost for each play.



        int money = 50;

        int playCost = 4;

        int playsWatched = 0;

        while (playCost <= money)
        {

            playsWatched++;

            money = money - playCost;

            Console.WriteLine("I have seen {0} play(s) and have spent {1:c}. I have {2:c} left.", playsWatched, (playsWatched * playCost), money);

        }
        Console.ReadLine();

        //#6  Create a List of strings where each item in the list is unique. 
        //Ask the user to select text to search for in the List. 
        //Create a loop that iterates through the loop 
        //and then displays the index of the array
        //that contains matching text on the screen.

        string[] thisSeason = new string[] { "Romeo and Juliet", "Julius Caesar", "The Comedy of Errors", "Twelfth Night", "Love's Labours Lost", "Macbeth", "King Lear", "Hamlet", "Two Gentlemen of Verona", "The Two Noble Kinsmen", "Henry VIII", "Timon of Athens" };
        Console.WriteLine("Please type in a Shakespeare show to see if it is playing this season: ");
        string search = Console.ReadLine();
        int notPlaying = 0;
        for (int i = 0; i < thisSeason.Length; i++)
            if (search == thisSeason[i])
            {
                Console.WriteLine(search + " will be playing this season! It has an index number of {0}.", i);


                // #8 Add code to that above loop that stops it from executing once a match has been found.
                i = thisSeason.Length;
            }
            //#7 Add code to that above loop that tells a user if 
            //they put in text that isn’t in the List.
            else
            {
                notPlaying++;
            }
        if (notPlaying == thisSeason.Length)
        {
            Console.Write("Sorry, we will not be playing " + search + "this season.");
        }

        // #9 Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
        //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.

        string[] Characters = new string[] { "Falstaff", "Henry", "Touchstone", "Audrey", "Quince", "Botton", "Falstaff", "Orlando", "Jaques", "Jacques", "Jacques", "Rosalind", "Quince", "Falstaff", "Rosalind", "Orlando" };
        Console.WriteLine("Please enter the character you would like to find: ");
        string yourSearch = Console.ReadLine();
        int notThere = 0;
        for (int c = 0; c < Characters.Length; c++)
        {
            if (yourSearch == Characters[c])
            {
                Console.WriteLine(yourSearch + " appears in the following index number: {0}.", c);
            }
            else
            {
                notThere++;
            }
            //# 10.Add code to that above loop that tells a user if they 
            //  put in text that isn’t in the List.
            if (notThere == Characters.Length)
                Console.WriteLine("We can not find " + yourSearch + " in our database.");


        }
        Console.ReadLine();


        // #11.Create a List of strings that has at 
        //least two identical strings in the List. 
        //Create a foreach loop that evaluates each item in the list, 
        //   and displays a message showing the string
        //  and whether or not it has already appeared in the list.


        List<string> histories = new List<string>() { "Richard II", "Henry IV, part I", "Henry IV, part II", "Henry V", "Henry VI, part I", "Henry VI, part 2", "Henry VI, part III", "Richard III", "Richard II", "Henry VI, part I", "Henry VI, part 2" };
        List<string> inList = new List<string>();
        foreach (string history in histories)
        {
            Console.Write(history);
            if (inList.Contains(history))
            {
                Console.WriteLine("(This history play is already in the list.)");
            }
        
        else 
        {
            Console.WriteLine();
        }
        inList.Add(history);
    }
    Console.ReadLine();


















       Console.WriteLine(thisSeason[2]);

        Console.ReadLine();










    }
}
  
