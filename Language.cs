// Utilities/Language.cs
using System;

namespace QuizApp.Utilities
{
    public static class Language
    {
        public static bool GetLanguageChoice()
        {
            Console.WriteLine("Lütfen bir dil seçin / Please select a language:");
            Console.WriteLine("1. Türkçe");
            Console.WriteLine("2. English");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Geçerli bir seçim yapın / Please make a valid choice (1 or 2):");
            }

            return choice == 2;  // İngilizce seçimi için `true` döner
        }
    }
}
