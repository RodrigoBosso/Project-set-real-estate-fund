//****************************************************************************************
//**Criado por: Geanluca
//**Data de Criação: 20/04/2021
//**Instruções:
//
//
//****** Atualizações: Criação do acesso ao banco de dados
//*** Data: 26/04/2021
//*** Responsável: Geanluca Sampaio de Sousa

//****** Atualizações: atualização no comando alteraCidadeBase, comando sql escrito de maneira errada
//*** Data: 02/05/2021
//*** Responsável: Guilherme de Andrade Rissato
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5 {
    class dbCidade {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereCidadeBase(classeCidade cidade) {
            string sql = $"insert into cidade  (cidadenome)  values ('{cidade.getCidadeNome()}');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraCidadeBase(classeCidade cidade) {
            //string sql = $"update cidade (cidadenome) values {cidade.getCidadeNome()} where cidadeid = {cidade.getCidadeId()}";
            string sql = $"update cidade set cidadenome = '{cidade.getCidadeNome()}' where cidadeid = {cidade.getCidadeId()}";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiCidadeBase(classeCidade cidade) {
            string sql = $"delete from cidade where cidadeid = {cidade.getCidadeId()} limit 1";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectCidadeBase(classeCidade cidade) {
            string sql = $"select * from cidade where cidadeid = {cidade.getCidadeId()}";
            return connect.retornaSQL(sql);
        }

        public classeCidade RetornaDadosObjeto(classeCidade cidade) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeCidade cidadeTemp = new classeCidade();

            string sql = "select cidadeId, cidadeNome from cidade where cidadeId = " + cidade.getCidadeId() + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            cidadeTemp.setCidadeId(cidade.getCidadeId());
            cidadeTemp.setCidadeNome(ds.Tables[0].Rows[0][1].ToString());

            return cidadeTemp;
        }

        public DataTable selectCidadeBase() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select cidadeId, cidadeNome from cidade;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
