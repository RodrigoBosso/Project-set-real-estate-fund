//****************************************************************************************
//**Criado por: Guilherme, Alexandro, Caique
//**Data de Criação: 20/04/2021
//**Instruções: Classe para auxiliar form Cor.
//
//
//****** Atualizações:
//*** Data:20/04/2021
//*** Responsável:Caique Bruno

//****** Atualizações: Inserção dos comandos para realizar a query, inserção de novas funções para selecionar informações e exibir no grid e organização geral do código.
//*** Data: 01/05/2021
//*** Responsável: Amanda Ferrari, André Costa, Giovanna Valim
//****************************************************************************************
//****** Atualizações: Atualizado para novo modelo do banco
//*** Data: 21/07/2021
//*** Responsável: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho de Costa
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
    class DbCor
    {
        private Int32 retorno;
        conexaoMySql connect = new conexaoMySql();

        public void InsereCorBase(ClasseCor tinta )
        {
            string sql = "insert into cor  (cornome)  values ('" + tinta.Nome + "');";
            retorno = connect.executaSQL(sql.ToString());
        }

    
        public void AlteraCorBase(ClasseCor tinta)
        {
            string sql = "update cor set cornome = ('" + tinta.Nome + "') where id_cor = " + tinta.ID + ";";
            retorno = connect.executaSQL(sql.ToString());
        }


        public void ExcluiCorBase(ClasseCor tinta)
        {
            string sql = "delete from cor where id_cor = " + tinta.ID + ";";
            retorno = connect.executaSQL(sql.ToString());
        }

        
        public MySqlDataAdapter SelectCorBase(ClasseCor tinta)
        {
            string sql = "select * from cor where id_cor = " + tinta.ID + ";";
            retorno = connect.executaSQL(sql.ToString());
            return connect.retornaSQL(sql.ToString());
        }

        public ClasseCor SelectCorDBase(ClasseCor tinta)
        {
            ClasseCor CorTemp = new ClasseCor();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "SELECT cornome FROM cor where id_cor =" + tinta.ID + " ;";

            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            CorTemp.ID = tinta.ID;
            CorTemp.Nome = ds.Tables[0].Rows[0][0].ToString();

            return CorTemp;
        }

        public MySqlDataAdapter SelectCorDBase()
        {
           string sql = "SELECT id_cor, cornome FROM cor;";
           return connect.retornaSQL(sql.ToString());
        }

        public DataTable SelectCorDBaseGrid()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter = SelectCorDBase();
            adapter.Fill(tabela);
            return tabela;
        }
    }
}
