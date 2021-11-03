using System;

namespace StyleCop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrsize, maxnum = 27;
            int[] numbers = new int[1];
            char[] specialLetter = { 'a', 'e', 'i', 'd', 'h', 'j' };
            do
            {
                if (int.TryParse(Console.ReadLine(), out arrsize))
                {
                    numbers = new int[arrsize];
                }
                else
                {
                    Console.WriteLine("Введите число!");
                }
            }
            while (arrsize == 0);
            Random rand = new Random();
            for (int i = 0; i < arrsize; i++)
            {
                numbers[i] = Convert.ToInt32(rand.Next(1, maxnum));
            }

            char[] evenNumbers = new char[maxnum];
            char[] oddNumbers = new char[maxnum];

            for (int i = 0; i < arrsize; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[numbers[i]] = Convert.ToChar(numbers[i] + 96);
                }
                else
                {
                    oddNumbers[numbers[i]] = Convert.ToChar(numbers[i] + 96);
                }
            }

            int countEven = 0, countOdd = 0;
            for (int i = 0; i < maxnum; i++)
            {
                for (int a = 0; a < specialLetter.Length; a++)
                {
                    if (evenNumbers[i] == specialLetter[a])
                    {
                        evenNumbers[i] = Convert.ToChar(evenNumbers[i] - 32);
                        countEven++;
                    }
                    else if (oddNumbers[i] == specialLetter[a])
                    {
                        oddNumbers[i] = Convert.ToChar(oddNumbers[i] - 32);
                        countOdd++;
                    }
                }
            }

            if (countEven > countOdd)
            {
                Console.WriteLine("Больше всего букв в верхнем регисте в четном массиве: ");
                foreach (var a in evenNumbers)
                {
                    Console.Write(a + " ");
                }
            }
            else if (countEven < countOdd)
            {
                Console.WriteLine("Больше всего букв в верхнем регисте в нечетном массиве: ");
                foreach (var a in oddNumbers)
                {
                    Console.Write(a + " ");
                }
            }
            else
            {
                Console.WriteLine("Букв в верхнем регисте в обоих массивах одинаковое кол-во");
            }

            Console.WriteLine("\n Четные: ");
            foreach (var a in evenNumbers)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("\n Нечетные: ");
            foreach (var a in oddNumbers)
            {
                Console.Write(a + " ");
            }
        }
    }
}
