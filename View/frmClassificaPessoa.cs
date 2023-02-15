//****************************************************************************************
//**Criado por:
//**Data de Criação:
//**Instruções:
//
//
//****** Atualizações: Edição do acesso ao banco de dados por completo. Informações ainda estavam em Default
//*** Data: 03/05/2021
//*** Responsável: Geanluca Sampaio de Sousa
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPRC5{
    public partial class frmClassificaPessoa : Form{
        public frmClassificaPessoa()
        {
            InitializeComponent();
        }

        dbClassificaPessoa db_ClassificaPessoa = new dbClassificaPessoa();
        classeClassificaPessoa classeClassificaPessoa = new classeClassificaPessoa();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosCid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCid.Columns[0].HeaderText = "Código";
            grdDadosCid.Columns[1].HeaderText = "Desc";

            grdDadosCid.Columns[0].Width = 0;
            grdDadosCid.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid()
        {
            //DataTable tabelaCidade = new DataTable();
            //tabelaCidade = dbCidade.selectCiddBase();
            //grdDadosCid.DataSource = tabelaCidade;

            //pode ser também

            grdDadosCid.DataSource = db_ClassificaPessoa.selectClassificaPessoaBase();
        }

        private void atualizaDadosControles()
        {
            if (classeClassificaPessoa.Equals(null)) {

            } else {
                classeClassificaPessoa = db_ClassificaPessoa.RetornaDadosObjeto(classeClassificaPessoa);
            }
            txtClassificaPessoa.Text = classeClassificaPessoa.getClassificaPessoaDescricao();
        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            barbtnNovo.Enabled = hablitar;
            barbtnEditar.Enabled = hablitar;
            barbtnExcluir.Enabled = hablitar;
            barbtnSalvar.Enabled = !hablitar;
            barbtnCancelar.Enabled = !hablitar;
            barbtnFechar.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar)
        {
            //txtNome.Enabled = habilitar;
            txtClassificaPessoa.Enabled = habilitar;
            grdDadosCid.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            //txtNome.Text = "";
            txtClassificaPessoa.Text = "";
            classeClassificaPessoa.setClassificaPessoaId(0);
            //padrao.setNome("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtClassificaPessoa.Text.Trim().Length < 4)
            {
                resultado = false;
            }


            return resultado;
        }

        private void insereClassificaPessoa()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnNovo.Tag)) == true) {

                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();
            } 
            else {
                MessageBox.Show("Usuário não tem permissão para realizar a Inclusão de Cidades", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void alteraClassificaPessoa()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnEditar.Tag)) == true) {

                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
            }
            else {
                MessageBox.Show("Usuário não tem permissão para realizar a Inclusão de Cidades", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void excluiClassificaPessoa()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnExcluir.Tag)) == true) {
                if (classeClassificaPessoa.getClassificaPessoaId() != 0) {
                    DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (retorno == DialogResult.Yes) {
                        db_ClassificaPessoa.excluiClassificaPessoaBase(classeClassificaPessoa);

                        limpaCamposDados();
                        atualizaDadosGrid();
                    }
                } else {
                    MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else {
                MessageBox.Show("Usuário não tem permissão para realizar a Exclusão de Cidades", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salvaClassificaPessoa()
        {
            if (verificaDadosObrigatorios() == true)
            {
                //Atualizando os dados do objeto estado.
                //padrao.setNome(txtNome.Text);

                if (classeClassificaPessoa.getClassificaPessoaId() == 0)
                {
                    //Insere os dados
                    classeClassificaPessoa.setClassificaPessoaDescricao(txtClassificaPessoa.Text);
                    db_ClassificaPessoa.insereClassificaPessoaBase(classeClassificaPessoa);
                }
                else
                {
                    //Altera os dados
                    classeClassificaPessoa.setClassificaPessoaDescricao(txtClassificaPessoa.Text);
                    db_ClassificaPessoa.alteraClassificaPessoaBase(classeClassificaPessoa);
                }
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                atualizaDadosGrid();
            }
            else
            {
                MessageBox.Show("Dados Obrigatórios não informados ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaClassificaPessoa()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Classifição Pessoa?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaClassificaPessoa()
        {
            this.Close();
        }

        private void frmCid_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereClassificaPessoa();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraClassificaPessoa();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiClassificaPessoa();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaClassificaPessoa();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaClassificaPessoa();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaClassificaPessoa();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classeClassificaPessoa.setClassificaPessoaId (Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }
    }
}
