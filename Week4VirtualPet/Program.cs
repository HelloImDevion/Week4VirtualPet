using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This is your own personal Wolf.");
            Console.WriteLine("Please Enter a name for your Wolf: ");
            string userName = Console.ReadLine();

            Wolf petWolf = new Wolf(userName);
            Console.WriteLine("This is " + userName + "'s " + "Stats and Main Menu:");
            petWolf.MainMenu();
            



            

            

        }
    }
}
