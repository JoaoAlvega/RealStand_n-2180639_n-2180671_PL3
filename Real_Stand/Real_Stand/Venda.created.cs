using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Stand
{
    public partial class Venda
    {
        public Venda(string valor, string estado, string data)
        {
            Valor = valor;
            Estado = estado;
            Data = data;
        }
        public Venda()
        {

        }
        public override string ToString()
        {
            return Valor.ToString() + "€";
        }
    }
}
