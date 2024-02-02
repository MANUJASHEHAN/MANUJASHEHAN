using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Please Type a Value:");
            double No1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Type a Value:");
            double No2 = Convert.ToDouble(Console.ReadLine());
            
            string LargeNo = "";
            if (No1 > No2)
            {
                LargeNo =Convert.ToString(No1); 
            }
            else
            {
                LargeNo= No2.ToString();

            }
            Console.WriteLine("LargeNo:"+LargeNo);
            






        }
    }
}
