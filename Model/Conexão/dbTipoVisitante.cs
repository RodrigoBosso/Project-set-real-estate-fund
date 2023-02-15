//****************************************************************************************
//**Criado por: Amanda Iaquinta, André Costa e Giovanna Frederico 
//**Data de Criação: 20/07/2021
//**Instruções:
//****************************************************************************************


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class dbTipoVisitante
    {
        private Int32 retorno;
        conexaoMySql connect = new conexaoMySql();

        public MySqlDataReader SelectCmbBox()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=dbcondominio;pwd=");
            conn.Open();
            MySqlCommand sc = new MySqlCommand("SELECT tipo_visitante_id, visitante_descricao FROM tipo_visitante;", conn);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();

            return reader;
        }

        public void InsereTipoVisitanteBase(classeTipoVisitante tipoVisitante)
        {
            string sql = "INSERT INTO tipo_visitante(visitante_descricao) VALUES('" + tipoVisitante.visitanteDescricao + "')";
            retorno = connect.executaSQL(sql);
        }

        public void AlteraTipoVisitanteBase(classeTipoVisitante tipoVisitante)
        {
            string sql = "UPDATE tipo_visitante SET visitante_descricao = '" + tipoVisitante.visitanteDescricao + "' WHERE tipo_visitante_id = " + tipoVisitante.tipoVisitanteId + ";";
            retorno = connect.executaSQL(sql);
        }

        public void ExcluiTipoVisitanteBase(classeTipoVisitante tipoVisitante)
        {
            string sql = "DELETE FROM tipo_visitante WHERE tipo_visitante_id = " + tipoVisitante.tipoVisitanteId + ";";
            retorno = connect.executaSQL(sql);
        }

        public MySqlDataAdapter SelectTipoVisitanteBase(classeTipoVisitante tipoVisitante)
        {
            string sql = "SELECT * FROM tipo_visitante WHERE tipo_visitante_id = " + tipoVisitante.tipoVisitanteId + ";";
            return connect.retornaSQL(sql);
        }

        public classeTipoVisitante SelectTipoVisitanteDBase(classeTipoVisitante tipoVisitante)
        {
            classeTipoVisitante tipoVisitanteTemp = new classeTipoVisitante();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "SELECT visitante_descricao FROM tipo_visitante WHERE tipo_visitante_id = " + tipoVisitante.tipoVisitanteId + ";";

            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            tipoVisitanteTemp.tipoVisitanteId = tipoVisitante.tipoVisitanteId;
            tipoVisitanteTemp.visitanteDescricao = ds.Tables[0].Rows[0][0].ToString();

            return tipoVisitanteTemp;
        }

        public MySqlDataAdapter SelectTipoVisitanteDBase()
        {
            string sql = "SELECT tipo_visitante_id, visitante_descricao FROM tipo_visitante;";
            return connect.retornaSQL(sql);
        }

        public DataTable SelectTipoVisitanteDBaseGrid()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "SELECT tipo_visitante_id, visitante_descricao FROM tipo_visitante;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
