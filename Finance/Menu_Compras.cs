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

namespace Finance
{
    public partial class Menu_Compras : Form
    {
        public Menu_Compras()
        {
            InitializeComponent();

        }

        private void btn_AdicionarNovaCompra_Click(object sender, EventArgs e)
        {
            panel_MenuCompras.Controls.Clear();
            Menu_Compras_UC.AdicionarCompraUC adicionarCompraUC = new Menu_Compras_UC.AdicionarCompraUC();
            panel_MenuCompras.Controls.Add(adicionarCompraUC);

        }

        private void Menu_Compras_Load(object sender, EventArgs e)
        {

        }

        private void btn_ExcluirCompra_Click(object sender, EventArgs e)
        {
            panel_MenuCompras.Controls.Clear();
            Menu_Compras_UC.ExcluirCompra_UC excluirCompra = new Menu_Compras_UC.ExcluirCompra_UC();
            panel_MenuCompras.Controls.Add(excluirCompra);
        }

        private void btn_AlterarCompra_Click(object sender, EventArgs e)
        {
            panel_MenuCompras.Controls.Clear();
            Menu_Compras_UC.AlterarCompraUC alterarCompra = new Menu_Compras_UC.AlterarCompraUC();
            panel_MenuCompras.Controls.Add(alterarCompra);
        }
    }
}
