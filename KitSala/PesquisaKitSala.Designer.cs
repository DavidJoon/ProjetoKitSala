
namespace KitSala
{
    partial class PesquisaKitSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaKitSala));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewPesqKits = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controledata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesKit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExcluirKit = new System.Windows.Forms.Button();
            this.buttonAltKit = new System.Windows.Forms.Button();
            this.textBoxPesquisaKit = new System.Windows.Forms.TextBox();
            this.labelKitsala2 = new System.Windows.Forms.Label();
            this.checkBoxPr = new System.Windows.Forms.CheckBox();
            this.labelDigiteKit = new System.Windows.Forms.Label();
            this.checkBoxAz = new System.Windows.Forms.CheckBox();
            this.buttonPesquisarKit = new System.Windows.Forms.Button();
            this.checkBoxCha = new System.Windows.Forms.CheckBox();
            this.checkBoxApag = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.checkBoxAr = new System.Windows.Forms.CheckBox();
            this.tbKitSala2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqKits)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewPesqKits);
            this.tabPage1.Controls.Add(this.buttonPesKit);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(514, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar Tudo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPesqKits
            // 
            this.dataGridViewPesqKits.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewPesqKits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesqKits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.sala,
            this.controlear,
            this.controledata,
            this.chave});
            this.dataGridViewPesqKits.Location = new System.Drawing.Point(6, 115);
            this.dataGridViewPesqKits.Name = "dataGridViewPesqKits";
            this.dataGridViewPesqKits.RowTemplate.Height = 25;
            this.dataGridViewPesqKits.Size = new System.Drawing.Size(502, 170);
            this.dataGridViewPesqKits.TabIndex = 1;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.Name = "sala";
            // 
            // controlear
            // 
            this.controlear.HeaderText = "Controle Ar";
            this.controlear.Name = "controlear";
            // 
            // controledata
            // 
            this.controledata.HeaderText = "Controle DataShow";
            this.controledata.Name = "controledata";
            // 
            // chave
            // 
            this.chave.HeaderText = "Chave";
            this.chave.Name = "chave";
            // 
            // buttonPesKit
            // 
            this.buttonPesKit.BackColor = System.Drawing.Color.Moccasin;
            this.buttonPesKit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesKit.Location = new System.Drawing.Point(161, 60);
            this.buttonPesKit.Name = "buttonPesKit";
            this.buttonPesKit.Size = new System.Drawing.Size(214, 35);
            this.buttonPesKit.TabIndex = 0;
            this.buttonPesKit.Text = "Pesquisar Todos os Kits";
            this.buttonPesKit.UseVisualStyleBackColor = false;
            this.buttonPesKit.Click += new System.EventHandler(this.buttonPesKit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExcluirKit);
            this.tabPage2.Controls.Add(this.buttonAltKit);
            this.tabPage2.Controls.Add(this.textBoxPesquisaKit);
            this.tabPage2.Controls.Add(this.labelKitsala2);
            this.tabPage2.Controls.Add(this.checkBoxPr);
            this.tabPage2.Controls.Add(this.labelDigiteKit);
            this.tabPage2.Controls.Add(this.checkBoxAz);
            this.tabPage2.Controls.Add(this.buttonPesquisarKit);
            this.tabPage2.Controls.Add(this.checkBoxCha);
            this.tabPage2.Controls.Add(this.checkBoxApag);
            this.tabPage2.Controls.Add(this.checkBoxData);
            this.tabPage2.Controls.Add(this.checkBoxAr);
            this.tabPage2.Controls.Add(this.tbKitSala2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Código";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirKit
            // 
            this.buttonExcluirKit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExcluirKit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirKit.Location = new System.Drawing.Point(433, 217);
            this.buttonExcluirKit.Name = "buttonExcluirKit";
            this.buttonExcluirKit.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirKit.TabIndex = 36;
            this.buttonExcluirKit.Text = "Excluir";
            this.buttonExcluirKit.UseVisualStyleBackColor = false;
            this.buttonExcluirKit.Click += new System.EventHandler(this.buttonExcluirKit_Click);
            // 
            // buttonAltKit
            // 
            this.buttonAltKit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAltKit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAltKit.Location = new System.Drawing.Point(433, 175);
            this.buttonAltKit.Name = "buttonAltKit";
            this.buttonAltKit.Size = new System.Drawing.Size(75, 23);
            this.buttonAltKit.TabIndex = 35;
            this.buttonAltKit.Text = "Alterar";
            this.buttonAltKit.UseVisualStyleBackColor = false;
            this.buttonAltKit.Click += new System.EventHandler(this.buttonAltKit_Click);
            // 
            // textBoxPesquisaKit
            // 
            this.textBoxPesquisaKit.Location = new System.Drawing.Point(182, 62);
            this.textBoxPesquisaKit.Name = "textBoxPesquisaKit";
            this.textBoxPesquisaKit.Size = new System.Drawing.Size(100, 23);
            this.textBoxPesquisaKit.TabIndex = 32;
            // 
            // labelKitsala2
            // 
            this.labelKitsala2.AutoSize = true;
            this.labelKitsala2.Location = new System.Drawing.Point(125, 105);
            this.labelKitsala2.Name = "labelKitsala2";
            this.labelKitsala2.Size = new System.Drawing.Size(48, 15);
            this.labelKitsala2.TabIndex = 31;
            this.labelKitsala2.Text = "Kit Sala:";
            // 
            // checkBoxPr
            // 
            this.checkBoxPr.AutoSize = true;
            this.checkBoxPr.Location = new System.Drawing.Point(273, 233);
            this.checkBoxPr.Name = "checkBoxPr";
            this.checkBoxPr.Size = new System.Drawing.Size(138, 19);
            this.checkBoxPr.TabIndex = 29;
            this.checkBoxPr.Text = "Canetão Digital Preto";
            this.checkBoxPr.UseVisualStyleBackColor = true;
            // 
            // labelDigiteKit
            // 
            this.labelDigiteKit.AutoSize = true;
            this.labelDigiteKit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDigiteKit.Location = new System.Drawing.Point(160, 27);
            this.labelDigiteKit.Name = "labelDigiteKit";
            this.labelDigiteKit.Size = new System.Drawing.Size(174, 21);
            this.labelDigiteKit.TabIndex = 34;
            this.labelDigiteKit.Text = "Digite o Código do Kit";
            // 
            // checkBoxAz
            // 
            this.checkBoxAz.AutoSize = true;
            this.checkBoxAz.Location = new System.Drawing.Point(273, 204);
            this.checkBoxAz.Name = "checkBoxAz";
            this.checkBoxAz.Size = new System.Drawing.Size(133, 19);
            this.checkBoxAz.TabIndex = 28;
            this.checkBoxAz.Text = "Canetão Digital Azul";
            this.checkBoxAz.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisarKit
            // 
            this.buttonPesquisarKit.BackColor = System.Drawing.Color.Moccasin;
            this.buttonPesquisarKit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarKit.Location = new System.Drawing.Point(311, 62);
            this.buttonPesquisarKit.Name = "buttonPesquisarKit";
            this.buttonPesquisarKit.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarKit.TabIndex = 33;
            this.buttonPesquisarKit.Text = "Pesquisar";
            this.buttonPesquisarKit.UseVisualStyleBackColor = false;
            this.buttonPesquisarKit.Click += new System.EventHandler(this.buttonPesquisarKit_Click);
            // 
            // checkBoxCha
            // 
            this.checkBoxCha.AutoSize = true;
            this.checkBoxCha.Location = new System.Drawing.Point(273, 175);
            this.checkBoxCha.Name = "checkBoxCha";
            this.checkBoxCha.Size = new System.Drawing.Size(99, 19);
            this.checkBoxCha.TabIndex = 27;
            this.checkBoxCha.Text = "Chave da Sala";
            this.checkBoxCha.UseVisualStyleBackColor = true;
            // 
            // checkBoxApag
            // 
            this.checkBoxApag.AutoSize = true;
            this.checkBoxApag.Location = new System.Drawing.Point(62, 233);
            this.checkBoxApag.Name = "checkBoxApag";
            this.checkBoxApag.Size = new System.Drawing.Size(165, 19);
            this.checkBoxApag.TabIndex = 26;
            this.checkBoxApag.Text = "Apagador da Lousa Digital";
            this.checkBoxApag.UseVisualStyleBackColor = true;
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(63, 204);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(145, 19);
            this.checkBoxData.TabIndex = 25;
            this.checkBoxData.Text = "Controle do DataShow";
            this.checkBoxData.UseVisualStyleBackColor = true;
            // 
            // checkBoxAr
            // 
            this.checkBoxAr.AutoSize = true;
            this.checkBoxAr.Location = new System.Drawing.Point(62, 175);
            this.checkBoxAr.Name = "checkBoxAr";
            this.checkBoxAr.Size = new System.Drawing.Size(182, 19);
            this.checkBoxAr.TabIndex = 24;
            this.checkBoxAr.Text = "Controle do Ar Condicionado";
            this.checkBoxAr.UseVisualStyleBackColor = true;
            // 
            // tbKitSala2
            // 
            this.tbKitSala2.Location = new System.Drawing.Point(182, 102);
            this.tbKitSala2.Name = "tbKitSala2";
            this.tbKitSala2.Size = new System.Drawing.Size(66, 23);
            this.tbKitSala2.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(46, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 120);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa de Kit Sala";
            // 
            // PesquisaKitSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "PesquisaKitSala";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Kit Sala";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqKits)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelKitsala2;
        private System.Windows.Forms.CheckBox checkBoxPr;
        private System.Windows.Forms.CheckBox checkBoxAz;
        private System.Windows.Forms.CheckBox checkBoxCha;
        private System.Windows.Forms.CheckBox checkBoxApag;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxAr;
        private System.Windows.Forms.TextBox tbKitSala2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPesquisaKit;
        private System.Windows.Forms.Label labelDigiteKit;
        private System.Windows.Forms.Button buttonPesquisarKit;
        private System.Windows.Forms.DataGridView dataGridViewPesqKits;
        private System.Windows.Forms.Button buttonPesKit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcluirKit;
        private System.Windows.Forms.Button buttonAltKit;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlear;
        private System.Windows.Forms.DataGridViewTextBoxColumn controledata;
        private System.Windows.Forms.DataGridViewTextBoxColumn chave;
    }
}