using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args) 
        {

            string noun, adjective, color, verb;

            Console.Write("Please Enter a noun");
            noun = Console.ReadLine();

            Console.Write("Please Enter a adjective");
            noun = Console.ReadLine();

            Console.Write("Please Enter a color");
            noun = Console.ReadLine();

            Console.Write("Please Enter a verb");
            noun = Console.ReadLine();

            Console.WriteLine("My name is " + noun);
            Console.WriteLine("My favorite milkshake is Bubblegum because it's " + adjective);
            Console.Writeline("I don't like the color " + color);
            Console.WriteLine("I like using the treadmills at the gym and " + verb + "on them");

            Console.ReadLine(); //MadLibs Program...Shut Down





        }
    }
}