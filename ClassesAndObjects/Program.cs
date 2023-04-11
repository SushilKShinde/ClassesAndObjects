using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the classes conce");
            Car car = new Car(); //class object
            Console.WriteLine(car.color);
            Console.WriteLine(car.modelName);
            car.MyMethod();

        }
    }
}
