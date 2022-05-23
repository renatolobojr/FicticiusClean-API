# Ficticius Clean API Logistics
> Uma API que auxilia na previsao de gastos através do cálculo de consumo de combustível de veículos cadastrados.
> Hospeda na Azure. Para testes clicar [_aqui_](https://ficticius-clean.azurewebsites.net/swagger/index.html).


## Sumário
* [Informações Gerais](#informações-gerais)
* [Tecnologias Usadas](#tecnologias-usadas)
* [Recursos](#recursos)
* [Instalação](#instalação)
* [Situação do Projeto](#situação-do-projeto)
* [Pontos de Melhoria](#pontos-de-melhoria)
* [Licença](#licença)


## Informações Gerais
Uma API desnvolvida em .NET 6 procurando seguir as melhores práticas e padrões de projeto e os princípios do SOLID. Alguns objetivos no desnvolvimento foram construir:
- API RESTful
- Com versionamento
- Uso de DLLs
- Orientado em Domínio (DDD)
- Utilizando testes de unidade (TDD)


## Recursos
Os Recursos Disponíveis para consumo são:
- /veículo (GET e POST)
- /Veiculo/:id (GET)
- /veículo/consumo (GET)


## Tecnologias Usadas
- ASP.NET 6
- Entity framework
- SQLite


## Instalação

Se certifique que esteja instalado em seu PC:
- Git
- dotnet SDK
- ASP.NET 6 rumtime

Clone esse Repositório
````
$ git clone https://github.com/renatolobojr/FicticiusClean-API.git
````

Rode a aplicação em localhost
````
$ dotnet run
````

## Situação do Projeto
O projeto teve que ser feito em poucos dias (3 na verdade), e eu pretendo continuar trabalhando nele. Quem estiver aprendendo e quiser constribuir, sinta-se a vontade para clona-lo em sua máquina e sugerir melhorias.


## Pontos de Melhoria
O intuito com esse projeto é melhorar minhas habilidaes como programador e que eu possa melhorá-lo de diversas formas:
- Complementação da API com outros verbos (PUT/PATCH/DELETE)
- Implementação de hipermídia (HATEOAS)
- Acesso a outros bancos de dados como MySQL, SQLServer...
- Criação de pipeline CI/CD
- Conteirização da API


## Licença
Este Projeto é Código Aberto e está sob a Licença MIT
