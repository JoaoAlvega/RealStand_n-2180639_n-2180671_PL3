using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Stand
{
    public partial class Cliente
    {
        public Cliente(string nome, int nif, string morada, int contacto)
        {
            Nome = nome;
            NIF = nif;
            Morada = morada;
            Contacto = contacto;
            this.Alugueres = new HashSet<Aluguer>();
            this.CarrosOficina = new HashSet<CarroOficina>();
        }
        public override string ToString()
        {
            return Nome + "("+ NIF +")";
        }
    }
}
