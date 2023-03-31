# Estacionamento

**Wendrya Andrade Oliveira**

### Aplicação

Este projeto foi desenvolvido em C# utilizando os princípios de POO.

**Classes**  

    Estacionamento: Guid Id, List<DivisaoVagas> DivisaoVagas
    DivisaoVagas: Guid Id, List<Vaga> Vagas, TipoVagaVeiculo TipoVagaVeiculo, int QtdVagasMax
    Vaga: Guid Id, Veiculo Veiculo
    Veiculo: Guid Id, TipoVagaVeiculo TipoVagaVeiculo

**Enum** 

    TipoVagaVeiculo: Moto, Carro e Van.`

### Funcionalidades

- Exibe a quantidade de vagas totais e vagas restantes no estacionamento
- Exibe se o estacionamento está cheio e se está vazio
- Exibe quando cada divisão de vagas está cheia: moto, carro e van
- Exibe a quantidade de tipo de veículo que está ocupadando vagas: moto, carro e van
- Exibe a quantidade de vagas que cada tipo de veículo está ocupando
