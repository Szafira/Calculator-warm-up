using System;
using System.IO;

namespace Basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            functions fun = new functions();
            menu menu = new menu();

            Console.WriteLine("Welcome to console calculator");


            menu.Form();
       
            
           
        }
    }
}
