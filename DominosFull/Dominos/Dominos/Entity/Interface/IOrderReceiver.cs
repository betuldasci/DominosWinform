using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Entity.Interface
{
    internal interface IOrderReceiver
    {
        void ReceiveOrder(List<Product> products);
    }
}
