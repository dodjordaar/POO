using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class Restaurante
    {
        public string nome, cnpj, cidade, endereco;
        public List<Cardápio> cardápios;
        public Restaurante(string nome, string cnpj, string cidade, string endereco)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.cidade = cidade;
            this.endereco = endereco;
        }
    }
}
