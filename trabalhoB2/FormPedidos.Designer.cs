namespace trabalhoB2
{
    partial class FormPedidos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtProdutoID;
        private System.Windows.Forms.TextBox txtFornecedorID;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDataPedido;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProdutoID;
        private System.Windows.Forms.Label lblFornecedorID;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProdutoID = new System.Windows.Forms.TextBox();
            this.txtFornecedorID = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDataPedido = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblProdutoID = new System.Windows.Forms.Label();
            this.lblFornecedorID = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 418);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtProdutoID
            // 
            this.txtProdutoID.Location = new System.Drawing.Point(157, 418);
            this.txtProdutoID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdutoID.Name = "txtProdutoID";
            this.txtProdutoID.Size = new System.Drawing.Size(132, 22);
            this.txtProdutoID.TabIndex = 2;
            // 
            // txtFornecedorID
            // 
            this.txtFornecedorID.Location = new System.Drawing.Point(299, 418);
            this.txtFornecedorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFornecedorID.Name = "txtFornecedorID";
            this.txtFornecedorID.Size = new System.Drawing.Size(132, 22);
            this.txtFornecedorID.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(440, 418);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(132, 22);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Location = new System.Drawing.Point(581, 418);
            this.txtDataPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.Size = new System.Drawing.Size(132, 22);
            this.txtDataPedido.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(723, 416);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 28);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(831, 416);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 28);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(939, 416);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(939, 382);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 394);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblProdutoID
            // 
            this.lblProdutoID.AutoSize = true;
            this.lblProdutoID.Location = new System.Drawing.Point(157, 394);
            this.lblProdutoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoID.Name = "lblProdutoID";
            this.lblProdutoID.Size = new System.Drawing.Size(70, 16);
            this.lblProdutoID.TabIndex = 10;
            this.lblProdutoID.Text = "ID Produto";
            // 
            // lblFornecedorID
            // 
            this.lblFornecedorID.AutoSize = true;
            this.lblFornecedorID.Location = new System.Drawing.Point(299, 394);
            this.lblFornecedorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedorID.Name = "lblFornecedorID";
            this.lblFornecedorID.Size = new System.Drawing.Size(93, 16);
            this.lblFornecedorID.TabIndex = 11;
            this.lblFornecedorID.Text = "ID Fornecedor";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(440, 394);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(77, 16);
            this.lblQuantidade.TabIndex = 12;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(581, 394);
            this.lblDataPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(102, 16);
            this.lblDataPedido.TabIndex = 13;
            this.lblDataPedido.Text = "Data do Pedido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(343, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 32);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Gerenciamento de Pedidos";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblFornecedorID);
            this.Controls.Add(this.lblProdutoID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDataPedido);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtFornecedorID);
            this.Controls.Add(this.txtProdutoID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPedidos";
            this.Text = "Gerenciamento de Pedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
