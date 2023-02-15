//****************************************************************************************
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Guilherme de Andrade Rissato
//**Data de Criação: 03/05/2021
//**Instruções: Criação da classe dbEncomenda
//
//
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: ajustes dos comandos sql para insercao, atualizacao, select, delete e foram colocadas tres funcoes de pesquisa uma para morador, uma para funcionario e outra para habitacao, pois sao necessarios para o preeenchimento dos combobox no formulario
//*** Data: 23/07/2021
//*** Responsável: Guilherme de Andrade Rissato
//****************************************************************************************
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class dbEncomenda
    {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "INSERT INTO encomenda(destinatario,funcionariorecebeu,dataentrada,datasaida,entregadorempresa,entregueparamorador,habitacao,descricao) VALUES" +
                "(" + encomenda.getdestinatario() + "," + encomenda.getRecebidaPor() + ",'" + encomenda.getDataEntrada().ToString("yyyy/MM/dd")+ "'," +
                "'" + encomenda.getDataSaida().ToString("yyyy/MM/dd") + "','" + encomenda.getEntreguePor().ToString() + "'," + encomenda.getEntreguePara() + "," + encomenda.getHabitacao()+ "," +
                "'" + encomenda.getDescricao().ToString()+ "');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "UPDATE encomenda SET" +
                                " destinatario = " + encomenda.getdestinatario() + "," +
                                "funcionariorecebeu = " + encomenda.getRecebidaPor()  + "," +
                                "dataentrada = '" + encomenda.getDataEntrada().ToString("yyyy/MM/dd") + "'," +
                                "datasaida = '" + encomenda.getDataSaida().ToString("yyyy/MM/dd") + "'," +
                                "entregadorempresa = '" + encomenda.getEntreguePor().ToString() + "'," +
                                "entregueparamorador = " + encomenda.getEntreguePara() + "," +
                                "habitacao = " + encomenda.getHabitacao() + "," +
                                "descricao = '" + encomenda.getDescricao().ToString() + "' " +
                                " WHERE encomendaid = "+ encomenda.getCodigo() + ";";
            ;
            connect.executaSQL(sql);
        }

        public void excluiEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "DELETE FROM encomenda WHERE encomendaid =" + encomenda.getCodigo() + ";";
            connect.executaSQL(sql);
        }

        public MySqlDataAdapter selectEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "SELECT * FROM encomenda WHERE encomendaid =" + encomenda.getCodigo() + ";";
            return connect.retornaSQL(sql);
        }

        public classeEncomendas RetornaDadosObjeto(classeEncomendas encomenda)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeEncomendas EncomendaTemp = new classeEncomendas();

            string sql = "select * from encomenda where encomendaid = " + encomenda.getCodigo() + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            EncomendaTemp.setCodigo(encomenda.getCodigo());
            EncomendaTemp.setDestinatario(Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()));
            EncomendaTemp.setRecebidaPor(Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString()));
            EncomendaTemp.setDataEntrada(Convert.ToDateTime(ds.Tables[0].Rows[0][3].ToString()));
            EncomendaTemp.setDataSaida(Convert.ToDateTime(ds.Tables[0].Rows[0][4].ToString()));
            EncomendaTemp.setEntreguePor(ds.Tables[0].Rows[0][5].ToString());
            EncomendaTemp.setEntreguePara(Convert.ToInt32(ds.Tables[0].Rows[0][6].ToString()));
            EncomendaTemp.setHabitacao(Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString()));
            EncomendaTemp.setDescricao(ds.Tables[0].Rows[0][8].ToString());

            return EncomendaTemp;
        }

        public DataTable selectEncomendaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select e.encomendaid, p.nome_registro, h.numero from encomenda as e inner join morador as m inner join pessoa_fisica as pf inner join pessoa as p on pf.pessoa_id = p.pessoa_id on m.idpessoa_fisica = pf.p_fisica_id right join habitacao as h on m.habitacao_id = h.habitacao_id on e.destinatario = m.morador_id;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }

        public DataTable selectMorador() {
            DataTable dtMorador = new DataTable();
            MySqlDataAdapter adapterMorador = new MySqlDataAdapter();
            string sql = "select m.morador_id, p.nome_registro from encomenda as e inner join morador as m inner join pessoa_fisica as pf inner join pessoa as p on pf.pessoa_id = p.pessoa_id on m.idpessoa_fisica = pf.p_fisica_id on e.destinatario = m.morador_id;";
            connect.executaSQL(sql.ToString());
            adapterMorador = connect.retornaSQL(sql);
            adapterMorador.Fill(dtMorador);


            return dtMorador;
        }
        public DataTable selectFuncionario()
        {
            DataTable dtFuncionario = new DataTable();
            MySqlDataAdapter adapterFuncionario = new MySqlDataAdapter();
            
            string sql = "select f.idfuncionario, p.nome_registro from encomenda as e inner join funcionario as f inner join pessoa_fisica as pf inner join pessoa as p on pf.pessoa_id = p.pessoa_id on f.idpessoa_fisica = pf.p_fisica_id on e.funcionariorecebeu = f.idfuncionario;";

            connect.executaSQL(sql.ToString());
            adapterFuncionario = connect.retornaSQL(sql);
            adapterFuncionario.Fill(dtFuncionario);

            return dtFuncionario;
        }
        public DataTable selectHabitacao()
        {
            DataTable dtHabitacao = new DataTable();
            MySqlDataAdapter adapterHabitacao = new MySqlDataAdapter();

            string sql = "select habitacao_id, numero from habitacao;";

            connect.executaSQL(sql.ToString());
            adapterHabitacao = connect.retornaSQL(sql);
            adapterHabitacao.Fill(dtHabitacao);

            return dtHabitacao;
        }
    }
}
