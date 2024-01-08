using System;
namespace M03UF2
{
    public class Ex2
    {
        public static void Main()
        {

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
    }
}