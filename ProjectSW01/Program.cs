using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSW
{
    class Program
    {
        /// <summary>
        /// Code loop example in Star Wars theme
        /// </summary>
        /// Author:     rapharma

        static void Main(string[] args)
        {
            Console.WriteLine("Star Wars characters's characteristics :\n");

            string[] characters = { "Luke", "R2-D2", "Darth", "Han" };

            //loop
            foreach (string s in characters)
            {
                if (s == "Luke" || s == "Darth")
                {
                    Console.WriteLine(s + " has the force");
                }
                else
                {
                    Console.WriteLine(s + " doesn't have the force");
                }
            }

            Console.WriteLine("\nLearn to Code you should! ;)");


        }
    }
    }






