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
    public partial class TelaKit : Form
    {
        public TelaKit()
        {
            InitializeComponent();
        }

        private void buttonSalvarKit_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarKitSala", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {

                byte apagador = 0;
                byte controlear = 0;
                byte controledata = 0;
                byte chave = 0;
                byte canetaoAzul = 0;
                byte canetaoPreto = 0;

                if (checkBoxApagador.Checked == true)
                {
                    apagador = 1;
                }
                if (checkBoxConAr.Checked == true)
                {
                    controlear = 1;
                }
                if (checkBoxConData.Checked == true)
                {
                    controledata = 1;
                }
                if (checkBoxChave.Checked == true)
                {
                    chave = 1;
                }
                if (checkBoxAzul.Checked == true)
                {
                    canetaoAzul = 1;
                }
                if (checkBoxPreto.Checked == true)
                {
                    canetaoPreto = 1;
                }


                comando.Parameters.AddWithValue("@sala", tbKitSala.Text);
                comando.Parameters.AddWithValue("@controlear", controlear);
                comando.Parameters.AddWithValue("@controledata", controledata);
                comando.Parameters.AddWithValue("@apagador", apagador);
                comando.Parameters.AddWithValue("@chave", chave);
                comando.Parameters.AddWithValue("@canetaoazul", canetaoAzul);
                comando.Parameters.AddWithValue("@canetaopreto", canetaoPreto);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Kit Sala cadastrado com sucesso." +
                    "Deseja cadastrar outro Kit Sala?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    tbKitSala.Clear();
                    checkBoxConAr.Checked = false;
                    checkBoxConData.Checked = false;
                    checkBoxApagador.Checked = false;
                    checkBoxChave.Checked = false;
                    checkBoxAzul.Checked = false;
                    checkBoxPreto.Checked = false;
                }
                else
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Kit Sala não cadastrado", "Atenção");
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
        
    
