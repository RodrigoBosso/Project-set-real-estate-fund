//****************************************************************************************
//**Criado por:
//**Data de Criação:
//**Instruções:
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
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

namespace Projeto_LPRC5
{
    public partial class frmEmpresa : Form
    {
        classePessoaJuridica pJuridica = new classePessoaJuridica();

        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosEmpresa.Columns[0].HeaderText = "Código";
            grdDadosEmpresa.Columns[1].HeaderText = "Nome";

            grdDadosEmpresa.Columns[0].Width = 0;
            grdDadosEmpresa.Columns[1].Width = 120;
        }

        public void atualizaDadosGrid()
        {
            //DataTable tabelaCidade = new DataTable();
            //tabelaCidade = dbCidade.selectCiddBase();
            //grdDadosCid.DataSource = tabelaCidade;

            //pode ser também
            grdDadosEmpresa.DataSource = pJuridica.dtRetornaDados();
        }

        private void atualizaDadosControles()
        {
            pJuridica = pJuridica.objRetornaDados();

            txtNomeRegistro.Text = pJuridica.getPessoaNomeRegistro();
            txtNomeSocial.Text = pJuridica.getPessoaNomeSocial();
            txtEmail.Text = pJuridica.getPessoaEmail();
            txtInscEstadual.Text = pJuridica.getPJuridicaInscEstadual();
            txtInscMunicipal.Text = pJuridica.getPJuridicaInscMunicipal();
            txtCNPJ.Text = pJuridica.getPJuridicaCNPJ();
            //Incluir a Foto

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
            txtNomeRegistro.Enabled = habilitar;
            txtNomeSocial.Enabled = habilitar;
            txtEmail.Enabled = habilitar;
            txtInscEstadual.Enabled = habilitar;
            txtInscMunicipal.Enabled = habilitar;
            txtCNPJ.Enabled = habilitar;
            grdDadosEmpresa.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtNomeRegistro.Text = "";
            txtNomeSocial.Text = "";
            txtEmail.Text = "";
            txtInscEstadual.Text = "";
            txtInscMunicipal.Text = "";
            txtCNPJ.Text = "";
            pJuridica.setPessoaID(0);
            pJuridica.setPessoaNomeRegistro("");
            pJuridica.setPessoaNomeSocial("");
            pJuridica.setPessoaEmail("");
            pJuridica.setPJuridicaInscEstadual("");
            pJuridica.setPJuridicaInscMunicipal("");
            pJuridica.setPJuridicaCNPJ("");
            pJuridica.setPessoaFoto("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            //if (txtNome.Text.Trim().Length < 4)
            //{
            //    resultado = false;
            //}


            return resultado;
        }

        private void insereDefault()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraDefault()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiDefault()
        {
            if (pJuridica.getPessoaID() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    pJuridica.atualizaDados("Del");
                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaDefault()
        {
            if (verificaDadosObrigatorios() == true)
            {
                //Atualizando os dados do objeto estado.
                pJuridica.setPessoaNomeRegistro(txtNomeRegistro.Text);
                pJuridica.setPessoaNomeSocial(txtNomeSocial.Text);
                pJuridica.setPessoaEmail(txtEmail.Text);
                pJuridica.setPJuridicaInscEstadual(txtInscEstadual.Text);
                pJuridica.setPJuridicaInscMunicipal(txtInscMunicipal.Text);
                pJuridica.setPJuridicaCNPJ(txtCNPJ.Text);
                //tratar a Foto
                pJuridica.setPessoaFoto("");

                if (pJuridica.getPessoaID() == 0)
                {
                    //Insere os dados
                    pJuridica.atualizaDados("Ins");
                }
                else
                {
                    //Altera os dados
                    pJuridica.atualizaDados("Upt");
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

        private void cancelaDefault()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Default?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaDefault()
        {
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

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
            insereDefault();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraDefault();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiDefault();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaDefault();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaDefault();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaDefault();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pJuridica.setPessoaID(Convert.ToInt16(grdDadosEmpresa.Rows[grdDadosEmpresa.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }

        private void grdDadosCid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
