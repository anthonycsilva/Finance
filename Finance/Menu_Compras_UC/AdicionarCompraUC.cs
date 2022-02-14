using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Finance.Menu_Compras_UC
{
    public partial class AdicionarCompraUC : UserControl
    {
        List<Fatura> faturaList;
        public AdicionarCompraUC()
        {
            InitializeComponent();

            Fatura objectFatura = new Fatura();
            faturaList = objectFatura.BuscarFaturas();
            faturaList.ForEach(fatura =>
            {
                comboBox_FaturasParaSelecionar.Items.Add(fatura.Id);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AdicionarCompraNoSistema();

        }

        private void AdicionarCompraNoSistema()
        {
            try
            {
                string nomeCompra = textBox_NomeCompra.Text;
                string nomeCompraApp = textBox_NomeAppBanco.Text;

                textBox_ValorCompra.ValidatingType = typeof(double);
                var valorCompra = Decimal.Parse(textBox_ValorCompra.Text);

                DateTime dataCompra = dateTimePicker_DataCompra.Value;
                Fatura faturaSelecionada = buscaFatura(faturaList, comboBox_FaturasParaSelecionar.Text);

                Compra novaCompra = new Compra();
                novaCompra.Nome_compra = nomeCompra;
                novaCompra.Nome_appbanco = nomeCompraApp;
                novaCompra.Valor_compra = valorCompra;
                novaCompra.Data_compra = dataCompra;
                novaCompra.faturaID = faturaSelecionada.Id;


                novaCompra.AdicionaCompra(novaCompra);

                MessageBox.Show($"Compra {novaCompra.Nome_compra} Adicionada Com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception k)
            {

                MessageBox.Show($"Ocorreu o seguinte erro: {k.Message}", "Aconteceu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Fatura buscaFatura(List<Fatura> listaFatura, string idString)
        {
            int id = int.Parse(idString);

            var fatura =
                from f in listaFatura
                where f.Id == id
                select f;

            return fatura.First();
                
        }
    }
}
