using System;

namespace A3_StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;

            Console.WriteLine($"1.{date,40:MMMM d, yyyy}");
            Console.WriteLine($"2.{date:yyyy.MM.dd}");
            Console.WriteLine($"3.Day {date:dd} of {date:MMMM,yyyy}");
            Console.WriteLine($"4.Year:{date:yyyy},Month:{date:MM},Day:{date:dd}");
            Console.WriteLine($"5.{date,10:dddd}");
            Console.WriteLine($"6.{date,10:h:mm:tt}{date,10:dddd}");
            Console.WriteLine($"7.h:{date:hh},m:{date:mm},s:{date:ss}");
            Console.WriteLine($"8.{date:yyyy.MM.dd.hh.mm.ss}");

            Console.WriteLine($"\n1.{Math.PI:C}");
            Console.WriteLine($"2.{Math.PI,10:N3}");
        }
    }
}