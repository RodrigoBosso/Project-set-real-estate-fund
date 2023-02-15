//****************************************************************************************
//**Criado por: André Costa, Amanda Ferrari, Giovanna Valim
//**Data de Criação: 19/04/2021
//**Instruções: --
//
//
//****** Atualizações: Removido usos desnecessários do MySqlCommand, outras pequenas correções
//*** Data: 02/05/2021
//*** Responsável: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho Costa
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projeto_LPRC5
{
    class dbTipoUsuario
    {
        private conexaoMySql connectUsu = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereTipoUsuario(classeTipoUsuario tUsuario)
        {
            string sql = "insert into tipousuario (tipousuariodescricao) values ('" + tUsuario.getDescricao() + "');";
            connectUsu.executaSQL(sql);
        }

        public void alteraTipoUsuario(classeTipoUsuario tUsuario)
        {
            string sql = "update tipousuario set tipousuariodescricao = ('" + tUsuario.getDescricao() + "') where tipousuarioid= " + tUsuario.getId() + ";";
            connectUsu.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiTipoUsuario(classeTipoUsuario tUsuario)
        {
            string sql = "DELETE FROM tipousuario WHERE tipousuarioid = " + tUsuario.getId() + ";";
			connectUsu.executaSQL(sql);
		}

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectTipoUsuario(classeTipoUsuario tUsuario)
        {
            string sql = "SELECT tipousuarioid, tipousuariodescricao FROM tipousuario;";
            return connectUsu.retornaSQL(sql);
        }

        public classeTipoUsuario selectTipoUsuarioDBase(classeTipoUsuario tUsuario)
        {
            classeTipoUsuario tempUsuario = new classeTipoUsuario();
            DataSet ds = new DataSet();       

            string sql = "SELECT tipousuariodescricao FROM tipousuario where tipousuarioid =" + tUsuario.getId() +" ;";

            MySqlDataAdapter adapter = connectUsu.retornaSQL(sql);
            adapter.Fill(ds);

            tempUsuario.setId(tUsuario.getId());
            tempUsuario.setDescricao(ds.Tables[0].Rows[0][0].ToString());
            
            return tempUsuario;
        }

        public MySqlDataAdapter selectTipoUsuarioDBase()
        {
            string sql = "SELECT tipousuarioid, tipousuariodescricao FROM tipousuario;";
            return connectUsu.retornaSQL(sql);
        }

        public DataTable selectTipoUsuarioDBaseGrid()
        {
            MySqlDataAdapter adapter;
            DataTable tabela = new DataTable();
            adapter = selectTipoUsuarioDBase();
            adapter.Fill(tabela);
            return tabela;
        }

    }
}

