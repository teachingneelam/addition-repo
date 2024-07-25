using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_code
{
    internal class Program
    {
        int num1;
        int num2;
        int result;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("enter your result is : {0}",num1*num2 );
            Console.ReadLine();
        }
    }
}
