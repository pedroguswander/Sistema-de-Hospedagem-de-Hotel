
using Sistema_de_Hospedagem_de_Hotel;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>();
        hospedes.Add(new Pessoa(nome: "Pedro", sobrenome: "Gus"));
        hospedes.Add(new Pessoa(nome: "Lucas", sobrenome: "Gal"));

        Suite suite = new Suite(tipoSuite: "LUXO", capacidade: 3, valorDiaria: 100m);

        Reserva reserva = new Reserva(diasReservados: 10);
        
        reserva.cadastrarSuite(suite);
        reserva.cadastrarHospedes(hospedes);

        Console.WriteLine($"{reserva.calcularValorDiaria()}");
    }
}