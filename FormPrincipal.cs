namespace trabalhoB2
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;

        private System.Windows.Forms.TextBox txtProdutoID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDataValidade;

        private System.Windows.Forms.Label lblProdutoID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDataValidade;

        private void InitializeComponent()
        {
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.txtProdutoID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDataValidade = new System.Windows.Forms.TextBox();
            this.lblProdutoID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.panelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
           
            this.panelMenuLateral.BackColor = System.Drawing.Color.LightGray;
            this.panelMenuLateral.Controls.Add(this.btnFornecedores);
            this.panelMenuLateral.Controls.Add(this.btnPedidos);
            this.panelMenuLateral.Controls.Add(this.btnProdutos);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(200, 450);
            this.panelMenuLateral.TabIndex = 2;
            
            this.btnFornecedores.Location = new System.Drawing.Point(10, 20);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(180, 30);
            this.btnFornecedores.TabIndex = 0;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            
            this.btnPedidos.Location = new System.Drawing.Point(10, 60);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(180, 30);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
           
            this.btnProdutos.Location = new System.Drawing.Point(10, 100);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(180, 30);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            
            this.dataGridViewProdutos.ColumnHeadersHeight = 29;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(220, 180);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(560, 250);
            this.dataGridViewProdutos.TabIndex = 0;
           
            this.txtProdutoID.Location = new System.Drawing.Point(352, 24);
            this.txtProdutoID.Name = "txtProdutoID";
            this.txtProdutoID.Size = new System.Drawing.Size(150, 22);
            this.txtProdutoID.TabIndex = 3;
           
            this.txtNome.Location = new System.Drawing.Point(352, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 22);
            this.txtNome.TabIndex = 4;
           
            this.txtQuantidade.Location = new System.Drawing.Point(352, 81);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(150, 22);
            this.txtQuantidade.TabIndex = 5;
            
            this.txtPreco.Location = new System.Drawing.Point(352, 113);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(150, 22);
            this.txtPreco.TabIndex = 6;
            
            this.txtDataValidade.Location = new System.Drawing.Point(352, 141);
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(150, 22);
            this.txtDataValidade.TabIndex = 7;
            this.txtDataValidade.TextChanged += new System.EventHandler(this.txtDataValidade_TextChanged);
            
            this.lblProdutoID.Location = new System.Drawing.Point(217, 27);
            this.lblProdutoID.Name = "lblProdutoID";
            this.lblProdutoID.Size = new System.Drawing.Size(100, 23);
            this.lblProdutoID.TabIndex = 8;
            this.lblProdutoID.Text = "Produto ID:";
        
            this.lblNome.Location = new System.Drawing.Point(217, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            
            this.lblQuantidade.Location = new System.Drawing.Point(217, 84);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(100, 23);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.Click += new System.EventHandler(this.lblQuantidade_Click);
            
            this.lblPreco.Location = new System.Drawing.Point(217, 116);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(100, 23);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço:";
           
            this.lblDataValidade.Location = new System.Drawing.Point(217, 144);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(126, 23);
            this.lblDataValidade.TabIndex = 12;
            this.lblDataValidade.Text = "Data de Validade:";
            this.lblDataValidade.Click += new System.EventHandler(this.lblDataValidade_Click);
           
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.txtProdutoID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.lblProdutoID);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDataValidade);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Estoque";
            this.panelMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
