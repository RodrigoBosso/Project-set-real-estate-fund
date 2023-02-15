//****************************************************************************************
//**Criado por: Amanda Iaquinta, André Costa e Giovanna Frederico 
//**Data de Criação: 20/07/2021
//**Instruções:
//****************************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Projeto_LPRC5.Model.Classe;

namespace Projeto_LPRC5.Model.Conexão
{
    class dbPessoaFisica
    {
        conexaoMySql connect = new conexaoMySql();


        public void inserePessoaFisicaBase(string nRegistro, string nSocial, string email, string cpf, string rg)
        {
            string sql1 = "INSERT INTO pessoa(pnomeregistro, pnomesocial, pemail) VALUES ('" + nRegistro + "', '" + nSocial + "', '" + email + "');";
            connect.executaSQL(sql1);

            string sql2 = "INSERT INTO pessoa_fisica(pessoa_id,cpf, rg) VALUES ((select max(pid) from pessoa), '" + cpf + "', '" + rg + "');";
            connect.executaSQL(sql2);
        }

      
        public void alteraPessoaFisicaBase(Int16 id, string nRegistro, string nSocial, string email, string cpf, string rg)
        {
            string sql = "UPDATE pessoa SET pnomeregistro = '" + nRegistro + "', pnomesocial = '" + nSocial + "', pemail= '" + email + "' WHERE pid = " + id + ";";
            connect.executaSQL(sql);

            string sql1 = "UPDATE pessoa_fisica SET cpf = '" + cpf + "', rg = '" + rg + "' where pessoa_id = " + id + ";";
            connect.executaSQL(sql1);
        }

        
        public void excluiPessoaFisicaBase(Int16 id)
        {
            string sql = "delete from pessoa_fisica where pessoa_id = " + id + ";";
            connect.executaSQL(sql);
        }

    
        public MySqlDataAdapter selectPessoaFisicaBase(Int16 id)
        {
            string sql = "select p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg from pessoa p inner join pessoa_fisica pf on p.pid = pf.pessoa_id where p.pid = " + id + ";";
            return connect.retornaSQL(sql);
        }

        public classePessoaFisica RetornaDadosObjeto(Int16 id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classePessoaFisica pessoaTemp = new classePessoaFisica();

            string sql = "select p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg from pessoa p inner join pessoa_fisica pf on p.pid = pf.pessoa_id where p.pid = " + id + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            pessoaTemp.setPessoaID(id);
            pessoaTemp.setPessoaNomeRegistro(ds.Tables[0].Rows[0][1].ToString());
            pessoaTemp.setPessoaNomeSocial(ds.Tables[0].Rows[0][2].ToString());
            pessoaTemp.setPessoaFoto(ds.Tables[0].Rows[0][3].ToString());
            pessoaTemp.setPessoaEmail(ds.Tables[0].Rows[0][4].ToString());
            pessoaTemp.cpf = (ds.Tables[0].Rows[0][5].ToString());
            pessoaTemp.rg = (ds.Tables[0].Rows[0][6].ToString());

            return pessoaTemp;
        }

        public DataTable selectPessoaFisicaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg from pessoa p inner join pessoa_fisica pf on p.pid = pf.pessoa_id;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

