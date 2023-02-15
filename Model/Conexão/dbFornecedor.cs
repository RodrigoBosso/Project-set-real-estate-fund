//****************************************************************************************
//**Criado por: Daniel Galdencio dos Santos, Antonio Naranjo
//**Data de Criação: 09/05/2021
//**Instruções: Realizada a criação dos parâmetros de insert, update e select dos dados da tabela no banco de dados 
//
//
//****** Atualizações: Criação de funções e métodos de conexão ao banco de dados mysql
//*** Data: 22/07/2021
//*** Responsável: Daniel Galdencio, Antonio Naranjo, Rafael de Angelis Fogaça e Letícia Lopes Abelha
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projeto_LPRC5
{
    class dbFornecedor
    {
        public static MySqlConnection conexao;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;

        public static void Conectar()
        {
            conexao = new MySqlConnection("server=127.0.0.1;port=5432;database=condominio_db;uid=root;pwd=;");

            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public static void Desconectar()
        {
            conexao.Close();
        }

        public int ExecutaSQL(string instrucaoSQL)
        {
            Conectar();
            command = new MySqlCommand(instrucaoSQL, conexao);
            command.ExecuteNonQuery();
            Desconectar();
            return 1;
        }

        public DataTable RetornaSQL(string instrucaoSQL)
        {
            Conectar();
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSQL, conexao))
            {
                adapter.Fill(dt);
            }
            Desconectar();
            return dt;
        }
    }
}

