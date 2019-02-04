using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    class Banco
    {
        private string nome;
        private List<string> listaAgencia = new List<string>();

        public string Nome { get => nome; set => nome = value; }
        public List<string> ListaAgencia { get => listaAgencia; set => listaAgencia = value; }

        public bool VerificarAgencia(string agencia)
        {
            foreach(string a in ListaAgencia)
            {
                if (agencia.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }
        public void AdicionarAgencia(string agencia)
        {
            ListaAgencia.Add(agencia);
        }
        public bool RemoverAgencia(string agencia)
        {
            foreach (string a in ListaAgencia)
            {
                if (agencia.Equals(a))
                {
                    ListaAgencia.Remove(a);
                    return true;
                }
            }
            return false;
        }
    }
}
