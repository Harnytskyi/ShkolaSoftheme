using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zodiak_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = GetBirthDay();
            YourZodiac(birthday);
            Console.ReadKey();
        }
        static DateTime GetBirthDay()
        {
            DateTime birthday;
            Console.WriteLine("Enter your birth date");
            var strDate = Console.ReadLine();
            string[] arrDate = strDate.Split('/');
            try
            {
                int day = Int32.Parse(arrDate[0]);
                int month = Int32.Parse(arrDate[1]);
                int year = Int32.Parse(arrDate[2]);
                birthday = new DateTime(year, month, day);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Incorrect date");
                return GetBirthDay();
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect date format");
                return GetBirthDay();
            }
            if ((DateTime.Today.CompareTo(birthday) < 0))
            {
                Console.WriteLine("Not an valid birthdate");
                return GetBirthDay();
            }
            return birthday;
        }
        static void YourZodiac(DateTime birthday)
        {
            Console.Write("Your zodiac sign is: ");
            if ((birthday.Day >= 20 && birthday.Month == 1 )|| birthday.Day < 19 && birthday.Month == 2)
                Console.WriteLine("Aquarius");
            if ((birthday.Day >= 19 && birthday.Month == 2) || birthday.Day < 21 && birthday.Month == 3)
                Console.WriteLine("Pisces");
            if ((birthday.Day >= 21 && birthday.Month == 3) || birthday.Day < 20 && birthday.Month == 4)
                Console.WriteLine("Aries");
            if ((birthday.Day >= 20 && birthday.Month == 4) || birthday.Day < 21 && birthday.Month == 5)
                Console.WriteLine("Taurus");
            if ((birthday.Day >= 21 && birthday.Month == 5) || birthday.Day < 21 && birthday.Month == 6)
                Console.WriteLine("Gemeni");
            if ((birthday.Day >= 21 && birthday.Month == 6) || birthday.Day < 23 && birthday.Month == 7)
                Console.WriteLine("Cancer");
            if ((birthday.Day >= 23 && birthday.Month == 7) || birthday.Day < 23 && birthday.Month == 8)
                Console.WriteLine("Leo");
            if ((birthday.Day >= 23 && birthday.Month == 8) || birthday.Day < 23 && birthday.Month == 9)
                Console.WriteLine("Virgo");
            if ((birthday.Day >= 23 && birthday.Month == 9) || birthday.Day < 23 && birthday.Month == 10)
                Console.WriteLine("Libra");
            if ((birthday.Day >= 23 && birthday.Month == 10) || birthday.Day < 22 && birthday.Month == 11)
                Console.WriteLine("Scorpio");
            if ((birthday.Day >= 22 && birthday.Month == 11) || birthday.Day < 22 && birthday.Month == 12)
                Console.WriteLine("Sagittarius");
            if ((birthday.Day >= 22 && birthday.Month == 12) || birthday.Day < 20 && birthday.Month == 1)
                Console.WriteLine("Corpicorn");
        }

    }
}
