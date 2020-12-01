using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_calculator
{
    class menu
    {
        public void Form()
        {
            functions fun = new functions();
            Console.WriteLine("Do you want to-");
            Console.WriteLine("a)Add");
            Console.WriteLine("b)Substract");
            Console.WriteLine("c)Multiply");
            Console.WriteLine("d)Divide");


            switch (Console.ReadLine())
            {
                case "a":
                    fun.Addition();
                    break;

                case "b":
                    fun.Substraction();
                    break;

                case "c":
                    fun.Multiply();
                    break;

                case "d":
                    fun.Divide();
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
            Console.WriteLine("Do you want to run another action? y/n");
            switch (Console.ReadLine())
            {
                case "y":
                    Console.WriteLine("...........................");
                    Form();
                    break;

                case "n":
                    break;
            }
        }
    }
}
