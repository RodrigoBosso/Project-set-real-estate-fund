//****************************************************************************************
//**Criado por: Alessandro Viola 
//**Data de Criação: 12/04/2021
//**Descrição: 
// Faz a conexão com o SGBD MySql.
//**Instruções:
// Faz uso do MySqlConnector, versão 8.0.23, que deve ser instalado;
// Pode ser encontrado no site: https://dev.mysql.com/downloads/connector/net/
// Incluir nas referências do projeto, "MySqlData"
// Incluir "using MySql.Data.MySqlClient;"
// 
//****** Atualizações: Adição das funções executaSQL e retornaSQL.
//*** Data: 19/04/2020
//*** Responsável: Giovanna Valim
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projeto_LPRC5
{
    public class conexaoMySql
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        public void conectaMySql(string servidor, string usuario, string bancoNome, string senha)
        {
             conexao = new MySqlConnection("server=" + servidor + ";uid=" + usuario + ";database=" + bancoNome + ";pwd=" + senha);

            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void desconectaMySql()
        {
            conexao.Close();
        }


        public Int32 executaSQL(string instrucaoSQL)
        {
            util.lerArquivoAcessoBanco();
            conectaMySql(util.servidor.ToString(), util.usuario.ToString(), util.banco.ToString(), util.senha.ToString());
            command = new MySqlCommand(instrucaoSQL, conexao);
            command.ExecuteNonQuery();
            desconectaMySql();
            return 0;
        }

        public MySqlDataAdapter retornaSQL(string instrucaoSQL)
        {
            util.lerArquivoAcessoBanco();
            conectaMySql(util.servidor.ToString(), util.usuario.ToString(), util.banco.ToString(), util.senha.ToString());
            MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSQL, conexao);
            desconectaMySql();
            return adapter;
        }
    }
}
