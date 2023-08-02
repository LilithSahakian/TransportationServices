using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationServices
{
    internal class Mercedes:Vehicle
    {
        public Mercedes(string model) : base("Mercedes", model)
        { }
        public override string Brand { get => "Mercedes"; set { } }
        public static  decimal CarryValue { get => 600m; }
    }
}
