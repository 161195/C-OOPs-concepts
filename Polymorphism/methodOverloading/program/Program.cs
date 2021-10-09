using System;

namespace methodOverloading
{
    class Program
    {
        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Sum(40.5f, 41.5f);
            Console.ReadLine();
        }
    }
}
