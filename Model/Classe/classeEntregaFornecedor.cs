//****************************************************************************************
//**Criado por: Daniel Galdencio, Antonio Naranjo, Rafael de Angelis Fogaça e Letícia Lopes Abelha
//**Data de Criação: 09/05/2021 
//**Instruções: Criação dos aributos e dos métodos acessores da classe
//
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Classe
{
    class classeEntregaFornecedor
    {

		//Métodos Acessores
		public int fornecedor { get; set; }
		public int condominio { get; set; }
		public int funcionario_remetente { get; set; }
		public string data_entrega { get; set; }
		public string horario_entrega { get; set; }



	}
}
