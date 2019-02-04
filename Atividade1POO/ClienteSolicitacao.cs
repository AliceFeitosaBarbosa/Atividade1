using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    class ClienteSolicitacao
    {
        public const string TIPO_DEPOSITO = "DEPOSITO";
        public const string TIPO_SAQUE = "SAQUE";

        private static List<Solicitacao> solicitacoes = new List<Solicitacao>();

        public static void FazerSolicitacao()
        {
            Solicitacao s = new Solicitacao();
            Console.WriteLine("Cpf do cliente: ");
            s.CpfCliente = Console.ReadLine();
            Console.WriteLine("Agencia do cliente");
            s.NumeroAgencia = Console.ReadLine();
            Console.WriteLine("Tipo de transacao 1- Deposito 2- Saque: ");
            int opc = int.Parse( Console.ReadLine());

            if (opc == 1)
            {
                s.TipoT = TIPO_DEPOSITO;
            } else if(opc == 2)
            {
                s.TipoT = TIPO_SAQUE;
            }

            if (s.TipoT.Equals(TIPO_DEPOSITO))
            {
                Console.WriteLine("Banco: ");
                string banco = Console.ReadLine();
                Console.WriteLine("Agencia: ");
                string agencia = Console.ReadLine();

                Banco b = Listas.BuscaBanco(banco);
                if (!b.VerificarAgencia(agencia))
                    return;

                Console.WriteLine("Conta: ");
                string conta = Console.ReadLine();
                Agencia a = Listas.BuscaAgencia(agencia);
                if (!a.VerificarConta(conta))
                    return;

                s.ContaDeposito = conta;

                Console.WriteLine("Digite 1- Conta Corrente 2- Conta Poupanca: ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    ContaCorrente cc = (ContaCorrente) Listas.BuscaConta(conta);
                    Console.WriteLine("Valor a ser Depositado: ");
                    decimal valor = int.Parse(Console.ReadLine());
                    cc.Depositar(valor);
                    s.Valor = valor;
                    Console.WriteLine("Valor atual: " + cc.Saldo);
                }
                else if (opc == 2)
                {
                    ContaPoupanca cp = (ContaPoupanca) Listas.BuscaConta(conta);
                    Console.WriteLine("Valor a ser Depositado: ");
                    decimal valor = int.Parse(Console.ReadLine());
                    cp.Depositar(valor);
                    s.Valor = valor;
                    Console.WriteLine("Valor atual: " + cp.Saldo);
                }
            } else if (s.TipoT.Equals(TIPO_SAQUE))
            {
                Console.WriteLine("Banco: ");
                string banco = Console.ReadLine();
                Console.WriteLine("Agencia: ");
                string agencia = Console.ReadLine();

                Banco b = Listas.BuscaBanco(banco);
                if (!b.VerificarAgencia(agencia))
                    return;

                Console.WriteLine("Conta: ");
                string conta = Console.ReadLine();
                Agencia a = Listas.BuscaAgencia(agencia);
                if (!a.VerificarConta(conta))
                    return;

                s.ContaDeposito = conta;

                Console.WriteLine("Digite 1- Conta Corrente 2- Conta Poupanca: ");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    ContaCorrente cc = (ContaCorrente)Listas.BuscaConta(conta);
                    Console.WriteLine("Valor a ser Sacado: ");
                    decimal valor = int.Parse(Console.ReadLine());
                    cc.Sacar(valor);
                    s.Valor = valor;
                    Console.WriteLine("Valor atual: " + cc.Saldo);
                }
                else if (op == 2)
                {
                    ContaPoupanca cp = (ContaPoupanca)Listas.BuscaConta(conta);
                    Console.WriteLine("Valor a ser Sacado: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    cp.Sacar(valor);
                    s.Valor = valor;
                    Console.WriteLine("Valor atual: " + cp.Saldo);
                }
            }
            solicitacoes.Add(s);
        }
        public static List<Solicitacao> Solicitacoes { get => solicitacoes; set => solicitacoes = value; }
    }
}
