﻿/* Código feito pelo Afonsope */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delete_and_Creat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            string Usu_nome, Usu_telefone, Usu_email;
            string exclhuir = "Drop table usuario";

            Console.WriteLine("+-------------------+");
            Console.WriteLine("| O que deseja ver? |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|1. Castrar-se      |");
            Console.WriteLine("|2. Excluir conta   |");
            Console.Write("|0. ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Sair            ");
            Console.ResetColor();
            Console.WriteLine("|");
            Console.WriteLine("+-------------------+");
            escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (escolha)
            {
                case 1:
                    {
                        Console.Write("Coloque seu nome :");
                        Usu_nome = Console.ReadLine();

                        Console.Write("\n Coloque seu telefone :");
                        Usu_telefone = Console.ReadLine();

                        Console.Write("\n Coloque seu E-mail :");
                        Usu_email = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"Prontinho você ja esta cadastrado em nosso banco de dados\n \n Nome: {Usu_nome} \n Telefone: {Usu_telefone} \n E-mail: {Usu_email}");
                        Console.ReadLine();
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Environment.Exit(0);


                        break;
                    }

                case 2:
                    {
                        Console.Write("Coloque seu nome :");
                        Usu_nome = Console.ReadLine();

                        Console.Write("\n Coloque seu telefone :");
                        Usu_telefone = Console.ReadLine();

                        Console.Write("\n Coloque seu E-mail :");
                        Usu_email = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("Conta deletada");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        break;
                    }

                case 0:
                    {
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Environment.Exit(0);

                        break;
                    }

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Comando não entendido");
                        Console.ResetColor();
                        Console.Clear();

                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(500);
                        Environment.Exit(0);

                        break;
                    }
            }
        }
    }
}
