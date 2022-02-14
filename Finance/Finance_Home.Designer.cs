namespace Finance
{
    partial class Finance_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_compras = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeappbancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_DiaAtual = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_AbrirMenuCompra = new System.Windows.Forms.Button();
            this.datagrid_Faturas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_FaturasMes = new System.Windows.Forms.Label();
            this.btn_PagarFatura = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SaldoConta = new System.Windows.Forms.Label();
            this.lbl_TotalPagarFatura = new System.Windows.Forms.Label();
            this.lbl_BalancoGeral = new System.Windows.Forms.Label();
            this.btn_abrirMenuConta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_idFaturaSelecionada = new System.Windows.Forms.Label();
            this.label_valorFaturaSelecionada = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_statusFaturaSelecionada = new System.Windows.Forms.Label();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Faturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_compras
            // 
            this.datagrid_compras.AllowUserToAddRows = false;
            this.datagrid_compras.AllowUserToDeleteRows = false;
            this.datagrid_compras.AllowUserToOrderColumns = true;
            this.datagrid_compras.AutoGenerateColumns = false;
            this.datagrid_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomecompraDataGridViewTextBoxColumn,
            this.nomeappbancoDataGridViewTextBoxColumn,
            this.datacompraDataGridViewTextBoxColumn,
            this.valorcompraDataGridViewTextBoxColumn});
            this.datagrid_compras.DataSource = this.compraBindingSource;
            this.datagrid_compras.Location = new System.Drawing.Point(291, 64);
            this.datagrid_compras.Name = "datagrid_compras";
            this.datagrid_compras.ReadOnly = true;
            this.datagrid_compras.RowTemplate.Height = 25;
            this.datagrid_compras.Size = new System.Drawing.Size(874, 325);
            this.datagrid_compras.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 99;
            // 
            // nomecompraDataGridViewTextBoxColumn
            // 
            this.nomecompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomecompraDataGridViewTextBoxColumn.DataPropertyName = "Nome_compra";
            this.nomecompraDataGridViewTextBoxColumn.HeaderText = "Nome Da Compra";
            this.nomecompraDataGridViewTextBoxColumn.Name = "nomecompraDataGridViewTextBoxColumn";
            this.nomecompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomecompraDataGridViewTextBoxColumn.Width = 117;
            // 
            // nomeappbancoDataGridViewTextBoxColumn
            // 
            this.nomeappbancoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeappbancoDataGridViewTextBoxColumn.DataPropertyName = "Nome_appbanco";
            this.nomeappbancoDataGridViewTextBoxColumn.HeaderText = "Nome no Aplicativo";
            this.nomeappbancoDataGridViewTextBoxColumn.Name = "nomeappbancoDataGridViewTextBoxColumn";
            this.nomeappbancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeappbancoDataGridViewTextBoxColumn.Width = 126;
            // 
            // datacompraDataGridViewTextBoxColumn
            // 
            this.datacompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datacompraDataGridViewTextBoxColumn.DataPropertyName = "Data_compra";
            this.datacompraDataGridViewTextBoxColumn.HeaderText = "Data da Compra";
            this.datacompraDataGridViewTextBoxColumn.Name = "datacompraDataGridViewTextBoxColumn";
            this.datacompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.datacompraDataGridViewTextBoxColumn.Width = 108;
            // 
            // valorcompraDataGridViewTextBoxColumn
            // 
            this.valorcompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorcompraDataGridViewTextBoxColumn.DataPropertyName = "Valor_compra";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.valorcompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorcompraDataGridViewTextBoxColumn.HeaderText = "Valor da Compra";
            this.valorcompraDataGridViewTextBoxColumn.Name = "valorcompraDataGridViewTextBoxColumn";
            this.valorcompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(BLL.Compra);
            // 
            // label_DiaAtual
            // 
            this.label_DiaAtual.AutoSize = true;
            this.label_DiaAtual.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_DiaAtual.Location = new System.Drawing.Point(45, 16);
            this.label_DiaAtual.Name = "label_DiaAtual";
            this.label_DiaAtual.Size = new System.Drawing.Size(184, 58);
            this.label_DiaAtual.TabIndex = 1;
            this.label_DiaAtual.Text = "15/11/1998";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 83);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_AbrirMenuCompra
            // 
            this.btn_AbrirMenuCompra.Location = new System.Drawing.Point(22, 346);
            this.btn_AbrirMenuCompra.Name = "btn_AbrirMenuCompra";
            this.btn_AbrirMenuCompra.Size = new System.Drawing.Size(227, 43);
            this.btn_AbrirMenuCompra.TabIndex = 3;
            this.btn_AbrirMenuCompra.Text = "Menu de Compra";
            this.btn_AbrirMenuCompra.UseVisualStyleBackColor = true;
            this.btn_AbrirMenuCompra.Click += new System.EventHandler(this.btn_AbrirMenuCompra_Click);
            // 
            // datagrid_Faturas
            // 
            this.datagrid_Faturas.AllowUserToAddRows = false;
            this.datagrid_Faturas.AllowUserToDeleteRows = false;
            this.datagrid_Faturas.AutoGenerateColumns = false;
            this.datagrid_Faturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Faturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.totalFaturaDataGridViewTextBoxColumn,
            this.pagoDataGridViewCheckBoxColumn});
            this.datagrid_Faturas.DataSource = this.faturaBindingSource;
            this.datagrid_Faturas.Location = new System.Drawing.Point(291, 452);
            this.datagrid_Faturas.Name = "datagrid_Faturas";
            this.datagrid_Faturas.ReadOnly = true;
            this.datagrid_Faturas.RowTemplate.Height = 25;
            this.datagrid_Faturas.Size = new System.Drawing.Size(590, 297);
            this.datagrid_Faturas.TabIndex = 4;
            this.datagrid_Faturas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagrid_Faturas_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Identificador";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de Vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalFaturaDataGridViewTextBoxColumn
            // 
            this.totalFaturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalFaturaDataGridViewTextBoxColumn.DataPropertyName = "TotalFatura";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.totalFaturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalFaturaDataGridViewTextBoxColumn.HeaderText = "Total da Fatura";
            this.totalFaturaDataGridViewTextBoxColumn.Name = "totalFaturaDataGridViewTextBoxColumn";
            this.totalFaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagoDataGridViewCheckBoxColumn
            // 
            this.pagoDataGridViewCheckBoxColumn.DataPropertyName = "Pago";
            this.pagoDataGridViewCheckBoxColumn.HeaderText = "Pago";
            this.pagoDataGridViewCheckBoxColumn.Name = "pagoDataGridViewCheckBoxColumn";
            this.pagoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataSource = typeof(BLL.Fatura);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Compras do mês:";
            // 
            // label_FaturasMes
            // 
            this.label_FaturasMes.AutoSize = true;
            this.label_FaturasMes.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_FaturasMes.Location = new System.Drawing.Point(291, 410);
            this.label_FaturasMes.Name = "label_FaturasMes";
            this.label_FaturasMes.Size = new System.Drawing.Size(185, 39);
            this.label_FaturasMes.TabIndex = 6;
            this.label_FaturasMes.Text = "Faturas do mês:";
            // 
            // btn_PagarFatura
            // 
            this.btn_PagarFatura.Location = new System.Drawing.Point(22, 655);
            this.btn_PagarFatura.Name = "btn_PagarFatura";
            this.btn_PagarFatura.Size = new System.Drawing.Size(227, 43);
            this.btn_PagarFatura.TabIndex = 7;
            this.btn_PagarFatura.Text = "Pagar Fatura";
            this.btn_PagarFatura.UseVisualStyleBackColor = true;
            this.btn_PagarFatura.Click += new System.EventHandler(this.btn_PagarFatura_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(898, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saldo na Conta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(918, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total a Pagar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(968, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Balanço :";
            // 
            // lbl_SaldoConta
            // 
            this.lbl_SaldoConta.AutoSize = true;
            this.lbl_SaldoConta.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SaldoConta.Location = new System.Drawing.Point(1088, 452);
            this.lbl_SaldoConta.Name = "lbl_SaldoConta";
            this.lbl_SaldoConta.Size = new System.Drawing.Size(57, 39);
            this.lbl_SaldoConta.TabIndex = 11;
            this.lbl_SaldoConta.Text = "null";
            // 
            // lbl_TotalPagarFatura
            // 
            this.lbl_TotalPagarFatura.AutoSize = true;
            this.lbl_TotalPagarFatura.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalPagarFatura.Location = new System.Drawing.Point(1088, 511);
            this.lbl_TotalPagarFatura.Name = "lbl_TotalPagarFatura";
            this.lbl_TotalPagarFatura.Size = new System.Drawing.Size(57, 39);
            this.lbl_TotalPagarFatura.TabIndex = 12;
            this.lbl_TotalPagarFatura.Text = "null";
            // 
            // lbl_BalancoGeral
            // 
            this.lbl_BalancoGeral.AutoSize = true;
            this.lbl_BalancoGeral.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BalancoGeral.Location = new System.Drawing.Point(1085, 566);
            this.lbl_BalancoGeral.Name = "lbl_BalancoGeral";
            this.lbl_BalancoGeral.Size = new System.Drawing.Size(57, 39);
            this.lbl_BalancoGeral.TabIndex = 13;
            this.lbl_BalancoGeral.Text = "null";
            // 
            // btn_abrirMenuConta
            // 
            this.btn_abrirMenuConta.Location = new System.Drawing.Point(918, 696);
            this.btn_abrirMenuConta.Name = "btn_abrirMenuConta";
            this.btn_abrirMenuConta.Size = new System.Drawing.Size(227, 43);
            this.btn_abrirMenuConta.TabIndex = 14;
            this.btn_abrirMenuConta.Text = "Menu de Conta";
            this.btn_abrirMenuConta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fatura Selecionada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor da Fatura:";
            // 
            // label_idFaturaSelecionada
            // 
            this.label_idFaturaSelecionada.AutoSize = true;
            this.label_idFaturaSelecionada.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_idFaturaSelecionada.Location = new System.Drawing.Point(163, 475);
            this.label_idFaturaSelecionada.Name = "label_idFaturaSelecionada";
            this.label_idFaturaSelecionada.Size = new System.Drawing.Size(15, 23);
            this.label_idFaturaSelecionada.TabIndex = 17;
            this.label_idFaturaSelecionada.Text = "1";
            // 
            // label_valorFaturaSelecionada
            // 
            this.label_valorFaturaSelecionada.AutoSize = true;
            this.label_valorFaturaSelecionada.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_valorFaturaSelecionada.Location = new System.Drawing.Point(139, 542);
            this.label_valorFaturaSelecionada.Name = "label_valorFaturaSelecionada";
            this.label_valorFaturaSelecionada.Size = new System.Drawing.Size(39, 23);
            this.label_valorFaturaSelecionada.TabIndex = 18;
            this.label_valorFaturaSelecionada.Text = "1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(22, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Status:";
            // 
            // label_statusFaturaSelecionada
            // 
            this.label_statusFaturaSelecionada.AutoSize = true;
            this.label_statusFaturaSelecionada.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_statusFaturaSelecionada.ForeColor = System.Drawing.Color.IndianRed;
            this.label_statusFaturaSelecionada.Location = new System.Drawing.Point(82, 600);
            this.label_statusFaturaSelecionada.Name = "label_statusFaturaSelecionada";
            this.label_statusFaturaSelecionada.Size = new System.Drawing.Size(68, 23);
            this.label_statusFaturaSelecionada.TabIndex = 20;
            this.label_statusFaturaSelecionada.Text = "Não Pago";
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(1085, 12);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(80, 43);
            this.btn_Atualizar.TabIndex = 21;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // Finance_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 761);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.label_statusFaturaSelecionada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_valorFaturaSelecionada);
            this.Controls.Add(this.label_idFaturaSelecionada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_abrirMenuConta);
            this.Controls.Add(this.lbl_BalancoGeral);
            this.Controls.Add(this.lbl_TotalPagarFatura);
            this.Controls.Add(this.lbl_SaldoConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_PagarFatura);
            this.Controls.Add(this.label_FaturasMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_Faturas);
            this.Controls.Add(this.btn_AbrirMenuCompra);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_DiaAtual);
            this.Controls.Add(this.datagrid_compras);
            this.Name = "Finance_Home";
            this.Text = "Finance";
            this.Enter += new System.EventHandler(this.Finance_Home_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Faturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_compras;
        private System.Windows.Forms.Label label_DiaAtual;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_AbrirMenuCompra;
        private System.Windows.Forms.DataGridView datagrid_Faturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FaturasMes;
        private System.Windows.Forms.Button btn_PagarFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SaldoConta;
        private System.Windows.Forms.Label lbl_TotalPagarFatura;
        private System.Windows.Forms.Label lbl_BalancoGeral;
        private System.Windows.Forms.Button btn_abrirMenuConta;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_idFaturaSelecionada;
        private System.Windows.Forms.Label label_valorFaturaSelecionada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_statusFaturaSelecionada;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeappbancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompraDataGridViewTextBoxColumn;
    }
}
