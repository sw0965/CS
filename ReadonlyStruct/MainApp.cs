using System;

namespace ReadonlyStruct
{
    readonly struct RGBColor
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            RGBColor Red = new RGBColor(255, 0, 0);
            //Red.G = 100;
            RGBColor myColor = new RGBColor(Red.R, 100, Red.B);
            Console.WriteLine(myColor.R);
            Console.WriteLine(myColor.G);
            Console.WriteLine(myColor.B);
        }
    }
}
