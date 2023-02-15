using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5
{
    class classePessoa
    {
        dbPessoa pessoa = new dbPessoa();
        private Int16 pessoaID;
        private string pessoaNomeRegistro; //Razão Social
        private string pessoaNomeSocial;   //Nome Fantasia
        private string pessoaFoto; 
        private string pessoaEmail;

        public Int16 getPessoaID()
        {
            return pessoaID;
        }

        public void setPessoaID(Int16 newValue)
        {
            pessoaID = newValue;
        }

        public string getPessoaNomeRegistro()
        {
            return pessoaNomeRegistro;
        }

        public void setPessoaNomeRegistro(string newValue)
        {
            pessoaNomeRegistro = newValue;
        }

        public string getPessoaNomeSocial()
        {
            return pessoaNomeSocial;
        }

        public void setPessoaNomeSocial(string newValue)
        {
            pessoaNomeSocial = newValue;
        }

        public string getPessoaFoto()
        {
            return pessoaFoto;
        }

        public void setPessoaFoto(string newValue)
        {
            pessoaFoto = newValue;
        }

        public string getPessoaEmail()
        {
            return pessoaEmail;
        }

        public void setPessoaEmail(string newValue)
        {
            pessoaEmail = newValue;
        }

        public virtual void atualizaDados(string operacao)
        {
            switch (operacao)
            {
                case "Ins":
                    pessoa.inserePessoaBase(pessoaNomeRegistro, pessoaNomeSocial, pessoaEmail, pessoaFoto);
                    break;
                case "Upt":
                    pessoa.alteraPessoaBase(pessoaID, pessoaNomeRegistro, pessoaNomeSocial, pessoaEmail, pessoaFoto);
                    break;
                case "Del":
                    pessoa.excluiPessoaBase(pessoaID);
                    break;
                default:
                    break;
            }
        }

        public MySqlDataAdapter daRetornaDados()
        {
            return pessoa.selectPessoaBase(pessoaID);
        }

        public DataTable dtRetornaDados()
        {
            return pessoa.selectPessoaBase();
        }

        public classePessoa objRetornaDados()
        {
            return pessoa.RetornaDadosObjeto(pessoaID);
        }
    }
}
