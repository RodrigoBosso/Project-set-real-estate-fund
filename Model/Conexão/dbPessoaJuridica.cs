using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5
{
    class dbPessoaJuridica
    {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void inserePessoaJuridicaBase(int id, string cnpj, string inscEstadual, string inscMunicipal)
        {
            string sql = "INSERT INTO pessoajuridica(pid, pjcnpj, pjinscestadual, pjinscmunicipal) VALUES (" + id + ", '" + cnpj + "', '" + inscEstadual + "', '" + inscMunicipal +"');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraPessoaJuridicaBase(int id, string cnpj, string inscEstadual, string inscMunicipal)
        {
            string sql = "UPDATE pessoajuridica SET pjcnpj = '" + cnpj + "', pjinscestadual = '" + inscEstadual + "', pjinscmunicipal = '" + inscMunicipal + "' WHERE pid = " + id +";";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiPessoaJuridicaBase(Int16 id)
        {
            string sql = "delete from pessoajuridica where pessoajuridica.pid = " + id + ";";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectPessoaJuridicaBase(Int16 id)
        {
            string sql = "select pessoa.pid, pessoa.pnomeregistro, pessoa.pnomesocial, pessoa.pfoto, pessoa.pemail, pessoajuridica.pjcnpj, pessoajuridica.pjinscestadual, pessoajuridica.pjinscmunicipal from pessoa inner JOIN pessoajuridica on pessoa.pid = pessoajuridica.pid where pessoa.pid = " + id + ";";
            return connect.retornaSQL(sql);
        }

        public classePessoaJuridica RetornaDadosObjeto(Int16 id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classePessoaJuridica pessoaJuridicaTemp = new classePessoaJuridica();

            string sql = "select pessoa.pid, pessoa.pnomeregistro, pessoa.pnomesocial, pessoa.pfoto, pessoa.pemail, pessoajuridica.pjcnpj, pessoajuridica.pjinscestadual, pessoajuridica.pjinscmunicipal from pessoa inner JOIN pessoajuridica on pessoa.pid = pessoajuridica.pid where pessoa.pid = " + id + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            pessoaJuridicaTemp.setPessoaID(id);
            pessoaJuridicaTemp.setPessoaNomeRegistro(ds.Tables[0].Rows[0][1].ToString());
            pessoaJuridicaTemp.setPessoaNomeSocial(ds.Tables[0].Rows[0][2].ToString());
            pessoaJuridicaTemp.setPessoaFoto(ds.Tables[0].Rows[0][3].ToString());
            pessoaJuridicaTemp.setPessoaEmail(ds.Tables[0].Rows[0][4].ToString());
            pessoaJuridicaTemp.setPJuridicaCNPJ(ds.Tables[0].Rows[0][5].ToString());
            pessoaJuridicaTemp.setPJuridicaInscEstadual(ds.Tables[0].Rows[0][6].ToString());
            pessoaJuridicaTemp.setPJuridicaInscMunicipal(ds.Tables[0].Rows[0][7].ToString());

            return pessoaJuridicaTemp;
        }

        public DataTable selectPessoaJuridicaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select pessoa.pid, pessoa.pnomeregistro, pessoa.pnomesocial, pessoa.pfoto, pessoa.pemail, pessoajuridica.pjcnpj, pessoajuridica.pjinscestadual, pessoajuridica.pjinscmunicipal from pessoa inner JOIN pessoajuridica on pessoa.pid = pessoajuridica.pid;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
