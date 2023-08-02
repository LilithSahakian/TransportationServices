using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationServices
{
    internal abstract class Vehicle
    {
        public abstract string Brand { get; set;}
        private string Model;
        public static  decimal CarryValue { get;}     //giny
        public virtual double Capacity { get; set;} //tonayov

        public Vehicle (string brand , string model)
        {
            Brand = brand;
            Model = model;
        }
        public override string ToString()
        {

            return $"Brand:{Brand}, Model:{Model}, Capacity: {Capacity*1000}kg";
        }
    }
}
