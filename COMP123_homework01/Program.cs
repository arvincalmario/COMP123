using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car.TestHarness();

            Date date = new Date(2022, 5, 9);
            Console.WriteLine(date);

            date.Add(22);
            Console.WriteLine(date);

            date.Add(3, 6);
            Console.WriteLine(date);

            Date date1 = date.copy(); // assign new object and copy the first object
            int day1 = 1, month1 = 1, year1 = 1;
            Date add1 = new Date(day1, month1, year1);

            date1.Add(add1);
            Console.WriteLine(date1);


        }
    }
    class Car
    {
        int year;
        string model;
        bool isElectric;
        double price;
        public Car(int year, string model, double price, bool isElectric = false)
        {
            this.year = year;
            this.model = model;
            this.price = price;
            this.isElectric = isElectric;
        }
        public override string ToString()
        {
            string ElectricCar = (isElectric == false) ? "NO, not electric" : "YES, Electric car";
            return $"Car model: {model} | year: {year} | price: {price:C} | Electric Car?: {ElectricCar}";
        }
        public static void TestHarness()
        {
            Car Honda = new Car(1991, "HondaJDM", 25000, true);
            Car Lexxus = new Car(2002, "LexxusNew", 69000, false);
            Car BMW = new Car(2022, "BMW325", 60000, false);
            Car Toyota = new Car(2004, "Hilux", 5000, false);

            Console.WriteLine(Honda);
            Console.WriteLine(Lexxus);
            Console.WriteLine(BMW);
            Console.WriteLine(Toyota);

        }

    }
    class Date
    {
        int year; //fields
        int month;
        int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }


        public Date copy() // copy the fields
        {
            return this.MemberwiseClone() as Date;
        }
        public void Add(int days)
        {
            day += days;
            Normalize();
        }
        public void Add(int days, int months)
        {
            day += days;
            month += months;
            Normalize();
        }

        public void Add(Date other)
        {
            year += other.year;
            month += other.month;
            day += other.day;
            Normalize();
        }
        void Normalize()
        {
            while (day > 30)
            {
                day -= 30;
                month += 1;
            }

            while (month > 12)
            {
                month -= 12;
                year += 1;
            }
        }
        public override string ToString()
        {
            return $"year: {year}, month: {month}, day: {day}";
        }

    }
}
