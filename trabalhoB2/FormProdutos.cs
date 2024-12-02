using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trabalhoB2
{
    public partial class FormProdutos : Form
    {
        private MySqlConnection connection;

        public FormProdutos()
        {
            InitializeComponent();
            connection = DatabaseConnection.Instance.Connection;
        }

        private void FormProdutos_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Produtos (Nome, Quantidade, Preco, DataValidade) VALUES (@nome, @quantidade, @preco, @datavalidade)", connection);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));
                cmd.Parameters.AddWithValue("@datavalidade", DateTime.Parse(txtDataValidade.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Produtos SET Nome=@nome, Quantidade=@quantidade, Preco=@preco, DataValidade=@datavalidade WHERE ProdutoID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));
                cmd.Parameters.AddWithValue("@datavalidade", DateTime.Parse(txtDataValidade.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Produtos WHERE ProdutoID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Produtos WHERE ProdutoID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
