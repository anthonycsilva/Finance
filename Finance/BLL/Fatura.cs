using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAO;
using DAO.Context;

namespace BLL
{
    public class Fatura : IFatura
    {
        private int id;
        private DateTime dataVencimento;
        private decimal totalFatura;
        private bool pago;

        private FinanceContext context = new FinanceContext();
        public Fatura()
        {

        }
        public Fatura(int id, DateTime dataVencimento, decimal totalFatura, bool pago)
        {
            this.id = id;
            this.dataVencimento = dataVencimento;
            this.totalFatura = totalFatura;
            this.pago = pago;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }


        public decimal TotalFatura
        {
            get { return totalFatura; }
            set { totalFatura = value; }
        }


        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        public void AdicionarFatura(Fatura fatura)
        {
            context.Fatura.Add(fatura);
            context.SaveChanges();
        }

        public void AlterarFatura(Fatura fatura)
        {
            context.Fatura.Update(fatura);
            context.SaveChanges();
        }

        public List<Fatura> BuscarFaturas()
        {
            return context.Fatura.ToList();
        }

        public Fatura CalcularValorFatura()
        {
            throw new NotImplementedException();
        }

        public void RemoverFatura(Fatura fatura)
        {
            context.Fatura.Remove(fatura);
        }
    }
}
