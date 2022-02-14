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

namespace Finance
{
    public partial class PagamentoFatura : Form
    {
        private Fatura fatura;
        private Conta conta;
        public PagamentoFatura(Fatura fatura, Conta conta)
        {
            this.fatura = fatura;
            this.conta = conta;
            InitializeComponent();
            CarregarInformacoesConta();
            CarregarInformacoesFatura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox_Confirmo.Checked)
            {
                ClassePagamentoFatura pagamentoFatura = new ClassePagamentoFatura(fatura, conta);
                try
                {
                    pagamentoFatura.pagarFatura();
                    if (DialogResult.OK == MessageBox.Show("Você acabou de pagar uma fatura!","Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                    {
                        this.Close();
                    }
                }
                catch (Exception k)
                {
                    MessageBox.Show($"Ocorreu um erro: {k.Message}", "Erro!");
                    throw;
                }
            }
        }

        private void CarregarInformacoesConta()
        {
            lbl_idFatura.Text = fatura.Id.ToString();
            lbl_dataFatura.Text = fatura.DataVencimento.ToString();
            lbl_valorFatura.Text = fatura.TotalFatura.ToString();

        }

        private void CarregarInformacoesFatura()
        {
            lbl_idConta.Text = conta.Id.ToString();
            lbl_SaldoConta.Text = conta.Saldo.ToString();
        }
    }
}
