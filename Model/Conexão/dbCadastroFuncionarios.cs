using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Projeto_LPRC5.Model.Classe;

namespace Projeto_LPRC5
{

    class dbCadastroFuncionarios
    {
        conexaoMySql connect = new conexaoMySql();


        public void insereCadastroFuncionarios(string nRegistro, string nSocial, string email, string cpf, string rg, string n_telefone, string data_adimissao, string estado_civil, string sexo)


        {
            string sql1 = "INSERT INTO pessoa(pnomeregistro, pnomesocial, pemail) VALUES ('" + nRegistro + "', '" + nSocial + "', '" + email + "');";
            connect.executaSQL(sql1);

            string sql2 = "INSERT INTO pessoa_fisica(pessoa_id,cpf, rg) VALUES ((select max(pid) from pessoa), '" + cpf + "', '" + rg + "');";
            connect.executaSQL(sql2);

            string sql3 = "INSERT INTO funcionario(funcionario_id, numero_telefone, data_adimissao, estado_civil, sexo) VALUES('" + n_telefone + "', '" + data_adimissao + "', '" + estado_civil + "', '" + sexo + "' ); ";
            connect.executaSQL(sql3);
        }

        public void alteraCadastroFuncionariosBase(Int16 id, string nRegistro, string nSocial, string email, string cpf, string rg, string n_telefone, string data_adimissao, string estado_civil, string sexo)
        {
            string sql1 = "UPDATE pessoa SET pnomeregistro = '" + nRegistro + "', pnomesocial = '" + nSocial + "', pemail= '" + email + "' WHERE pid = " + id + ";";
            connect.executaSQL(sql1);

            string sql2 = "UPDATE pessoa_fisica SET cpf = '" + cpf + "', rg = '" + rg + "' where pessoa_id = " + id + ";";
            connect.executaSQL(sql2);

            string sql3 = "UPDATE funcionario SET numero_telefone = '" + n_telefone + "', '" + data_adimissao + "', '" + data_adimissao + "', '" + estado_civil + "' WHERE funcionarios_id " + id + " ;";
            connect.executaSQL(sql3);
        }

        public void excluiCadastroFuncionariosBase(Int16 id)
        {
            string sql = "DELETE FROM pessoa WHERE  pid = " + id + ";";
            connect.executaSQL(sql);
        }

        public MySqlDataAdapter selectCadastroFuncionariosBase(Int16 id)
        {
            string sql = "SELECT p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg , f.n_telefone FROM pessoa p JOIN pessoa_fisica pf ON p.pid = pf.pessoa_id JOIN funcionario f ON p.pid = f.funcionarios_id WHERE p.pid = " + id + ";";
            return connect.retornaSQL(sql);
        }
        public ClasseCadastroFuncionarios RetornaDadosObjeto(Int16 id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            ClasseCadastroFuncionarios funcionariosTemp = new ClasseCadastroFuncionarios();


            string sql = "SELECT p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg , f.n_telefone  FROM pessoa p JOIN pessoa_fisica pf ON p.pid = pf.pessoa_id JOIN funcionario f ON p.pid = f.funcionarios_id WHERE p.pid = " + id + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            funcionariosTemp.setPessoaID(id);
            funcionariosTemp.setPessoaNomeRegistro(ds.Tables[0].Rows[0][1].ToString());
            funcionariosTemp.setPessoaNomeSocial(ds.Tables[0].Rows[0][2].ToString());
            funcionariosTemp.setPessoaFoto(ds.Tables[0].Rows[0][3].ToString());
            funcionariosTemp.setPessoaEmail(ds.Tables[0].Rows[0][4].ToString());
            funcionariosTemp.cpf = (ds.Tables[0].Rows[0][5].ToString());
            funcionariosTemp.rg = (ds.Tables[0].Rows[0][6].ToString());
            funcionariosTemp.setfuncionarioID(Convert.ToInt16(ds.Tables[0].Rows[0][7].ToString()));

            return funcionariosTemp;
        }


        public DataTable selectCadastroFuncionariosBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "SELECT p.pid, p.pnomeregistro, p.pnomesocial, p.pemail, pf.cpf, pf.rg , f.n_telefone  FROM pessoa p JOIN pessoa_fisica pf ON p.pid = pf.pessoa_id JOIN funcionario ON p.pid = f.funcionario_id ;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
