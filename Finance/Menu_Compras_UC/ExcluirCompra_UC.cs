using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance.Menu_Compras_UC
{
    public partial class ExcluirCompra_UC : UserControl
    {
        private List<Compra> listaCompra;
        private Compra CompraSelecionada;
        public ExcluirCompra_UC()
        {
            InitializeComponent();
            Compra objectCompra = new Compra();
            listaCompra = objectCompra.BuscarComprasEmFaturas();
            AtualizarDataGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show($"Deseja Excluir {CompraSelecionada.Nome_compra} ?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                try
                {
                    CompraSelecionada.RemoverCompra(CompraSelecionada);
                    MessageBox.Show($"A Compra {CompraSelecionada.Nome_compra} foi excluida!", $"Atenção!", MessageBoxButtons.OK);
                    AtualizarDataGrid();
                }
                catch (Exception)
                {

                    throw;
                }
                
                
            }
         
        }

        private void AtualizarDataGrid()
        {
            dataGridView_Compras.DataSource = listaCompra;
        }

        private void ExcluirCompra_UC_Enter(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void dataGridView_Compras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            CompraSelecionada = listaCompra[index];
        }
    }
}
