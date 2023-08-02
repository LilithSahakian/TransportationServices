using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationServices
{
    internal interface ITransportationService<T,TProduct>
    {
        void Transport(T[] vehicle, TProduct[] products,int distance);
    }
}
