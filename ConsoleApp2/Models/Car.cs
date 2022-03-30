using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    class Car
    {
        public readonly string Make = "Mercedes";
        public readonly string Model;
        public readonly int Year;
        public readonly string VinCode;
        public string Color;
        public int Milage;

        public Car()
        {
        }

        public Car(string make, string model, int year, string vincode)
        {
            Make = make;
            Model = model;
            Year = year;
            VinCode = vincode;
        }
    }
}
