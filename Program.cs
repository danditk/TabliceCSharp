using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Temperatura na 365 dni

            Random randomTemperature = new Random();
            int dayTemperature;
            int[] yearTemp356 = new int[365];
            string[] weekDay = { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
            int counterDay = 0;
            int counterWeek = 1;
            int repeatedTimeTemperature = 0;

            for (int i = 0; i < 364; i++)
            {
                dayTemperature = randomTemperature.Next(-30, 43);
                //Console.WriteLine(temperature);
                yearTemp356[i] = dayTemperature;
            }

            for (int i = 0; i < yearTemp356.GetLength(0); i++)
            {
                _ = (yearTemp356[i] == yearTemp356[152]) ? repeatedTimeTemperature++ : repeatedTimeTemperature;
            }

            Console.WriteLine("Dane statystyczne:");
            Console.WriteLine("W tym roku najniższa odnotowana temperature to: " + yearTemp356.Min());
            Console.WriteLine("W tym roku najwyższa odnotowana temperature to: " + yearTemp356.Max());
            Console.WriteLine($"W tym roku temperatura zanotowana 1 czerwca, tj. {yearTemp356[152]}*C odnotowana była {repeatedTimeTemperature} razy.");

            for (int i = 0; i < yearTemp356.Length; i++)
            {

                if (counterDay == 0) Console.Write(counterWeek + ". ");

                Console.Write(weekDay[counterDay] + " - " + yearTemp356[i] + "*C, ");

                if(i % 7 == 6 ) {
                    Console.WriteLine();
                }

                _ = (counterDay == 6) ? counterDay = 0 : counterDay++;
                _ = (counterDay == 6) ? counterWeek++ : counterWeek;
            }

            Console.ReadKey();
        }
    }
}
