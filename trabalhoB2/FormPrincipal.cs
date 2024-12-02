using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trabalhoB2
{
    public partial class FormPrincipal : Form
    {
        private MySqlConnection connection;

        public FormPrincipal()
        {
            InitializeComponent();
            connection = DatabaseConnection.Instance.Connection;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Produtos", connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPrincipal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.MdiParent = this;
            formProdutos.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedores formFornecedores = new FormFornecedores();
            formFornecedores.MdiParent = this;
            formFornecedores.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.MdiParent = this;
            formPedidos.Show();
        }

        private void txtIDProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeProduto_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }
    }
}
