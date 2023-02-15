//****************************************************************************************
//**Criado por:
//**Data de Criação:
//**Instruções:
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
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5
{
    class dbDefault
    {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereDefaultBase(classeDefault padrao)
        {
            string sql = "";
            //connect.executaSQL("");
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraDefaultBase(classeDefault padrao)
        {
            string sql = "";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiDefaultBase(classeDefault padrao)
        {
            string sql = "";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectDefaultBase(classeDefault padrao)
        {
            string sql = "";
            //return connect.retornaSQL(sql);
            return null;
        }

        public classeDefault RetornaDadosObjeto(classeDefault padrao)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeDefault defaultTemp = new classeDefault();

            //string sql = "select cidId, cidNome from cidade where cidId = " + padrao.getId() + ";";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            defaultTemp.setId(padrao.getId());
            

            return defaultTemp;
        }

        public DataTable selectDefaultBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            //string sql = "select cidId, cidNome from cidade;";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
