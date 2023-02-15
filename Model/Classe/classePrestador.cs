//****************************************************************************************
//**Criado por: Amanda, André e Giovanna 
//**Data de Criação: 20/07/2021
//**Instruções:
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Classe
{
    class classePrestador : classePessoaJuridica
    {
        public int visitaId { get; set; }
        public int pessoaJuridicaId { get; set; }
        public string servicodescricao { get; set; }
    }
}
