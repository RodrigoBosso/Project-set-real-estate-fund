
namespace Projeto_LPRC5
{
    partial class frmEmpresaPrestadoraServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresaPrestadoraServico));
            this.barraManutencaoMarca = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.grdDadosEmpresaPrestadoraServico = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txt_Servico = new System.Windows.Forms.TextBox();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.Txt_Empresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Telefone = new System.Windows.Forms.TextBox();
            this.Txt_Descricao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Cnpj = new System.Windows.Forms.TextBox();
            this.Txt_InscEstadual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_InscMunicipal = new System.Windows.Forms.TextBox();
            this.barraManutencaoMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosEmpresaPrestadoraServico)).BeginInit();
            this.SuspendLayout();
            // 
            // barraManutencaoMarca
            // 
            this.barraManutencaoMarca.Dock = System.Windows.Forms.DockStyle.None;
            this.barraManutencaoMarca.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraManutencaoMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnNovo,
            this.barbtnEditar,
            this.barbtnExcluir,
            this.barbtnSalvar,
            this.barbtnCancelar,
            this.barbtnFechar});
            this.barraManutencaoMarca.Location = new System.Drawing.Point(12, 11);
            this.barraManutencaoMarca.Name = "barraManutencaoMarca";
            this.barraManutencaoMarca.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.barraManutencaoMarca.Size = new System.Drawing.Size(270, 39);
            this.barraManutencaoMarca.TabIndex = 8;
            this.barraManutencaoMarca.Text = "toolStrip1";
            // 
            // barbtnNovo
            // 
            this.barbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNovo.Image")));
            this.barbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnNovo.Name = "barbtnNovo";
            this.barbtnNovo.Size = new System.Drawing.Size(36, 36);
            this.barbtnNovo.Text = "Novo";
            this.barbtnNovo.ToolTipText = "Adicionar";
          //  this.barbtnNovo.Click += new System.EventHandler(this.barbtnNovo_Click_1);
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
            // grdDadosEmpresaPrestadoraServico
            // 
            this.grdDadosEmpresaPrestadoraServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosEmpresaPrestadoraServico.Location = new System.Drawing.Point(12, 95);
            this.grdDadosEmpresaPrestadoraServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDadosEmpresaPrestadoraServico.Name = "grdDadosEmpresaPrestadoraServico";
            this.grdDadosEmpresaPrestadoraServico.RowHeadersWidth = 51;
            this.grdDadosEmpresaPrestadoraServico.Size = new System.Drawing.Size(305, 458);
            this.grdDadosEmpresaPrestadoraServico.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 22);
            this.textBox1.TabIndex = 10;
            // 
            // Txt_Servico
            // 
            this.Txt_Servico.Location = new System.Drawing.Point(689, 220);
            this.Txt_Servico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Servico.Name = "Txt_Servico";
            this.Txt_Servico.Size = new System.Drawing.Size(203, 22);
            this.Txt_Servico.TabIndex = 12;
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.Location = new System.Drawing.Point(419, 292);
            this.Txt_Endereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.Size = new System.Drawing.Size(473, 22);
            this.Txt_Endereco.TabIndex = 14;
            // 
            // Txt_Empresa
            // 
            this.Txt_Empresa.Location = new System.Drawing.Point(689, 95);
            this.Txt_Empresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Empresa.Name = "Txt_Empresa";
            this.Txt_Empresa.Size = new System.Drawing.Size(203, 22);
            this.Txt_Empresa.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descrição";
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(416, 220);
            this.Txt_Telefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(205, 22);
            this.Txt_Telefone.TabIndex = 23;
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.Location = new System.Drawing.Point(419, 415);
            this.Txt_Descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(473, 117);
            this.Txt_Descricao.TabIndex = 24;
            this.Txt_Descricao.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "CNPJ";
            // 
            // Txt_Cnpj
            // 
            this.Txt_Cnpj.Location = new System.Drawing.Point(419, 95);
            this.Txt_Cnpj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Cnpj.Name = "Txt_Cnpj";
            this.Txt_Cnpj.Size = new System.Drawing.Size(203, 22);
            this.Txt_Cnpj.TabIndex = 26;
            // 
            // Txt_InscEstadual
            // 
            this.Txt_InscEstadual.Location = new System.Drawing.Point(419, 155);
            this.Txt_InscEstadual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_InscEstadual.Name = "Txt_InscEstadual";
            this.Txt_InscEstadual.Size = new System.Drawing.Size(203, 22);
            this.Txt_InscEstadual.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Inscrição Estadual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(685, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Inscrição Municipal";
            // 
            // Txt_InscMunicipal
            // 
            this.Txt_InscMunicipal.Location = new System.Drawing.Point(689, 155);
            this.Txt_InscMunicipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_InscMunicipal.Name = "Txt_InscMunicipal";
            this.Txt_InscMunicipal.Size = new System.Drawing.Size(203, 22);
            this.Txt_InscMunicipal.TabIndex = 30;
            // 
            // frmEmpresaPrestadoraServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 569);
            this.Controls.Add(this.Txt_InscMunicipal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_InscEstadual);
            this.Controls.Add(this.Txt_Cnpj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Descricao);
            this.Controls.Add(this.Txt_Telefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Empresa);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.Txt_Servico);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grdDadosEmpresaPrestadoraServico);
            this.Controls.Add(this.barraManutencaoMarca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEmpresaPrestadoraServico";
            this.Text = "Form1";
            this.barraManutencaoMarca.ResumeLayout(false);
            this.barraManutencaoMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosEmpresaPrestadoraServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraManutencaoMarca;
        private System.Windows.Forms.ToolStripButton barbtnNovo;
        private System.Windows.Forms.ToolStripButton barbtnEditar;
        private System.Windows.Forms.ToolStripButton barbtnExcluir;
        private System.Windows.Forms.ToolStripButton barbtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barbtnFechar;
        private System.Windows.Forms.DataGridView grdDadosEmpresaPrestadoraServico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Txt_Servico;
        private System.Windows.Forms.TextBox Txt_Endereco;
        private System.Windows.Forms.TextBox Txt_Empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Telefone;
        private System.Windows.Forms.RichTextBox Txt_Descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Cnpj;
        private System.Windows.Forms.TextBox Txt_InscEstadual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_InscMunicipal;
    }
}