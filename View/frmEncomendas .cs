//****************************************************************************************
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Roberto Marcheti Neto
//**Data de Criação: 03/05/2021
//**Instruções: Criação do formulário frmEncomendas
//
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: Ajustes das funçoes de procedures
//*** Data:03/05/2021
//*** Responsável: Guilherme de Andrade Rissato

//**Grupo 7: Guilherme A.Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: verificacao da data na procedure de dados obrigatorios
//*** Data:03/05/2021
//*** Responsável: Guilherme de Andrade Rissato

//**Grupo 7: Guilherme A.Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: atualizacao dos campos para insert, update e delete, ja que houve alteracoes no modo como o nome do morador e acessado devido a heranca entre as classes
//*** Data:03/05/2021
//*** Responsável: Guilherme de Andrade Rissato
//****************************************************************************************
using Projeto_LPRC5.Model.Classe;
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
    public partial class frmEncomendas : Form
    {

        dbEncomenda db_Encomenda = new dbEncomenda();
        classeEncomendas encomenda = new classeEncomendas();
        public frmEncomendas()
        {
            InitializeComponent();
            
        }

        private void preencherComboMorador()
        {
            cmbDestinatario.DataSource = db_Encomenda.selectMorador();
            cmbDestinatario.ValueMember = "moradorid";
            cmbDestinatario.DisplayMember = "nome";
        }

        private void preencherComboFuncionario()
        {
            cmbDestinatario.DataSource = db_Encomenda.selectFuncionario();
            cmbDestinatario.ValueMember = "funcionarioid";
            cmbDestinatario.DisplayMember = "nome";
        }

        private void preencherComboHabitacao()
        {
            cmbDestinatario.DataSource = db_Encomenda.selectHabitacao();
            cmbDestinatario.ValueMember = "habitacaoid";
            cmbDestinatario.DisplayMember = "numero";
        }

        private void preencherComboMoradorRecebeu()
        {
            cmbDestinatario.DataSource = db_Encomenda.selectMorador();
            cmbDestinatario.ValueMember = "moradorid";
            cmbDestinatario.DisplayMember = "nome";
        }

        public void atualizaDadosGrid()
        {
            grdDadosEncomenda.DataSource = db_Encomenda.selectEncomendaBase();
        }

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosEncomenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosEncomenda.Columns[0].HeaderText = "Código";
            grdDadosEncomenda.Columns[1].HeaderText = "Nome";
            grdDadosEncomenda.Columns[2].HeaderText = "Habitação";

            grdDadosEncomenda.Columns[0].Width = 0;
            grdDadosEncomenda.Columns[1].Width = 80;
            grdDadosEncomenda.Columns[2].Width = 80;

        }

        private void iniciaCombos()
        {
            preencherComboFuncionario();
            preencherComboHabitacao();
            preencherComboMorador();
            preencherComboMoradorRecebeu();
        }

        private void atualizaDadosControles()
        {
            encomenda = db_Encomenda.RetornaDadosObjeto(encomenda);

            cmbDestinatario.SelectedValue = encomenda.getdestinatario();
            cmbHabitacao.SelectedValue = encomenda.getHabitacao();
            txtDescricao.Text = encomenda.getDescricao();
            cmbFuncionario.SelectedValue = encomenda.getEntreguePara();
            txtEntreguePor.Text = encomenda.getEntreguePor();
            cmbMoradorRecebeu.SelectedValue = encomenda.getRecebidaPor();
            msktxtDataEntrada.Text = Convert.ToString(encomenda.getDataEntrada());
            msktxtDataSaida.Text = Convert.ToString(encomenda.getDataSaida());

        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            barbtnNovo.Enabled = hablitar;
            barbtnEditar.Enabled =hablitar;
            barbtnExcluir.Enabled = hablitar;
            barbtnSalvar.Enabled = !hablitar;
            barbtnCancelar.Enabled = !hablitar;
            barbtnFechar.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar)
        {
            txtBusca.Enabled = !habilitar;
            txtDescricao.Enabled = habilitar;
            cmbDestinatario.Enabled = habilitar;
            cmbFuncionario.Enabled = habilitar;
            txtEntreguePor.Enabled = habilitar;
            cmbHabitacao.Enabled = habilitar;
            cmbMoradorRecebeu.Enabled = habilitar;
            msktxtDataEntrada.Enabled = habilitar;
            msktxtDataSaida.Enabled = habilitar;
            grdDadosEncomenda.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtBusca.Text = "";
            cmbHabitacao.SelectedValue = -1;
            txtDescricao.Text = "";
            cmbDestinatario.SelectedValue = -1;
            cmbHabitacao.SelectedValue = -1;
            txtEntreguePor.Text = "";
            cmbMoradorRecebeu.SelectedValue = -1;
            msktxtDataEntrada.Text = "";
            msktxtDataSaida.Text = "";

            encomenda.setCodigo(-1);
            encomenda.setHabitacao(-1);
            encomenda.setDataEntrada(Convert.ToDateTime(null));
            encomenda.setDataSaida(Convert.ToDateTime(null));
            encomenda.setDescricao("");
            encomenda.setDestinatario(-1);
            encomenda.setEntreguePara(-1);
            encomenda.setEntreguePor("");
            encomenda.setRecebidaPor(-1);
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (cmbDestinatario.SelectedIndex == -1 || txtEntreguePor.Text.ToString() == "" ||
                msktxtDataEntrada.Text.ToString() == "" ||cmbFuncionario.SelectedIndex == -1|| 
                cmbHabitacao.SelectedIndex == -1)
                {
                    resultado = false;
                }

            return resultado;
        }

        private void InsereEncomenda()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void AlteraEncomenda()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void ExcluiEncomenda()
        {
            if (encomenda.getCodigo() != -1)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_Encomenda.excluiEncomendaBase(encomenda);

                    limpaCamposDados();
                    
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setEncomendas() {
            encomenda.setHabitacao(cmbHabitacao.SelectedIndex);
            encomenda.setDataEntrada(Convert.ToDateTime(msktxtDataEntrada.Text));
            if (msktxtDataSaida.Text.ToString() == "  /  /") {
                encomenda.setDataSaida(Convert.ToDateTime(null));
            }
            else
            {
                encomenda.setDataSaida(Convert.ToDateTime(msktxtDataSaida.Text));
            }
            encomenda.setDescricao(txtDescricao.Text.ToString());
            encomenda.setDestinatario(cmbDestinatario.SelectedIndex);
            encomenda.setEntreguePara(cmbFuncionario.SelectedIndex);
            encomenda.setEntreguePor(txtEntreguePor.Text.ToString());
            encomenda.setRecebidaPor(cmbMoradorRecebeu.SelectedIndex);
        }

        private void SalvaEncomenda()
        {
           
            if (verificaDadosObrigatorios() == true)
            {
                setEncomendas();

                if (encomenda.getCodigo() == -1)
                {
                    //Insere os dados
                    db_Encomenda.insereEncomendaBase(encomenda);
                }
                else
                {
                    //Altera os dados
                    db_Encomenda.alteraEncomendaBase(encomenda);
                }
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
            else
            {
                MessageBox.Show("Dados Obrigatórios não informados ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaEncomenda()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Encomenda?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }

        private void frmEncomendas_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void FechaEncomenda()
        {
            this.Close();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            InsereEncomenda();
            iniciaCombos();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            AlteraEncomenda();
            iniciaCombos();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluiEncomenda();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            SalvaEncomenda();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaEncomenda();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            FechaEncomenda();
        }

        private void grdDadosEncomenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            encomenda.setCodigo(Convert.ToInt16(grdDadosEncomenda.Rows[grdDadosEncomenda.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }

        private void cmbDestinatario_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }

        private void cmbFuncionario_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }

        private void cmbMoradorRecebeu_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }

        private void cmbHabitacao_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }
    }
}
