using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_with_Asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
           int number1;
           int number2;
           int sum;

           Console.Write("enter number 1: ");

           string userEnter = Console.ReadLine();
           number1 = Convert.ToInt32(userEnter);

            

           Console.Write("enter number 2:  ");
        
           number2 = Convert.ToInt32(Console.ReadLine());

           sum = number1 + number2;

           Console.Write("sum is {0}", sum);


           Console.Read();











        }

    }
}
