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

        private void CarregarProdutos()
        {
            try
            {
                string query = "SELECT ProdutoID, Nome, Quantidade, Preço, DataValidade FROM Produtos";
                var adapter = new MySqlDataAdapter(query, DatabaseConnection.Instance.Connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewProdutos.DataSource = dataTable;

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    txtProdutoID.Text = row["ProdutoID"].ToString();
                    txtNome.Text = row["Nome"].ToString();
                    txtQuantidade.Text = row["Quantidade"].ToString();
                    txtPreco.Text = row["Preço"].ToString();
                    txtDataValidade.Text = row["DataValidade"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
            }
        }


        private void btnFornecedores_Click(object sender, EventArgs e)

        {

            FormFornecedores fornecedoresForm = new FormFornecedores();

            fornecedoresForm.Show();

        }


        private void btnPedidos_Click(object sender, EventArgs e)

        {

            FormPedidos pedidosForm = new FormPedidos();

            pedidosForm.Show();

        }

        private void btnProdutos_Click(object sender, EventArgs e)

        {

            FormProdutos produtosForm = new FormProdutos();

            produtosForm.Show();

        }

        private void txtDataValidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDataValidade_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }
    }

}
