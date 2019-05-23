using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Stand
{
    public partial class CarroOficina
    {
        public CarroOficina(string numeroChassis, string marca, string modelo, string combustivel, 
            string matricula, int kms) : base(numeroChassis, marca, modelo, combustivel)
        {
            Matricula = matricula;
            Kms = kms;
        }
        public override string ToString()
        {
            return Matricula + "(" + Kms + ")";
        }

    }
}
