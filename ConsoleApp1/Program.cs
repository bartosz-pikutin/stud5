﻿using System;

namespace ConsoleApp1
{
    public class Program 
    {
        static void Main(string[] args){
           
            int a = 0;
            int b = 0;

            Console.WriteLine("Podaj liczbe 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe 2");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);

            Console.WriteLine("coś tam " + a + " i jeszcze o to " + b);

        }   
    }
}


//Console.WriteLine("Hello, World!");