using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are we making PB and J sandwiches for?");
            string people = Console.ReadLine();
            int num1 = int.Parse(people);

            int slices = num1 * 2;

            int tbs = num1 * 2;

            int tsp = num1 * 4;

            Console.WriteLine("You need: " + slices + " slices of bread " + tbs + " tablespoons of peanut butter " + tsp + " teaspoons of jelly");

            int loaves = (int) Math.Ceiling(slices / 28.0);

            int pbjars = (int)Math.Ceiling(tbs / 32.0);

            int jjars = (int)Math.Ceiling(tsp / 48.0);

            Console.WriteLine(" Which is... " + loaves + " loaves of bread " + pbjars + " jars of peanut butter " + jjars + " jars of jelly ");

            string restart;

            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");

            do
            {
                restart = Console.ReadLine();
                


                if (restart == "yes" | restart == "y")
                {
                    Console.WriteLine("How many people are we making PB and J sandwiches for?");
                    string people2 = Console.ReadLine();
                    int num2 = int.Parse(people2);

                    int slices2 = num2 * 2;

                    int tbs2 = num2 * 2;

                    int tsp2 = num2 * 4;

                    Console.WriteLine("You need: " + slices2 + " slices of bread " + tbs2 + " tablespoons of peanut butter " + tsp2 + " teaspoons of jelly");

                    int loaves2 = (int)Math.Ceiling(slices2 / 28.0);

                    int pbjars2 = (int)Math.Ceiling(tbs2 / 32.0);

                    int jjars2 = (int)Math.Ceiling(tsp2 / 48.0);

                    Console.WriteLine(" Which is... " + loaves2 + " loaves of bread " + pbjars2 + " jars of peanut butter " + jjars2 + " jars of jelly ");

                    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");


                }

            } while (restart == "yes" | restart == "y");
                

            {
                Console.WriteLine("Goodbye!");
            }

            
































        }
    }
}
