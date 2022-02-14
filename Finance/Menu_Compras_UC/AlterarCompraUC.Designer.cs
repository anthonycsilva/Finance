namespace Finance.Menu_Compras_UC
{
    partial class AlterarCompraUC
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
            this.dataGridView_ComprasParaExcluir = new System.Windows.Forms.DataGridView();
            this.faturaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NomeCompra = new System.Windows.Forms.TextBox();
            this.textBox_NomeCompraApp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.dateTimePicker_DataCompra = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_ValorCompra = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ComprasParaExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ComprasParaExcluir
            // 
            this.dataGridView_ComprasParaExcluir.AllowUserToAddRows = false;
            this.dataGridView_ComprasParaExcluir.AllowUserToDeleteRows = false;
            this.dataGridView_ComprasParaExcluir.AutoGenerateColumns = false;
            this.dataGridView_ComprasParaExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ComprasParaExcluir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaIDDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nomecompraDataGridViewTextBoxColumn,
            this.datacompraDataGridViewTextBoxColumn,
            this.valorcompraDataGridViewTextBoxColumn});
            this.dataGridView_ComprasParaExcluir.DataSource = this.compraBindingSource;
            this.dataGridView_ComprasParaExcluir.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ComprasParaExcluir.Name = "dataGridView_ComprasParaExcluir";
            this.dataGridView_ComprasParaExcluir.ReadOnly = true;
            this.dataGridView_ComprasParaExcluir.RowTemplate.Height = 25;
            this.dataGridView_ComprasParaExcluir.Size = new System.Drawing.Size(623, 162);
            this.dataGridView_ComprasParaExcluir.TabIndex = 4;
            this.dataGridView_ComprasParaExcluir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ComprasParaExcluir_CellClick);
            // 
            // faturaIDDataGridViewTextBoxColumn
            // 
            this.faturaIDDataGridViewTextBoxColumn.DataPropertyName = "faturaID";
            this.faturaIDDataGridViewTextBoxColumn.HeaderText = "Identificador Fatura";
            this.faturaIDDataGridViewTextBoxColumn.Name = "faturaIDDataGridViewTextBoxColumn";
            this.faturaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Identificador Compra";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomecompraDataGridViewTextBoxColumn
            // 
            this.nomecompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomecompraDataGridViewTextBoxColumn.DataPropertyName = "Nome_compra";
            this.nomecompraDataGridViewTextBoxColumn.HeaderText = "Nome da Compra";
            this.nomecompraDataGridViewTextBoxColumn.Name = "nomecompraDataGridViewTextBoxColumn";
            this.nomecompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacompraDataGridViewTextBoxColumn
            // 
            this.datacompraDataGridViewTextBoxColumn.DataPropertyName = "Data_compra";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.datacompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.datacompraDataGridViewTextBoxColumn.HeaderText = "Data da Compra";
            this.datacompraDataGridViewTextBoxColumn.Name = "datacompraDataGridViewTextBoxColumn";
            this.datacompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorcompraDataGridViewTextBoxColumn
            // 
            this.valorcompraDataGridViewTextBoxColumn.DataPropertyName = "Valor_compra";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.valorcompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorcompraDataGridViewTextBoxColumn.HeaderText = "Valor da Compra";
            this.valorcompraDataGridViewTextBoxColumn.Name = "valorcompraDataGridViewTextBoxColumn";
            this.valorcompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(BLL.Compra);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome da Compra:";
            // 
            // textBox_NomeCompra
            // 
            this.textBox_NomeCompra.Location = new System.Drawing.Point(158, 174);
            this.textBox_NomeCompra.Name = "textBox_NomeCompra";
            this.textBox_NomeCompra.Size = new System.Drawing.Size(157, 23);
            this.textBox_NomeCompra.TabIndex = 6;
            // 
            // textBox_NomeCompraApp
            // 
            this.textBox_NomeCompraApp.Location = new System.Drawing.Point(158, 212);
            this.textBox_NomeCompraApp.Name = "textBox_NomeCompraApp";
            this.textBox_NomeCompraApp.Size = new System.Drawing.Size(157, 23);
            this.textBox_NomeCompraApp.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome da Compra no App:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data da Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(341, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor da Compra:";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(378, 245);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(216, 35);
            this.btn_Alterar.TabIndex = 13;
            this.btn_Alterar.Text = "Alterar Compra";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // dateTimePicker_DataCompra
            // 
            this.dateTimePicker_DataCompra.Location = new System.Drawing.Point(158, 256);
            this.dateTimePicker_DataCompra.Name = "dateTimePicker_DataCompra";
            this.dateTimePicker_DataCompra.Size = new System.Drawing.Size(197, 23);
            this.dateTimePicker_DataCompra.TabIndex = 15;
            // 
            // maskedTextBox_ValorCompra
            // 
            this.maskedTextBox_ValorCompra.Location = new System.Drawing.Point(447, 180);
            this.maskedTextBox_ValorCompra.Name = "maskedTextBox_ValorCompra";
            this.maskedTextBox_ValorCompra.Size = new System.Drawing.Size(147, 23);
            this.maskedTextBox_ValorCompra.TabIndex = 16;
            // 
            // AlterarCompraUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBox_ValorCompra);
            this.Controls.Add(this.dateTimePicker_DataCompra);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NomeCompraApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_ComprasParaExcluir);
            this.Name = "AlterarCompraUC";
            this.Size = new System.Drawing.Size(623, 309);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ComprasParaExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ComprasParaExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NomeCompra;
        private System.Windows.Forms.TextBox textBox_NomeCompraApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataCompra;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ValorCompra;
    }
}
