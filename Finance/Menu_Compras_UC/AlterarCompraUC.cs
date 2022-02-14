using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Finance.Menu_Compras_UC
{
    public partial class AlterarCompraUC : UserControl
    {
        private List<Compra> listaCompras = new List<Compra>();
        private Compra compra = new Compra();
        private Compra compraSelecionada = new Compra();
        public AlterarCompraUC()
        {
            InitializeComponent();
            listaCompras = buscarCompras();
            dataGridView_ComprasParaExcluir.DataSource = listaCompras;
            maskedTextBox_ValorCompra.ValidatingType = typeof(double);
            

        }

        private List<Compra> buscarCompras()
        {
            return compra.BuscaCompras();
        }

        private void dataGridView_ComprasParaExcluir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            compraSelecionada = listaCompras[index];
            CarregarInformacoesNaInterface(compraSelecionada);
        }

        private void CarregarInformacoesNaInterface(Compra compra)
        {
            textBox_NomeCompra.Text = compra.Nome_compra;
            textBox_NomeCompraApp.Text = compra.Nome_appbanco;
            dateTimePicker_DataCompra.Value = compra.Data_compra;
            maskedTextBox_ValorCompra.Text = compra.Valor_compra.ToString();

        }

        private void AlteraObjetoCompra()
        {
            compraSelecionada.Nome_compra = textBox_NomeCompra.Text;
            compraSelecionada.Nome_appbanco = textBox_NomeCompraApp.Text;
            compraSelecionada.Data_compra = dateTimePicker_DataCompra.Value;
            compraSelecionada.Valor_compra = Decimal.Parse(maskedTextBox_ValorCompra.Text);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            AlteraObjetoCompra();
            AlterarCompra(compraSelecionada);
        }

        private void AlterarCompra(Compra compraAlterada)
        {
            try
            {
                if (DialogResult.OK == MessageBox.Show($"A Compra: {compraAlterada.Nome_compra} será alterada, Deseja Continuar?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    compra.AlterarCompra(compraAlterada);
                }

            }
            catch (Exception k)
            {
                MessageBox.Show($"Ocorreu o seguinte erro ao alterar a compra: {k.Message}");
                throw;
            }
        }
    }
}
