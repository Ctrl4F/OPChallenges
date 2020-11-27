using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string registration;
            string color;
            int odometer;
            int fuel;
            
            public Car(string _mark, string _model, string _registration, string _color)
        {
            mark = _mark;
            model = _model;
            registration = _registration;
            color = _color;
            odometer = 0;
            fuel = 60;
            Console.WriteLine($"the car {mark} has been created");
        }
            public string Mark
            {
                get { return mark; }
            }
            public string Model
            {
                get { return model; }
            }
        public string Registration
        {
            get { return registration; }
                set
                {
                    if (value.Length == 6)
                    {
                        Registration = value;
                    }
                    else
                    {
                        registration = "Really fast";
                    }
                }
        }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fuel
            {
                get { return fuel; }
            }
        }
        
    

        static void Main(string[] args)
        {
            Car newCar = new Car("FerraMedez", "sesan", "CBT420", "green");
            Console.WriteLine(newCar.Mark);
            Console.WriteLine(newCar.Model);
            Console.WriteLine(newCar.Registration);
            Console.WriteLine(newCar.Color);
        }
    }
}
