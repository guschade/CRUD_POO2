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

        private void InitializeComponent()
        {
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
           
            this.panelMenuLateral.Controls.Add(this.btnFornecedores);
            this.panelMenuLateral.Controls.Add(this.btnPedidos);
            this.panelMenuLateral.Controls.Add(this.btnProdutos);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Width = 200;
            this.panelMenuLateral.BackColor = System.Drawing.Color.LightGray;
            
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
           
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(200, 0);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(600, 450);
            this.dataGridViewProdutos.TabIndex = 1;
           
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.panelMenuLateral);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
