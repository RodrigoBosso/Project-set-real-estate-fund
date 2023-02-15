//****************************************************************************************
//**Criado por: André Luiz Costa
//**Data de Criação: 19/04/2021
//**Instruções: Criação da classe 'Tipo de Usuário'
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
    class classeTipoUsuario
    {
        //Atributos da Classe
        private int tipoUsuarioId;
        private string tipoUsuarioDescricao;

        //Método Construtor
        public classeTipoUsuario()
        {

        }

        //Métodos Acessores
        public void setId(int id)
        {
            tipoUsuarioId = id;
        }
        public int getId()
        {
            return tipoUsuarioId;
        }

        public void setDescricao(string desc)
        {
            tipoUsuarioDescricao = desc;
        }

        public string getDescricao()
        {
            return tipoUsuarioDescricao;
        }
    }
}
