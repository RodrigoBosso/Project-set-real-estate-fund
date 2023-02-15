//****************************************************************************************
//**Criado por: Giovanni Marques, Bruno Bragagnolo e Renan Vaz
//**Data de Criação: 02/05/2021
//**Instruções: Classe referente ao formulário "formCadastroFuncionario".
//
//
//****** Atualizações: criação do set e get
//*** Data:02/05/2021
//*** Responsável:Giovanni Marques
//*****************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5.Model.Classe
{
    class ClasseCadastroFuncionarios : classePessoaFisica
    {


        public int Id { get; set; }
        public string NomeRegistro { get; set; }
        public string NomeSocial { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        private string NumeroTelefone { get; set; }
        public string Email { get; set; }
        private string DataAdmissao { get; set; }
        private string EstadoCivil { get; set; }
        private char Sexo { get; set; }
 


        public ClasseCadastroFuncionarios()
        {

        }
        public ClasseCadastroFuncionarios(string nomeregistro, string nomesocial, string cpf, string rg, string numerotelefone, string email, string dataadimissao, char estadocivil, string sexo)
        {
            this.NomeRegistro = nomeregistro;
            this.NomeSocial = nomesocial;
            this.CPF = cpf;
            this.RG = rg;
            this.Email = email;
            this.NumeroTelefone = numerotelefone;
            this.DataAdmissao = dataadimissao;
            this.EstadoCivil = estadocivil;
            this.Sexo = sexo;

        }
    }
}