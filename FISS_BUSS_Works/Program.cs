using System;
using System.Globalization;

namespace FISS_BUSS
{
    internal class Program
    {
        /* These are the values, I'm using to make the code, so that if I wanted to change 1 value, 
        I would be able to do so without going though all of my code */
        static int Numbers = 0;
        static int Length;

        static int FISS;
        static int BUSS;

        static string Fiss = "FISS";
        static string Buss = "BUSS";
        // By doing it this way, I'm able to make more conditions, and eddit thouse I have 

        static void Main(string[] args)
        {
            //while (true)

            Console.WriteLine("Let's play FISS - BUSS!");
            Console.Write("For how long do you witch to continue? ");
            string LengthInput = Console.ReadLine();
            Length = int.Parse(LengthInput);

            Console.Write("What number is FISS ");
            string FISSInput = Console.ReadLine();
            FISS = int.Parse(FISSInput);

            Console.Write("What numer is BUSS ");
            string BUSSInput = Console.ReadLine();
            BUSS = int.Parse(BUSSInput);

            MainNumber();

        }
        static void MainNumber()
        {
            while (Numbers != Length)
            {
                Numbers++;
                if (Numbers % FISS != 0 && Numbers % BUSS != 0)
                {
                    Console.WriteLine(Numbers);
                }

                FISS_BUSS();

            }

        }

        static void FISS_BUSS()
        {
            if (Numbers % FISS == 0 && Numbers % BUSS == 0)
            {
                Console.WriteLine(Fiss + Buss);
            }

            else if (Numbers % FISS == 0)
            {
                Console.WriteLine(Fiss);
            }

            else if (Numbers % BUSS == 0)
            {
                Console.WriteLine(Buss);
            }

        }

    }
}