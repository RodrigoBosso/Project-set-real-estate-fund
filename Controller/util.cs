//****************************************************************************************
//**Criado por: Alessandro Viola 
//**Data de Criação: 12/04/2021
//**Descrição: 
// Contém Funções úteis para o gerenciamento e configurção das funcionalidades implementadas 
// de uso geral para o Software
//**Instruções:
// 
// 
//****** Atualizações:
//*** Data: 13/04/2021
//*** Responsável: Alessandro Viola
//*** O que feito:
// Inclusão da informação para guardar o SGBD Selecionado.
//*** Data: 14/04/2021
//*** Responsável: Caique, Guilherme, Alexandro
//*** O que feito:
//  Botão Salvar exibe mensagem de confirmação e limpa campos, botão cancelar fecha frame Acesso.
//*** Data:
//*** Responsável:
//*** O que feito:
// 
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_LPRC5
{
    public static class util
    {
        public static string servidor = "";
        public static string usuario = "";
        public static string senha = "";
        public static string banco = "";
        public static Int16 sgbd_Id = -1;
        private static string path = "C:\\software\\acesso.txt";

        public static Int16 usuarioAtual;


        public static void lerArquivoAcessoBanco()
        {
            string linha = "";
            if (System.IO.File.Exists(path))
            {
                StreamReader texto = new StreamReader(path);
                while (texto.EndOfStream == false)
                {
                    linha = texto.ReadLine().ToString();
                    if (linha.Contains("servidor="))
                    {
                        servidor = linha.Substring(9, linha.IndexOf(";") - 9);
                    }
                    else if (linha.Contains("usuario="))
                    {
                        usuario = linha.Substring(8, linha.IndexOf(";") - 8);
                    }
                    else if (linha.Contains("banco="))
                    {
                        banco = linha.Substring(6, linha.IndexOf(";") - 6);
                    }
                    else if (linha.Contains("senha="))
                    {
                        senha = linha.Substring(6, linha.IndexOf(";") - 6);
                    }
                    else if (linha.Contains("sgbd="))
                    {
                        sgbd_Id = Convert.ToInt16(linha.Substring(5, linha.IndexOf(";") - 5));
                    }
                }
                texto.Close();
            }
        }

        public static void gravaArquivoAcessoBanco(string servidor, string usuario, string banco, string senha, Int16 sgbd)
        {
            StreamWriter texto = new StreamWriter(path);
            texto.WriteLine("servidor=" + servidor + ";");
            texto.WriteLine("usuario=" + usuario + ";");
            texto.WriteLine("banco=" + banco + ";");
            texto.WriteLine("senha=" + senha + ";");
            texto.WriteLine("sgbd=" + sgbd.ToString() + ";");
            texto.Close();
        }

        private static string salvaPictureArquivo(PictureBox imagem, string destinoPath)
        {
            //string arquivo = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            string arquivo = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";

            imagem.Image.Save(destinoPath + "\\" + arquivo, System.Drawing.Imaging.ImageFormat.Jpeg);

            return arquivo;
        }

        public static string decriptografaDados(string info)
        {

            return info;
        }

        public static string criptografaDados(string info)
        {

            return info;
        }

        public static Int16 loginAcesso(string login, string senha)
        {
            dbFuncionario funcionario = new dbFuncionario();
            return funcionario.RetornaDadosObjeto(login, senha);
        }

        public static bool verificaPermissao(Int16 usuarioCodigo, Int16 tagFormCodigo, Int16 tagOpcaoCodigo)
        {
            bool retorno;
            if (usuarioCodigo == -1)
            {
                retorno = false;
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
