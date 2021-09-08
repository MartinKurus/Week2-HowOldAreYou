using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaastat
            //programm kuvab kasutaja sünniaastat konsoolis

            Console.WriteLine("Kui vana sa oled?");
            
            //convert string from Readline() to int
            int Age = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - Age;

            //Console.WriteLine("Oled sündinud " + YearOfBirth + ".");
            Console.WriteLine($"Oled sündinud aastal {YearOfBirth}.");
        }
    }
}
