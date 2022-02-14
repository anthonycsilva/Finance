using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DAO.Context;
using BLL;

namespace Finance
{
    public partial class Finance_Home : Form
    {
        private List<Compra> listaCompras;
        private List<Fatura> listaFaturas;
        private Conta conta;
        private bool negativado;
        private Fatura faturaSelecionada;
        public Finance_Home()
        {
            InitializeComponent();
            string dia = DateTime.Now.ToString("dd/MM/yyyy");
            label_DiaAtual.Text = dia;

            listaCompras = PesquisaCompras();
            listaFaturas = PesquisaFatura();
            conta = PesquisaConta();

            PreencheinformacoesFaturaAutomatica();

            PopulaDataGrid();
        }

        private void calcularFaturas()
        {
            CalculoDeFaturas cf = new CalculoDeFaturas(PesquisaFatura(), PesquisaCompras());
            Fatura faturaAtual = PesquisarFaturaAtual();
            Decimal valorSomadoDasCompras = cf.SomarValoresDasCompras(faturaAtual.DataVencimento.Month);
            if (valorSomadoDasCompras > faturaAtual.TotalFatura)
            {
                faturaAtual.TotalFatura = valorSomadoDasCompras;
                faturaAtual.AlterarFatura(faturaAtual);
            }
            else if (valorSomadoDasCompras < faturaAtual.TotalFatura)
            {
                faturaAtual.TotalFatura = valorSomadoDasCompras;
                faturaAtual.AlterarFatura(faturaAtual);
            }
        }

        private Fatura PesquisarFaturaAtual()
        {
            foreach (Fatura fatura in listaFaturas)
            {
                if(fatura.DataVencimento.Month == DateTime.Now.Month)
                {
                    return fatura;
                }
            }
            throw new Exception("Não foram encontrada uma fatura correspondente ao mes atual");
        }

        private void PreencheinformacoesFaturaAutomatica()
        {
            Fatura faturaAtual = PesquisarFaturaAtual();
            label_idFaturaSelecionada.Text = faturaAtual.Id.ToString();
            label_valorFaturaSelecionada.Text = faturaAtual.TotalFatura.ToString();
            if (faturaAtual.Pago)
            {
                label_statusFaturaSelecionada.ForeColor = Color.Green;
                label_statusFaturaSelecionada.Text = "Essa Fatura já foi paga";
            }
            else
            {
                label_statusFaturaSelecionada.ForeColor = Color.Red;
                label_statusFaturaSelecionada.Text = "Não Paga";
            }

            lbl_SaldoConta.Text = conta.Saldo.ToString();
            lbl_TotalPagarFatura.Text = faturaAtual.TotalFatura.ToString();
            if (conta.Saldo > faturaAtual.TotalFatura)
            {
                lbl_BalancoGeral.ForeColor = Color.Green;
                negativado = false;
                lbl_BalancoGeral.Text = $"+{conta.Saldo - faturaAtual.TotalFatura}";
            }
            else
            {
                lbl_BalancoGeral.ForeColor = Color.Red;
                negativado = true;
                lbl_BalancoGeral.Text = $"{conta.Saldo - faturaAtual.TotalFatura}";
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label_DiaAtual.Text = e.Start.ToShortDateString();
        }

        private List<Compra> PesquisaCompras()
        {
            
            FinanceContext context = new FinanceContext();
            return context.Compras.ToList();
        }

        private List<Fatura> PesquisaFatura()
        {
            FinanceContext context = new FinanceContext();
            return context.Fatura.ToList();
        }

        private Conta PesquisaConta()
        {
            FinanceContext context = new FinanceContext();
            var list = context.Conta.ToList();
            return list[0];
        }

        private void datagrid_Faturas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linhaSelecionada = e.RowIndex;
            faturaSelecionada = listaFaturas[linhaSelecionada];
            label_valorFaturaSelecionada.Text = listaFaturas[linhaSelecionada].TotalFatura.ToString();
            lbl_TotalPagarFatura.Text = listaFaturas[linhaSelecionada].TotalFatura.ToString();
            label_idFaturaSelecionada.Text = listaFaturas[linhaSelecionada].Id.ToString();

            if (listaFaturas[linhaSelecionada].Pago)
            {
                label_statusFaturaSelecionada.ForeColor = Color.Green;
                label_statusFaturaSelecionada.Text = "Essa Fatura já foi paga";
                negativado = false;
            }
            else
            {
                label_statusFaturaSelecionada.ForeColor = Color.Red;
                label_statusFaturaSelecionada.Text = "Não Paga";
                negativado = true;
            }
        }

        private void btn_AbrirMenuCompra_Click(object sender, EventArgs e)
        {
            Menu_Compras novaInstanciaMenu_Compras = new Menu_Compras();
            novaInstanciaMenu_Compras.Show();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            PreencheinformacoesFaturaAutomatica();
        }

        private void AtualizarGrid()
        {
            //para limpar o datagrid é preciso atualizar a lista de onde ele é buscado!

            LimpaDataGrids();
            PopulaDataGrid();

        }

        private void PopulaDataGrid()
        {
            calcularFaturas();
            datagrid_compras.DataSource = PesquisaCompras();
            datagrid_Faturas.DataSource = PesquisaFatura();
        }

        private void LimpaDataGrids()
        {

            datagrid_compras.DataSource = null;
            datagrid_Faturas.DataSource = null;
        }

        private void Finance_Home_Enter(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btn_PagarFatura_Click(object sender, EventArgs e)
        {
            //if(negativado == true)
            //{
            //    MessageBox.Show("Você não pode pagar fatura estando já negativo!");
            //    return;
            //}

            PagamentoFatura novaAbaPagamento = new PagamentoFatura(faturaSelecionada, conta);
            novaAbaPagamento.Show();

        }
    }
}
