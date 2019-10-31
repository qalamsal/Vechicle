using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name ?");
            string name=Console.ReadLine(); //sandesh
            Console.WriteLine("Welcome to IT sutra "+name);

            Console.WriteLine("What is your Age ?");
            string ageString = Console.ReadLine(); //
            //int age1 = Convert.ToInt32(ageString); //
            Console.WriteLine(" Your age is "+ ageString);


            Console.ReadLine(); //to stop screen
        }
    }
}
