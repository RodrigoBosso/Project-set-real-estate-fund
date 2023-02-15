//****************************************************************************************
//**Criado por: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho de Costa
//**Data de Criação: 21/07/2021
//**Instruções:
//
//
using MySql.Data.MySqlClient;
using Projeto_LPRC5.Model.Classe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Conexão {
	class DbVeiculoPessoa {
        private Int32 retorno;
        conexaoMySql connect = new conexaoMySql();

        public void InsereVeiculoPessoaBase(ClasseVeiculoPessoa veiculoPessoa) {
            string sql = $"INSERT INTO veiculopessoa (placaveiculo, id_morador, id_cor, id_veiculo) VALUES ('{veiculoPessoa.Placa}', {veiculoPessoa.MoradorID}, {veiculoPessoa.CorID}, {veiculoPessoa.VeiculoID})";
            retorno = connect.executaSQL(sql);
        }


        public void AlteraVeiculoPessoaBase(ClasseVeiculoPessoa veiculoPessoa) {
            string sql = $"UPDATE veiculopessoa SET id_veiculo = {veiculoPessoa.VeiculoID}, id_cor = {veiculoPessoa.CorID}, id_morador = {veiculoPessoa.MoradorID}, placaveiculo = '{veiculoPessoa.Placa}' WHERE id_veiculo = {veiculoPessoa.ID}";
            retorno = connect.executaSQL(sql);
        }


        public void ExcluiVeiculoPessoaBase(ClasseVeiculoPessoa veiculoPessoa) {
            string sql = "DELETE FROM veiculopessoa WHERE id_veiculopessoa = " + veiculoPessoa.ID;
			retorno = connect.executaSQL(sql);
        }


        public MySqlDataAdapter SelectVeiculoPessoaBase(ClasseVeiculoPessoa veiculoPessoa) {
            string sql = "SELECT * FROM veiculopessoa WHERE id_veiculopessoa = " + veiculoPessoa.ID;
            return connect.retornaSQL(sql);
        }

        public ClasseVeiculoPessoa SelectVeiculoPessoaDBase(ClasseVeiculoPessoa veiculoPessoa) {
            ClasseVeiculoPessoa veiculoTemp = new ClasseVeiculoPessoa();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "SELECT placaveiculo, id_morador, id_cor, id_veiculo FROM veiculopessoa WHERE id_veiculopessoa = " + veiculoPessoa.ID;

            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            veiculoTemp.ID = veiculoPessoa.ID;
            veiculoTemp.Placa = ds.Tables[0].Rows[0][0].ToString();
            veiculoTemp.MoradorID = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
            veiculoTemp.CorID = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
            veiculoTemp.VeiculoID = Convert.ToInt32(ds.Tables[0].Rows[0][3]);

            return veiculoTemp;
        }

        public MySqlDataAdapter SelectVeiculoPessoaDBase() {
            string sql = "SELECT placaveiculo, id_morador, id_cor, id_veiculo FROM veiculopessoa";
            return connect.retornaSQL(sql);
        }

        public DataTable SelectVeiculoPessoaDBaseGrid() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter = SelectVeiculoPessoaDBase();
            adapter.Fill(tabela);
            return tabela;
        }
    }
}
