using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Stand
{
    public partial class Aluguer
    {
        public Aluguer(string dataInicio, string dataFim, int valor, int kms)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            Valor = valor;
            Kms = kms;
        }
        public Aluguer()
        {

        }
        public override string ToString()
        {
            return Valor.ToString() + "€";
        }
    }
}
