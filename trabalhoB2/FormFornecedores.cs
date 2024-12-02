using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trabalhoB2
{
    public partial class FormFornecedores : Form
    {
        private MySqlConnection connection;

        public FormFornecedores()
        {
            InitializeComponent();
            connection = DatabaseConnection.Instance.Connection;
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Fornecedores", connection);
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
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Fornecedores (Nome, Telefone, Email) VALUES (@nome, @telefone, @email)", connection);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar fornecedor: " + ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("UPDATE Fornecedores SET Nome=@nome, Telefone=@telefone, Email=@email WHERE FornecedorID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Fornecedores WHERE FornecedorID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Fornecedores WHERE FornecedorID=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar fornecedor: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
