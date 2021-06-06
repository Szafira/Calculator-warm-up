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
            Console.WriteLine("e)Divisibility");
            int n1 = 1;
            string calculatedNumber = "15";

            switch (Console.ReadLine())
            {
                case "a":
                    fun.Addition(n1, calculatedNumber);
                    break;

                case "b":
                    fun.Substraction(n1, calculatedNumber);
                    break;

                case "c":
                    fun.Multiply(n1, calculatedNumber);
                    break;

                case "d":
                    fun.Divide(n1);
                    break;
                case "e":
                    fun.Divisibilty(n1);
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
