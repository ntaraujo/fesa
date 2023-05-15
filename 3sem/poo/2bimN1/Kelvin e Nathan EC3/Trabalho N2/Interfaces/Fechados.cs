using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_N2.Interfaces
{
    internal interface Fechados : Base
    {
        void LigaDesligaLimpador(string Identificacao, bool ligado) ;
    }
}
