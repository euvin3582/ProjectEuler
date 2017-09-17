using ProjectEuler1.Enums;
using ProjectEuler1.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1 {
    class Program {
        static void Main(string[] args) {
            StringBuilder description = new StringBuilder("Project Euler");
            description.AppendLine("Project Euler provides a large collection of challenges in the domain of computer science and mathematics.");
            description.AppendLine("The challenges typically involve writing a small program to figure out the solution");
            description.AppendLine("to a clever mathematical formula or equation, such as finding the sum of digits");
            description.AppendLine("of all numbers preceding each number in a series.\n");
            description.AppendLine("Bellow is a list of the problems to pick from to get a solution for\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(description);

            int id = -1;
            foreach(var value in Enum.GetValues(typeof(EulerProblems))) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write((int)value + ": " + value + "\n");
                id = (int)value;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nType in a number to get Problems answers.\n");
            var input = Console.ReadKey();
            Console.WriteLine();

            // stops wrong inputs
            int number = 0;
            while(!Int32.TryParse(input.KeyChar.ToString(), out number) || (number > id || number == 0)) {
                Console.Write("\nPick a number from the list of problems.\n");
                input = Console.ReadKey();
            }


            // Get a enum value to check agaisnt list
            if(Enum.IsDefined(typeof(EulerProblems), number)) {

                var problem = (EulerProblems)number;
                Console.Clear();

                switch(problem) {
                    case EulerProblems.MultiplesOf3And5:
                        MultiplesOf3And5.SolveMultiples();
                        break;

                    case EulerProblems.EvenFibonacciNumbers:
                        EvenFibonacciNumbers.SolveEvenFibonacci();
                        break;
                }
            }

            // pause at the end
            Console.Read();

        }
    }
}
