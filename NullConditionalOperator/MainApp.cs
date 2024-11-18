using System.Collections;
using static System.Console;

namespace NullConditionalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a가 null이 아니면 add 야구 a가 null 이기 때문에 메소드는 호출되지 않음
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

        }
    }
}
