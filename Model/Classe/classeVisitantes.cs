//****************************************************************************************
//**Criado por: Amanda Iaquinta, André Costa e Giovanna Frederico 
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
    class classeVisitantes : classePessoaFisica
    {
        public int visitaId { get; set; }
        public DateTime dataVisita { get; set; }
        public int pessoaFidicaId { get; set; }
        public int habitacaoId { get; set; }
        public int tipoVisitanteId { get; set; }

    }
}
