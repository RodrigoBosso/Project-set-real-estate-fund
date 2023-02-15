//****************************************************************************************
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Roberto Marcheti Neto
//**Data de Criação: 03/05/2021
//**Instruções: Criação dos getters and setters do objeto frmEncomendas
//
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações:ajuste de variaveis
//*** Data:03/05/2021
//*** Responsável:Guilherme de Andrade Rissato
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações:ajuste dos tipos das variaveis
//*** Data:03/05/2021
//*** Responsável:Roberto Marcheti Neto
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeEncomendas
    {
        private int codigo;
        private int destinatario;
        private int recebidaPor;
        private DateTime dataEntrada;
        private string entreguePor;
        private DateTime dataSaida;
        private int entreguePara;
        private int habitacao;
        private string descricao;


        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int getCodigo() {
            return codigo;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return descricao;
        }
        public void setDestinatario(int destina)
        {
            destinatario = destina;
        }

        public int getdestinatario()
        {
            return destinatario;
        }
        public void setRecebidaPor(int recepor)
        {
            recebidaPor = recepor;
        }

        public int getRecebidaPor()
        {
            return recebidaPor;
        }
        public void setDataEntrada(DateTime datentra)
        {
            dataEntrada = datentra;
        }

        public DateTime getDataEntrada()
        {
            return dataEntrada;
        }
        public void setEntreguePor(string entrepor)
        {
            entreguePor = entrepor;
        }

        public string getEntreguePor()
        {
            return entreguePor;
        }
        public void setDataSaida(DateTime datesai)
        {
            dataSaida = datesai;
        }

        public DateTime getDataSaida()
        {
            return dataSaida;
        }
        public void setEntreguePara(int entrepara)
        {
            entreguePara = entrepara;
        }

        public int getEntreguePara()
        {
            return entreguePara;
        }
        public void setHabitacao(int habitacao)
        {
            this.habitacao = habitacao;
        }

        public int getHabitacao()
        {
            return habitacao;
        }
    }
}
    

