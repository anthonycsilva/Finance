namespace Finance.Menu_Compras_UC
{
    partial class ExcluirCompra_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.compraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_Fatura = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dataGridView_Compras = new System.Windows.Forms.DataGridView();
            this.faturaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // compraBindingSource1
            // 
            this.compraBindingSource1.DataSource = typeof(BLL.Compra);
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(BLL.Compra);
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataSource = typeof(BLL.Fatura);
            // 
            // label_Fatura
            // 
            this.label_Fatura.AutoSize = true;
            this.label_Fatura.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Fatura.Location = new System.Drawing.Point(129, 208);
            this.label_Fatura.Name = "label_Fatura";
            this.label_Fatura.Size = new System.Drawing.Size(0, 23);
            this.label_Fatura.TabIndex = 1;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(167, 258);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(260, 32);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Compra";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // dataGridView_Compras
            // 
            this.dataGridView_Compras.AutoGenerateColumns = false;
            this.dataGridView_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaIDDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nomecompraDataGridViewTextBoxColumn,
            this.datacompraDataGridViewTextBoxColumn,
            this.valorcompraDataGridViewTextBoxColumn});
            this.dataGridView_Compras.DataSource = this.compraBindingSource;
            this.dataGridView_Compras.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Compras.Name = "dataGridView_Compras";
            this.dataGridView_Compras.RowTemplate.Height = 25;
            this.dataGridView_Compras.Size = new System.Drawing.Size(617, 202);
            this.dataGridView_Compras.TabIndex = 3;
            this.dataGridView_Compras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Compras_CellClick);
            // 
            // faturaIDDataGridViewTextBoxColumn
            // 
            this.faturaIDDataGridViewTextBoxColumn.DataPropertyName = "faturaID";
            this.faturaIDDataGridViewTextBoxColumn.HeaderText = "Identificador da Fatura";
            this.faturaIDDataGridViewTextBoxColumn.Name = "faturaIDDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Identificador da Compra";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomecompraDataGridViewTextBoxColumn
            // 
            this.nomecompraDataGridViewTextBoxColumn.DataPropertyName = "Nome_compra";
            this.nomecompraDataGridViewTextBoxColumn.HeaderText = "Nome da Compra";
            this.nomecompraDataGridViewTextBoxColumn.Name = "nomecompraDataGridViewTextBoxColumn";
            // 
            // datacompraDataGridViewTextBoxColumn
            // 
            this.datacompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datacompraDataGridViewTextBoxColumn.DataPropertyName = "Data_compra";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.datacompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.datacompraDataGridViewTextBoxColumn.HeaderText = "Data da Compra";
            this.datacompraDataGridViewTextBoxColumn.Name = "datacompraDataGridViewTextBoxColumn";
            this.datacompraDataGridViewTextBoxColumn.Width = 108;
            // 
            // valorcompraDataGridViewTextBoxColumn
            // 
            this.valorcompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorcompraDataGridViewTextBoxColumn.DataPropertyName = "Valor_compra";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorcompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorcompraDataGridViewTextBoxColumn.HeaderText = "Valor da Compra";
            this.valorcompraDataGridViewTextBoxColumn.Name = "valorcompraDataGridViewTextBoxColumn";
            // 
            // ExcluirCompra_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_Compras);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.label_Fatura);
            this.Name = "ExcluirCompra_UC";
            this.Size = new System.Drawing.Size(623, 309);
            this.Enter += new System.EventHandler(this.ExcluirCompra_UC_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private System.Windows.Forms.Label label_Fatura;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.BindingSource compraBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView_Compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompraDataGridViewTextBoxColumn;
    }
}
