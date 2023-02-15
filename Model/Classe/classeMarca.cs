//****************************************************************************************
//**Criado por: Giovanni Marques, Bruno Bragagnolo
//**Data de Criação: 22/04/2021
//**Instruções: Classe referente ao formulário "formMarca".
//
//
//****** Atualizações: criação do set e get
//*** Data:22/04/2021
//*** Responsável:Giovanni Marques
//*****************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_LPRC5
{
    class classeMarca
    {
        private int marcaveiculoid;
        private string marcaveiculonome;

        public classeMarca()
        {

        }
        public void setmarcaveiculoid(int IDmarca)
        {
            marcaveiculoid = IDmarca;
        }

        public int getmarcaveiculoid()
        {
            return marcaveiculoid;
        }

        public void setmarcaveiculonome(string Nomemarca)
        {
           marcaveiculonome = Nomemarca;

        }

        public string getmarcaveiculonome()
        {
            return marcaveiculonome;

        }
    }
}
