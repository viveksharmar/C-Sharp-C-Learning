using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check it is palindrome:");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            int rev = 0, rem;

            while (num > 0)
            {
                rem = num % 10;

                rev = (rev * 10) + rem;

                num /= 10;
            }


            if (temp == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }


            Console.ReadLine(); 
        }
    }
}
