using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Rules rules = new Rules();
            Console.WriteLine("Podaj liczbe iteracji");
            string amounOfIteration = Console.ReadLine();
            int numberOfIteration = int.Parse(amounOfIteration);
            int numberOfCells = 50;
         
            int[,] tab = new int[numberOfIteration,numberOfCells+2];

            for (int i = 0; i < numberOfIteration; i++)
            {
                for (int j = 0; j < numberOfCells+2; j++)
                {
                    if (i == 0 && j == (numberOfCells+2)/2)
                        tab[i, j] = 1;
                    else 
                        tab[i, j] = 0;
                }
            }

            rules.Rule30(tab, numberOfIteration, numberOfCells);
            Console.WriteLine("Rule 30 - Results: ");
            rules.showResults(tab, numberOfIteration, numberOfCells);
            Console.WriteLine();
            rules.Rule60(tab, numberOfIteration, numberOfCells);
            Console.WriteLine("Rule 60 - Results: ");
            rules.showResults(tab, numberOfIteration, numberOfCells);
            Console.WriteLine();
            rules.Rule90(tab, numberOfIteration, numberOfCells);
            Console.WriteLine("Rule 90 - Results: ");
            rules.showResults(tab, numberOfIteration, numberOfCells);
            Console.WriteLine();

            Console.ReadKey();

        }
       
    }

   
}
