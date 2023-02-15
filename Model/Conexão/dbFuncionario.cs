//****************************************************************************************
//**Criado por:Giovanni Marques, Bruno Bragagnolo, Renan Vaz
//**Data de Criação:25/05/2021
//**Instruções: criação do CRUD
//
//
//****** Atualizações: Montamos o banco de dados pedido pelo professor, os botoes e a classe
//*** Data:
//*** Responsável:
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5
{
    class dbFuncionario
    {
        conexaoMySql connect = new conexaoMySql();

        public void InsireFuncionarioBase(classeFuncionario funcionario)
        {
            string sql = $"insert into funcionario (funcionarioNome, funcionarioSenha, funcionarioNivelId) values ('{funcionario.getFuncionarioNome()}','{funcionario.getFuncionarioSenha()}',{funcionario.getFuncionarioNivelId()});";
            connect.executaSQL(sql);
        }

        public void AlteraFuncionarioBase(classeFuncionario funcionario)
        {
            string sql = $"update funcionario set funcionarioNome = {funcionario.getFuncionarioNome()},funcionarioSenha = '{funcionario.getFuncionarioSenha()}', FuncionarioNivelId = {funcionario.getFuncionarioNivelId()} where funcionarioId = {funcionario.getFuncionarioId()};";
            connect.executaSQL(sql);
        }

        public void excluiFuncionarioBase(classeFuncionario funcionario)
        {
            string sql = $"delete from funcionario where funcionarioId = {funcionario.getFuncionarioId()};";
            connect.executaSQL(sql);
        }

        public MySqlDataAdapter selectFuncionarioBase(classeFuncionario funcionario)
        {
            string sql = $"select * from funcionario where funcionarioId = {funcionario.getFuncionarioId()};";
            return connect.retornaSQL(sql);
        }

        public classeFuncionario RetornaDadosObjeto(classeFuncionario funcionario)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeFuncionario FuncionarioTemp = new classeFuncionario();

            string sql = "select funcionarioId, funcionarioNome, funcionarioSenha, funcionarioNivelId from funcionario where funcionarioId = " + funcionario.getFuncionarioId() + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            FuncionarioTemp.setFuncionarioId(funcionario.getFuncionarioId());
            FuncionarioTemp.setFuncionarioNome(ds.Tables[0].Rows[0][1].ToString());
            FuncionarioTemp.setFuncionarioSenha(ds.Tables[0].Rows[0][2].ToString());
            FuncionarioTemp.setFuncionarioNivelId(funcionario.getFuncionarioNivelId());

            return FuncionarioTemp;
        }

        public Int16 RetornaDadosObjeto(string login, string senha)
        {
            Int16 codigoFuncionario = 0;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "select funcionarioId from funcionario where funcionarioNome = '" + login + "' and funcionarioSenha = '" + senha + "';";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                codigoFuncionario = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
            }

            return codigoFuncionario;
        }

        public DataTable selectFuncionarioBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select * from funcionario;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);
            return tabela;
        }
    }
}    