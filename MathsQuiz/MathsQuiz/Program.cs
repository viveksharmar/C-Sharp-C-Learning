using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, marks = 0;
            Console.WriteLine("Maths Quiz of 10 questions(1 mark each)\n\n");

            while (i <= 10)
            {
                Random rnd = new Random();
                int num1 = Convert.ToInt32(rnd.Next(0, 200));
                int num2 = Convert.ToInt32(rnd.Next(0, 200));
                int num3 = Convert.ToInt32(rnd.Next(0, 15));
                int rndchoice = Convert.ToInt32(rnd.Next(1, 5));
                Console.WriteLine("\nQuestion no.:"+i+"\n\n");
                i++;

                switch (rndchoice)
                {
                    case (1):
                        Console.WriteLine(num1);
                        Console.WriteLine(num2);
                        Console.Write("Add the given two numbers:");
                        int sum = Convert.ToInt32(Console.ReadLine());

                        if (sum == (num1 + num2))
                        {
                            Console.WriteLine("Correcto!");
                            marks++;
                        }
                        else
                        {
                            Console.WriteLine("Oh ho!, The correct result is " + (num1 + num2));
                        }
                        break;

                    case (2):
                        Console.WriteLine(num1);
                        Console.WriteLine(num3);
                        Console.Write("Multiply the given two numbers:");
                        int multi = Convert.ToInt32(Console.ReadLine());

                        if (multi == (num1 * num3))
                        {
                            Console.WriteLine("Correcto!");
                            marks++;
                        }
                        else
                        {
                            Console.WriteLine("Oh ho!, The correct result is " + (num1 * num3));
                        }
                        break;

                    case (3):
                        Console.WriteLine(num1);
                        Console.WriteLine(num2);
                        Console.Write("Difference the given two numbers:");
                        int sub = Convert.ToInt32(Console.ReadLine());

                        if ((sub == (num1 - num2)) || (sub == (num2 - num1)))
                        {
                            Console.WriteLine("Correcto!");
                            marks++;
                        }
                        else
                        {
                            Console.WriteLine("Oh ho!, The correct result is " + Math.Abs(num1 - num2));
                        }
                        break;

                    case (4):
                        Console.WriteLine(num1);
                        Console.WriteLine(num3);
                        Console.Write("Remainder if abover number divided by below one:");
                        int rem = Convert.ToInt32(Console.ReadLine());

                        if (rem == (num1 % num3))
                        {
                            Console.WriteLine("Correcto!");
                            marks++;
                        }
                        else
                        {
                            Console.WriteLine("Oh ho!, The correct result is " + (num1 % num3));
                        }
                        break;
                }
            }
            Console.WriteLine("\n\nScored Marks:"+marks);
            if(marks == 10)
            {
                Console.WriteLine("Excellent");
            }
            else if(marks == 9) 
            {
                Console.WriteLine("Good");
            }
            else if(marks == 7 || marks == 8)
            {
                Console.WriteLine("Fair");
            }
            else if(marks >=0 && marks < 7)
            {
                Console.WriteLine("Need to improve yourself!");
            }
            else
            {
                Console.WriteLine("Something went wrong in assigning marks");
            }
            Console.ReadLine();
        }
    }
}
