//****************************************************************************************
//**Criado por: Alexandro Junior, Caique Bruno e Guilherme Beig
//**Data de Criação: 23/07/2021
//**Instruções:Criação completa da conexão de banco de dados
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Projeto_LPRC5.Model.Classe;

namespace Projeto_LPRC5.Model.Conexão
{
    class dbMoradores
    {
        private Int16 retorno;
        conexaoMySql con = new conexaoMySql();

        public void insereMoradoresBase(string nRegistro, string nSocial, string email, string cpf, string rg, Int16 habitacaoId)
        {
            string sql1 = "INSERT INTO pessoa(pnomeregistro, pnomesocial, pemail) VALUES ('" + nRegistro + "', '" + nSocial + "', '" + email + "');";
            con.executaSQL(sql1);

            string sql2 = "INSERT INTO pessoa_fisica(pessoa_id,cpf, rg) VALUES ((select max(pid) from pessoa), '" + cpf + "', '" + rg + "');";
            con.executaSQL(sql2);

            string sql3 = "INSERT INTO Moradores( morador_id habitacao_id) VALUES ((select max(pid) from pessoa) , " + habitacaoId + ");";
            con.executaSQL(sql3);

           
        }

        public void alteraMoradoresBase(Int16 id, string nRegistro, string nSocial, string email, string cpf, string rg, Int16 habitacaoId)
        {
            string sql1 = "UPDATE pessoa SET pnomeregistro = '" + nRegistro + "', pnomesocial = '" + nSocial + "', pemail= '" + email + "' WHERE pid = " + id + ";";
            con.executaSQL(sql1);

            string sql2 = "UPDATE pessoa_fisica SET cpf = '" + cpf + "', rg = '" + rg + "' where pessoa_id = " + id + ";";
            con.executaSQL(sql2);

            string sql3 = "UPDATE Moradores SET habitacao_id = " + habitacaoId + " WHERE moradores_id " + id + " ;";
            con.executaSQL(sql3);
        }
        public void excluiMoradoresBase(Int16 id)
        {
            string sql = "DELETE FROM pessoa WHERE  pid = " + id + ";";
            con.executaSQL(sql);
        }

        public MySqlDataAdapter selectMoradoresBase(Int16 id)
        {
            string sql = "SELECT p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg , m.habitacao_id  FROM pessoa p JOIN pessoa_fisica pf ON p.pid = pf.pessoa_id JOIN moradores m ON p.pid = m.moradores_id WHERE p.pid = " + id + ";";
            return con.retornaSQL(sql);

        }
        public classeMoradores RetornaDadosObjeto(Int16 id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeMoradores moradoresTemp = new classeMoradores();
          
            string sql = "SELECT p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg , m.habitacao_id  FROM pessoa p JOIN pessoa_fisica pf ON p.pid = pf.pessoa_id JOIN moradores m ON p.pid = m.moradores_id WHERE p.pid = " + id + ";";
            adapter = con.retornaSQL(sql);
            adapter.Fill(ds);

            moradoresTemp.setPessoaID(id);
            moradoresTemp.setPessoaNomeRegistro(ds.Tables[0].Rows[0][1].ToString());
            moradoresTemp.setPessoaNomeSocial(ds.Tables[0].Rows[0][2].ToString());
            moradoresTemp.setPessoaFoto(ds.Tables[0].Rows[0][3].ToString());
            moradoresTemp.setPessoaEmail(ds.Tables[0].Rows[0][4].ToString());
            moradoresTemp.cpf = (ds.Tables[0].Rows[0][5].ToString());
            moradoresTemp.rg = (ds.Tables[0].Rows[0][6].ToString());
            moradoresTemp.setHabitacaoId(Convert.ToInt16(ds.Tables[0].Rows[0][7].ToString()));
            

            return moradoresTemp;
        }

        public DataTable selectMoradoresBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "SELECT p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg , m.habitacao_id  FROM pessoa p JOIN pessoa_fisica pf ON p.pid = pf.pessoa_id JOIN moradores m ON p.pid = m.moradores_id ;";
            adapter = con.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }

        public MySqlDataReader SelectComboBox()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=dbcondominio;pwd=");
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT habitacao_id FROM habitacao;", conn);
            MySqlDataReader reader;
            reader = sql.ExecuteReader();

            return reader;

            
        }

       
    }
}
