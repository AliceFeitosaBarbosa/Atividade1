using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    class Solicitacao
    {
        private string cpfCliente;
        private string numeroAgencia;
        private string contaSaque;
        private string contaDeposito;
        private string tipoT;
        private decimal valor;


        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }  
        public string NumeroAgencia { get => numeroAgencia; set => numeroAgencia = value; }
        public string ContaSaque { get => contaSaque; set => contaSaque = value; }
        public string ContaDeposito { get => contaDeposito; set => contaDeposito = value; }
        public string TipoT { get => tipoT; set => tipoT = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}
