using System;

namespace homework24oct
{
    class Program
    {
        static void Main(string[] args)
        {
            int say = 0;
            for (int i = 0; i < 8000; i++)
            {

                if (i % 2 == 0)
                {
                    say++;
                }
                i++;
            }
            Console.WriteLine("1-den 8000-dek ededler icerisinde cut olanlarin sayi:" + say);
        }
    }
}
