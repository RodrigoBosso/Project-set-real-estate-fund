//****************************************************************************************
//**Criado por: Amanda Iaquinta, André Costa e Giovanna Frederico
//**Data de Criação: 21/07/2021
//**Instruções:
//****************************************************************************************
using System;
using MySql.Data.MySqlClient;
using System.Data;
using Projeto_LPRC5.Model.Classe;

namespace Projeto_LPRC5.Model.Conexão
{
    class dbPrestador
    {
        conexaoMySql connect = new conexaoMySql();

        dbPessoa pessoa = new dbPessoa();
        dbPessoaJuridica pessoaJuridica = new dbPessoaJuridica();

        public int verificaPrestador(string cnpj)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "SELECT pid from pessoa_juridica where pjcnpj = '" + cnpj + "';";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);
            int id;

            if (ds.Tables[0].Rows.Count == 0)
            {
                id = 0;
                return id;
            }

            id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            return id;
        }

        public void inserePrestador(classePrestador prestador)
        {
            int id = this.verificaPrestador(prestador.getPJuridicaCNPJ());
            if (id < 1)
            {
                string sql1 = "INSERT INTO pessoa(pnomeregistro, pnomesocial, pemail) VALUES('" + prestador.getPessoaNomeRegistro() + "', '" + prestador.getPessoaNomeSocial() + "', '" + prestador.getPessoaEmail() + "' );";
                connect.executaSQL(sql1);

                string sql2 = "INSERT INTO pessoa_juridica(pid, pjcnpj, pjinscestadual, pjinscmunicipal) VALUES((select max(pid) from pessoa), " + prestador.getPJuridicaCNPJ() + ", " + prestador.getPJuridicaInscEstadual() + ", " + prestador.getPJuridicaInscMunicipal() + ");";
                connect.executaSQL(sql2);

                string sql3 = "INSERT INTO prestador(visita_id, p_juridica_id, servicodescricao) VALUES ((select max(visita_id) from visitantes), (select max(p_juridica_id) from pessoa_juridica), '" + prestador.servicodescricao + "');";
                connect.executaSQL(sql3);
            }
            else
            {
                string sql3 = "INSERT INTO prestador(visita_id, p_juridica_id, servicodescricao) VALUES ((select max(visita_id) from visitantes), (select p_juridica_id from pessoa_juridica where pid = " + id + "), '" + prestador.servicodescricao + "');";
                connect.executaSQL(sql3);
            }

            
        }

        public void alteraPrestador(int visitaId, string descricao)
        {
            string sql = "UPDATE prestador SET servicodescricao  = '" + descricao + "' WHERE visita_id = " + visitaId + ";";
            connect.executaSQL(sql);
        }

        public void excluiPrestador(int id)
        {
            string sql = "delete from prestador where prestador.visita_id = " + id + ";";
            connect.executaSQL(sql);
        }

        public MySqlDataAdapter selectPrestador(int visitaId)
        {
            string sql = "select p.pnomeregistro, pr.visita_id, pr.p_juridica_id, pr.servicodescricao from prestador pr inner join pessoa_juridica pe on pe.pjid =  pr.p_juridica_id  inner join pessoa pe on p.pessoa_id = pe.pid where pr.visita_id = " + visitaId + ";";
            return connect.retornaSQL(sql);
        }

        public classePrestador RetornaDadosObjeto(classePrestador prestador)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classePrestador prestadorTemp = new classePrestador();

            string sql = "select p.pnomeregistro, pr.visita_id, pr.p_juridica_id, pr.servicodescricao from prestador pr inner join pessoa_juridica pe on pe.pjid =  pr.p_juridica_id  inner join pessoa pe on p.pessoa_id = pe.pid where pr.visita_id = " + prestador.visitaId + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            prestadorTemp.visitaId = prestador.visitaId;
            prestadorTemp.setPessoaNomeRegistro(ds.Tables[0].Rows[0][0].ToString());
            prestadorTemp.pessoaJuridicaId = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
            prestadorTemp.servicodescricao = Convert.ToString(ds.Tables[0].Rows[0][3]);

            return prestadorTemp;
        }

        public DataTable selectPrestador()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select p.pnomeregistro, pr.visita_id, pr.p_juridica_id, pr.servicodescricao from prestador pr inner join pessoa_juridica pe on pe.p_juridica_id = pr.p_juridica_id inner join pessoa p on p.pid = pe.pid;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
