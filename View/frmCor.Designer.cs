
namespace Projeto_LPRC5
{
    partial class frmCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCor));
            this.barManutencaoCor = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.grdDadosCor = new System.Windows.Forms.DataGridView();
            this.lblCorNome = new System.Windows.Forms.Label();
            this.txtNomeCor = new System.Windows.Forms.TextBox();
            this.barManutencaoCor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosCor)).BeginInit();
            this.SuspendLayout();
            // 
            // barManutencaoCor
            // 
            this.barManutencaoCor.Dock = System.Windows.Forms.DockStyle.None;
            this.barManutencaoCor.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barManutencaoCor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnNovo,
            this.barbtnEditar,
            this.barbtnExcluir,
            this.barbtnSalvar,
            this.barbtnCancelar,
            this.barbtnFechar});
            this.barManutencaoCor.Location = new System.Drawing.Point(0, 0);
            this.barManutencaoCor.Name = "barManutencaoCor";
            this.barManutencaoCor.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.barManutencaoCor.Size = new System.Drawing.Size(229, 39);
            this.barManutencaoCor.TabIndex = 1;
            this.barManutencaoCor.Text = "toolStrip1";
            // 
            // barbtnNovo
            // 
            this.barbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNovo.Image")));
            this.barbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnNovo.Name = "barbtnNovo";
            this.barbtnNovo.Size = new System.Drawing.Size(36, 36);
            this.barbtnNovo.Tag = "1";
            this.barbtnNovo.Text = "Novo";
            this.barbtnNovo.ToolTipText = "Adicionar Cor";
            this.barbtnNovo.Click += new System.EventHandler(this.barbtnNovo_Click);
            // 
            // barbtnEditar
            // 
            this.barbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditar.Image")));
            this.barbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnEditar.Name = "barbtnEditar";
            this.barbtnEditar.Size = new System.Drawing.Size(36, 36);
            this.barbtnEditar.Tag = "2";
            this.barbtnEditar.Text = "Editar";
            this.barbtnEditar.ToolTipText = "Editar Cor";
            this.barbtnEditar.Click += new System.EventHandler(this.barbtnEditar_Click);
            // 
            // barbtnExcluir
            // 
            this.barbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barbtnExcluir.Image")));
            this.barbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnExcluir.Name = "barbtnExcluir";
            this.barbtnExcluir.Size = new System.Drawing.Size(36, 36);
            this.barbtnExcluir.Tag = "3";
            this.barbtnExcluir.Text = "Excluir";
            this.barbtnExcluir.ToolTipText = "Excluir Cor";
            this.barbtnExcluir.Click += new System.EventHandler(this.barbtnExcluir_Click);
            // 
            // barbtnSalvar
            // 
            this.barbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSalvar.Image")));
            this.barbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnSalvar.Name = "barbtnSalvar";
            this.barbtnSalvar.Size = new System.Drawing.Size(36, 36);
            this.barbtnSalvar.Tag = "4";
            this.barbtnSalvar.Text = "Salvar";
            this.barbtnSalvar.ToolTipText = "Salvar nova Cor";
            this.barbtnSalvar.Click += new System.EventHandler(this.barbtnSalvar_Click);
            // 
            // barbtnCancelar
            // 
            this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelar.Image")));
            this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelar.Name = "barbtnCancelar";
            this.barbtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.barbtnCancelar.Tag = "5";
            this.barbtnCancelar.Text = "Cancelar";
            this.barbtnCancelar.ToolTipText = "Cancelar";
            this.barbtnCancelar.Click += new System.EventHandler(this.barbtnCancelar_Click);
            // 
            // barbtnFechar
            // 
            this.barbtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnFechar.Image")));
            this.barbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnFechar.Name = "barbtnFechar";
            this.barbtnFechar.Size = new System.Drawing.Size(36, 36);
            this.barbtnFechar.Tag = "6";
            this.barbtnFechar.Text = "Fechar";
            this.barbtnFechar.ToolTipText = "Fechar";
            this.barbtnFechar.Click += new System.EventHandler(this.barbtnSair_Click);
            // 
            // grdDadosCor
            // 
            this.grdDadosCor.AllowUserToAddRows = false;
            this.grdDadosCor.AllowUserToDeleteRows = false;
            this.grdDadosCor.AllowUserToResizeColumns = false;
            this.grdDadosCor.AllowUserToResizeRows = false;
            this.grdDadosCor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosCor.Location = new System.Drawing.Point(10, 41);
            this.grdDadosCor.Margin = new System.Windows.Forms.Padding(4);
            this.grdDadosCor.Name = "grdDadosCor";
            this.grdDadosCor.ReadOnly = true;
            this.grdDadosCor.RowHeadersWidth = 51;
            this.grdDadosCor.Size = new System.Drawing.Size(220, 282);
            this.grdDadosCor.TabIndex = 4;
            this.grdDadosCor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCid_CellClick);
            this.grdDadosCor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCid_CellContentClick);
            // 
            // lblCorNome
            // 
            this.lblCorNome.AutoSize = true;
            this.lblCorNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorNome.Location = new System.Drawing.Point(237, 41);
            this.lblCorNome.Name = "lblCorNome";
            this.lblCorNome.Size = new System.Drawing.Size(47, 19);
            this.lblCorNome.TabIndex = 11;
            this.lblCorNome.Text = "Nome";
            // 
            // txtNomeCor
            // 
            this.txtNomeCor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCor.Location = new System.Drawing.Point(237, 65);
            this.txtNomeCor.Name = "txtNomeCor";
            this.txtNomeCor.Size = new System.Drawing.Size(237, 26);
            this.txtNomeCor.TabIndex = 10;
            // 
            // frmCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 331);
            this.Controls.Add(this.lblCorNome);
            this.Controls.Add(this.txtNomeCor);
            this.Controls.Add(this.grdDadosCor);
            this.Controls.Add(this.barManutencaoCor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCor";
            this.Tag = "12";
            this.Text = "Manutenção Cor";
            this.Load += new System.EventHandler(this.fmrCor_Load);
            this.barManutencaoCor.ResumeLayout(false);
            this.barManutencaoCor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosCor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barManutencaoCor;
        private System.Windows.Forms.ToolStripButton barbtnNovo;
        private System.Windows.Forms.ToolStripButton barbtnEditar;
        private System.Windows.Forms.ToolStripButton barbtnExcluir;
        private System.Windows.Forms.ToolStripButton barbtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barbtnFechar;
        private System.Windows.Forms.DataGridView grdDadosCor;
        private System.Windows.Forms.Label lblCorNome;
        private System.Windows.Forms.TextBox txtNomeCor;
    }
}