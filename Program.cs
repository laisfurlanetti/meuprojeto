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
            tring cad1, email;

            List<string> listaemail = new List<string>();
            List<int> listasenha = new List<int>();


            //tela1
            Console.Write("BEM VINDO MIGUS!\n");

            //tela2

            Cadastro();

            Console.WriteLine("DESEJA REALIZAR UM NOVO CADASTRO?");
            cad1 = Console.ReadLine();
            Console.Clear();

            while (cad1 == "sim")
            {
                Cadastro();
                Console.WriteLine("DESEJA REALIZAR UM NOVO CADASTRO?");
                cad1 = Console.ReadLine();
                Console.Clear();
            }
            if (cad1 == "nao")
            {
                Login(email);

            }

            if (email != listaemail)
            {
                Console.Write("Dados invalidos, tente novamente");
                Login(email);
            }



            //tela3



            Console.ReadLine();
        }
        public static void Cadastro()
        {
            int senha, senha2;
            string nome, email;
            List<string> listaemail = new List<string>();
            List<int> listasenha = new List<int>();

            Console.WriteLine("CRIAR SUA CONTA");
            Console.Write("NOME: ");
            nome = Console.ReadLine();
            Console.Write("E-MAIL: ");
            email = Console.ReadLine();
            listaemail.Add(email);
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
            listasenha.Add(senha);
            Console.Clear();
        }
        public static void Login (string email)
        {
            List<string> listaemail = new List<string>();
            List<int> listasenha = new List<int>();
            int senha;
            Console.WriteLine("LOGIN");
            Console.Write("E-MAIL: ");
            email = Console.ReadLine();
            listaemail.Contains(email);
            Console.Write("SENHA: ");
            senha = Convert.ToInt32(Console.ReadLine());
            listasenha.Contains(senha);
        }
    }
}
