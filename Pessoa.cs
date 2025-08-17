using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem_de_Hotel
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            _nome = nome;
            _sobrenome = sobrenome;
        }

        private string _nome;

        public string Nome { get => _nome; set => _nome = value; }

        private string _sobrenome;
        public string Sobrenome { get => _sobrenome; set => _sobrenome = value; }

    }
}