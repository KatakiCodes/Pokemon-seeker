# Pokemon-seeker

## Sobre o Projeto

Esta é uma aplicação desenvolvida em .NET e ASP.NET Core que busca informações de um Pokémon através de uma requisição HTTP GET para uma API externa (Pokedex API). A aplicação processa a resposta, mapeia os dados relevantes e retorna um objeto contendo o status da requisição e os dados do Pokémon, caso a busca seja bem-sucedida. Em cenários de erro, o status da requisição é igualmente retornado para indicar a falha.

## Objetivo

O principal objetivo deste projeto é consolidar e praticar conceitos importantes do desenvolvimento .NET e ASP.NET Core, incluindo:

* Consumo de APIs ou serviços externos.
* Utilização de funcionalidades e ferramentas do ASP.NET Core para realizar requisições web e manipulação de dados.

## Serviço/API

A aplicação consome dados da seguinte API:

https://pokeapi.co/

## Outros Conhecimentos Postos em Prática

Além dos objetivos principais, este projeto também demonstra a aplicação dos seguintes conceitos e padrões de desenvolvimento:

* **Arquitetura em Camadas:** A aplicação é estruturada em diferentes camadas para separação de responsabilidades (ex: Controller, Service, Data Transfer Objects).
* **DTOs (Data Transfer Objects) e Mappers:** Utilização de DTOs para a transferência de dados entre camadas e mappers para facilitar a conversão entre diferentes tipos de objetos.
* **Service Pattern:** Implementação de uma camada de serviço para encapsular a lógica de negócios e o consumo da API externa.

## Como Executar a API (.NET 9 e ASP.NET Core)

A seguir, estão os passos e comandos necessários para executar uma API .NET 9 e ASP.NET Core recém baixada do GitHub em seu ambiente local.

### Pré-requisitos

* **SDK do .NET 9:** Certifique-se de ter o SDK do .NET 9 instalado em sua máquina. Você pode baixá-lo no site oficial da Microsoft.

### Passos e Comandos

1.  **Navegue até o diretório do projeto:** Abra o terminal ou prompt de comando e navegue até a pasta onde os arquivos do projeto foram clonados do GitHub. Por exemplo:

    ```bash
    cd pokemon-seeker
    ```

2.  **Restaure as dependências NuGet:** Este comando baixa todas as bibliotecas e pacotes necessários definidos no arquivo `.csproj` do seu projeto.

    ```bash
    dotnet restore
    ```

3.  **Construa o projeto:** Este comando compila o código da sua aplicação.

    ```bash
    dotnet build
    ```

4.  **Execute a aplicação:** Este comando inicia o servidor web Kestrel (servidor padrão do ASP.NET Core) e hospeda sua API.

    ```bash
    dotnet run
    ```

    Você deverá ver uma saída no terminal indicando que a aplicação está rodando e em qual(is) URL(s) ela está acessível (geralmente `http://localhost:5xxx`).

