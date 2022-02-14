namespace Finance.Menu_Compras_UC
{
    partial class AdicionarCompraUC
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_FaturasParaSelecionar = new System.Windows.Forms.ComboBox();
            this.textBox_NomeCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NomeAppBanco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_DataCompra = new System.Windows.Forms.DateTimePicker();
            this.textBox_ValorCompra = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionando Compras";
            // 
            // comboBox_FaturasParaSelecionar
            // 
            this.comboBox_FaturasParaSelecionar.FormattingEnabled = true;
            this.comboBox_FaturasParaSelecionar.Location = new System.Drawing.Point(223, 256);
            this.comboBox_FaturasParaSelecionar.Name = "comboBox_FaturasParaSelecionar";
            this.comboBox_FaturasParaSelecionar.Size = new System.Drawing.Size(121, 23);
            this.comboBox_FaturasParaSelecionar.TabIndex = 2;
            // 
            // textBox_NomeCompra
            // 
            this.textBox_NomeCompra.Location = new System.Drawing.Point(223, 86);
            this.textBox_NomeCompra.Name = "textBox_NomeCompra";
            this.textBox_NomeCompra.Size = new System.Drawing.Size(181, 23);
            this.textBox_NomeCompra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome da Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome no Aplicativo do Banco: ";
            // 
            // textBox_NomeAppBanco
            // 
            this.textBox_NomeAppBanco.Location = new System.Drawing.Point(223, 125);
            this.textBox_NomeAppBanco.Name = "textBox_NomeAppBanco";
            this.textBox_NomeAppBanco.Size = new System.Drawing.Size(181, 23);
            this.textBox_NomeAppBanco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(102, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor da Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(102, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data da Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(162, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fatura:";
            // 
            // dateTimePicker_DataCompra
            // 
            this.dateTimePicker_DataCompra.Location = new System.Drawing.Point(223, 209);
            this.dateTimePicker_DataCompra.Name = "dateTimePicker_DataCompra";
            this.dateTimePicker_DataCompra.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_DataCompra.TabIndex = 13;
            // 
            // textBox_ValorCompra
            // 
            this.textBox_ValorCompra.Location = new System.Drawing.Point(223, 170);
            this.textBox_ValorCompra.Mask = "9999.99";
            this.textBox_ValorCompra.Name = "textBox_ValorCompra";
            this.textBox_ValorCompra.Size = new System.Drawing.Size(181, 23);
            this.textBox_ValorCompra.TabIndex = 15;
            // 
            // AdicionarCompraUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_ValorCompra);
            this.Controls.Add(this.dateTimePicker_DataCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NomeAppBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeCompra);
            this.Controls.Add(this.comboBox_FaturasParaSelecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AdicionarCompraUC";
            this.Size = new System.Drawing.Size(623, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_FaturasParaSelecionar;
        private System.Windows.Forms.TextBox textBox_NomeCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NomeAppBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataCompra;
        private System.Windows.Forms.MaskedTextBox textBox_ValorCompra;
    }
}
