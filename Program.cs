using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "", cad1;
            int senha = 0, opicao = 0;
            List<string> listaEmail = new List<string>();
            List<int> listaSenha = new List<int>();
            List<string> listaModelo = new List<string>();
            List<int> listaCor = new List<int>();
            List<int> listaTex = new List<int>();

            #region Cadastro e Login
            //tela1
            Console.Write("BEM VINDO MIGUS!\n");

            //tela2
            Cadastro(listaEmail, listaSenha);

            Console.WriteLine("DESEJA REALIZAR UM NOVO CADASTRO?");
            cad1 = Console.ReadLine();
            Console.Clear();

            while (cad1 == "sim")
            {
                Cadastro(listaEmail, listaSenha);
                Console.WriteLine("DESEJA REALIZAR UM NOVO CADASTRO?");
                cad1 = Console.ReadLine();
                Console.Clear();
            }

            if (cad1 == "nao")
            {
                Login(listaEmail, listaSenha);
                //bool emailCorreto = listaEmail.Contains(email);
                //while (emailCorreto)
                //{
                    //Login(listaEmail, listaSenha);
                    int posicao = listaSenha.FindIndex(x => x == senha);

                    if (senha == listaSenha[posicao])
                    {
                        Menu(opicao);
                    }
                    else
                    {
                        for (int i = 0; listaSenha.Contains(senha); i++)
                            Console.Write("SENHA INCORRETA");
                    }
                //}
            }
            Console.Clear();
            #endregion

            //tela3
            Menu(opicao);
            if(opicao == 1)
            {
                Material(opicao, listaModelo, listaCor, listaTex);

            }

            Console.Write("DESEJA CADASTRAR UM NOVO MATERIAL? ");
            string novo = Console.ReadLine();
            while (novo == "sim")
            {
                Material(opicao, listaModelo, listaCor, listaTex);
            }
            if(novo == "nao")
            {
                Menu(opicao);
            }
            Console.ReadLine();
        }
        public static void Cadastro(List<string> listaEmail, List<int> listaSenha)
        {
            int senha, senha2;
            string nome, email;

            Console.WriteLine("CRIAR SUA CONTA");
            Console.Write("NOME: ");
            nome = Console.ReadLine();
            Console.Write("E-MAIL: ");
            email = Console.ReadLine();
            listaEmail.Add(email);
            Console.Write("SENHA: ");
            senha = Convert.ToInt32(Console.ReadLine());
            Console.Write("CONFIRME SUA SENHA: ");
            senha2 = Convert.ToInt32(Console.ReadLine());

            while (senha != senha2)
            {
                Console.Write("As Senhas nao correspondem \n");
                Console.Write("CONFIRME SUA SENHA NOVAMENTE: ");
                senha2 = Convert.ToInt32(Console.ReadLine());
            }
            listaSenha.Add(senha);
            Console.Clear();
        }
        public static void Login(List<string> listaEmail, List<int> listaSenha)
        {
            string email;
            int senha;
            Console.WriteLine("LOGIN");
            Console.Write("E-MAIL: ");
            email = Console.ReadLine();
            listaEmail.Contains(email);
            Console.Write("SENHA: ");
            senha = Convert.ToInt32(Console.ReadLine());
            listaSenha.Contains(senha);
        }
        public static void Material(int opicao, List<string>listaModelo, List<int>listaCor, List<int>listaTex)
        {
            Console.Write("MODELO: ");
            string modelo = Console.ReadLine();
            listaModelo.Add(modelo);
            Console.Write("COR: ");
            int cor = Convert.ToInt32(Console.ReadLine());
            listaCor.Add(cor);
            Console.Write("TEX: ");
            int tex = Convert.ToInt32(Console.ReadLine());
            listaTex.Add(tex);
            Console.Clear();
            Console.WriteLine("ITEM CADASTRADO");
          
        }
        public static void Menu(int opicao)
        {
            Console.Write("1- CADASTRAR MATERIAL\n" +
                 "2 - CADASTRAR VENDA");
            opicao = Convert.ToInt32(Console.ReadLine());
        }

    }
}
