using System;

namespace Uppgift_1_Metod_inl
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 3 tal");
            int tal1 = 0;
            int tal2 = 0;
            int tal3 = 0;

            tal1 = int.Parse(Console.ReadLine());
            tal2 = int.Parse(Console.ReadLine());
            tal3 = int.Parse(Console.ReadLine());

            int summan = 0;
            summan = uträkning(tal1, tal2, tal3);
            Console.WriteLine(summan);
        }
        static int uträkning(int t1, int t2, int t3)
        {
            int tal4 = 0;
            tal4 = t1 + t2 + t3;
            return tal4;
        }
    }
}