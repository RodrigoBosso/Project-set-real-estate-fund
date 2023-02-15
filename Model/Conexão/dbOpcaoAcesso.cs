//****************************************************************************************
//**Criado por: Grupo 6
//**Data de Criação: 24/05/2021
//**Instruções:Criação CRUD.
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
    class dbOpcaoAcesso
    {

        conexaoMySql connect = new conexaoMySql();

        public void insereOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"insert into opcaoacesso (opcaoacessotag, opcaoacessodescricao)  values ({OpcaoAcesso.CodigoTag},'{OpcaoAcesso.Descricao}');";
            connect.executaSQL(sql);
        }

        public void alteraOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"update opcaoacesso set opcaoacessotag = {OpcaoAcesso.CodigoTag}, opcaoacessodescricao = '{OpcaoAcesso.Descricao}'  where opcaoacessoid = {OpcaoAcesso.Codigo};";
            connect.executaSQL(sql);
        }

        public void excluiOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"delete from opcaoacesso where opcaoacessoid = {OpcaoAcesso.Codigo};";
            connect.executaSQL(sql);
        }

        public MySqlDataAdapter selectOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"select * from opcaoacesso where opcaoacessoid = {OpcaoAcesso.Codigo};";
            return connect.retornaSQL(sql);
        }

        public classeOpcaoAcesso RetornaDadosObjeto(classeOpcaoAcesso OpcaoAcesso)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeOpcaoAcesso OpcaoAcessoTemp = new classeOpcaoAcesso();

            string sql = "select opcaoacessoid, opcaoacessotag, opcaoacessodescricao from opcaoacesso where opcaoacessoid = " + OpcaoAcesso.Codigo + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            OpcaoAcessoTemp.Codigo = OpcaoAcesso.Codigo;
            OpcaoAcessoTemp.CodigoTag = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
            OpcaoAcessoTemp.Descricao = (ds.Tables[0].Rows[0][2].ToString());

            return OpcaoAcessoTemp;
        }

        public DataTable selectOpcaoAcessoBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select * from opcaoacesso;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
