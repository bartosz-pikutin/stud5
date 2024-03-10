using System;

namespace ConsoleApp1
{
    public class Program 
    {
        static void Main(string[] args){
           
            int[] a = [13, 2, 100, 5, 12, 4, 3];
            //countAverageFromIntArray(a);

           /* int a = 0;
            int a = 0;
            int b = 0;

            Console.WriteLine("Podaj liczbe 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe 2");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);

            Console.WriteLine("coś tam " + a + " i jeszcze o to " + b);
            */
        }   
        static void countAverageFromIntArray(int[] b){
            float sum = 0;
            for(int a = 0; a < b.Length; a++){
                sum += b[a];
            }
            Console.WriteLine("The average of the given array is: {0}", sum/b.Length);
        }
         static void writeMaxValueFromIntArray(int[] c){
         
        }



    }
}


//Console.WriteLine("Hello, World!");