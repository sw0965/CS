using System;
using System.Runtime.InteropServices.Marshalling;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //uint a = uint.MaxValue;
            int a = int.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}
