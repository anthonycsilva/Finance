namespace Finance
{
    partial class Menu_Compras
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panel_MenuCompras = new System.Windows.Forms.Panel();
            this.btn_AdicionarNovaCompra = new System.Windows.Forms.Button();
            this.btn_AlterarCompra = new System.Windows.Forms.Button();
            this.btn_ExcluirCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(308, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu de Compras";
            // 
            // panel_MenuCompras
            // 
            this.panel_MenuCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MenuCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_MenuCompras.Location = new System.Drawing.Point(81, 63);
            this.panel_MenuCompras.Name = "panel_MenuCompras";
            this.panel_MenuCompras.Size = new System.Drawing.Size(623, 309);
            this.panel_MenuCompras.TabIndex = 6;
            // 
            // btn_AdicionarNovaCompra
            // 
            this.btn_AdicionarNovaCompra.Location = new System.Drawing.Point(81, 403);
            this.btn_AdicionarNovaCompra.Name = "btn_AdicionarNovaCompra";
            this.btn_AdicionarNovaCompra.Size = new System.Drawing.Size(191, 33);
            this.btn_AdicionarNovaCompra.TabIndex = 7;
            this.btn_AdicionarNovaCompra.Text = "Adicionar Nova Compra";
            this.btn_AdicionarNovaCompra.UseVisualStyleBackColor = true;
            this.btn_AdicionarNovaCompra.Click += new System.EventHandler(this.btn_AdicionarNovaCompra_Click);
            // 
            // btn_AlterarCompra
            // 
            this.btn_AlterarCompra.Location = new System.Drawing.Point(295, 403);
            this.btn_AlterarCompra.Name = "btn_AlterarCompra";
            this.btn_AlterarCompra.Size = new System.Drawing.Size(191, 33);
            this.btn_AlterarCompra.TabIndex = 8;
            this.btn_AlterarCompra.Text = "Alterar Compra";
            this.btn_AlterarCompra.UseVisualStyleBackColor = true;
            this.btn_AlterarCompra.Click += new System.EventHandler(this.btn_AlterarCompra_Click);
            // 
            // btn_ExcluirCompra
            // 
            this.btn_ExcluirCompra.Location = new System.Drawing.Point(513, 403);
            this.btn_ExcluirCompra.Name = "btn_ExcluirCompra";
            this.btn_ExcluirCompra.Size = new System.Drawing.Size(191, 33);
            this.btn_ExcluirCompra.TabIndex = 9;
            this.btn_ExcluirCompra.Text = "Excluir Compra";
            this.btn_ExcluirCompra.UseVisualStyleBackColor = true;
            this.btn_ExcluirCompra.Click += new System.EventHandler(this.btn_ExcluirCompra_Click);
            // 
            // Menu_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 474);
            this.Controls.Add(this.btn_ExcluirCompra);
            this.Controls.Add(this.btn_AlterarCompra);
            this.Controls.Add(this.btn_AdicionarNovaCompra);
            this.Controls.Add(this.panel_MenuCompras);
            this.Controls.Add(this.label2);
            this.Name = "Menu_Compras";
            this.Text = "Menu_Compras";
            this.Load += new System.EventHandler(this.Menu_Compras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_MenuCompras;
        private System.Windows.Forms.Button btn_AdicionarNovaCompra;
        private System.Windows.Forms.Button btn_AlterarCompra;
        private System.Windows.Forms.Button btn_ExcluirCompra;
    }
}