using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_oops_concept.inheritance
{/// <summary>
/// parent class
/// </summary>
    class Car
    {
        public string model;
        public string color;
        public int price;

        public void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }

    }
    /// <summary>
    /// child class
    /// </summary>
    /// <seealso cref="learning_oops_concept.inheritance.Car" />
    class Maruti : Car
    {
        float milage;
        void PrintMilage()
        {
            Console.WriteLine("Milage" + milage);
        }
        public static void Main(string[] args)
        {
            Maruti mycar = new Maruti();
            mycar.model = "Alto";
            mycar.color = "white";
            mycar.price = 200000;
            mycar.milage = 22.5f;
            mycar.PrintCarInformation();
            mycar.PrintMilage();
            Console.ReadLine();
        }



    }
}
