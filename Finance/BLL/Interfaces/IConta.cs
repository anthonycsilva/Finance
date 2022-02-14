using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface IConta
    {
        void AlterarSalario(decimal amount);
        void AlterarSaldoConta(decimal amount);
        void AdicionarSaldo(decimal amount);
        bool PagarFatura(Fatura fatura);
        List<Conta> GetContaList();

    }
}
