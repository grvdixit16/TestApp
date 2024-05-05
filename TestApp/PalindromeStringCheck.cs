using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class PalindromeStringCheck
    {
        public PalindromeStringCheck(string inputString)
        {
            var IsPalindrome = false;  
            if (!string.IsNullOrEmpty(inputString))
            {
                for(int i = 0; i< inputString.Length/2; i++)
                {
                    if (inputString[i] == inputString[inputString.Length - 1 - i])
                    {
                        IsPalindrome = true;
                    }
                    else
                    {
                        IsPalindrome = false;
                    }
                }   
            }
            if (!IsPalindrome)
            {
                Console.WriteLine($"Given string {inputString} is not palindrome !!");
            }
            else
            {
                Console.WriteLine($"Given string {inputString} is palindrome !!");
            }
        
        }
    }
}
