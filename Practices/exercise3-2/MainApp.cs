using System;

namespace exercise3_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 다음 코드에서 잘못된 부분을 찾고, 그 이유를 설명하시오.
            //int a = 7.3;
            int a = 7; // 정수여야함
            //float b = 3.14;
            float b = 3.14f; // 뒤에 f 가 붙어야함
            // double c = a * b;
            double c = a * b;
            // char d = "abc";
            char d = 'a'; // 작은 따옴표를 사용해야함 + 한글자여야 한다.
            // string e = '한';
            string e = "한"; // 큰 따옴표를 사용해야한다.

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
