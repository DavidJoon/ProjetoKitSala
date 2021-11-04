
namespace KitSala
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.labelTituloFun = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelChapa = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxChapa = new System.Windows.Forms.TextBox();
            this.buttonSalvarFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloFun
            // 
            this.labelTituloFun.AutoSize = true;
            this.labelTituloFun.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloFun.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloFun.Location = new System.Drawing.Point(122, 50);
            this.labelTituloFun.Name = "labelTituloFun";
            this.labelTituloFun.Size = new System.Drawing.Size(220, 25);
            this.labelTituloFun.TabIndex = 0;
            this.labelTituloFun.Text = "Cadastro de Funcionário";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNome.Location = new System.Drawing.Point(56, 108);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(55, 150);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelChapa
            // 
            this.labelChapa.AutoSize = true;
            this.labelChapa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChapa.Location = new System.Drawing.Point(55, 192);
            this.labelChapa.Name = "labelChapa";
            this.labelChapa.Size = new System.Drawing.Size(44, 15);
            this.labelChapa.TabIndex = 3;
            this.labelChapa.Text = "Chapa:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(102, 105);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(291, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(102, 147);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 23);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxChapa
            // 
            this.textBoxChapa.Location = new System.Drawing.Point(103, 189);
            this.textBoxChapa.Name = "textBoxChapa";
            this.textBoxChapa.Size = new System.Drawing.Size(100, 23);
            this.textBoxChapa.TabIndex = 6;
            // 
            // buttonSalvarFun
            // 
            this.buttonSalvarFun.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSalvarFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarFun.Location = new System.Drawing.Point(289, 192);
            this.buttonSalvarFun.Name = "buttonSalvarFun";
            this.buttonSalvarFun.Size = new System.Drawing.Size(84, 23);
            this.buttonSalvarFun.TabIndex = 7;
            this.buttonSalvarFun.Text = "Salvar";
            this.buttonSalvarFun.UseVisualStyleBackColor = false;
            this.buttonSalvarFun.Click += new System.EventHandler(this.buttonSalvarFun_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 294);
            this.Controls.Add(this.buttonSalvarFun);
            this.Controls.Add(this.textBoxChapa);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelChapa);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelTituloFun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaFuncionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloFun;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelChapa;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxChapa;
        private System.Windows.Forms.Button buttonSalvarFun;
    }
}