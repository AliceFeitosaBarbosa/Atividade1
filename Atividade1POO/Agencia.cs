using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    class Agencia
    {
        private string numeroAgencia;
        private List<string> listaConta = new List<string>();

        public List<string> ListaConta { get => listaConta; set => listaConta = value; }

        public string NumeroAgencia { get => numeroAgencia; set => numeroAgencia = value; }

        public bool VerificarConta(string conta)
        {
            foreach (string c in ListaConta)
            {
                if (conta.Equals(c))
                {
                    return true;
                }

            }
            return false;
        }

        public void AdicionarConta(string conta)
        {
            listaConta.Add(conta);
        }
        public bool RemoverConta(string conta)
        {
            foreach(string c in ListaConta)
            {
                if(conta.Equals(c))
                {
                    ListaConta.Remove(c);
                    return true;
                }
            }
            return false;
        }

    }
}
