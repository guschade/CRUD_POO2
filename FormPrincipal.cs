using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace trabalhoB2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        // Método para carregar os produtos no DataGridView
        private void CarregarProdutos()
        {
            try
            {
                // Criar a consulta para buscar todos os produtos
                string query = "SELECT ProdutoID, Nome, Quantidade, Preço, DataValidade FROM Produtos";
                var adapter = new MySqlDataAdapter(query, DatabaseConnection.Instance.Connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Atribuir os dados ao DataGridView
                dataGridViewProdutos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
            }
        }

        // Botão para abrir a tela de Fornecedores
        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedores fornecedoresForm = new FormFornecedores();
            fornecedoresForm.Show();
        }

        // Botão para abrir a tela de Pedidos
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos pedidosForm = new FormPedidos();
            pedidosForm.Show();
        }

        // Botão para abrir a tela de Produtos (caso queira editar os produtos)
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos produtosForm = new FormProdutos();
            produtosForm.Show();
        }
    }
}
