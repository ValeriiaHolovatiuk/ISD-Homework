using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2._3
{
    class Vehicle
    {
        protected double price, speed;
        protected int year, x, y;

        public Vehicle(double price, double speed, int year, int x, int y)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
            this.x = x;
            this.y = y;
        }

        public virtual void Show() { }
    }

    class Plane : Vehicle
    {
        private double height;
        private int numberOfPassangers;

        public Plane(double height, int numberOfPassangers) : base(250000, 925, 2018, 10, 20)
        {
            this.height = height;
            this.numberOfPassangers = numberOfPassangers;
        }

        public override void Show()
        {
            Console.WriteLine("Plane\nPrice: {0}\nSpeed: {1}\nYear: {2}\nX: {3}\nY: {4}\nHeight: {5}\nNumber of passangers: {6}", price, speed, year, x, y, height, numberOfPassangers);
        }
    }

    class Ship : Vehicle
    {
        private int numberOfPassangers;
        private string homePort;

        public Ship(int numberOfPassangers, string homePort) : base(1000000000, 60, 1875, 15, 25)
        {
            this.numberOfPassangers = numberOfPassangers;
            this.homePort = homePort;
        }
        public override void Show()
        {
            Console.WriteLine("Ship\nPrice: {0}\nSpeed: {1}\nYear: {2}\nX: {3}\nY: {4}\nHome port: {5}\nNumber of passangers: {6}", price, speed, year, x, y, homePort, numberOfPassangers);
        }

    }

    class Car : Vehicle
    {
        private int numberOfPassangers;

        public Car(int numberOfPassangers) : base(15000, 60, 2016, 25, 30)
        {
            this.numberOfPassangers = numberOfPassangers;
        }

        public override void Show()
        {
            Console.WriteLine("Car\nPrice: {0}\nSpeed: {1}\nYear: {2}\nX: {3}\nY: {4}\nNumber of passangers: {5}", price, speed, year, x, y, numberOfPassangers);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane(15, 185);
            Vehicle ship = new Ship(50, "Glasgo");
            Vehicle car = new Car(4);

            plane.Show();
            ship.Show();
            car.Show();
        }
    }
}
