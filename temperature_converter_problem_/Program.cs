﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_converter_problem_
{
    internal class Program
    {
        // Subroutine to convert Centigrade to Fahrebheit
        static double CtoF(double C)

        {
            return (C * 1.8) + 32;
        }
        //Subroutine to convert Faherenheit to Centrigade 
        static double FtoC(double F)
        {
            return (F - 32) / 1.8;
        }
        //Main program 
        static void Main(string[]args)
        {
            double C = 30;
            double F = CtoF(C);
            Console.WriteLine
        }
    }
    
}
