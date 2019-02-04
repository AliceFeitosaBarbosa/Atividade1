using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    class Principal
    {
        public static void Main( String [] args) {

            while (true)
            {
                Console.WriteLine("    Seja Bem Vindo ! ");
                Console.WriteLine("Digite a opcao desejada: ");
                Console.WriteLine("1- Banco  2- Agencia  3- Conta  0- Sair");
                
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine(op);

                if (op == 0)
                {
                    break;
                }

                if (op == 1)
                {
                    Console.WriteLine("----Banco----");
                    Console.WriteLine("1- Criar  2- Remover  3- Buscar  4- Adicionar Agencias  0- Voltar");
                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Listas.AdicionarBanco();
                    } else if (op == 2)
                    {
                        Console.WriteLine("Digite o nome do banco: ");
                        string nome = Console.ReadLine();
                        Listas.RemoverBanco(nome);
                    } else if (op == 3)
                    {
                        Console.WriteLine("Digite o nome do banco: ");
                        string nome = Console.ReadLine();
                        Banco b = Listas.BuscaBanco(nome);
                        if (b == null)
                        {
                            Console.WriteLine("Banco nao encontrado. Tente novamente!\n");
                        } else
                        {
                            Console.WriteLine("Banco: " + b.Nome);
                            Console.WriteLine("Agencia:");
                            for (int i = 0; i < b.ListaAgencia.Count; i++)
                            {
                                Console.WriteLine(Listas.BuscaAgencia(b.ListaAgencia[i]).NumeroAgencia);
                            }
                        }
                    } else if (op == 4)
                    {
                        Console.WriteLine("Digite o nome do banco: ");
                        string banco = Console.ReadLine();
                        Banco b = Listas.BuscaBanco(banco);
                        if (b == null)
                        {
                            Console.WriteLine("Banco nao encontrado.Tente novamente!\n");
                        } else
                        {
                            Console.WriteLine("Digite o numero da agencia: ");
                            string agencia = Console.ReadLine();
                            Agencia a = Listas.BuscaAgencia(agencia);
                            if (a != null)
                            {
                                b.AdicionarAgencia(a.NumeroAgencia);
                            }
                            else
                            {
                                Console.WriteLine("Agencia não encontrada.Tente navamente!\n");
                            }
                        }
                    } else if (op == 0)
                    {
                        continue;
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("----Agencia----");
                    Console.WriteLine("1- Criar  2- Remover  3- Buscar  4- Adicionar Conta  0- Voltar");

                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Listas.AdicionarAgencia();
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Digite o numero da agencia: ");
                        string nome = Console.ReadLine();
                        Listas.RemoverBanco(nome);
                    }
                    else if (op == 3)
                    {
                        Console.WriteLine("Digite o numero da agencia: ");
                        string agencia = Console.ReadLine();
                        Agencia a = Listas.BuscaAgencia(agencia);
                        if (a == null)
                        {
                            Console.WriteLine("Agencia nao encontrada. Tente noavemente!\n");
                        } else
                        {
                            Console.WriteLine("Agencia: " + a.NumeroAgencia);
                            Console.WriteLine("Conta:");
                            Console.WriteLine(a.ListaConta.Count);
                            foreach (String conta in a.ListaConta)
                            {
                                Console.WriteLine("Identificador: " + Listas.BuscaConta(conta).ID + " | Saldo: " + Listas.BuscaConta(conta).Saldo);
                            }
                        }
                    } else if (op == 4)
                    {
                        Console.WriteLine("Digite o numero da agencia:");
                        string agencia = Console.ReadLine();
                        Agencia a = Listas.BuscaAgencia(agencia);
                        if (a == null)
                        {
                            Console.WriteLine("Agencia nao encontrada. Tente navamente!\n");
                        }
                        else
                        {
                            Console.WriteLine("Digite o identificador da conta: ");
                            string conta = Console.ReadLine();
                            Conta c = Listas.BuscaConta(conta);
                            if (c != null)
                            {
                                a.AdicionarConta(c.ID);
                            }
                            else
                            {
                                Console.WriteLine("Conta não encontrada. Tente novamente!\n");
                            }
                        }
                    } else if (op == 0)
                    {
                        continue;
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("----Conta----");
                    Console.WriteLine("1- Criar  2- Remover  3- Buscar  4- Solicitar  0- Voltar");
                
                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Conta c = Listas.AdicionarConta();
                        if (c != null)
                        {
                            Listas.AdicionarCliente(c);
                        }
                    } else if (op == 2)
                    {
                        Console.WriteLine("Digite o nome da conta: ");
                        string conta = Console.ReadLine();
                        Listas.RemoverConta(conta);
                    } else if (op == 3)
                    {
                        Console.WriteLine("Digite o identificador da conta: ");
                        string conta = Console.ReadLine();
                        Conta c = Listas.BuscaConta(conta);
                        if (c == null)
                        {
                            Console.WriteLine("Conta nao encontrada. Tente novamente!\n");
                        } else
                        {
                            Console.WriteLine("ID: " + c.ID);
                            Console.WriteLine("Saldo: " + c.Saldo);
                            Console.WriteLine("Titular: " + c.Titular);
                        }
                    }
                    else if (op == 4)
                    {   
                        ClienteSolicitacao.FazerSolicitacao();
                    }
                    else if (op == 0)
                    {
                        continue;
                    }
                } 
               
            }
        }
    }
}
