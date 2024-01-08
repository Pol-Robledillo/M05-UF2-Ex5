using System;
namespace M03UF2
{
    public class Ex2
    {
        public static void Main()
        {
            string option, word;
            int num1, num2;

            Console.WriteLine("a. Validar si un nombre és senar\r\nb. Calcular la potència d'un nombre\r\nc. Retornar un valor aleatori\r\nd. Comptar el nombre de vocals o consonants en un text\r\ne. Sortir");
            do
            {
                option = Console.ReadLine().ToLower();
            } while ((option != "a") ||  (option != "b") || (option != "c") || (option != "d") || (option != "e"));

            switch (option)
            {
                case "a":
                    num1 = Convert.ToInt32(Console.ReadLine());
                    if (!ValidateOdd(num1))
                    {
                        Console.WriteLine("És senar");
                    } else
                    {
                        Console.WriteLine("No és senar");
                    }
                    break;
                case "b":
                    Console.WriteLine("Introdueix la base");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdueix l'exponent");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Potencia(num1, num2));
                    break;
                case "c":
                    Console.WriteLine("Introdueix el mínim");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdueix el màxim");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(RandomNumber(num1, num2));
                    break;
                case "d":
                    Console.WriteLine("Introdueix la paraula");
                    word = Console.ReadLine();
                    Console.WriteLine("Aquesta paraula té {0} vocals i {1} consonats", CountVowels(word), CountConsonats(word));
                    break;
                case "e":
                    Console.WriteLine("Adeu");
                    break;
            }
        }
        public static bool ValidateOdd(int num)
        {
            return num % 2 == 0;
        }
        public static int Potencia(int num, int exp)
        {
            int result = 1;

            for (int i = 0; i < exp; i++)
            {
                result = result * num;
            }

            return result;
        }
        public static int RandomNumber(int min, int max)
        {
            Random ran = new Random();

            return ran.Next(min, max);
        }
        public static int CountVowels(string word)
        {
            int count = 0;
            foreach (char c in word)
            {
                if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountConsonats(string word)
        {
            int count = 0;
            foreach (char c in word)
            {
                if ((c != 'a') || (c != 'e') || (c != 'i') || (c != 'o') || (c != 'u'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}