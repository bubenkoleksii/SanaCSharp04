﻿namespace Helpers
{
    public static class ConsoleReader
    {
        public static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
        {
            int number;

            Console.Write($"\"{label}\" = ");
            while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
            {
                Console.WriteLine($"Error! The number \"{label}\" is not correct!");
                Console.Write($"Please repeat entering a integer value.\n\n\"{label}\" = ");
            }

            return number;
        }

        public static void MakeCustomSeparator()
        {
            var customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}