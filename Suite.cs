using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem_de_Hotel
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria; 
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }

        private decimal _valorDiaria;
        public decimal ValorDiaria { get => _valorDiaria; set => _valorDiaria = value; }
    }
}