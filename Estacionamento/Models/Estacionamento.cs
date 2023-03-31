using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Estacionamento
    {
        public Guid Id { get; set; }
        public List<DivisaoVagas> DivisaoVagas { get; set; }

        public Estacionamento()
        {
            Id = Guid.NewGuid();
            DivisaoVagas = new List<DivisaoVagas>();
        }

        public void EstacionarVeiculo(Veiculo veiculo, TipoVagaVeiculo tipoVagaVeiculo)
        {
            Vaga vaga = new Vaga(veiculo);
            DivisaoVagas divisaoVagas = BuscarDivisaoVagasPorTipo(tipoVagaVeiculo);
            
            if (!divisaoVagas.DivisaoVagasCheia() &&
               ((veiculo.TipoVagaVeiculo == TipoVagaVeiculo.Carro && tipoVagaVeiculo != TipoVagaVeiculo.Moto) ||
                (veiculo.TipoVagaVeiculo == TipoVagaVeiculo.Van && tipoVagaVeiculo != TipoVagaVeiculo.Moto) ||
                (veiculo.TipoVagaVeiculo == TipoVagaVeiculo.Moto)))
            {
                divisaoVagas.Vagas.Add(vaga);
            }     
        }

        public bool EstacionamentoCheio()
        {
            foreach (DivisaoVagas divisaoVagas in this.DivisaoVagas)
            {
                if (!divisaoVagas.DivisaoVagasCheia())
                    return false;     
            }

            return true;
        }

        public bool EstacionamentoVazio()
        {
            foreach (DivisaoVagas divisaoVagas in this.DivisaoVagas)
            {
                if (!divisaoVagas.DivisaoVagasVazia())
                    return false;
            }

            return true;
        }

        public int BuscarVagasTotais()
        {
            int vagasTotais = 0;

            foreach (DivisaoVagas divisaoVagas in this.DivisaoVagas)
            {
                vagasTotais += divisaoVagas.QtdVagasMax;
            }

            return vagasTotais;
        }

        public int BuscarVagasOcupadas()
        {
            int vagasOcupadas = 0;

            foreach (DivisaoVagas divisaoVagas in this.DivisaoVagas)
            {
                vagasOcupadas += divisaoVagas.BuscarQtdVagasOcupadas();
            }

            return vagasOcupadas;
        }

        public int BuscarVagasRestantes()
        {
            return BuscarVagasTotais() - BuscarVagasOcupadas();
        }

        public string ExibirDivisaoVagasCheia()
        {
            string texto = "";

            foreach (DivisaoVagas divisaoVagas in this.DivisaoVagas)
            {
                if (divisaoVagas.DivisaoVagasCheia())
                {
                    texto += "Vagas de " + divisaoVagas.TipoVagaVeiculo.ToString().ToLower() + " estão cheias \n";
                }
                else
                {
                    texto += "Vagas de " + divisaoVagas.TipoVagaVeiculo.ToString().ToLower() + " não estão cheias \n";
                }
            }

            return texto;
        }

        public string ExibirDivisaoVagasOcupadas()
        {
            string texto = "";

            foreach (DivisaoVagas divisaoVagas in this.DivisaoVagas)
            {
                divisaoVagas.BuscarQtdVagasOcupadas();

                texto += divisaoVagas.BuscarQtdVagasOcupadas() + " vagas de " + divisaoVagas.TipoVagaVeiculo.ToString().ToLower() + " estão ocupadas \n";
            }

            return texto;
        }

        public string ExibirQtdVeiculosEstacionados()
        {
            string texto = "";
            int qtdMoto = 0, qtdCarro = 0, qtdVan = 0;

            foreach (DivisaoVagas divisaoVagas in this.DivisaoVagas)
            {
                foreach (Vaga vaga in divisaoVagas.Vagas)
                {
                    switch (vaga.Veiculo.TipoVagaVeiculo)
                    {
                        case TipoVagaVeiculo.Moto:
                            qtdMoto++;
                            break;

                        case TipoVagaVeiculo.Carro:
                            qtdCarro++;
                            break;

                        case TipoVagaVeiculo.Van:
                            qtdVan++;
                            break;
                    }
                }
            }

            texto += qtdMoto + " vagas ocupadas por motos \n";
            texto += qtdCarro + " vagas ocupadas por carros \n";
            texto += qtdVan + " vagas ocupadas por vans \n";

            return texto;
        }

        public DivisaoVagas BuscarDivisaoVagasPorTipo(TipoVagaVeiculo tipoVagaVeiculo)
        {
            DivisaoVagas divisaoVagas = this.DivisaoVagas
                .Where(divisaoVagas => divisaoVagas.TipoVagaVeiculo == tipoVagaVeiculo).FirstOrDefault();

            return divisaoVagas;
        }
    }
}