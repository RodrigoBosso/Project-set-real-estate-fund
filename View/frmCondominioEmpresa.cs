//****************************************************************************************
//**Criado por: Thomas Taino, Aldemir Neto, Felipe Lopes, Geanluca Sampaio de Sousa
//**Data de Criação: 09/05
//**Instruções: Criação do formulário (faltou implementar a imagem dos botões)
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************
using Projeto_LPRC5.Model.Conexão;
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
    public partial class frmCondominioEmpresa : Form
    {
        public frmCondominioEmpresa()
        {
            InitializeComponent();
        }

        dbCondominioEmpresa dbCondominioEmpresa = new dbCondominioEmpresa();
        classeCondominioEmpresa condominioEmpresa = new classeCondominioEmpresa();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosCid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCid.Columns[0].HeaderText = "CódigoCondEmp";
            grdDadosCid.Columns[1].HeaderText = "Nome";
            grdDadosCid.Columns[2].HeaderText = "ID_PJ";
            grdDadosCid.Columns[3].HeaderText = "CEP";
            grdDadosCid.Columns[4].HeaderText = "Síndico";
            grdDadosCid.Columns[5].HeaderText = "Tipo de Habitação";
            grdDadosCid.Columns[6].HeaderText = "Tipo de Condominio";
            grdDadosCid.Columns[7].HeaderText = "Contato";
            grdDadosCid.Columns[8].HeaderText = "ID_PJ2";
            grdDadosCid.Columns[9].HeaderText = "Insc. Estadual";
            grdDadosCid.Columns[10].HeaderText = "Insc. Municipal";
            grdDadosCid.Columns[11].HeaderText = "CNPJ";

            grdDadosCid.Columns[0].Width = 0;
            grdDadosCid.Columns[1].Width = 120;
            grdDadosCid.Columns[2].Width = 0;
            grdDadosCid.Columns[3].Width = 30;
            grdDadosCid.Columns[4].Width = 80;
            grdDadosCid.Columns[5].Width = 80;
            grdDadosCid.Columns[6].Width = 80;
            grdDadosCid.Columns[7].Width = 80;
            grdDadosCid.Columns[8].Width = 0;
            grdDadosCid.Columns[9].Width = 100;
            grdDadosCid.Columns[10].Width = 100;
            grdDadosCid.Columns[11].Width = 80;


        }

        public void atualizaDadosGrid()
        {
            //DataTable tabelaCidade = new DataTable();
            //tabelaCidade = dbCidade.selectCiddBase();
            //grdDadosCid.DataSource = tabelaCidade;

            //pode ser também

            grdDadosCid.DataSource = dbCondominioEmpresa.selectCondominioEmpresaBase(condominioEmpresa);
        }

        private void atualizaDadosControles()
        {
            condominioEmpresa = dbCondominioEmpresa.RetornaDadosObjeto(condominioEmpresa);

            txtNomeCE.Text = condominioEmpresa.ceNome;
            txtCEP.Text = condominioEmpresa.ceCEP;
            TxtTipoHabitacao.Text = condominioEmpresa.ceTipoHabitacao;
            TxtTipoCondominio.Text = condominioEmpresa.ceTipoCondominio;
            txtCEP.Text = condominioEmpresa.ceCEP;
            TxtContato.Text = condominioEmpresa.ceContato;
            TxtCNPJ.Text = Convert.ToString(condominioEmpresa.ceCNPJ);
            TxtSindico.Text = condominioEmpresa.ceSindico;

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
            txtBusca.Enabled = !habilitar;
            txtNomeCE.Enabled = habilitar;
            txtCEP.Enabled = habilitar;
            TxtTipoHabitacao.Enabled = habilitar;
            TxtTipoCondominio.Enabled = habilitar;
            TxtContato.Enabled = habilitar;
            TxtCNPJ.Enabled = habilitar;
            TxtSindico.Enabled = habilitar;
            grdDadosCid.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtNomeCE.Text = "";
            txtCEP.Text = "";
            TxtTipoHabitacao.Text = "";
            TxtTipoCondominio.Text = "";
            TxtContato.Text = "";
            TxtCNPJ.Text = "";
            TxtSindico.Text = "";

            condominioEmpresa.ceId = -1;
            //padrao.setNome("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtNomeCE.Text == string.Empty || txtCEP.Text == string.Empty || TxtTipoHabitacao.Text == string.Empty || TxtTipoCondominio.Text == string.Empty || TxtCNPJ.Text == string.Empty || TxtContato.Text == string.Empty)
            {
                resultado = false;
            }


            return resultado;
        }

        private void insereCondominioEmpresa()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraCondominioEmpresa()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiCondominioEmpresa()
        {
            if (condominioEmpresa.ceId != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    dbCondominioEmpresa.excluiCondominioEmpresaBase(condominioEmpresa);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaCondominioEmpresa()
        {
            if (verificaDadosObrigatorios() == true)
            {
                //Atualizando os dados do objeto estado.
                condominioEmpresa.ceNome = txtNomeCE.Text;
                condominioEmpresa.ceCEP = txtCEP.Text;
                condominioEmpresa.ceTipoHabitacao = TxtTipoHabitacao.Text;
                condominioEmpresa.ceTipoCondominio = TxtTipoCondominio.Text;
                condominioEmpresa.ceCNPJ = TxtCNPJ.Text;
                condominioEmpresa.ceContato = txtCEP.Text;
                condominioEmpresa.ceSindico = TxtSindico.Text;

                if (condominioEmpresa.ceId == -1)
                {
                    //Insere os dados
                    dbCondominioEmpresa.insereCondominioEmpresaBase(condominioEmpresa);
                }
                else
                {
                    //Altera os dados
                    dbCondominioEmpresa.alteraCondominioEmpresaBase(condominioEmpresa);
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

        private void cancelaCondominioEmpresa()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Default?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaCondominioEmpresa()
        {
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        
        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereCondominioEmpresa();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraCondominioEmpresa();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiCondominioEmpresa();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaCondominioEmpresa();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaCondominioEmpresa();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaCondominioEmpresa();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmCondominioEmpresa_Load(object sender, EventArgs e) {
            dbCondominioEmpresa.selectCondominioEmpresaBase();
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void grdDadosCid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            condominioEmpresa.ceId = (Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }
    }
}
