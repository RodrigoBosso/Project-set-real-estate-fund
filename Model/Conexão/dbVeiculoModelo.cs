//****************************************************************************************
//Grupo 7: Guilherme A Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por:Guilherme de Andrade Rissato
//**Data de Criação:27/04/2021
//**Descrição: criação dos SQL`s
//**Instruções:
//
//
//****** Atualizações: Atualizado para novo modelo do banco
//*** Data: 21/07/2021
//*** Responsável: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho de Costa
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Projeto_LPRC5
{
	class DbVeiculoModelo {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void InsereVeiculoModelo(ClasseVeiculoModelo veiculoModelo)
        {
            string sql = "INSERT INTO veiculomodelo(veiculomodelonome) VALUES('" + veiculoModelo.Nome +"');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void AlteraVeiculoModelo(ClasseVeiculoModelo veiculoModelo)
        {
           string sql = "UPDATE veiculomodelo SET veiculomodelonome ='" + veiculoModelo.Nome + "' WHERE id_veiculomodelo = " + veiculoModelo.ID;
           connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void ExcluiVeiculoModelo(ClasseVeiculoModelo veiculoModelo)
        {
            string sql = "DELETE FROM veiculomodelo WHERE id_veiculomodelo = " + veiculoModelo.ID;
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter SelectVeiculoModelo(ClasseVeiculoModelo veiculoModelo)
        {
            string sql = "SELECT * FROM veiculomodelo WHERE id_veiculomodelo = " + veiculoModelo.ID;
            return connect.retornaSQL(sql);
        }

        public ClasseVeiculoModelo RetornaDadosObjeto(ClasseVeiculoModelo veiculoModelo)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            ClasseVeiculoModelo veiculoModeloTemp = new ClasseVeiculoModelo();

            string sql = "SELECT veiculomodelonome FROM veiculomodelo WHERE id_veiculomodelo = " + veiculoModelo.ID;
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            veiculoModeloTemp.ID = veiculoModelo.ID;
            veiculoModeloTemp.Nome = ds.Tables[0].Rows[0][0].ToString();

            return veiculoModeloTemp;
        }

        public DataTable SelectVeiculoModeloBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "SELECT * FROM veiculomodelo";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }

    }
}
