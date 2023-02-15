//****************************************************************************************
//**Criado por: Rodrigo Bosso
//**Data de Criação: 26 /04 /2021
//**Instruções:
//
//
//****** Atualizações:Adição das 'empresaPrestadoraTemp'
//*** Data:21/07
//*** Responsável:André Sirikaku, Mateus Siste, Rodrigo Bosso
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Projeto_LPRC5
{

    class bdEmpresaPrestadoraServico
    {
        conexaoMySql connect = new conexaoMySql();


        public void insereEmpresaPrestadoraServico(ClasseEmpresaPrestadoraServico empresaPrestadora)
        {

            string sql = "insert into EmpresaServicos  (EmpresaId, EmpresaNome, EmpresaTipoServico, EmpresaTelefone , EmpresaEndereco, EmpresaDescricao ) " +
                $"values({empresaPrestadora.EmpresaId},{empresaPrestadora.EmpresaNome},{empresaPrestadora.EmpresaTipoServico},{empresaPrestadora.EmpresaTelefone},{empresaPrestadora.EmpresaEndereco}),{empresaPrestadora.EmpresaDescricao};";
            //connect.executaSQL("");
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraEmpresaPrestadoraServico(ClasseEmpresaPrestadoraServico empresaPrestadora)
        {
            string sql = $"Update EmpresaServicos set EmpresaNome ={empresaPrestadora.EmpresaNome}, EmpresaTipoServico ={empresaPrestadora.EmpresaTipoServico}" +
                $", EmpresaTelefone= { empresaPrestadora.EmpresaTelefone}, EmpresaEndereco= {empresaPrestadora.EmpresaEndereco } where EmpresaId = {empresaPrestadora.EmpresaId};";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiEmpresaPrestadoraServico(ClasseEmpresaPrestadoraServico empresaPrestadora)
        {
            string sql = $"Delete from EmpresaServicos where EmpresaId = {empresaPrestadora.EmpresaId};";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados


        public ClasseEmpresaPrestadoraServico selectEmpresaPrestadoraServicoDBase(ClasseEmpresaPrestadoraServico empresaPrestadora)
        {

            ClasseEmpresaPrestadoraServico empresaPrestadoraTemp = new ClasseEmpresaPrestadoraServico();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = $"SELECT EmpresaNOmoe FROM EmpresaServicos where EmpresaId ={empresaPrestadora.EmpresaId};";

            adapter = connect.retornaSQL(sql.ToString());
            adapter.Fill(ds);

            empresaPrestadoraTemp.EmpresaId = empresaPrestadora.EmpresaId;
            empresaPrestadoraTemp.EmpresaNome = ds.Tables[0].Rows[0][0].ToString();
            empresaPrestadoraTemp.EmpresaTipoServico = ds.Tables[0].Rows[0][1].ToString();
            empresaPrestadoraTemp.EmpresaTelefone = ds.Tables[0].Rows[0][2].ToString();
            empresaPrestadoraTemp.EmpresaEndereco = ds.Tables[0].Rows[0][3].ToString();
            empresaPrestadoraTemp.EmpresaDescricao = ds.Tables[0].Rows[0][4].ToString();

            return empresaPrestadoraTemp;
        }

        public MySqlDataAdapter selectEmpresaPrestadoraServicoDBase()
        {
            string sql = "SELECT EmpresaId, EmpresaNome, EmpresaTipoServico, EmpresaTelefone , EmpresaEndereco, EmpresaDescricao  FROM EmpresaServicos;";
            return connect.retornaSQL(sql.ToString());
        }
        public DataTable selectEmpresaPrestadoraServicoDBaseGrid()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter = selectEmpresaPrestadoraServicoDBase();
            adapter.Fill(tabela);
            return tabela;
        }
    }
}


