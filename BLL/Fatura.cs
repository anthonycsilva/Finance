using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Fatura : 
    {
        private int id;
        private DateTime dataVencimento;
        private double totalFatura;
        private bool pago;

        public Fatura()
        {

        }
        public Fatura(int id, DateTime dataVencimento, double totalFatura, bool pago)
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


        public double TotalFatura
        {
            get { return totalFatura; }
            set { totalFatura = value; }
        }


        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }




    }
}
