//****************************************************************************************
//**Criado por:André Sirikaku Miyashiro
//**Data de Criação: 26/04/2021
//**Instruções:
//
//
//****** Atualizações:Herança com PessoaJuridica
//*** Data:21/07
//*** Responsável:André Sirikaku, Mateus Siste, Rodrigo Bosso
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class ClasseEmpresaPrestadoraServico : classePessoaJuridica
    {
        //Atributos da Classe
        public int EmpresaId { get; set; }
        public string EmpresaNome { get; set; }
        public string EmpresaTipoServico { get; set; }
        public string EmpresaEndereco { get; set; }
        public string EmpresaTelefone { get; set; }
        public string EmpresaDescricao { get; set; }

        public ClasseEmpresaPrestadoraServico()
        {

        }
        public ClasseEmpresaPrestadoraServico(int id, string Nome, string Numero, string Servico, string Local, string Desc)
        {
            EmpresaId = id;
            EmpresaNome = Nome;
            EmpresaTelefone = Numero;
            EmpresaTipoServico = Servico;
            EmpresaEndereco = Local;
            EmpresaDescricao = Desc;
        }

    } 
}
