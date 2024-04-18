using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibleForMarriage
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = "female";
            int age = 20;
            if (gender == "male")
            {
                if (age >= 23)
                {
                    Console.WriteLine("Eligible");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("NotEligibleForMarriage");
                    Console.ReadLine();
                }
            }

            else if (gender == "female")
            {
                if (age >= 21)
                {
                    Console.WriteLine("Eligible");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("not Eligible");
                    Console.ReadLine();
                }
            }

            else if (gender == "transgender")
            {
                if (age >= 21)
                {
                    Console.WriteLine("Eligible");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("not Eligible");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("not valid data");
                Console.ReadLine();
            }
        }
    }
}
