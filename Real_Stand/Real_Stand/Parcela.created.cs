using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Stand
{
    public partial class Parcela
    {
        public Parcela(int valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao;
        }
        public Parcela()
        {

        }
        public override string ToString()
        {
            return Descricao + "(" + Valor + "€)";
        }
    }
}
