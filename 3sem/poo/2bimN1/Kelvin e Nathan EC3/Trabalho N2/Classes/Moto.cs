using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_N2.Interfaces;
using static Trabalho_N2.Classes.Veículos;

namespace Trabalho_N2.Classes
{
    internal class Moto : Veiculo, Rodoviarios
    {
        public bool Empinar { get; set; }

        public void pagarPedagio()
        {
            throw new NotImplementedException();
        }
    }
}
