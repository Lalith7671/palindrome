using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //palin();//palindome of a number
            //among();//finding amstrong of 3 digit number
            //sums();
            //rev();
            //reverse();
        }
        public static void palin()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0, temp;
            temp = num;
            while (num != 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("it is a palindrome number");
            }
            else
            {
                Console.WriteLine("it is not a palindrome number");
            }

        }
        public static void among()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0, temp;
            temp = num;
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem*rem*rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("it is an armstrong number");
            }
            else 
            {
                Console.WriteLine("it is not an armstrong number");
            }


        }
        public static void sums()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0, temp;
            temp = num;
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("sum of digits: "+sum);


        }
        public static void revese()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0, temp;
            temp = num;
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("sum of digits: " + sum);
        }
        public static void rev()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0, temp;
            temp = num;
            while (num != 0)
            {
                rem = num % 10;
                sum = (sum *10)+ rem;
                num = num / 10;
            }
            Console.WriteLine("reverse of digits: " + sum);
        }
        public static void reverse()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while (num != 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("reverse of digits: " + sum);
        }
    }
}
