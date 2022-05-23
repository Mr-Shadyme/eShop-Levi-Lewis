using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop_Levi_Lewis
{
    internal class Program
    {
       public static string UserName = "";


        static void Start()
        {
            Console.WriteLine("\tWelcome to our eShop, please enter your name\n");
            UserName = Console.ReadLine();
            Console.WriteLine("\tWelcome " + UserName + " Please select an option from the menu below");
            Console.WriteLine("\t[1] Check Balance \n \t[2] Clothing Menu \n \t[3] Technoloy Menu\n");
            MenuOne();
        }

        static void Main()
        {
            Start();
        }// end of Main

        static void MenuOne()
        {
            Console.WriteLine("\t********************************\n");
            Console.WriteLine("[This is the clothing menu]\n");

        }//end of MenuOne

    }

    }//end of internal class Program
}// end of namespace
