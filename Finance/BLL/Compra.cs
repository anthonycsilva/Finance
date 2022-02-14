using BLL.Interfaces;
using DAO.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BLL
{
    public class Compra : ICompra
    {
        public Compra()
        {

        }
        private int id;
        private string nome_compra;
        private string nome_appbanco;
        private DateTime data_compra;
        private decimal valor_compra;
        public int faturaID { get; set; }
        private Fatura faturaAssociada;
        private FinanceContext context = new FinanceContext(); 

        public Compra(int id, string nome_compra, string nome_appbanco, DateTime data_compra, decimal valor_compra, Fatura faturaAssociada)
        {
            this.id = id;
            this.nome_compra = nome_compra;
            this.nome_appbanco = nome_appbanco;
            this.data_compra = data_compra;
            this.valor_compra = valor_compra;
            this.faturaAssociada = faturaAssociada;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Nome_compra
        {
            get { return nome_compra; }
            set { nome_compra = value; }
        }


        public string Nome_appbanco
        {
            get { return nome_appbanco; }
            set { nome_appbanco = value; }
        }


        public DateTime Data_compra
        {
            get { return data_compra; }
            set { data_compra = value; }
        }


        public decimal Valor_compra
        {
            get { return valor_compra; }
            set { valor_compra = value; }
        }


        public Fatura FaturaAssociada
        {
            get { return faturaAssociada; }
            set { faturaAssociada = value; }
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome_compra}, AppBanco: {this.Nome_appbanco}, Valor: {this.valor_compra}, Data:`{this.Data_compra}, FaturaId{this.FaturaAssociada.Id}";
        }

        public void AdicionaCompra(Compra compra)
        {
            context.Compras.Add(compra);
            context.SaveChanges();
        }

        public void AlterarCompra(Compra compra)
        {
            context.Compras.Update(compra);
            context.SaveChanges();
        }

        public void RemoverCompra(Compra compra)
        {
            context.Compras.Remove(compra);
            context.SaveChanges();
        }

        public List<Compra> BuscaCompras()
        {
            return context.Compras.ToList();
        }

        public List<Compra> BuscarComprasEmFaturas()
        {
            var comprasEmFaturas = context
                .Compras
                .Include(f => f.FaturaAssociada)
                .ToList();

            return comprasEmFaturas;
        }
    }
}
