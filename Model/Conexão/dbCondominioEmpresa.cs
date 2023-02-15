//****************************************************************************************
//**Criado por: Geanluca Sampaio de Sousa, Thomas Taino, Aldemir Humberto Soares Neto, Felipe Lopes Silva e Silva
//**Data de Criação: 09/05/2021
//**Instruções: Criação do arquivo
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5.Model.Conexão {
    class dbCondominioEmpresa {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"INSERT INTO pessoa_juridica (CNPJ, Inscricao_Municipal, Inscricao_Estadual) VALUES ('{condominioEmpresa.ceCNPJ}','{condominioEmpresa.ceInscMunicipal}','{condominioEmpresa.ceInscEstadual}')";
            connect.executaSQL(sql);
            int pj_id = Convert.ToInt32(connect.retornaSQL($"SELECT P_Juridica_ID FROM pessoa_juridica WHERE CNPJ = '{condominioEmpresa.ceCNPJ}'"));
            sql = $"INSERT INTO condominio_empresa (P_Juridica_ID, nome, CEP, tpHabit, sindico, tpCond, contato) VALUES ('{pj_id}','{condominioEmpresa.ceNome}','{condominioEmpresa.ceCEP}','{condominioEmpresa.ceTipoHabitacao}', '{condominioEmpresa.ceSindico}','{condominioEmpresa.ceTipoCondominio}','{condominioEmpresa.ceContato}')";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"UPDATE condominio_empresa SET nome = '{condominioEmpresa.ceNome}', CEP = '{condominioEmpresa.ceCEP}', tpHabit = '{condominioEmpresa.ceTipoHabitacao}', sindico = '{condominioEmpresa.ceSindico}', tpCond = '{condominioEmpresa.ceTipoCondominio}', contato = '{condominioEmpresa.ceContato}' WHERE condominioEmpresa.ceId = '{condominioEmpresa.ceId}'";
            connect.executaSQL(sql);
            int pj_id = Convert.ToInt32(connect.retornaSQL($"SELECT P_Juridica_ID FROM pessoa_juridica WHERE CNPJ = '{condominioEmpresa.ceCNPJ}'"));
            sql = $"UPDATE pessoa_juridica SET CNPJ = '{condominioEmpresa.ceCNPJ}', Inscricao_Municipal = '{condominioEmpresa.ceInscMunicipal}', Inscricao_Estadual = '{condominioEmpresa.ceInscEstadual}' WHERE P_Juridica_ID = {pj_id}";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"DELETE FROM pessoa_juridica WHERE CNPJ = '{condominioEmpresa.ceCNPJ}' LIMITE 1";
            sql = $"DELETE FROM condominio_empresa WHERE condominio_empresa.Id = '{condominioEmpresa.ceId}' LIMIT 1";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"SELECT * FROM condominio_empresa c INNER JOIN pessoa_juridica pj on c.P_Juridica_ID = pj.P_Juridica_ID WHERE ceId = '{condominioEmpresa.ceId}';";
            return connect.retornaSQL(sql);
        }

        public classeCondominioEmpresa RetornaDadosObjeto(classeCondominioEmpresa condominioEmpresa) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeCondominioEmpresa condominioEmpresaTemp = new classeCondominioEmpresa();

            string sql = $"SELECT * FROM condominio_empresa c INNER JOIN pessoa_juridica pj on c.P_Juridica_ID = pj.P_Juridica_ID WHERE ceId = '{condominioEmpresa.ceId}';";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            condominioEmpresaTemp.ceId = (condominioEmpresa.ceId);


            return condominioEmpresaTemp;
        }

        public DataTable selectCondominioEmpresaBase() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = $"SELECT * FROM condominio_empresa c INNER JOIN pessoa_juridica pj on c.P_Juridica_ID = pj.P_juridica_ID;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
