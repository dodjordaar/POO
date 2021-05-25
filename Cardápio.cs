using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class Cardápio
    {
        public string nome, descricao;
        public float valor;
        public Cardápio(string nome, string descricao, int valor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}
