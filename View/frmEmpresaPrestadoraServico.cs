//****************************************************************************************
//**Criado por: Mateus Siste
//**Data de Criação:
//**Instruções:
//
//
//****** Atualizações:Adição dos campos CNPJ, InscMunicipio e InscEstadual e conexão com dbPessoaJuridica
//*** Data:21/07
//*** Responsável:André Sirikaku, Mateus Siste, Rodrigo Bosso
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_LPRC5.Model.Conexão;
using System.Windows.Forms;

namespace Projeto_LPRC5
{
    public partial class frmEmpresaPrestadoraServico : Form
    {
        public frmEmpresaPrestadoraServico()
        {
            InitializeComponent();
        }

		private ClasseEmpresaPrestadoraServico empresa = new ClasseEmpresaPrestadoraServico();
		private bdEmpresaPrestadoraServico db = new bdEmpresaPrestadoraServico();
		private dbPessoaJuridica pessoaJuridica = new dbPessoaJuridica();

		public void AtualizaDadosGrid()
		{
			grdDadosEmpresaPrestadoraServico.DataSource = db.selectEmpresaPrestadoraServicoDBaseGrid();
		}

		private void HabilitaBotoesMenu(bool hablitar)
		{
			barbtnNovo.Enabled = hablitar;
			barbtnEditar.Enabled = hablitar;
			barbtnExcluir.Enabled = hablitar;
			barbtnSalvar.Enabled = !hablitar;
			barbtnCancelar.Enabled = !hablitar;
			barbtnFechar.Enabled = hablitar;
		}

		private void HabilitaCamposDados(bool habilitar)
		{
			Txt_Cnpj.Enabled = habilitar;
			Txt_Descricao.Enabled = habilitar;
			Txt_Empresa.Enabled = habilitar;
			Txt_Endereco.Enabled = habilitar;
			Txt_InscEstadual.Enabled = habilitar;
			Txt_InscMunicipal.Enabled = habilitar;
			Txt_Servico.Enabled = habilitar;
			Txt_Telefone.Enabled = habilitar;

			grdDadosEmpresaPrestadoraServico.Enabled = !habilitar;
		}

		private void LimpaCamposDados()
		{
			Txt_Cnpj.Text = "";
			Txt_Descricao.Text = "";
			Txt_Empresa.Text = "";
			Txt_Endereco.Text = "";
			Txt_InscEstadual.Text = "";
			Txt_InscMunicipal.Text = "";
			Txt_Servico.Text = "";
			Txt_Telefone.Text = "";
			empresa = new ClasseEmpresaPrestadoraServico();
		}

		private bool VerificaDadosObrigatorios()
		{
			if (Txt_Cnpj.Text == "" || Txt_Empresa.Text == "" || Txt_InscEstadual.Text == "" || Txt_InscMunicipal.Text == "" || Txt_Servico.Text == "")
			{
				return false;
			}

			return true;
		}

		private void frmCid_Load(object sender, EventArgs e)
		{
			HabilitaBotoesMenu(true);
			HabilitaCamposDados(false);
			AtualizaDadosGrid();
		}

		private void barbtnNovo_Click(object sender, EventArgs e)
		{
			HabilitaBotoesMenu(false);
			HabilitaCamposDados(true);
			LimpaCamposDados();
		}

		private void barbtnEditar_Click(object sender, EventArgs e)
		{
			HabilitaBotoesMenu(false);
			HabilitaCamposDados(true);
		}

		private void barbtnExcluir_Click(object sender, EventArgs e)
		{
			if (empresa.EmpresaId != 0)
			{
				DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (retorno == DialogResult.Yes)
				{
					db.excluiEmpresaPrestadoraServico(empresa);

					LimpaCamposDados();
					AtualizaDadosGrid();
				}
			}
			else
			{
				MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void barbtnSalvar_Click(object sender, EventArgs e)
		{
			if (VerificaDadosObrigatorios())
			{
				int id = empresa.EmpresaId;
				empresa = new ClasseEmpresaPrestadoraServico
				{
					EmpresaId = id,
					EmpresaDescricao =  Convert.ToString(Txt_Descricao.Text),
					EmpresaNome = Convert.ToString(Txt_Empresa.Text),
					EmpresaEndereco = Convert.ToString(Txt_Endereco.Text),
					EmpresaTelefone = Convert.ToString(Txt_Telefone.Text),
					EmpresaTipoServico = Convert.ToString(Txt_Servico.Text)
				};
				
				empresa.setPJuridicaCNPJ(Convert.ToString(Txt_Cnpj.Text));
				empresa.setPJuridicaInscEstadual(Convert.ToString(Txt_InscEstadual.Text));
				empresa.setPJuridicaInscMunicipal(Convert.ToString(Txt_InscMunicipal.Text));

				if (id == 0)
				{
					db.insereEmpresaPrestadoraServico(empresa);
					pessoaJuridica.inserePessoaJuridicaBase(empresa.EmpresaId,empresa.getPJuridicaCNPJ(),empresa.getPJuridicaInscEstadual(),empresa.getPJuridicaInscMunicipal());
				}
				else
				{
					db.alteraEmpresaPrestadoraServico(empresa);
				}


				HabilitaBotoesMenu(true);
				HabilitaCamposDados(false);
				LimpaCamposDados();
				AtualizaDadosGrid();
			}
			else
			{
				MessageBox.Show("Dados Obrigatórios não informados ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void barbtnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Deseja cancelar o Cadastro/Atualização de estado?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (dialog == DialogResult.Yes)
			{
				HabilitaBotoesMenu(true);
				HabilitaCamposDados(false);
				LimpaCamposDados();
			}
		}

		private void barbtnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = Convert.ToInt32(grdDadosEmpresaPrestadoraServico.CurrentRow.Cells[0].Value);
			empresa = db.selectEmpresaPrestadoraServicoDBase(new ClasseEmpresaPrestadoraServico { EmpresaId = id });

			Txt_Cnpj.Text = empresa.getPJuridicaCNPJ();
			Txt_Descricao.Text = empresa.EmpresaDescricao;
			Txt_Empresa.Text = empresa.EmpresaNome;
			Txt_Endereco.Text = empresa.EmpresaEndereco;
			Txt_InscEstadual.Text = empresa.getPJuridicaInscEstadual();
			Txt_InscMunicipal.Text = empresa.getPJuridicaInscMunicipal();
			Txt_Servico.Text = empresa.EmpresaTipoServico;
			Txt_Telefone.Text = empresa.EmpresaTelefone;
		}

    }
}