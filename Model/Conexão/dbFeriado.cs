//****************************************************************************************
//**Criado por: Rodrigo Bosso
//**Data de Criação: 19 /04 /2021
//**Instruções:
//
//
//****** Atualizações: Modificação de praticamente todo o codico pois só existia conflito por conta de copiar e colar. Adicionados comandos para realizar a query, novas funções para selecionar informações e exibir no grid e por fim a organização completa do código.
//*** Data:03/05/2021
//*** Responsável:Grupo 6
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
    class bdFeriado
    {
        private Int32 retornoferiado;
        conexaoMySql connect = new conexaoMySql();

        
        public void insereFeriadoBase(classeFeriado feriado)
        {
            string sql = "insert into feriado  (feriadodia, feriadomes, feriadonome)  values ("+feriado.FeriadoDia+", "+feriado.FeriadoMes+",'"+feriado.FeriadoNome + "')";

            retornoferiado = connect.executaSQL(sql.ToString());
        }

        
        public void alteraFeriadoBase(classeFeriado feriado)
        {
            string sql = "Update feriado set feriadodia ="+feriado.FeriadoDia+", feriadomes ="+feriado.FeriadoMes+", feriadonome = '"+feriado.FeriadoNome+"' where feriadoid = "+feriado.FeriadoId+";";
            retornoferiado = connect.executaSQL(sql.ToString());
        }

        
        public void excluiFeriadoBase(classeFeriado feriado)
        {
            string sql = "Delete from feriado where feriadoid = "+feriado.FeriadoId+";" ;
            retornoferiado = connect.executaSQL(sql.ToString());
        }

        
        public MySqlDataAdapter selectFeriadoBase(classeFeriado feriado)
        {
            string sql = "Select * from feriado where feriadoid = "+feriado.FeriadoId+";" ;
            retornoferiado = connect.executaSQL(sql.ToString());
            return connect.retornaSQL(sql.ToString());
        }

        public classeFeriado selectFeriadoDBase(classeFeriado feriado)
        {
          
            classeFeriado FeriadoTemp = new classeFeriado();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "SELECT feriadonome, feriadodia, feriadomes FROM feriado where feriadoid =" + feriado.FeriadoId + " ;";

            adapter = connect.retornaSQL(sql.ToString());
            adapter.Fill(ds);

            FeriadoTemp.FeriadoId = feriado.FeriadoId;
            FeriadoTemp.FeriadoNome = ds.Tables[0].Rows[0][0].ToString();
            FeriadoTemp.FeriadoDia = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
            FeriadoTemp.FeriadoMes = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());



            return FeriadoTemp;
        }

        public MySqlDataAdapter selectFeriadoDBase()
        {
            string sql = "SELECT feriadoid, feriadonome, feriadodia,feriadomes FROM feriado;";
            return connect.retornaSQL(sql.ToString());
        }

        public DataTable selectFeriadoDBaseGrid()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter = selectFeriadoDBase();
            adapter.Fill(tabela);
            return tabela;
        }
    }
}
