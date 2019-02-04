using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Atividade1POO
{
    class Listas
    {
        private static List<Conta> contas = new List<Conta>();
        private static List<Banco> bancos = new List<Banco>();
        private static List<Agencia> agencias = new List<Agencia>();
        private static List<Cliente> clientes = new List<Cliente>();
        
        public static List<Conta> Contas { get => contas; set => contas = value; }
        public static List<Banco> Bancos { get => bancos; set => bancos = value; }
        public static List<Agencia> Agencias { get => agencias; set => agencias = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public static Conta BuscaConta(string c)
        {
            foreach(Conta conta in contas)
            {
                if (conta.ID.Equals(c))
                {
                    return conta;
                }
            }
            return null;            
        }

        public static Conta AdicionarConta()
        {
            Console.WriteLine("1- Conta Corrente 2- Conta Poupanca ");
            int op = int.Parse(Console.ReadLine());

            if(op == 1)
            {
                Console.WriteLine("Digite o nome do titular: ");
                string nome = Console.ReadLine();
                Conta c = Listas.BuscaConta(nome);
                if (c != null)
                {
                    Console.WriteLine("Conta ja existe. Tente navamente!\n");
                    return null;
                }
                ContaCorrente cc = new ContaCorrente(nome);
                contas.Add(cc);
                return cc;
            } else if (op == 2)
            {
                Console.WriteLine("Digite o nome do titular: ");
                string nome = Console.ReadLine();
                Conta c = Listas.BuscaConta(nome);
                if (c != null)
                {
                    Console.WriteLine("Conta ja existe. Tente novamente!\n");
                    return null;
                }
                Console.WriteLine("Digite sua data de aniversario: ");
                string niver = Console.ReadLine();
                ContaPoupanca cp = new ContaPoupanca(ContaPoupanca.JUROS, DateTime.ParseExact(niver, "dd/MM/yyyy", CultureInfo.InvariantCulture), nome);
                contas.Add(cp);
                return cp;
            } else
            {
                return null;
            }
        }

        public static bool RemoverConta(string t)
        {
            foreach(Conta c in contas)
            {
                if (c.ID.Equals(t))
                {
                    contas.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public static Banco BuscaBanco(string b)
        {
            foreach (Banco banco in bancos)
            {
                if (banco.Nome.Equals(b))
                {
                    return banco;
                }
            }
            return null;
        }

        public static void AdicionarBanco()
        {
            Console.WriteLine("Digite o nome do banco: ");
            string nome = Console.ReadLine();

            Banco banco = new Banco();
            banco.Nome = nome;

            bancos.Add(banco);

        }

        public static bool RemoverBanco(string n)
        {
            
            foreach (Banco b in bancos)
            {
                if (b.Nome.Equals(n))
                {
                    bancos.Remove(b);
                    return true;
                }
            }
            return false;
        }


        public static Agencia BuscaAgencia(string a)
        {
            foreach (Agencia agencia in agencias)
            {
                if (agencia.NumeroAgencia.Equals(a))
                {
                    return agencia;
                }
            }
            return null;
        }

        public static void AdicionarAgencia()
        {
            Console.WriteLine("Digite o numero da agencia: ");
            string numero = Console.ReadLine();

            Agencia agencia = new Agencia();
            agencia.NumeroAgencia = numero;

            agencias.Add(agencia);
        }

        public static bool RemoverAgencia(string n)
        {
            foreach (Agencia a in agencias)
            {
                if (a.NumeroAgencia.Equals(n))
                {
                    agencias.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public static Cliente BuscaCliente(string c)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Cpf.Equals(c))
                {
                    return cliente;
                }
            }
            return null;
        }

        public static void AdicionarCliente(Conta c)
        {
            Console.WriteLine("Digite nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite cpf: ");
            string cpf = Console.ReadLine();

            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.Conta = c.ID;

            clientes.Add(cliente);
        }

        public static bool RemoverCliente(string cpf)
        {
            foreach (Cliente c in clientes)
            {
                if (c.Cpf.Equals(cpf))
                {
                    clientes.Remove(c);
                    return true;
                }
            }
            return false;
        }
    }
}
