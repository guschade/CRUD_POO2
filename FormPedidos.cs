using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trabalhoB2
{
    public partial class FormPedidos : Form
    {
        private MySqlConnection connection;

        public FormPedidos()
        {
            InitializeComponent();
            connection = DatabaseConnection.Instance.Connection;
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Pedidos", connection);
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
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Pedidos (ProdutoID, FornecedorID, Quantidade, DataPedido) VALUES (@produtoID, @fornecedorID, @quantidade, @dataPedido)", connection);
                cmd.Parameters.AddWithValue("@produtoID", int.Parse(txtProdutoID.Text));
                cmd.Parameters.AddWithValue("@fornecedorID", int.Parse(txtFornecedorID.Text));
                cmd.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@dataPedido", DateTime.Parse(txtDataPedido.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar pedido: " + ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("UPDATE Pedidos SET ProdutoID=@produtoID, FornecedorID=@fornecedorID, Quantidade=@quantidade, DataPedido=@dataPedido WHERE PedidoID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@produtoID", int.Parse(txtProdutoID.Text));
                cmd.Parameters.AddWithValue("@fornecedorID", int.Parse(txtFornecedorID.Text));
                cmd.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@dataPedido", DateTime.Parse(txtDataPedido.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pedido: " + ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Pedidos WHERE PedidoID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir pedido: " + ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Pedidos WHERE PedidoID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar pedido: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
