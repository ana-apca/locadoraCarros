# 🚗 Locadora de Carros

Sistema desktop para gerenciamento de locação de veículos, desenvolvido como **Projeto Integrador III** do curso de ADS.

## Sobre o Projeto

Aplicação Windows Forms em C# para controle completo de uma locadora de veículos, incluindo cadastro de veículos, clientes e gerenciamento de locações com integração a banco de dados SQL Server.

## Tecnologias

- **Linguagem:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Banco de Dados:** SQL Server (via DataSet tipado)
- **IDE:** Visual Studio

## Funcionalidades

- Cadastro e gerenciamento de veículos
- Cadastro de clientes
- Registro de locações e devoluções
- Consulta e filtragem de dados
- Interface gráfica intuitiva com Windows Forms

## Como Executar

1. Clone o repositório
2. Abra `locadoraCarros.sln` no Visual Studio
3. Configure a connection string no `App.config` para seu SQL Server
4. Execute o projeto (F5)

## Estrutura

```
├── Form1.cs                          # Formulário principal
├── Form1.Designer.cs                 # Design da interface
├── Program.cs                        # Entry point
├── locadora_carrosDataSet.xsd        # DataSet tipado (SQL Server)
├── locadoraCarros.csproj             # Projeto C#
└── locadoraCarros.sln                # Solution
```

## Licença

Este projeto é de uso acadêmico.
