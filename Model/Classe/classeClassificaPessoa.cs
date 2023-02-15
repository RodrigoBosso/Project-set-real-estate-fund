//****************************************************************************************
//**Criado por: Antonio Jose Naranjo, Leticia Lopes Abelha, Rafael de Angelis Fogaça e Daniel Galdencio
//**Data de Criação: 19/04/2021
//**Instruções: criação dos atributos id e descrição utilizando propriedades
//
//
//****** Atualizações: Mudar tipo de classificapessoadescricao de int para String / Edição nos gets e sets
//*** Data: 03/05/2021
//*** Responsável: Geanluca Sampaio de Sousa
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeClassificaPessoa
    {
        //Atributos da Classe
        private int classificapessoaid;
        private String classificapessoadescricao;


        //Método Construtor
        public classeClassificaPessoa()
        {

        }

        //Métodos Acessores
        public void setClassificaPessoaId(int id)
        {
            classificapessoaid = id;
        }
        public int getClassificaPessoaId()
        {
            return classificapessoaid;
        }
        public void setClassificaPessoaDescricao(String desc) {
            classificapessoadescricao = desc;
        }
        public String getClassificaPessoaDescricao() {
            return classificapessoadescricao;
        }
    } 
}
