//****************************************************************************************
//**Criado por: Thomas Taino, Aldemir Neto, Felipe Lopes, Geanluca Sampaio de Sousa
//**Data de Criação:09/05
//**Instruções: Criação da classe com uso de geração automático dos getter's e setter's.
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

namespace Projeto_LPRC5{
    public class classeCondominioEmpresa{

        //Atributos da Classe
        public int ceId { get; set; }
        public string ceNome { get; set; }
        public string ceCEP { get; set; }
        public string ceTipoHabitacao { get; set; }
        public string ceContato { get; set; }
        public string ceTipoCondominio { get; set; }
        public string ceSindico { get; set; }
        public string ceCNPJ { get; set; }
        public string ceInscMunicipal { get; set; }
        public string ceInscEstadual { get; set; }



        //Método Construtor
        public classeCondominioEmpresa() {

        }

        public classeCondominioEmpresa(int Id, string nome, string CEP, string tipoHab, string contato, string tipoCond, string sindico, string CNPJ, string inscMunicipal, string inscEstadual) {
            this.ceId = Id;
            this.ceNome = nome;
            this.ceCEP = CEP;
            this.ceTipoHabitacao = tipoHab;
            this.ceContato = contato;
            this.ceTipoCondominio = tipoCond;
            this.ceSindico = sindico;
            this.ceInscMunicipal = inscMunicipal;
            this.ceCNPJ = CNPJ;
            this.ceInscEstadual = inscEstadual;
        }

        
    }
}
