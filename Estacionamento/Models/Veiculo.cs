using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Veiculo
    {
        public Guid Id { get; set; }
        public TipoVagaVeiculo TipoVagaVeiculo { get; set; }

        public Veiculo(TipoVagaVeiculo tipoVagaVeiculo)
        {
            Id = Guid.NewGuid();
            TipoVagaVeiculo = tipoVagaVeiculo;
        }
    }
}
