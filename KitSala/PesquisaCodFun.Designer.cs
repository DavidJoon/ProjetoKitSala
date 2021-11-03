
namespace KitSala
{
    partial class PesquisaCodFun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxChapaFun = new System.Windows.Forms.TextBox();
            this.textBoxEmailFun = new System.Windows.Forms.TextBox();
            this.textBoxNomeFun = new System.Windows.Forms.TextBox();
            this.labelChapa = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelDigite = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonPesqFun = new System.Windows.Forms.Button();
            this.dataGridViewFun = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFun)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxChapaFun
            // 
            this.textBoxChapaFun.Location = new System.Drawing.Point(64, 201);
            this.textBoxChapaFun.Name = "textBoxChapaFun";
            this.textBoxChapaFun.Size = new System.Drawing.Size(100, 23);
            this.textBoxChapaFun.TabIndex = 4;
            // 
            // textBoxEmailFun
            // 
            this.textBoxEmailFun.Location = new System.Drawing.Point(63, 159);
            this.textBoxEmailFun.Name = "textBoxEmailFun";
            this.textBoxEmailFun.Size = new System.Drawing.Size(290, 23);
            this.textBoxEmailFun.TabIndex = 3;
            // 
            // textBoxNomeFun
            // 
            this.textBoxNomeFun.Location = new System.Drawing.Point(63, 117);
            this.textBoxNomeFun.Name = "textBoxNomeFun";
            this.textBoxNomeFun.Size = new System.Drawing.Size(291, 23);
            this.textBoxNomeFun.TabIndex = 2;
            // 
            // labelChapa
            // 
            this.labelChapa.AutoSize = true;
            this.labelChapa.Location = new System.Drawing.Point(16, 204);
            this.labelChapa.Name = "labelChapa";
            this.labelChapa.Size = new System.Drawing.Size(44, 15);
            this.labelChapa.TabIndex = 9;
            this.labelChapa.Text = "Chapa:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 162);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 15);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(17, 120);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 7;
            this.labelNome.Text = "Nome:";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(224, 79);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 13;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // labelDigite
            // 
            this.labelDigite.AutoSize = true;
            this.labelDigite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDigite.Location = new System.Drawing.Point(82, 44);
            this.labelDigite.Name = "labelDigite";
            this.labelDigite.Size = new System.Drawing.Size(239, 21);
            this.labelDigite.TabIndex = 14;
            this.labelDigite.Text = "Digite o Código do Funcionário";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(104, 79);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(100, 23);
            this.textBoxPesquisa.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(35, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 310);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExcluir);
            this.tabPage2.Controls.Add(this.buttonAlterar);
            this.tabPage2.Controls.Add(this.textBoxPesquisa);
            this.tabPage2.Controls.Add(this.labelDigite);
            this.tabPage2.Controls.Add(this.textBoxChapaFun);
            this.tabPage2.Controls.Add(this.labelNome);
            this.tabPage2.Controls.Add(this.labelChapa);
            this.tabPage2.Controls.Add(this.textBoxNomeFun);
            this.tabPage2.Controls.Add(this.buttonPesquisar);
            this.tabPage2.Controls.Add(this.labelEmail);
            this.tabPage2.Controls.Add(this.textBoxEmailFun);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa Código";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(289, 204);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(65, 23);
            this.buttonExcluir.TabIndex = 16;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(208, 204);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(65, 23);
            this.buttonAlterar.TabIndex = 15;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPesqFun);
            this.tabPage1.Controls.Add(this.dataGridViewFun);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Tudo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonPesqFun
            // 
            this.buttonPesqFun.Location = new System.Drawing.Point(76, 44);
            this.buttonPesqFun.Name = "buttonPesqFun";
            this.buttonPesqFun.Size = new System.Drawing.Size(243, 35);
            this.buttonPesqFun.TabIndex = 1;
            this.buttonPesqFun.Text = "Pesquisar Todos os Funcionários";
            this.buttonPesqFun.UseVisualStyleBackColor = true;
            this.buttonPesqFun.Click += new System.EventHandler(this.buttonPesqFun_Click);
            // 
            // dataGridViewFun
            // 
            this.dataGridViewFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Email,
            this.Chapa});
            this.dataGridViewFun.Location = new System.Drawing.Point(6, 105);
            this.dataGridViewFun.Name = "dataGridViewFun";
            this.dataGridViewFun.RowTemplate.Height = 25;
            this.dataGridViewFun.Size = new System.Drawing.Size(371, 150);
            this.dataGridViewFun.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 60;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 141;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.Width = 142;
            // 
            // Chapa
            // 
            this.Chapa.HeaderText = "Chapa";
            this.Chapa.Name = "Chapa";
            this.Chapa.Width = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pesquisar Funcionário";
            // 
            // PesquisaCodFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "PesquisaCodFun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa por Código";
            this.Load += new System.EventHandler(this.PesquisaCodFun_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChapaFun;
        private System.Windows.Forms.TextBox textBoxEmailFun;
        private System.Windows.Forms.TextBox textBoxNomeFun;
        private System.Windows.Forms.Label labelChapa;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label labelDigite;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesqFun;
        private System.Windows.Forms.DataGridView dataGridViewFun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chapa;
    }
}