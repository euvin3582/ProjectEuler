using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1.Problems {
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    ///
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public static class MultiplesOf3And5 {
        
        public static void SolveMultiples() {
            Console.ForegroundColor = ConsoleColor.Red;
            var summary = new StringBuilder("Problem: Multiples of 3 and 5\n\n");
            summary.AppendLine("If we list all the natural numbers below 10 that are multiples of 3 or 5,");
            summary.AppendLine("we get 3, 5, 6 and 9. The sum of these multiples is 23.\n");
            Console.Write(summary);

            // print answer
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Answer\n");
            Console.Write(Answer());

        }

        private static int Answer() {
            int sum = 0;

            try {
                for(int i = 1; i < 1000; i++) {
                    if(i % 3 == 0 || i % 5 == 0)
                        sum += i;
                }

            } catch(Exception xcptn) {
                Console.WriteLine(xcptn);
            }
            return sum;

        }
    }
}
