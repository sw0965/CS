using System;

namespace IntegerLiterals
{
    class MainApp
    {
        static void Main(string[] args)
        {
            byte a = 240;               // 10 진수 리터럴
            Console.WriteLine($"a={a}"); 

            byte b = 0b1111_0000;       // 2 진수 리터럴
            Console.WriteLine($"a={b}");

            byte c = 0XF0;              // 16 진수 리터럴
            Console.WriteLine($"a={c}");

            uint d = 0x1234_abcd;       // 16 진수 리터럴
            Console.WriteLine($"a={d}");

        }
    }
}
