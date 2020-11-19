using System;
using Project_Euler;

namespace Project_Euler
{
    public class UserInterface
    {
        ProblemsLevel1 _level1 = new ProblemsLevel1();
        public void Start()
        {
            Console.WriteLine("Welcome to the Project Euler Solution Selector!");
            Console.WriteLine();
            Console.Write("Input: ");
            //int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine(_level1.LargestProductInSeries(13));
        }

        private void SolutionSelection(int problemNumber)
        {
            
        }
    }
}