//****************************************************************************************
//**Criado por: Giovanni Marques
//**Data de Criação: 22/04/2021
//**Instruções:
//
//
//****** Atualizações: 
//*** Data: 
//*** Responsável:
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Projeto_LPRC5
{
    class dbMarca
    {
        conexaoMySql connect = new conexaoMySql();
        public void insereMarcaBase(classeMarca marca)
        {
            string sql = $"insert into marcaveiculo (marcaveiculonome)  values ('{marca.getmarcaveiculonome()}');";
            connect.executaSQL(sql);
        }
        public void alteraMarcaBase(classeMarca marca)
        {
            string sql = $"update marcaveiculo set marcaveiculonome = '{marca.getmarcaveiculonome()}' where marcaveiculoid = {marca.getmarcaveiculoid()};";
            connect.executaSQL(sql);
        }
        public void excluiMarcaBase(classeMarca marca)
        {
            string sql = $"delete from marcaveiculo where marcaveiculoid = {marca.getmarcaveiculoid()} limit 1";
            connect.executaSQL(sql);
        }


        public MySqlDataAdapter selectMarcaBase(classeMarca marca)
        {
            string sql = $"select * from marcaveiculo where marcaveiculoid = {marca.getmarcaveiculoid()}";

            return null;
        }

        public DataTable selectMarcaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "select marcaveiculoid, marcaveiculonome from marcaveiculo;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }

        public classeMarca RetornaDadosObjeto(classeMarca marca)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeMarca marcaTemp = new classeMarca();

            string sql = "select marcaveiculonome from marcaveiculo where marcaveiculoid = " + marca.getmarcaveiculoid() + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            marcaTemp.setmarcaveiculoid(marca.getmarcaveiculoid());
            marcaTemp.setmarcaveiculonome(ds.Tables[0].Rows[0][0].ToString());

            return marcaTemp;
        }
    }
}