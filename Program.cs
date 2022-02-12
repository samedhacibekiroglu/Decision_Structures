using System;

namespace Decision_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final, ortalama;
            Console.WriteLine("Vize notu: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notu: ");
            final = Convert.ToInt32(Console.ReadLine());
            ortalama = (vize + final) / 2;
            Console.WriteLine("Ortalamanız: " + ortalama);
            if (ortalama < 30 && ortalama > 0)
            {
                Console.WriteLine("FF");
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                Console.WriteLine("DD");
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                Console.WriteLine("CC");
            }
            else if (ortalama >= 60 && ortalama < 80)
            {
                Console.WriteLine("BB");
            }
            else if (ortalama >= 80 && ortalama <= 100)
            {
                Console.WriteLine("AA");
            }
            else
            {
                Console.WriteLine("Hata var");
            }
        }
    }
}
