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
        
        static void Main()
        {
            Console.WriteLine("Welcome to our eShop, please enter your name");
            UserName = Console.ReadLine();
            Console.WriteLine("Welcome " + UserName + " Please select an option from the menu below");
            Console.WriteLine("{1} Check Balance \n [2] Clothing Menu \n [3] Technoloy Menu");
            MenuOne();
        }// end of Main

        static void MenuOne()
        {
            Console.WriteLine("This is the clothing menu/n");
            


        }//end of MenuOne

    }//end of internal class Program
}// end of namespace
