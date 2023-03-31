# Estacionamento

**Wendrya Andrade Oliveira**

### Aplicação

Este projeto Estacionamento foi desenvolvido em C# utilizando os princípios de POO.

O estacionamento possui vagas para motos, carros e vans. 

- Moto pode estacionar em qualquer vaga
- Carro pode estacionar apenas em vaga para carro ou van
- Van pode estacionar em vaga para van ou carro, mas ocupará 3 vagas para carro

**Classes**  

    Estacionamento: Guid Id, List<DivisaoVagas> DivisaoVagas
    DivisaoVagas: Guid Id, List<Vaga> Vagas, TipoVagaVeiculo TipoVagaVeiculo, int QtdVagasMax
    Vaga: Guid Id, Veiculo Veiculo
    Veiculo: Guid Id, TipoVagaVeiculo TipoVagaVeiculo

**Enum** 

    TipoVagaVeiculo: Moto, Carro e Van

### Funcionalidades

- Exibe a quantidade de vagas totais e vagas restantes no estacionamento
- Exibe se o estacionamento está cheio e se está vazio
- Exibe quando cada divisão de vagas está cheia: moto, carro e van
- Exibe a quantidade de tipo de veículo que está ocupadando vagas: moto, carro e van
- Exibe a quantidade de vagas que cada tipo de veículo está ocupando
