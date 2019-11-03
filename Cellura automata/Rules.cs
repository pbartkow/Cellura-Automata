using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rules
    {
        public void Rule30(int[,] tab, int numberOfIteration, int numberOfCells)
        {
            for (int i = 1; i < numberOfIteration; i++)
            {
                for (int j = 1; j < numberOfCells + 1; j++)
                {
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 0;

                }
            }
        }
        public void Rule90(int[,] tab, int numberOfIteration, int numberOfCells)
        {
            for (int i = 1; i < numberOfIteration; i++)
            {
                for (int j = 1; j < numberOfCells + 1; j++)
                {
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 0;

                }
            }
        }
        public void Rule60(int[,] tab, int numberOfIteration, int numberOfCells)
        {
            for (int i = 1; i < numberOfIteration; i++)
            {
                for (int j = 1; j < numberOfCells + 1; j++)
                {
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 1 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 1 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 1;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 1)
                        tab[i, j] = 0;
                    if (tab[i - 1, j - 1] == 0 && tab[i - 1, j] == 0 && tab[i - 1, j + 1] == 0)
                        tab[i, j] = 0;

                }
            }
        }
        public void showResults(int[,] tab, int iterations, int cells)
        {
            for (int i = 0; i < iterations; i++)
            {
                for (int j = 0; j < cells + 2; j++)
                {
                    Console.Write(" " + tab[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
