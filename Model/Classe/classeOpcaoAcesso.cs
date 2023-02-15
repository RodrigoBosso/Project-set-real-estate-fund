//****************************************************************************************
//**Criado por: André Sirikaku, Mateus Siste, Rodrigo Bosso
//**Data de Criação: 24/05/2021
//**Instruções: 
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeOpcaoAcesso
    {
        //Atributos da Classe
        public int Codigo { get; set; }
        public int CodigoTag { get; set; }
        public string Descricao { get; set; }

        //Método Construtor
        public void ClasseOpcaoAcesso()
        {

        }

        public void ClasseOpcaoAcesso(int codigo, int tag, string descricao)
        {
            this.Codigo = codigo;
            this.CodigoTag = tag;
            this.Descricao = descricao;
        }
    } 
}
