using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Type a Value:");
            double No1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Type a Value:");
            double No2= Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Type a Value:");
            double No3= Convert.ToDouble(Console.ReadLine());
            double Total=No1 + No2 + No3;
            double Average = Total / 3;
            string Grade = "";
            if (Average >= 75) 
            {
                Grade = "Very Good";
            
            }
            else if (Average >= 65)
            {
                Grade = "Good";
            }
            else if (Average >= 55)
            {
                Grade = "Pass";
            
            }
            else
            {
                Grade = "Faill";
            }
            Console.WriteLine("Total is:" + Total);
            Console.WriteLine("Average is:"+Average);
            Console.WriteLine("The Grade is:" + Grade);
        }
    }
}
