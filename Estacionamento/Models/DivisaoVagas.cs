using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class DivisaoVagas
    {
        public Guid Id { get; set; }
        public List<Vaga> Vagas { get; set; }
        public TipoVagaVeiculo TipoVagaVeiculo { get; set; }
        public int QtdVagasMax { get; set; }

        public DivisaoVagas(TipoVagaVeiculo tipoVagaVeiculo, int qtdVagasMax)
        {
            Id = Guid.NewGuid();
            Vagas = new List<Vaga>();
            TipoVagaVeiculo = tipoVagaVeiculo;
            QtdVagasMax = qtdVagasMax;
        }

        public int BuscarQtdVagasOcupadas()
        {
            int vagasOcupadas = 0;

            foreach (Vaga vaga in this.Vagas)
            { 
                if (vaga.Veiculo.TipoVagaVeiculo == TipoVagaVeiculo.Carro ||
                    vaga.Veiculo.TipoVagaVeiculo == TipoVagaVeiculo.Moto)
                {
                    vagasOcupadas++;
                }

                else if (vaga.Veiculo.TipoVagaVeiculo == TipoVagaVeiculo.Van)
                {
                    if (this.TipoVagaVeiculo == TipoVagaVeiculo.Van)
                        vagasOcupadas++;
                    else
                        vagasOcupadas = vagasOcupadas + 3;
                }
            }

            return vagasOcupadas;
        }

        public bool DivisaoVagasCheia()
        {
            int vagasOcupadas = BuscarQtdVagasOcupadas();

            if (this.QtdVagasMax == vagasOcupadas)
                return true;
            else
                return false;
        }

        public bool DivisaoVagasVazia()
        {
            int vagasOcupadas = BuscarQtdVagasOcupadas();

            if (vagasOcupadas == 0)
                return true;
            else
                return false;
        }
    }
}
