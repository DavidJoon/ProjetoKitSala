using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitSala
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaFuncionario funcionario = new TelaFuncionario();
            funcionario.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisaCodFun pesquisafun = new PesquisaCodFun();
            pesquisafun.Show();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControle controle = new TelaControle();
            controle.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaKit telakitsala = new TelaKit();
            telakitsala.Show();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisaKitSala pesquisakit = new PesquisaKitSala();
            pesquisakit.Show();
        }
    }
}
