using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5
{
    class dbPessoa
    {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void inserePessoaBase(string nRegistro, string nSocial, string email, string foto)
        {
            string sql = "INSERT INTO pessoa(pnomeregistro, pnomesocial, pfoto, pemail) VALUES ('" + nRegistro + "', '" + nSocial + "', '" + foto + "', '" + email + "');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraPessoaBase(Int16 id, string nRegistro, string nSocial, string email, string foto)
        {
            string sql = "UPDATE pessoa SET pnomeregistro = '" + nRegistro + "', pnomesocial = '" + nSocial + "', pfoto = '" + foto + "', pemail= '" + email + "' WHERE pid = " + id + ";";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiPessoaBase(Int16 id)
        {
            string sql = "delete from pessoa where pessoa.pid = " + id + ";"; 
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectPessoaBase(Int16 id)
        {
            string sql = "select pid, pnomeregistro, pnomesocial, pfoto, pemail from pessoa where pessoa.pid = " + id + ";";
            return connect.retornaSQL(sql);
        }

        public classePessoa RetornaDadosObjeto(Int16 id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classePessoa pessoaTemp = new classePessoa();

            string sql = "select pid, pnomeregistro, pnomesocial, pfoto, pemail from pessoa where pessoa.pid = " + id + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            pessoaTemp.setPessoaID(id);
            pessoaTemp.setPessoaNomeRegistro(ds.Tables[0].Rows[0][1].ToString());
            pessoaTemp.setPessoaNomeSocial(ds.Tables[0].Rows[0][2].ToString());
            pessoaTemp.setPessoaFoto(ds.Tables[0].Rows[0][3].ToString());
            pessoaTemp.setPessoaEmail(ds.Tables[0].Rows[0][4].ToString());

            return pessoaTemp;
        }

        public DataTable selectPessoaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select pid, pnomeregistro, pnomesocial, pfoto, pemail from pessoa;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
