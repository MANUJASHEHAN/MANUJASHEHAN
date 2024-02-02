using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please Type a Value:");
            double No1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Type a Value:");
            double No2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Type a Value:");
            double No3 = Convert.ToDouble(Console.ReadLine());

            string SmallestNo = "";
            if (No1 < No2)
            {
                SmallestNo = Convert.ToString(No1);
                if (No1 < No3)
                {
                    SmallestNo = Convert.ToString(No1);
                }

                else
                {
                    SmallestNo = Convert.ToString(No3);
                }


            }
            else 
            {
                SmallestNo = Convert.ToString(No2);
                if (No2 < No3)
                    SmallestNo = Convert.ToString(No2);
                else 
                {
                    SmallestNo = No3.ToString();

                }
            }
            Console.WriteLine("Smallest Number is:" + SmallestNo);

        }

            
        
            

            
                

                
            




                



        }
    }

