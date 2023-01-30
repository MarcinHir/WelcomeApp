using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Witaj w programie powitalnym.");

                Console.WriteLine("Na początek podaj jak masz na imię: ");
                var name = Console.ReadLine();

                Console.WriteLine("Podaj miejsce urodzenia: ");
                var place = Console.ReadLine();

                Console.WriteLine("Podaj rok urodzenia: ");
                var year = GetInputYear();

                Console.WriteLine("Podaj miesiąc urodzenia(1-12): ");
                var month = GetInputMonth();

                Console.WriteLine("Podaj dzień urodzenia(1-31): ");
                var day = GetInputDay();

                var age = CalculateAge(year, month, day);

                Console.WriteLine($"Cześć {name} urodziłeś/aś się w {place} i masz {age} lat/a.");
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }   

            finally 
            { 
             Console.ReadLine();
            }

    }

        private static int GetInputYear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int input))
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Wpisz liczbę:");

                else if (input < 1800 || input > DateTime.Now.Year)
                    Console.WriteLine("Podany rok jest nieprawidłowy. Podaj jeszcze raz:");

                else
                    return input;
            }
        }

        private static int GetInputMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int input))
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Wpisz liczbę:");

                else if (input < 1 || input > 12)
                    Console.WriteLine("Podany miesiąc jest nieprawidłowy. Podaj jeszcze raz w zakresie 1-12 :");

                else
                    return input;
            }
        }

        private static int GetInputDay()
        {
            while (true)
            {

                if (!int.TryParse(Console.ReadLine(), out int input))
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Wpisz liczbę:");

                else if (input < 1 || input > 31)
                    Console.WriteLine("Podany dzień jest nieprawidłowy. Podaj jeszcze raz w zakresie 1-31 :");

                else 
                    return input;
            }
        }
        private static int CalculateAge(int year, int month, int day)
        {            
            DateTime date = new DateTime(year, month, day);
            
            int age = DateTime.Now.Year - date.Year;

            if (date.Month > DateTime.Now.Month) 
                age--;

            else if (date.Month == DateTime.Now.Month && date.Day > DateTime.Now.Day) 
                age--;

            return age;
        }
    }
}
