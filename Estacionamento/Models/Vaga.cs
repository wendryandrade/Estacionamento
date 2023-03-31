using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Vaga
    {
        public Guid Id { get; set; }
        public Veiculo Veiculo { get; set; }

        public Vaga(Veiculo veiculo)
        {
            Id = Guid.NewGuid();
            Veiculo = veiculo;
        }
    }
}
