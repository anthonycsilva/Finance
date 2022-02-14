
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CalculoDeFaturas
    {
        private List<Fatura> listaFaturas;
        private List<Compra> listaCompras;
        private int mesAtual = DateTime.Now.Month;
        private List<Compra> listaComprasDoMesAtual;

        public CalculoDeFaturas(List<Fatura> faturas, List<Compra> compras)
        {
            listaCompras = compras;
            listaFaturas = faturas;
            listaComprasDoMesAtual = listarComprasDoMes(compras, mesAtual);

        }

        private List<Compra> listarComprasDoMes(List<Compra> compras, int mesSelecionado)
        {
            List<Compra> list = new List<Compra>();
            foreach (Compra compra in listaCompras)
            {
                if(compra.Data_compra.Month == mesSelecionado)
                {
                    list.Add(compra);
                }
                    
            }
            return list;
        }

        public Decimal SomarValoresDasCompras(int mesDaFaturaPesquisada)
        {
            Decimal valor = 0;
            var lista = listarComprasDoMes(listaCompras, mesDaFaturaPesquisada);
            lista.ForEach(compra => {
                valor += compra.Valor_compra;
            });

            return valor;
        }
    }
}
