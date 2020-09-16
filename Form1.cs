using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace locadoraCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Crio a estrutura da conexão com o banco
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadora_carros";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "SK8360flip";

            //Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco
                //MessageBox.Show("Conexão Aberta!");

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "INSERT INTO clientes (nome,local_retirada,data_retirada,data_entrega,modelo_veiculo) " +
                    "VALUES('" + textboxNome.Text + "', '" + comboboxLocal.Text + "', '" + dateTimePickerRetirada.Value.ToString("yyyy-MM-dd") + "', '" + dateTimePickerDevolucao.Value.ToString("yyyy-MM-dd") + "', '" + comboboxVeiculo.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Inserido com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            //Crio a estrutura da conexão com o banco
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadora_carros";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "SK8360flip";

            //Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * from clientes WHERE cliente_ativo = 0"; //Traz todo mundo da tabela autor
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewLocadora.Rows.Clear();//FAZ LIMPAR A TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewLocadora.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//LOCAL
                    row.Cells[3].Value = reader.GetDateTime(3);//DATA_RETIRADA
                    row.Cells[4].Value = reader.GetDateTime(4);//DATA_DEVOLUCAO
                    row.Cells[5].Value = reader.GetString(5);//VEÍCULO
                    dataGridViewLocadora.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridViewLocadora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLocadora.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewLocadora.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textboxId.Text = dataGridViewLocadora.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
                textboxNome.Text = dataGridViewLocadora.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                comboboxLocal.Text = dataGridViewLocadora.Rows[e.RowIndex].Cells["ColumnLocal"].FormattedValue.ToString();
                dateTimePickerRetirada.Text = dataGridViewLocadora.Rows[e.RowIndex].Cells["ColumnRetirada"].FormattedValue.ToString();
                dateTimePickerDevolucao.Text = dataGridViewLocadora.Rows[e.RowIndex].Cells["ColumnDevolucao"].FormattedValue.ToString();
                comboboxVeiculo.Text = dataGridViewLocadora.Rows[e.RowIndex].Cells["ColumnVeiculo"].FormattedValue.ToString();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {
            textboxId.Clear();
            textboxNome.Clear();
            comboboxLocal.Text = "";
            comboboxVeiculo.Text = "";
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadora_carros";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "SK8360flip";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE clientes SET nome = '" + textboxNome.Text + "', " +
                    "local_retirada = '" + comboboxLocal.Text + "', " +
                    "data_retirada = '" + dateTimePickerRetirada.Value.ToString("yyyy-MM-dd") + "', " +
                    "data_entrega = '" + dateTimePickerDevolucao.Value.ToString("yyyy-MM-dd") + "', " +
                    "modelo_veiculo = '" + comboboxVeiculo.Text + "' WHERE id = " + textboxId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadora_carros";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "SK8360flip";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE clientes SET cliente_ativo = 1 WHERE id = " + textboxId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
