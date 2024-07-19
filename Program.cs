using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additon_code
{
  
    
    internal class Program
    {
        int num1;
        int num2;
        int sum;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int nun2=int.Parse(Console.ReadLine());
            int sum =num1 + nun2;
            Console.WriteLine("your addition result is : {0}",sum);
            Console.ReadLine();
        }
    }
}
