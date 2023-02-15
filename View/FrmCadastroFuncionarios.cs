//****************************************************************************************
//**Criado por: Giovanni Marques, Bruno Bragagnolo, Renan Vaz
//**Data de Criação: 02/05/2021
//**Instruções: Criação e configuração do formCadastroFuncionario".
//
//
//****** Atualizações: Montamos o banco de dados pedido pelo professor, os botoes e a classe como atividade final do semestre
//*** Data:
//*** Responsável:
//*****************************************************************




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
using MySql;


namespace Projeto_LPRC5
{
    public partial class FrmCadastroFuncionarios : Form
    {
        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
        }



        dbCadastroFuncionarios db_CadastroFuncionarios = new dbCadastroFuncionarios();
        ClasseCadastroFuncionarios CadastroFuncionarios = new ClasseCadastroFuncionarios();

        private void formataGrid()
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns[0].HeaderText = "Nome Registro";
            dataGridView1.Columns[1].HeaderText = "Nome Social";
            dataGridView1.Columns[2].HeaderText = "CPF";
            dataGridView1.Columns[3].HeaderText = "RG";
            dataGridView1.Columns[4].HeaderText = "Telefone";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Data de Adimissão";
            dataGridView1.Columns[7].HeaderText = "Estado Civil";
            dataGridView1.Columns[8].HeaderText = "Sexo";

            dataGridView1.Columns[0].Width = 0;
            
        }

        public void atualizaDadosGrid()
        {
            dataGridView1.DataSource = db_CadastroFuncionarios.selectCadastroFuncionariosBase();
        }

        private void atualizaDadosControles()
        {
            CadastroFuncionarios = db_CadastroFuncionarios.RetornaDadosObjeto(CadastroFuncionarios);
        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            barbtnnovofuncionario_click.Enabled = hablitar;
            barbtnEditar.Enabled = hablitar;
            barbtnExcluir.Enabled = hablitar;
            barbtnSalvar.Enabled = !hablitar;
            barbtnCancelar.Enabled = !hablitar;
            barbtnFechar.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar)
        {

            dataGridView1.Enabled = !habilitar;
            nome_registro.Enabled = !habilitar;
            nome_social.Enabled = !habilitar;
            maskedbox_cpf.Enabled = !habilitar;
            maskedbox_rg = !habilitar;
            maskedbox_tel = !habilitar;
            email = !habilitar;
            dateTimePicker2 = !habilitar;
            combobox_sexo = !habilitar;
            combox_estadocivil = !habilitar;



        }


        private void limpaCamposDados()
        {
            CadastroFuncionarios.Id = 0;
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (nome_registro.Text.Length < 2)
            {
                resultado = false;
            }
            else if (nome_social.Text.Length < 2)
            {
                resultado = false;
            }
            else if (email.Text.Length < 2)
            {
                resultado = false;
            }
            else if (maskedbox_cpf.Text.Length < 12)
            {
                resultado = false;
            }
            else if (maskedbox_rg.Text.Length < 10)
            {
                resultado = false;
            }

            return resultado;
        }

        private void insereCadastroFuncionarios()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraCadastroFuncionarios()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiCadastroFuncionarios()
        {
          if (CadastroFuncionarios.Id != 0)
            {
                DialogResult retorno = MessageBox.Show("A informação será excluida", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_CadastroFuncionarios.excluiCadastroFuncionariosBase(CadastroFuncionarios);
                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há nada a ser excluido!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaCadastroFuncionarios()
        {
            if (verificaDadosObrigatorios() == true)
            {

              if (CadastroFuncionarios.Id == 0)
                {
                    db_CadastroFuncionarios.insereCadastroFuncionariosBase(CadastroFuncionarios);
                }
                else
                {
         
                    db_CadastroFuncionarios.alteraCadastroFuncionariosBase(CadastroFuncionarios);
                }
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                atualizaDadosGrid();
            }
            else
            {
                MessageBox.Show("Os dados obrigatórios não foram informados", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaCadastroFuncionarios()
        {
            DialogResult retorno = MessageBox.Show("Deseja realmente cancelar o Cadastro/Atualização dos dados do funcionário?", "AVISO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaCadastroFuncionarios()
        {
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroFuncionarios_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereCadastroFuncionarios();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraCadastroFuncionarios();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiCadastroFuncionarios();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaCadastroFuncionarios();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaCadastroFuncionarios();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaCadastroFuncionarios();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroFuncionarios.Id = Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            atualizaDadosControles();

        }

        private void FrmCadastroFuncionarios_Load_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void barbtnNovo_Click_1(object sender, EventArgs e)
        {

        }
    }
}