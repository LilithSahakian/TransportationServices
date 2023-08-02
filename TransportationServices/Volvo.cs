using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationServices
{
    internal class Volvo : Vehicle
    {
        public Volvo( string model) : base("Volvo", model)
        { }
        public override string Brand { get =>"Volvo"; set { } }
        public static decimal CarryValue { get => 500m; }
    }
}
