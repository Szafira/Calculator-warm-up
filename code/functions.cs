using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Basic_calculator
{
    public class functions
    {
        private double x1, x2, result, example;
        int NumberTest;
        string arraytest, n1;


        void Getxnum()
        {
            Console.WriteLine("How many numbers do you want to count?");
            n1 = Console.ReadLine();
            while (!int.TryParse(n1, out int result))
            {
                Console.WriteLine("Invalid input");
                n1 = Console.ReadLine();
            }
            NumberTest=Convert.ToInt32(n1);
            Console.WriteLine("Type your numbers");
        }
       
           

        public void Addition()
        {
            Getxnum();
            double[] array1 = new double[NumberTest];

            for (int i = 0; i < NumberTest; i++)
            {
                arraytest = Console.ReadLine();
                while (!double.TryParse(arraytest, out example))
                { 
                    Console.WriteLine("Invalid input");
                    arraytest = Console.ReadLine();
                }                   

                array1[i] = Convert.ToDouble(arraytest);
                
            }
            Console.WriteLine("Your numbers are:");
            foreach (double i in array1)
            { Console.Write("{0} ", i); }
            Console.WriteLine();

            Console.WriteLine("The result is:");
            for (int i = 0; i< NumberTest; i++)
            {
                 result = result + array1[i];
            }
          
            Console.WriteLine(result);


        }
        public void Substraction()
        {
        Getxnum();
             double[] array1 = new double[NumberTest];
        for (int i = 0; i < NumberTest; i++)
            {
                arraytest = Console.ReadLine();
                while (!double.TryParse(arraytest, out example))
                {
                    Console.WriteLine("Invalid input");
                    arraytest = Console.ReadLine();
                }

                array1[i] = Convert.ToDouble(arraytest);
            }
                Console.WriteLine("Your numbers are:");
            foreach (double i in array1)
            { Console.Write("{0} ", i); }
            Console.WriteLine();

  
            Console.WriteLine("The result is:");
            result = array1[0];
            for (int i = 1; i < NumberTest; i++)
            {
                result = result - array1[i];
            }

            Console.WriteLine(result);
        }
        public void Multiply()
        {
        Getxnum();
                double[] array1 = new double[NumberTest];
            for (int i = 0; i < NumberTest; i++)
            {
                arraytest = Console.ReadLine();
                while (!double.TryParse(arraytest, out example))
                {
                    Console.WriteLine("Invalid input");
                    arraytest = Console.ReadLine();
                }

                array1[i] = Convert.ToDouble(arraytest);
            }
            Console.WriteLine("Your numbers are:");
            foreach (double i in array1)
            { Console.Write("{0} ", i); }
            Console.WriteLine();

            Console.WriteLine("The result is:");
            result = array1[0];
            for (int i = 1; i < NumberTest; i++)
            {
                result = result*array1[i];
            }

            Console.WriteLine(result);
        }
        public void Divide()
        {
            Getxnum();
                double[] array1 = new double[NumberTest];
            if(x1 == 0 || x2 ==0)
            {
                Console.WriteLine("Parametr cannot be null");
                Getxnum();
               // throw new System.ArgumentException("Parametr cannot be null", "x1 or x2");
            }
            result = x1 / x2;
            Console.WriteLine(result);
        }
    }
}
