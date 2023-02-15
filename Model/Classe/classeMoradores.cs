//****************************************************************************************
//**Criado por: Alexandro Junior, Caique Bruno e Guilherme Beig
//**Data de Criação: 22/07/2021
//**Instruções: Criação da classe Moradores completa
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Projeto_LPRC5.Model.Classe;
using Projeto_LPRC5.Model.Conexão;



namespace Projeto_LPRC5.Model.Classe
{
    class classeMoradores : classePessoaFisica
    {
        dbMoradores moradores = new dbMoradores();
        private Int16 moradores_id;
        private Int16 habitacao_id;
        
        public classeMoradores()
        {
        
        }
        public Int16 getMoradoresId()
        {
            return moradores_id;
        }

        public void setMoradoresId(Int16 MoradoresId) 
        {

            moradores_id = MoradoresId;

        }

        public Int16 getHabitacaoId()
        {
            return habitacao_id;
        }

        public void setHabitacaoId(Int16 HabitacaoId)
        {
            habitacao_id = HabitacaoId;
        }

        public virtual void atualizaMoradores(string operacao)
        {
            switch (operacao)
            {
                case "inserir":
                    moradores.insereMoradoresBase(getPessoaNomeRegistro(), getPessoaNomeSocial(), getPessoaEmail(),cpf,rg,getHabitacaoId());
                    
                break;

                case "alterar":
                    moradores.alteraMoradoresBase(getPessoaID(),getPessoaNomeRegistro(), getPessoaNomeSocial(), getPessoaEmail(), cpf, rg, getHabitacaoId());

                    break;

                case "deletar":
                    moradores.excluiMoradoresBase(getPessoaID());

                    break;
                
                default:
                    break;
            }
        }

        public MySqlDataAdapter daRetornaMoradores()
        {
            return moradores.selectMoradoresBase(getPessoaID());
        }

        public DataTable dtRetornaMoradores()
        {
            return moradores.selectMoradoresBase();
        }

        public classeMoradores objRetornaMoradores(classeMoradores morad)
        {
            return moradores.RetornaDadosObjeto(morad);
        }

    }
}
