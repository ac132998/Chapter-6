using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperature = new int[7];
            int input;
            int average = 0;
            int total = 0;


            for (int i = 0; i < temperature.Length; ++i)
            {
                Console.WriteLine("Please enter the temperature on Day " + (i+1));
                input = Convert.ToInt32(Console.ReadLine());
                temperature[i] = input;
              
                
            }
            RunLine();
            DisplayTemperatures(temperature);
           

        }
        public static void DisplayTemperatures(int [] temperature)
        {

            for (int i = 0; i < temperature.Length; ++i)
            {
                Console.WriteLine("{0 , 6}", temperature[i]);
            }
            

        }
        
        public static void RunLine()
        {
            Console.WriteLine("\n--------------------------------------------------------");

        }
    }
}
