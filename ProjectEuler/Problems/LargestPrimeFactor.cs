using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1.Problems {
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class LargestPrimeFactor {

        public static void ComputeLargestPrime() {
            Console.ForegroundColor = ConsoleColor.Red;
            var summary = new StringBuilder("Problem 3: Largest prime factors\n\n");
            summary.AppendLine("The prime factors of 13195 are 5, 7, 13 and 29.");
            summary.AppendLine("What is the largest prime factor of the number 600851475143 ?\n");
            Console.Write(summary);

            // print answer
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Answer\n");
            Console.Write(ComputeAnswer());
        }

        private static long ComputeAnswer() {
            var sqrt = (int)Math.Sqrt(600851475143);
            var factors = new List<long>();
            var primeFactors = new List<long>();

            try {
                for(long i = 1; i < sqrt; i++) {

                    if(600851475143 % i == 0)
                        factors.Add(i);
                }

                factors.ForEach(x => {
                    int factor = 0;

                    for(long i = 2; i <= x; i++) {
                        if(x % i == 0)
                            factor++;
                    }

                    if(factor == 1)
                        primeFactors.Add(x);
                });
            } catch(Exception xcptn) {
                Console.Write(xcptn);
            }
            return primeFactors.Last();
        }
    }
}
