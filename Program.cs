using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int countBeers = 0;
            int countParty = 0;
            int countWorkOnProject = 0;
            int countForce = 0;
            int countAll = 0;
            string action = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    countBeers++;
                    countAll++;
                }
                else if (numbers[i] == 1)
                {
                    countParty++;
                    countAll++;
                }
                else if (numbers[i] == 2)
                {
                    countWorkOnProject++;
                    countAll++;
                }
                else if (numbers[i] == 3)
                {
                    countForce++;
                    countAll++;
                }
                if (countBeers == 3)
                {
                    action = "Beers!";
                    break;
                }
                else if (countParty == 3)
                {
                    action = "Party";
                    break;
                }
                else if (countWorkOnProject == 3)
                {
                    action = "Work on the project";
                    break;
                }
                else if (countForce == 3)
                {
                    action = "May the DSA Force be with you!";
                    break;
                }
                
            }
            
            Console.WriteLine($"{countAll}: {action}");
        }
    }
}
