using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5
{
    class classePessoaJuridica : classePessoa
    {
        dbPessoaJuridica pessoaJuridica = new dbPessoaJuridica();
        private string pJuridicaCNPJ;
        private string pJuridicaInscEstadual;
        private string pJuridicaInscMunicipal;

        public string getPJuridicaCNPJ()
        {
            return pJuridicaCNPJ;
        }

        public void setPJuridicaCNPJ(string newValue)
        {
            pJuridicaCNPJ = newValue;
        }

        public string getPJuridicaInscEstadual()
        {
            return pJuridicaInscEstadual;
        }

        public void setPJuridicaInscEstadual(string newValue)
        {
            pJuridicaInscEstadual = newValue;
        }

        public string getPJuridicaInscMunicipal()
        {
            return pJuridicaInscMunicipal;
        }

        public void setPJuridicaInscMunicipal(string newValue)
        {
            pJuridicaInscMunicipal = newValue;
        }

        public override void atualizaDados(string operacao)
        {
            base.atualizaDados(operacao);

            switch (operacao)
            {
                case "Ins":
                    pessoaJuridica.inserePessoaJuridicaBase(getPessoaID(), pJuridicaCNPJ, pJuridicaInscEstadual, pJuridicaInscMunicipal);
                    break;
                case "Upt":
                    pessoaJuridica.alteraPessoaJuridicaBase(getPessoaID(), pJuridicaCNPJ, pJuridicaInscEstadual, pJuridicaInscMunicipal);
                    break;
                case "Del":
                    pessoaJuridica.excluiPessoaJuridicaBase(getPessoaID());
                    break;
                default:
                    break;
            }
        }

        public MySqlDataAdapter daRetornaDados()
        {
            return pessoaJuridica.selectPessoaJuridicaBase(getPessoaID());
        }

        public DataTable dtRetornaDados()
        {
            return pessoaJuridica.selectPessoaJuridicaBase();
        }

        public classePessoaJuridica objRetornaDados()
        {
            return pessoaJuridica.RetornaDadosObjeto(getPessoaID());
        }
    }
}
