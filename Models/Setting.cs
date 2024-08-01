using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Setting
    {
        public static string InputString(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            return input;
        }

        public static void FinishOption()
        {
            string message = "Presione cualquier tecla para volver al menú principal...";
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
        }

        public static int InputInt(string prompt)
        {

            Console.Write(prompt);
            int input;
            while (!int.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
            {
                Console.WriteLine("Por favor, ingresa un valor entero");
                Console.Write(prompt);
            }
            return input;
        }

        public static byte InputByte(string prompt)
        {
            Console.Write(prompt);

            byte input;
            while (!byte.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
            {
                Console.WriteLine("Por favor, ingresa un valor entero");
                Console.Write(prompt);
            }
            return input;
        }

        public static double InputDouble(string prompt)
        {
            Console.Write(prompt);

            double input;
            while (!double.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
            {
                Console.WriteLine("Por favor, ingresa un valor numérico");
                Console.Write(prompt);
            }
            return input;
        }

        public static DateTime InputDate(string prompt)
        {
            Console.Write(prompt);
            DateTime input;
            while (!DateTime.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Por favor, ingresa una fecha válida:");
                Console.Write(prompt);
            }
            return input;
        }

        public static DateOnly InputDateOnly(string prompt)
        {
            Console.Write(prompt);
            DateTime tempDateTime;
            while (!DateTime.TryParse(Console.ReadLine(), out tempDateTime))
            {
                Console.WriteLine("Por favor, ingresa una fecha válida:");
                Console.Write(prompt);
            }
            return DateOnly.FromDateTime(tempDateTime);
        }

        public static string Header(string title)
        {
            int maxWidth = Console.WindowWidth;

            string LineSeprator = new('#', maxWidth);

            var titleLength = title.Length % 2 == 0 ? title.Length : title.Length + 1;
            var paddedTitle = title.PadLeft(titleLength, ' ');

            var spacesCount = (maxWidth - titleLength) / 2 - 1;
            string spaceInTitle = new(' ', spacesCount);

            string titleLine = $"#{spaceInTitle}{paddedTitle}{spaceInTitle}#";
            string header = $"{LineSeprator}\n{titleLine}\n{LineSeprator}";

            return header;
        }

        public static string LineSeparator(char symbol)
        {
            int maxWidth = Console.WindowWidth;
            string LineSeprator = new(symbol, maxWidth);
            return LineSeprator;
        }

        
    }
}