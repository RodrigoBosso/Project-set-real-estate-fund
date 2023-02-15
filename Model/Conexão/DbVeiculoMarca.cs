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
	class DbVeiculoMarca {
        private Int32 retorno;
        conexaoMySql connect = new conexaoMySql();

        public void InsereVeiculoMarcaBase(ClasseVeiculoMarca veiculoMarca) {
            string sql = $"INSERT INTO veiculomarca (veiculomarcanome) VALUES ('{veiculoMarca.Nome}')";
            retorno = connect.executaSQL(sql);
        }


        public void AlteraVeiculoMarcaBase(ClasseVeiculoMarca veiculoMarca) {
            string sql = $"UPDATE veiculomarca SET veiculomarcanome = '{veiculoMarca.Nome}' WHERE id_veiculomarca = {veiculoMarca.ID}";
            retorno = connect.executaSQL(sql);
        }


        public void ExcluiVeiculoMarcaBase(ClasseVeiculoMarca veiculoMarca) {
            string sql = "DELETE FROM veiculomarca WHERE id_veiculomarca = " + veiculoMarca.ID;
            retorno = connect.executaSQL(sql);
        }


        public MySqlDataAdapter SelectVeiculoMarcaBase(ClasseVeiculoMarca veiculoMarca) {
            string sql = "SELECT * FROM veiculomarca WHERE id_veiculomarca = " + veiculoMarca.ID;
            return connect.retornaSQL(sql);
        }

        public ClasseVeiculoMarca SelectVeiculoMarcaDBase(ClasseVeiculoMarca veiculoMarca) {
            ClasseVeiculoMarca veiculoTemp = new ClasseVeiculoMarca();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "SELECT veiculomarcanome FROM veiculomarca WHERE id_veiculomarca = " + veiculoMarca.ID;

            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            veiculoTemp.ID = veiculoMarca.ID;
            veiculoTemp.Nome = ds.Tables[0].Rows[0][0].ToString();

            return veiculoTemp;
        }

        public MySqlDataAdapter SelectVeiculoMarcaDBase() {
            string sql = "SELECT veiculomarcanome FROM veiculomarca";
            return connect.retornaSQL(sql);
        }

        public DataTable SelectVeiculoMarcaDBaseGrid() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter = SelectVeiculoMarcaDBase();
            adapter.Fill(tabela);
            return tabela;
        }
    }
}
