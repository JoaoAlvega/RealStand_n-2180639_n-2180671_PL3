using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Stand
{
    public partial class CarroVenda
    {
        public CarroVenda(string extras)
        {
            Extras = extras;
        }
        public override string ToString()
        {
            return Extras;
        }
    }
}
