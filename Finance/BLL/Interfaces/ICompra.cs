using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface ICompra
    {
        void AdicionaCompra(Compra compra);
        void AlterarCompra(Compra compra);
        void RemoverCompra(Compra compra);
        List<Compra> BuscaCompras();
    }
}
