using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KitSala
{
    public partial class PesquisaCodFun : Form
    {
        public PesquisaCodFun()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxPesquisa.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                textBoxPesquisa.Focus();
                return;
            }
            else
            {
                SqlConnection conexao = new SqlConnection(Conexao.conectar());
                SqlCommand comandos = new SqlCommand("pBuscarCodigoFun", conexao);
                comandos.CommandType = CommandType.StoredProcedure;

                try
                {
                    comandos.Parameters.AddWithValue("@codigo", textBoxPesquisa.Text);
                    conexao.Open();

                    var tabelaDados = comandos.ExecuteReader();
                    if (tabelaDados.Read())
                    {
                        textBoxNomeFun.Text = tabelaDados["Nome"].ToString();
                        textBoxEmailFun.Text = tabelaDados["Email"].ToString();
                        textBoxChapaFun.Text = tabelaDados["Chapa"].ToString();

                        buttonAlterar.Enabled = true;
                        buttonExcluir.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        textBoxNomeFun.Clear();
                        textBoxEmailFun.Clear();
                        textBoxChapaFun.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não conseguimos localizar o código", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                finally
                {
                    if (conexao.State != ConnectionState.Closed)
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", textBoxPesquisa.Text);
                comandos.Parameters.AddWithValue("@nome", textBoxNomeFun.Text);
                comandos.Parameters.AddWithValue("@email", textBoxEmailFun.Text);
                comandos.Parameters.AddWithValue("@chapa", textBoxChapaFun.Text);

                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Funcionário alterado com sucesso!");

            }
            catch
            {
                MessageBox.Show("Funcionário não alterado!");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }

        }

        private void PesquisaCodFun_Load(object sender, EventArgs e)
        {
            buttonAlterar.Enabled = false;
            buttonExcluir.Enabled = false;
        }

        private void buttonPesqFun_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscarTudoFun", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter info = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            info.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            dataGridViewFun.DataSource = dados;
            dataGridViewFun.Columns[0].Visible = false;
            dataGridViewFun.Columns[1].Visible = false;
            dataGridViewFun.Columns[2].Visible = false;
            dataGridViewFun.Columns[3].Visible = false;
            dataGridViewFun.Columns[4].HeaderCell.Value = "Código";
            dataGridViewFun.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewFun.Columns[6].HeaderCell.Value = "E-mail";
            dataGridViewFun.Columns[7].HeaderCell.Value = "Chapa";
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", textBoxPesquisa.Text);
                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Funcionário Excluido com sucesso!");
             
            }
            catch
            {
                MessageBox.Show("Funcionário não Excluido.");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }
    }
}
