using System;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Tesla tesla = new Tesla();
            tesla.Drive();
        }
    }

    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving Manuel");
        }
    }
    class Tesla : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Driving Auto");
        }
    }
}
