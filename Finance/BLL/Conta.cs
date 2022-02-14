using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAO.Context;

namespace BLL
{
    public class Conta : IConta
    {
        private int id;
        private decimal salario_conta;
        private decimal saldo;
        private int dia_pagamento;
        

        private FinanceContext ContaContext = new FinanceContext();
        Regex regex = new Regex(@"/^(((\d+)(\.\d{3})*(.\d{2}))|(\d*))$/");

        public Conta()
        {

        }

        public Conta(int id, decimal salario_conta, decimal saldo, int dia_pagamento)
        {
            this.id = id;
            this.salario_conta = salario_conta;
            this.saldo = saldo;
            this.dia_pagamento = dia_pagamento;
        }

        //Getters and Setters

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Salario_Conta
        {
            get { return salario_conta; }
            set { salario_conta = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int Dia_Pagamento
        {
            get { return dia_pagamento; }
            set { dia_pagamento = value; }
        }


        //Metodos da Classe


        public void AdicionarSaldo(decimal amount)
        {

            if (amount == 0 || amount < 0)
            {
                throw new Exception("Você não pode adicionar 0 ou valor menor que 0 no saldo!");
            }
            else if (regex.IsMatch(amount.ToString()))
            {
                //Incrementa Valor;
                this.Saldo += amount;
                //salvar no context;
                ContaContext.Conta.Update(this);
                ContaContext.SaveChanges();
            }
        }

        public void AlterarSalario(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Você não pode alterar para um valor menor que 0!");
            }
            else if (regex.IsMatch(amount.ToString()))
            {
                //Incrementa Valor;
                this.Salario_Conta = amount;
                //salvar no context;
                ContaContext.Conta.Update(this);
                ContaContext.SaveChanges();
            }
        }

        public void AlterarSaldoConta(decimal amount)
        {
            if (amount == 0 || amount < 0)
            {
                throw new Exception("Você não pode adicionar 0 ou valor menor que 0 no saldo!");
            }
            //Incrementa Valor;
            this.Saldo = amount;
            //salvar no context;
            ContaContext.Conta.Update(this);
            ContaContext.SaveChanges();
        }

        public List<Conta> GetContaList()
        {
            return ContaContext.Conta.ToList();
        }

        public bool PagarFatura(Fatura fatura)
        {
            throw new NotImplementedException();
        }
    }
}
