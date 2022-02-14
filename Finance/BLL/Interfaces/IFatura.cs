using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface IFatura
    {
        void AdicionarFatura(Fatura fatura);
        void AlterarFatura(Fatura fatura);
        void RemoverFatura(Fatura fatura);
        List<Fatura> BuscarFaturas();
        Fatura CalcularValorFatura();
    }
}
