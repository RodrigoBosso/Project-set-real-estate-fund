//**Criado por: Murilo Azevedo Jacon
//**Data de Criação: 26/04/2021
//**Instruções:
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5 {
	class DbEstado {
		public DataTable SelecionarDataTable() {
			DataTable tabela = new DataTable();

			string sql = "SELECT * FROM estado";
			MySqlDataAdapter adapter = new conexaoMySql().retornaSQL(sql);
			adapter.Fill(tabela);

			return tabela;
		}

		public void Excluir(int id) {
			string sql = "DELETE FROM estado WHERE estadoid = " + id;
			new conexaoMySql().executaSQL(sql);
		}

		public ClasseEstado SelecionarObjeto(int id) {
			string sql = "SELECT * FROM estado WHERE estadoid = " + id;
			var adapter = new conexaoMySql().retornaSQL(sql);
			var dataSet = new DataSet();
			adapter.Fill(dataSet);

			return new ClasseEstado {
				Id = id,
				Nome = dataSet.Tables[0].Rows[0]["estadonome"].ToString(),
				Sigla = dataSet.Tables[0].Rows[0]["estadosigla"].ToString(),
			};
		}

		public void Salvar(ClasseEstado estado) {
			string sql = $"INSERT INTO estado (estadonome, estadosigla) VALUES ('{estado.Nome}', '{estado.Sigla}')";
			new conexaoMySql().executaSQL(sql);
		}

		public void Alterar(ClasseEstado estado) {
			string sql = $"UPDATE estado SET estadonome = '{estado.Nome}', estadosigla = '{estado.Sigla}' WHERE estadoid = {estado.Id}";
			new conexaoMySql().executaSQL(sql);
		}
	}
}
