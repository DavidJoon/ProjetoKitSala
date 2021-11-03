using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace KitSala
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void buttonSalvarFun_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarFun", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nome", textBoxNome.Text);
                comando.Parameters.AddWithValue("@email", textBoxEmail.Text);
                comando.Parameters.AddWithValue("@chapa", textBoxChapa.Text);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Funcionário cadastrado com sucesso., Deseja cadastrar outro funcionário ou sair?", "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    textBoxNome.Clear();
                    textBoxEmail.Clear();
                    textBoxChapa.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Funcionário não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
    }
}
