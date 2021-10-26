using System;

namespace _14._26._10._2021_class_task
{
    class Program
    {
        static void Main(string[] args)
        {
            OutParam(out int x, out int y);
            Console.WriteLine(x + " " + y);
        }

        static void OutParam(out int a, out int b)
        {
            a = 5;
            b = 6;
        }
    }
}
