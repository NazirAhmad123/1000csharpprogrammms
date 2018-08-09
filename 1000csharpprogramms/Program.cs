using _1000csharpprogramms.Programms;
using System;



namespace _1000csharpprogramms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2, temp;

            //Console.WriteLine("\nEnter two numbers: ");
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());

            //temp = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.Write("After swapping: " + num1 + ", " + num2);
            //Console.Write("Enter a string in upper-case: ");
            //string strr = Console.ReadLine();

            //Console.Write("Here is the upper-case v of it: " + ToLower(strr));

            EvenOrOdd e = new EvenOrOdd();
            Console.Write("Enter a number: ");
            e.EvenOdd(int.Parse(Console.ReadLine()));

            Console.ReadKey();

        }
        public static string ToLower(string str)
        {
            str = str.ToLower();
            return str;
        }
    }
}
