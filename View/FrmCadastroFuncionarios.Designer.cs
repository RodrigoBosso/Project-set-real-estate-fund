
namespace Projeto_LPRC5
{
    partial class FrmCadastroFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barraManutencaoMarca = new System.Windows.Forms.ToolStrip();
            this.barbtnnovofuncionario_click = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome_registro = new System.Windows.Forms.TextBox();
            this.maskedbox_tel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.combox_estadocivil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedbox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.nome_social = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.RG = new System.Windows.Forms.Label();
            this.maskedbox_rg = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.combobox_sexo = new System.Windows.Forms.ComboBox();
            this.barraManutencaoMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Adimissão:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // barraManutencaoMarca
            // 
            this.barraManutencaoMarca.Dock = System.Windows.Forms.DockStyle.None;
            this.barraManutencaoMarca.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraManutencaoMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnnovofuncionario_click,
            this.barbtnEditar,
            this.barbtnExcluir,
            this.barbtnSalvar,
            this.barbtnCancelar,
            this.barbtnFechar});
            this.barraManutencaoMarca.Location = new System.Drawing.Point(9, 9);
            this.barraManutencaoMarca.Name = "barraManutencaoMarca";
            this.barraManutencaoMarca.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.barraManutencaoMarca.Size = new System.Drawing.Size(260, 39);
            this.barraManutencaoMarca.TabIndex = 7;
            this.barraManutencaoMarca.Text = "toolStrip1";
            // 
            // barbtnnovofuncionario_click
            // 
            this.barbtnnovofuncionario_click.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnnovofuncionario_click.Image = ((System.Drawing.Image)(resources.GetObject("barbtnnovofuncionario_click.Image")));
            this.barbtnnovofuncionario_click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnnovofuncionario_click.Name = "barbtnnovofuncionario_click";
            this.barbtnnovofuncionario_click.Size = new System.Drawing.Size(36, 36);
            this.barbtnnovofuncionario_click.Text = "Novo";
            this.barbtnnovofuncionario_click.ToolTipText = "Adicionar";
            this.barbtnnovofuncionario_click.Click += new System.EventHandler(this.barbtnNovo_Click_1);
            // 
            // barbtnEditar
            // 
            this.barbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditar.Image")));
            this.barbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnEditar.Name = "barbtnEditar";
            this.barbtnEditar.Size = new System.Drawing.Size(36, 36);
            this.barbtnEditar.Text = "Editar";
            this.barbtnEditar.ToolTipText = "Editar";
            // 
            // barbtnExcluir
            // 
            this.barbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barbtnExcluir.Image")));
            this.barbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnExcluir.Name = "barbtnExcluir";
            this.barbtnExcluir.Size = new System.Drawing.Size(36, 36);
            this.barbtnExcluir.Text = "Excluir";
            this.barbtnExcluir.ToolTipText = "Excluir";
            // 
            // barbtnSalvar
            // 
            this.barbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSalvar.Image")));
            this.barbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnSalvar.Name = "barbtnSalvar";
            this.barbtnSalvar.Size = new System.Drawing.Size(36, 36);
            this.barbtnSalvar.Text = "Salvar";
            this.barbtnSalvar.ToolTipText = "Salvar";
            // 
            // barbtnCancelar
            // 
            this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelar.Image")));
            this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelar.Name = "barbtnCancelar";
            this.barbtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.barbtnCancelar.Text = "Cancelar";
            this.barbtnCancelar.ToolTipText = "Cancelar ação";
            // 
            // barbtnFechar
            // 
            this.barbtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnFechar.Image")));
            this.barbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnFechar.Name = "barbtnFechar";
            this.barbtnFechar.Size = new System.Drawing.Size(36, 36);
            this.barbtnFechar.Text = "Fechar";
            this.barbtnFechar.ToolTipText = "Fechar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 387);
            this.dataGridView1.TabIndex = 8;
            // 
            // nome_registro
            // 
            this.nome_registro.Location = new System.Drawing.Point(389, 28);
            this.nome_registro.Name = "nome_registro";
            this.nome_registro.Size = new System.Drawing.Size(357, 20);
            this.nome_registro.TabIndex = 9;
            // 
            // maskedbox_tel
            // 
            this.maskedbox_tel.Location = new System.Drawing.Point(389, 164);
            this.maskedbox_tel.Mask = "(00) 00000-0000";
            this.maskedbox_tel.Name = "maskedbox_tel";
            this.maskedbox_tel.Size = new System.Drawing.Size(357, 20);
            this.maskedbox_tel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado Civil:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(389, 231);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(357, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // combox_estadocivil
            // 
            this.combox_estadocivil.AutoCompleteCustomSource.AddRange(new string[] {
            "Solteiro(a)",
            "Casado(a)",
            "Separado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.combox_estadocivil.FormattingEnabled = true;
            this.combox_estadocivil.Location = new System.Drawing.Point(389, 270);
            this.combox_estadocivil.Name = "combox_estadocivil";
            this.combox_estadocivil.Size = new System.Drawing.Size(357, 21);
            this.combox_estadocivil.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // maskedbox_cpf
            // 
            this.maskedbox_cpf.Location = new System.Drawing.Point(389, 101);
            this.maskedbox_cpf.Mask = "000.000.000-00";
            this.maskedbox_cpf.Name = "maskedbox_cpf";
            this.maskedbox_cpf.Size = new System.Drawing.Size(357, 20);
            this.maskedbox_cpf.TabIndex = 10;
            this.maskedbox_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // nome_social
            // 
            this.nome_social.Location = new System.Drawing.Point(389, 65);
            this.nome_social.Name = "nome_social";
            this.nome_social.Size = new System.Drawing.Size(357, 20);
            this.nome_social.TabIndex = 21;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(276, 68);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 13);
            this.label.TabIndex = 22;
            this.label.Text = "Nome Social:";
            // 
            // RG
            // 
            this.RG.AutoSize = true;
            this.RG.Location = new System.Drawing.Point(276, 137);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(26, 13);
            this.RG.TabIndex = 23;
            this.RG.Text = "RG:";
            // 
            // maskedbox_rg
            // 
            this.maskedbox_rg.Location = new System.Drawing.Point(389, 129);
            this.maskedbox_rg.Mask = "00.000.00-0";
            this.maskedbox_rg.Name = "maskedbox_rg";
            this.maskedbox_rg.Size = new System.Drawing.Size(357, 20);
            this.maskedbox_rg.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(389, 195);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(357, 20);
            this.email.TabIndex = 26;
            // 
            // combobox_sexo
            // 
            this.combobox_sexo.FormattingEnabled = true;
            this.combobox_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não dizer"});
            this.combobox_sexo.Location = new System.Drawing.Point(389, 306);
            this.combobox_sexo.Name = "combobox_sexo";
            this.combobox_sexo.Size = new System.Drawing.Size(121, 21);
            this.combobox_sexo.TabIndex = 27;
            // 
            // FrmCadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combobox_sexo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedbox_rg);
            this.Controls.Add(this.RG);
            this.Controls.Add(this.label);
            this.Controls.Add(this.nome_social);
            this.Controls.Add(this.combox_estadocivil);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedbox_tel);
            this.Controls.Add(this.maskedbox_cpf);
            this.Controls.Add(this.nome_registro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.barraManutencaoMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroFuncionarios";
            this.Text = "FrmCadastroFuncionarios";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionarios_Load_1);
            this.barraManutencaoMarca.ResumeLayout(false);
            this.barraManutencaoMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip barraManutencaoMarca;
        private System.Windows.Forms.ToolStripButton barbtnnovofuncionario_click;
        private System.Windows.Forms.ToolStripButton barbtnEditar;
        private System.Windows.Forms.ToolStripButton barbtnExcluir;
        private System.Windows.Forms.ToolStripButton barbtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barbtnFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nome_registro;
        private System.Windows.Forms.MaskedTextBox maskedbox_tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox combox_estadocivil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedbox_cpf;
        private System.Windows.Forms.TextBox nome_social;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label RG;
        private System.Windows.Forms.MaskedTextBox maskedbox_rg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox combobox_sexo;
    }
}