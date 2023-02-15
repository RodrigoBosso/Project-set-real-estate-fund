//****************************************************************************************
//**Criado por: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho de Costa
//**Data de Criação: 21/07/2021
//**Instruções:
//
//
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Conexão {
	class DbVeiculo {
        private Int32 retorno;
        conexaoMySql connect = new conexaoMySql();

        public void InsereVeiculoBase(ClasseVeiculo veiculo) {
            string sql = $"INSERT INTO veiculo (id_marca, id_modelo) VALUES ({veiculo.MarcaID}, {veiculo.ModeloID})";
            retorno = connect.executaSQL(sql);
        }


        public void AlteraVeiculoBase(ClasseVeiculo veiculo) {
            string sql = $"UPDATE veiculo SET id_modelo = {veiculo.ModeloID}, id_marca = {veiculo.MarcaID} WHERE id_veiculo = {veiculo.ID}";
            retorno = connect.executaSQL(sql);
        }


        public void ExcluiVeiculoBase(ClasseVeiculo veiculo) {
            string sql = "DELETE FROM veiculo WHERE id_veiculo = " + veiculo.ID;
            retorno = connect.executaSQL(sql);
        }


        public MySqlDataAdapter SelectVeiculoBase(ClasseVeiculo veiculo) {
            string sql = "SELECT * FROM veiculo WHERE id_veiculo = " + veiculo.ID;
            return connect.retornaSQL(sql);
        }

        public ClasseVeiculo SelectVeiculoDBase(ClasseVeiculo veiculo) {
            ClasseVeiculo veiculoTemp = new ClasseVeiculo();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "SELECT id_marca, id_modelo FROM veiculo WHERE id_veiculo = " + veiculo.ID;

            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            veiculoTemp.ID = veiculo.ID;
            veiculoTemp.MarcaID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            veiculoTemp.ModeloID = Convert.ToInt32(ds.Tables[0].Rows[0][1]);

            return veiculoTemp;
        }

        public MySqlDataAdapter SelectVeiculoDBase() {
            string sql = "SELECT id_marca, id_veiculo FROM veiculo";
            return connect.retornaSQL(sql);
        }

        public DataTable SelectVeiculoDBaseGrid() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter = SelectVeiculoDBase();
            adapter.Fill(tabela);
            return tabela;
        }
    }
}
