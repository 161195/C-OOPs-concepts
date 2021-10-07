 using System;

namespace learning_oops_concept
{
    public class Calculator
    {
        int num1;
        int num2;
        int result;  
        void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void Substract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            obj.num1 = 20;
            obj.num2 = 30;
            obj.Add();
            obj.Substract();

            Calculator obj1 = new Calculator();
            obj.num1 = 40;
            obj.num2 = 70;
            obj.Add();
            obj.Substract();
        }
    }
}
