using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem_de_Hotel
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            _diasReservados = diasReservados;
        }

        private Suite _suite;
        public Suite Suite { get => _suite; }

        public void cadastrarSuite(Suite suite)
        {
            _suite = suite;
        }

        private List<Pessoa> _hospedes;

        public string cadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > _suite.Capacidade) return "Capacidade ultrapassada!!";
            _hospedes = hospedes;
            return "Hospedes cadastrados!";
        }

        public int obterQuantidadeHospedes()
        {
            return _hospedes.Count;
        }

        private int _diasReservados;
        public int DiasReservados { get => _diasReservados; set => _diasReservados = value; }

        public decimal calcularValorDiaria()
        {
            if (_diasReservados > 10) return _suite.ValorDiaria * _diasReservados * 0.9m;
            return _suite.ValorDiaria * _diasReservados;
        }
    }
}