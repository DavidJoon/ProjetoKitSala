using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitSala
{
    public partial class PesquisaKitSala : Form
    {
        public PesquisaKitSala()
        {
            InitializeComponent();
        }

        private void buttonPesKit_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pBuscarTudoKitSala", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            conexao.Open();
            comando.ExecuteNonQuery();

            SqlDataAdapter info = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            info.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            dados.DataSource = table;
            dataGridViewPesqKits.DataSource = dados;
            dataGridViewPesqKits.Columns[0].Visible = false;
            dataGridViewPesqKits.Columns[1].Visible = false;
            dataGridViewPesqKits.Columns[2].Visible = false;
            dataGridViewPesqKits.Columns[3].Visible = false;
            dataGridViewPesqKits.Columns[4].Visible = false;
            dataGridViewPesqKits.Columns[5].HeaderCell.Value = "Código";
            dataGridViewPesqKits.Columns[6].HeaderCell.Value = "Sala";
            dataGridViewPesqKits.Columns[7].HeaderCell.Value = "Controle do Ar";
            dataGridViewPesqKits.Columns[8].HeaderCell.Value = "Controle DataShow";
            dataGridViewPesqKits.Columns[9].Visible = false;
            dataGridViewPesqKits.Columns[10].HeaderCell.Value = "Chave";
            dataGridViewPesqKits.Columns[11].Visible = false;
            dataGridViewPesqKits.Columns[12].Visible = false;

        }

        private void buttonPesquisarKit_Click(object sender, EventArgs e)
        {
            if (textBoxPesquisaKit.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                textBoxPesquisaKit.Focus();
                return;
            }

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pBuscarCodigoKitSala", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigo", textBoxPesquisaKit.Text);
                conexao.Open();

                var tabelaDados = comando.ExecuteReader();
                if (tabelaDados.Read())
                {
                    tbKitSala2.Text = tabelaDados["nomesala"].ToString();
                    checkBoxAr.Checked = (bool)tabelaDados["controleAr"];
                    checkBoxData.Checked = (bool)tabelaDados["controleData"];
                    checkBoxApag.Checked = (bool)tabelaDados["apagador"];
                    checkBoxCha.Checked = (bool)tabelaDados["chave"];
                    checkBoxAz.Checked = (bool)tabelaDados["canetaoAzul"];
                    checkBoxPr.Checked = (bool)tabelaDados["canetaoPreto"];

                    buttonAltKit.Enabled = true;
                    buttonExcluirKit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }




        private void buttonAltKit_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pAlterarKitSala", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                byte apagador = 0;
                byte controlear = 0;
                byte controledata = 0;
                byte chave = 0;
                byte canetaoAzul = 0;
                byte canetaoPreto = 0;

                if (checkBoxApag.Checked == true)
                {
                    apagador = 1;
                }
                if (checkBoxAr.Checked == true)
                {
                    controlear = 1;
                }
                if (checkBoxData.Checked == true)
                {
                    controledata = 1;
                }
                if (checkBoxCha.Checked == true)
                {
                    chave = 1;
                }
                if (checkBoxAz.Checked == true)
                {
                    canetaoAzul = 1;
                }
                if (checkBoxPr.Checked == true)
                {
                    canetaoPreto = 1;
                }

                comando.Parameters.AddWithValue("@sala", tbKitSala2.Text);
                comando.Parameters.AddWithValue("@controleAr", controlear);
                comando.Parameters.AddWithValue("@controleData", controledata);
                comando.Parameters.AddWithValue("@apagador", apagador);
                comando.Parameters.AddWithValue("@chave", chave);
                comando.Parameters.AddWithValue("@canetaoAzul", canetaoAzul);
                comando.Parameters.AddWithValue("@canetaoPreto", canetaoPreto);
                comando.Parameters.AddWithValue("@codigo", textBoxPesquisaKit.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Kit Sala Alterado com sucesso!");

            }
            catch
            {
                MessageBox.Show("Kit Sala não alterado.");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }

        }

        private void buttonExcluirKit_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarKitSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", textBoxPesquisaKit.Text);
                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("KitSala Excluido com sucesso!");
                tbKitSala2.Clear();
                checkBoxAr.Checked = false;
                checkBoxData.Checked = false;
                checkBoxApag.Checked = false;
                checkBoxCha.Checked = false;
                checkBoxAz.Checked = false;
                checkBoxPr.Checked = false;

            }
            catch
            {
                MessageBox.Show("KitSala não Excluido.");
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