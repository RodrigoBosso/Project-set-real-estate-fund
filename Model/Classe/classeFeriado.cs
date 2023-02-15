//****************************************************************************************
//**Criado por: André Sirikaku Miyashiro
//**Data de Criação: 19/04/2021
//**Instruções: criação dos atributos dia, mês e descrição utilizando prop.
// O prop ja cria os metodos get e set para os atributos criados
//
//
//****** Atualizações: passei a variavel feriadoId para Id e utilizei o prop para criar os 
// metods get e set
//*** Data:20/04
//*** Responsável: André Sirikaku
//
//
//****** Atualizações: Get e Set funcionais alem da criação do construtor e nomes corrigidos de acordo com o banco de dados
//*** Data:03/05/2021
//*** Responsável:Grupo 6
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeFeriado
    {

        public int FeriadoId { get; set; }
        public int FeriadoDia { get; set; }
        public int FeriadoMes { get; set; }
        public string FeriadoNome { get; set; }

        public classeFeriado() { 
        
        
        
        }
        public classeFeriado(int id, int dia, int mes, string nome)
        {
            FeriadoId = id;
            FeriadoDia = dia;
            FeriadoMes = mes;
            FeriadoNome = nome;

        }

    }
}

