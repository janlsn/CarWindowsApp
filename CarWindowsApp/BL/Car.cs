using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWindowsApp.BL
{
    class Car
    {
        public string brand, model, color;
        public int price;
        public Car(string brand, string model, string color, int price)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.price = price;
        }
    }
}
