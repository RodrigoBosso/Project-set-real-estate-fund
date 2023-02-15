

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Classe
{
    class ClasseHabitacao
    {
        private int idHabitacao;
        private string rua;
        private string bloco;
        private int numero;

        public int getidHabitacao()
        {
            return idHabitacao;
        }

        public void setidHabitacao(int newValue)
        {
            idHabitacao = newValue;
        }

        public string getrua()
        {
            return rua;
        }

        public void setrua(string newValue)
        {
            rua = newValue;
        }

        public string getbloco()
        {
            return bloco;
        }

        public void setbloco(string newValue)
        {
            bloco = newValue;
        }

        public int getnumero()
        {
            return numero;
        }

        public void setnumero(int newValue)
        {
            numero = newValue;
        }

    }
}
