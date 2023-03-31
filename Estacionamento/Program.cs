using System;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            //Criando Divisão de Vagas
            DivisaoVagas divisaoVagasCarros = new DivisaoVagas(TipoVagaVeiculo.Carro, 50); 
            DivisaoVagas divisaoVagasMotos = new DivisaoVagas(TipoVagaVeiculo.Moto, 30);
            DivisaoVagas divisaoVagasVans = new DivisaoVagas(TipoVagaVeiculo.Van, 20);

            //Adicionando Divisão de Vagas no Estacionamento
            estacionamento.DivisaoVagas.Add(divisaoVagasCarros);
            estacionamento.DivisaoVagas.Add(divisaoVagasMotos);
            estacionamento.DivisaoVagas.Add(divisaoVagasVans);

            //Criando Veículos
            Veiculo carro1 = new Veiculo(TipoVagaVeiculo.Carro);
            Veiculo carro2 = new Veiculo(TipoVagaVeiculo.Carro);
            Veiculo carro3 = new Veiculo(TipoVagaVeiculo.Carro);

            Veiculo moto1 = new Veiculo(TipoVagaVeiculo.Moto);
            Veiculo moto2 = new Veiculo(TipoVagaVeiculo.Moto);

            Veiculo van1 = new Veiculo(TipoVagaVeiculo.Van);
            Veiculo van2 = new Veiculo(TipoVagaVeiculo.Van);

            //Estacionar veiculos
            estacionamento.EstacionarVeiculo(carro1, TipoVagaVeiculo.Carro);
            estacionamento.EstacionarVeiculo(carro2, TipoVagaVeiculo.Moto);
            estacionamento.EstacionarVeiculo(carro3, TipoVagaVeiculo.Van);

            estacionamento.EstacionarVeiculo(moto1, TipoVagaVeiculo.Moto);
            estacionamento.EstacionarVeiculo(moto2, TipoVagaVeiculo.Carro);

            estacionamento.EstacionarVeiculo(van1, TipoVagaVeiculo.Van);
            estacionamento.EstacionarVeiculo(van2, TipoVagaVeiculo.Carro);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============");
            Console.WriteLine("ESTACIONAMENTO");
            Console.WriteLine("==============");
            Console.WriteLine();

            Console.WriteLine("Vagas totais");
            Console.WriteLine(estacionamento.BuscarVagasTotais());
            Console.WriteLine();

            Console.WriteLine("Vagas restantes");
            Console.WriteLine(estacionamento.BuscarVagasRestantes());
            Console.WriteLine();

            Console.WriteLine("Estacionamento cheio?");
            Console.WriteLine(estacionamento.EstacionamentoCheio() ? "Sim" : "Não");
            Console.WriteLine();

            Console.WriteLine("Estacionamento vazio?");
            Console.WriteLine(estacionamento.EstacionamentoVazio() ? "Sim" : "Não");
            Console.WriteLine();

            Console.WriteLine("Vagas Cheias?");
            Console.WriteLine(estacionamento.ExibirDivisaoVagasCheia());
            Console.WriteLine();

            Console.WriteLine("Vagas Ocupadas");
            Console.WriteLine(estacionamento.ExibirDivisaoVagasOcupadas());

            Console.WriteLine("Quantidade de veículos estacionados:");
            Console.WriteLine(estacionamento.ExibirQtdVeiculosEstacionados());

            Console.ReadKey();
        }
    }
}
