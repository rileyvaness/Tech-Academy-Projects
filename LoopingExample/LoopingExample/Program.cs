namespace LoopingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In what year did Shakespeare die?");
            int number = Convert.ToInt32(Console.ReadLine());


            bool isYear = number == 1616;
            do
            {
                switch (number)
                {
                    case 1616:
                        Console.WriteLine("Congratulations. You guessed correctly!");
                        isYear = true;
                        break;


                    default:
                        Console.WriteLine("Sorry. Try again.");
                        Console.WriteLine("In what year did Shakespeare die?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isYear);
            Console.Read();
        }
    }
}
