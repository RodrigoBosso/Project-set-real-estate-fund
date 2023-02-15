//****************************************************************************************
//**Criado por: Geanluca Sampaio de Sousa, Thomas Taino, Aldemir Humberto Soares Neto, Felipe Lopes Silva e Silva
//**Data de Criação: 03/05/2021
//**Instruções: Criação do arquivo que não foi disponibilizado
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Projeto_LPRC5 {
    class dbClassificaPessoa {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereClassificaPessoaBase(classeClassificaPessoa classificaPessoa) {
            string sql = $"insert into classificapessoa (classificapessoadescricao)  values ('{classificaPessoa.getClassificaPessoaDescricao()}');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraClassificaPessoaBase(classeClassificaPessoa classificaPessoa) {
            string sql = $"update classificapessoa set classificapessoadescricao = '{classificaPessoa.getClassificaPessoaDescricao()}' where classificapessoaid = {classificaPessoa.getClassificaPessoaId()}";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiClassificaPessoaBase(classeClassificaPessoa classificaPessoa) {
            string sql = $"delete from classificapessoa where classificapessoaid = {classificaPessoa.getClassificaPessoaId()} limit 1";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectClassificaPessoaBase(classeClassificaPessoa classificaPessoa) {
            string sql = $"select * from classificapessoa where cidadeid = {classificaPessoa.getClassificaPessoaId()}";
            return connect.retornaSQL(sql);
        }

        public classeClassificaPessoa RetornaDadosObjeto(classeClassificaPessoa classificaPessoa) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeClassificaPessoa classificaPessoaTemp = new classeClassificaPessoa();

            string sql = $"select classificapessoaid, classificapessoadescricao from classificapessoa where classificapessoaid =  {classificaPessoa.getClassificaPessoaId()};";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            classificaPessoaTemp.setClassificaPessoaId(classificaPessoa.getClassificaPessoaId());
            classificaPessoaTemp.setClassificaPessoaDescricao(ds.Tables[0].Rows[0][1].ToString());

            return classificaPessoaTemp;
        }

        public DataTable selectClassificaPessoaBase() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select classificapessoaid, classificapessoadescricao from classificapessoa;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
