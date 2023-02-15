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
using Projeto_LPRC5.Model.Classe;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5.Model.Conexão
{
    class dbVisitantes
    {
        conexaoMySql connect = new conexaoMySql();

        public void insereVeiculo(string placa)
        {
            string sql = "INSERT INTO veiculo_visitante(visita_id, veiculo_id) values((select max(visita_id) from visitantes), (select id_veiculo from veiculopessoa where placaveiculo = '" + placa + "'));";
            connect.executaSQL(sql);
        }

        public void insereVisitante(classeVisitantes visitante)
        {
            int id = this.verificaPessoa(visitante.cpf);
            if (id < 1)
            {
                string sql1 = "INSERT INTO pessoa(pnomeregistro, pnomesocial, pemail) VALUES('" + visitante.getPessoaNomeRegistro() + "', '" + visitante.getPessoaNomeSocial() + "', '" + visitante.getPessoaEmail() + "' );";
                connect.executaSQL(sql1);

                string sql2 = "INSERT INTO pessoa_fisica(pessoa_id, cpf, rg) VALUES((select max(pid) from pessoa), '" + visitante.cpf + "', '" + visitante.rg + "');";
                connect.executaSQL(sql2);
            }
            string sql3 = "INSERT INTO visitantes(data_visita, pessoa_fisica_id, habitacao_id, tipo_visitante_id) VALUES((current_date()) ," + "(select max(p_fisica_id) from pessoa_fisica)" + ", " + 1 + ", " + visitante.tipoVisitanteId + "); ";
            connect.executaSQL(sql3);

        }

        public int verificaPessoa(string cpf)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "SELECT p_fisica_id from pessoa_fisica where cpf = '" + cpf + "';";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);
            int id;
            
            if(ds.Tables[0].Rows.Count == 0)
            {
                id = 0;
                return id;
            }

            id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            return id;
        }

        public MySqlDataAdapter selectVisitanteBase(int id)
        {
            string sql = "select p.pnomeregistro, v.visita_id, v.data_visita, v.pessoa_fisica_id, habitacao_id, v.tipo_visitante_id from visitantes v from visitantes inner join pessoa_fisica pe on p.p_fisica_id =  v.pessoa_fisica_id  inner join pessoa pe on p.pessoa_id = pe.pid where v.pessoa_fisica_id = " + id + ";";
            return connect.retornaSQL(sql);
        }

        public classeVisitantes RetornaDadosObjeto(classeVisitantes visitantes)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeVisitantes visitanteTemp = new classeVisitantes();

            string sql = "select p.pnomeregistro, v.visita_id, v.data_visita, v.pessoa_fisica_id, habitacao_id, v.tipo_visitante_id from visitantes v from visitantes inner join pessoa_fisica pe on p.p_fisica_id =  v.pessoa_fisica_id  inner join pessoa pe on p.pessoa_id = pe.pid where v.pessoa_fisica_id = " + visitantes.pessoaFidicaId + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            visitanteTemp.visitaId = visitantes.visitaId;
            visitanteTemp.setPessoaNomeRegistro(ds.Tables[0].Rows[0][0].ToString());
            visitanteTemp.dataVisita = Convert.ToDateTime(ds.Tables[0].Rows[0][2]);
            visitanteTemp.pessoaFidicaId = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
            visitanteTemp.habitacaoId = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
            visitanteTemp.tipoVisitanteId = Convert.ToInt32(ds.Tables[0].Rows[0][5]);


            return visitanteTemp;
        }

        public DataTable selectVisitantes()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select p.pnomeregistro, v.visita_id, v.data_visita, v.pessoa_fisica_id, habitacao_id, v.tipo_visitante_id from visitantes v inner join pessoa_fisica pf on v.pessoa_fisica_id = pf.p_fisica_id inner join pessoa p on pf.pessoa_id = p.pid;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
