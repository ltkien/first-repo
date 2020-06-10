using System;

namespace doForAss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you love me ?");
            Console.WriteLine("Press 1 : YES");
            Console.WriteLine("Press 2 : NO");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 2)
            {
                do
                {
                    Console.WriteLine("You can do that !!");
                    Console.WriteLine("Press again");
                    answer = int.Parse(Console.ReadLine());

                } while (answer == 2);
            }
            Console.WriteLine("I love you too <3 <3 <3 <3 <3 <3 <3  ");
        }
    }
}
