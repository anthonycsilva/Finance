using System;

namespace BLL
{
    public class Compra
    {
        public Compra()
        {

        }
        private int id;
        private string nome_compra;
        private string nome_appbanco;
        private DateTime data_compra;
        private double valor_compra;
        private Fatura faturaAssociada; 
        

        public Compra(int id, string nome_compra, string nome_appbanco, DateTime data_compra, double valor_compra, Fatura faturaAssociada)
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


        public double Valor_compra
        {
            get { return valor_compra; }
            set { valor_compra = value; }
        }


        public Fatura FaturaAssociada
        {
            get { return faturaAssociada; }
            set { faturaAssociada = value; }
        }








    }
}
