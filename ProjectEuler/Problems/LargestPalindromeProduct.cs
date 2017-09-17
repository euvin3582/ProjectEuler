using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1.Problems {
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product 
    /// of two 2-digit numbers is 9009 = 91 × 99. 
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public static class LargestPalindromeProduct {
        public static void GetLargestPalindrome() {
            Console.ForegroundColor = ConsoleColor.Red;
            var summary = new StringBuilder("Problem 4: Largest Palindrome Product\n\n");
            summary.AppendLine("A palindromic number reads the same both ways. The largest palindrome made from the product ");
            summary.AppendLine("of two 2-digit numbers is 9009 = 91 × 99. ");
            summary.AppendLine("Find the largest palindrome made from the product of two 3-digit numbers.\n");
            Console.Write(summary);

            // print answer
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Answer\n");
            Console.Write(ComputePalindrome());
        }

        private static int ComputePalindrome() {
            var palindromes = new List<int>();

            for(var i = 100; i <= 999; i++) {
                for(var j = 100; j <= 999; j++) {
                    int temp = i * j;

                    var reversed = new string(temp.ToString().Reverse().ToArray());

                    if(temp.ToString() == reversed)
                        palindromes.Add(temp);
                }
            }
                       
            return palindromes.OrderBy(x => x).Last();
        }
    }
}
