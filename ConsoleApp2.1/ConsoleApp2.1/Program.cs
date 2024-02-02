using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Type a Value:");
            double No1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Type a Value:");
            double No2 = Convert.ToDouble(Console.ReadLine());

            double LargeNo;
            if (No1 > No2)
            {
                LargeNo =(No1);
            }
            else
            {
                LargeNo = (No2);

            }
            Console.WriteLine("Large Number:" + LargeNo);



        }
    }
}
