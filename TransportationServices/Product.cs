using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationServices
{
    internal class Product
    {
        public Product(string name )
        {
            Name = name;
        }
        private string Name;

        //public int ID { get; set; }
        public double Weight { get; set;}
    }
}
