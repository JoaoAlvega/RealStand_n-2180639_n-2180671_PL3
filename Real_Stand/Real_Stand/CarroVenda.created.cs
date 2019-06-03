using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Stand
{
    public partial class CarroVenda
    {
        public CarroVenda(string numeroChassis, string marca, string modelo, string combustivel,
            string extras) : base(numeroChassis, marca, modelo, combustivel)
        {
            Extras = extras;
            
        }

        public CarroVenda()
        {

        }
        public override string ToString()
        {
            return Extras;
        }
    }
}
