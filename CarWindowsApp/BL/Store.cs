using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWindowsApp.BL
{
    class Store
    {
        public List<Car> stock;
        public List<int> kurv;
        public Store()
        {
            stock = new List<Car>();
            kurv = new List<int>();
        }
    }
}
