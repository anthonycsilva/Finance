using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassePagamentoFatura
    {
        private Fatura fatura;
        private Conta conta;

        public Fatura Fatura
        {
            get { return fatura; }
            set { fatura = value; }
        }


        public Conta Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        public ClassePagamentoFatura(Fatura fatura, Conta conta)
        {
            this.fatura = fatura;
            this.conta = conta;
        }

        public bool pagarFatura()
        {
            if(conta.Saldo < fatura.TotalFatura)
            {
                throw new Exception("Atenção, seu saldo é negativo");
            }
            else if(conta.Saldo <= 0)
            {
                throw new Exception("Sua conta está zerada ou negativa, verifique sua conta no menu de contas");
            }

            try
            {
                conta.Saldo -= fatura.TotalFatura;
                conta.AlterarSaldoConta(conta.Saldo);
                fatura.Pago = true;
                fatura.AlterarFatura(fatura);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro ao pagar a fatura, fale com o Anthony!");
            }



        }





    }
}
