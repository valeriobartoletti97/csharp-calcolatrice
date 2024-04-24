using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int SommaNumeri(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double SommaNumeri(double num1, double num2)
        {
            return num1 + num2;
        }

        public static int DifferenzaNumeri(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double DifferenzaNumeri(double num1, double num2)
        {
            return num1 - num2;
        }
        public static int MoltiplicaNumeri(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double MoltiplicaNumeri(double num1, double num2)
        {
            return num1 * num2;
        }
        public static int ValoreAssoluto(int num)
        {
            return num = num < 0 ? (-num) : num;
        }
        public static double ValoreAssoluto(double num)
        {
            return num = num < 0 ? (-num) : num;
        }
        public static int NumeroMinore(int num1, int num2)
        {
            if (num1 < num2)
                return num1;
            else if (num2 < num1)
                return num2;
            else Console.WriteLine("I numeri sono uguali");
            return 0;
        }
        public static double NumeroMinore(double num1, double num2)
        {
            if (num1 < num2)
                return num1;
            else if (num2 < num1)
                return num2;
            else Console.WriteLine("I numeri sono uguali");
            return 0;
        }
        public static int NumeroMaggiore(int num1, int num2)
        {
            if (num1 < num2)
                return num2;
            else if (num2 < num1)
                return num1;
            else Console.WriteLine("I numeri sono uguali");
            return 0;
        }
        public static double NumeroMaggiore(double num1, double num2)
        {
            if (num1 < num2)
                return num2;
            else if (num2 < num1)
                return num1;
            else Console.WriteLine("I numeri sono uguali");
            return 0;
        }
        public static decimal ElevaAPotenza(decimal num1, decimal num2)
        {
            if (num1 == 0)
            {
                return 0;
            }
            //se esponente è zero
            else if (num2 == 0 && num1 > 0) return 1;
            else if (num2 == 0 && num1 < 0) return -1;
            //se esponente è 1 
            else if (num2 == 1 && num1 != 0) return num1;

            else if (num1 != 0 && num2 > 0)
            {
                decimal result = 1;
                for (int i = 0; i < num2; i++)
                {
                    result *= num1;
                }

                return result;
            }
            else
            {
                decimal result = num1;
                result = 1 / result;
                num2 = -num2;
                decimal moltiplicatore = 1 / num1;
                for (int i = 1; i < num2; i++)
                {
                    result *= moltiplicatore;
                }
                return result;
            }
        }
    }
}

