using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace subtraction_code
{
    internal class Program
    {
        int num1;
        int num;
        int sub;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int num = int.Parse(Console.ReadLine());
            int sub = (num1 - num);
            Console.WriteLine("your subtraction result is :{0}",sub);
            Console.ReadLine();
        }
    }
}
