
namespace KitSala
{
    partial class TelaKit
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
            this.buttonSalvarKit = new System.Windows.Forms.Button();
            this.checkBoxPreto = new System.Windows.Forms.CheckBox();
            this.checkBoxAzul = new System.Windows.Forms.CheckBox();
            this.checkBoxChave = new System.Windows.Forms.CheckBox();
            this.checkBoxApagador = new System.Windows.Forms.CheckBox();
            this.checkBoxConData = new System.Windows.Forms.CheckBox();
            this.checkBoxConAr = new System.Windows.Forms.CheckBox();
            this.tbKitSala = new System.Windows.Forms.TextBox();
            this.labelTituloSalas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalvarKit
            // 
            this.buttonSalvarKit.Location = new System.Drawing.Point(162, 266);
            this.buttonSalvarKit.Name = "buttonSalvarKit";
            this.buttonSalvarKit.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarKit.TabIndex = 21;
            this.buttonSalvarKit.Text = "Salvar";
            this.buttonSalvarKit.UseVisualStyleBackColor = true;
            this.buttonSalvarKit.Click += new System.EventHandler(this.buttonSalvarKit_Click);
            // 
            // checkBoxPreto
            // 
            this.checkBoxPreto.AutoSize = true;
            this.checkBoxPreto.Location = new System.Drawing.Point(244, 213);
            this.checkBoxPreto.Name = "checkBoxPreto";
            this.checkBoxPreto.Size = new System.Drawing.Size(138, 19);
            this.checkBoxPreto.TabIndex = 19;
            this.checkBoxPreto.Text = "Canetão Digital Preto";
            this.checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzul
            // 
            this.checkBoxAzul.AutoSize = true;
            this.checkBoxAzul.Location = new System.Drawing.Point(244, 184);
            this.checkBoxAzul.Name = "checkBoxAzul";
            this.checkBoxAzul.Size = new System.Drawing.Size(133, 19);
            this.checkBoxAzul.TabIndex = 18;
            this.checkBoxAzul.Text = "Canetão Digital Azul";
            this.checkBoxAzul.UseVisualStyleBackColor = true;
            // 
            // checkBoxChave
            // 
            this.checkBoxChave.AutoSize = true;
            this.checkBoxChave.Location = new System.Drawing.Point(244, 155);
            this.checkBoxChave.Name = "checkBoxChave";
            this.checkBoxChave.Size = new System.Drawing.Size(99, 19);
            this.checkBoxChave.TabIndex = 17;
            this.checkBoxChave.Text = "Chave da Sala";
            this.checkBoxChave.UseVisualStyleBackColor = true;
            // 
            // checkBoxApagador
            // 
            this.checkBoxApagador.AutoSize = true;
            this.checkBoxApagador.Location = new System.Drawing.Point(33, 213);
            this.checkBoxApagador.Name = "checkBoxApagador";
            this.checkBoxApagador.Size = new System.Drawing.Size(165, 19);
            this.checkBoxApagador.TabIndex = 16;
            this.checkBoxApagador.Text = "Apagador da Lousa Digital";
            this.checkBoxApagador.UseVisualStyleBackColor = true;
            // 
            // checkBoxConData
            // 
            this.checkBoxConData.AutoSize = true;
            this.checkBoxConData.Location = new System.Drawing.Point(34, 184);
            this.checkBoxConData.Name = "checkBoxConData";
            this.checkBoxConData.Size = new System.Drawing.Size(145, 19);
            this.checkBoxConData.TabIndex = 15;
            this.checkBoxConData.Text = "Controle do DataShow";
            this.checkBoxConData.UseVisualStyleBackColor = true;
            // 
            // checkBoxConAr
            // 
            this.checkBoxConAr.AutoSize = true;
            this.checkBoxConAr.Location = new System.Drawing.Point(33, 155);
            this.checkBoxConAr.Name = "checkBoxConAr";
            this.checkBoxConAr.Size = new System.Drawing.Size(182, 19);
            this.checkBoxConAr.TabIndex = 14;
            this.checkBoxConAr.Text = "Controle do Ar Condicionado";
            this.checkBoxConAr.UseVisualStyleBackColor = true;
            // 
            // tbKitSala
            // 
            this.tbKitSala.Location = new System.Drawing.Point(188, 78);
            this.tbKitSala.Name = "tbKitSala";
            this.tbKitSala.Size = new System.Drawing.Size(66, 23);
            this.tbKitSala.TabIndex = 13;
            // 
            // labelTituloSalas
            // 
            this.labelTituloSalas.AutoSize = true;
            this.labelTituloSalas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloSalas.Location = new System.Drawing.Point(138, 34);
            this.labelTituloSalas.Name = "labelTituloSalas";
            this.labelTituloSalas.Size = new System.Drawing.Size(138, 21);
            this.labelTituloSalas.TabIndex = 12;
            this.labelTituloSalas.Text = "Cadastro de Salas";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(17, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 120);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kit Sala:";
            // 
            // TelaKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvarKit);
            this.Controls.Add(this.checkBoxPreto);
            this.Controls.Add(this.checkBoxAzul);
            this.Controls.Add(this.checkBoxChave);
            this.Controls.Add(this.checkBoxApagador);
            this.Controls.Add(this.checkBoxConData);
            this.Controls.Add(this.checkBoxConAr);
            this.Controls.Add(this.tbKitSala);
            this.Controls.Add(this.labelTituloSalas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaKit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Kits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvarKit;
        private System.Windows.Forms.CheckBox checkBoxPreto;
        private System.Windows.Forms.CheckBox checkBoxAzul;
        private System.Windows.Forms.CheckBox checkBoxChave;
        private System.Windows.Forms.CheckBox checkBoxApagador;
        private System.Windows.Forms.CheckBox checkBoxConData;
        private System.Windows.Forms.CheckBox checkBoxConAr;
        private System.Windows.Forms.TextBox tbKitSala;
        private System.Windows.Forms.Label labelTituloSalas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}