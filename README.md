# Gerenciamento de chamados

![Status do Projeto](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![Linguagem](https://img.shields.io/badge/linguagem-C%23-blueviolet)
![Framework](https://img.shields.io/badge/framework-.NET-blue)

> Este trabalho é referente ao Projeto Integrado Multidisciplinar (PIM) do curso de Análise e Desenvolvimento de Sistemas da Faculdade UNIP de São José dos Campos.

<p align="center">
  <img src="img/203549358.jpg" alt="logo da Fatal System" width="400">
  <br/>
  <strong>Gerenciamento de Chamados com Triagem por IA</strong>
</p>

<p align="center">
  <a href="#desafio">Desafio</a> •
  <a href="#tecnologias-utilizadas">Tecnologias</a> •
  <a href="#como-executar-o-projeto">Como Executar</a> •
  <a href="#documenta--o">Documentação</a> •
  <a href="#diagramas-uml">Diagramas UML</a> •
  <a href="#cronograma-de-sprints">Sprints</a> •
  <a href="#integrantes-do-grupo">Integrantes</a>
</p>

## Desafio <a id="desafio"></a>
O desafio consiste em criar um sistema de gerenciamento de chamados triados por uma Inteligência Artificial (IA), otimizando o fluxo de atendimento e reduzindo a sobrecarga da equipe de TI. O sistema permite que chamados sejam analisados automaticamente, com soluções propostas pela IA para validação da equipe técnica, enquanto todo o histórico é armazenado para aprendizado contínuo e futuras consultas.

## Tecnologias Utilizadas <a id="tecnologias-utilizadas"></a>
* **Linguagem:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Banco de Dados:** SQL Server (utilizando Azure SQL)
* **Modelagem:** Astah UML
* **Versionamento:** Git & GitHub

## Como Executar o Projeto <a id="como-executar-o-projeto"></a>
### Pré-requisitos
* Visual Studio 2019 ou superior
* .NET Framework 4.7.2
* Acesso a uma instância do SQL Server (local ou na nuvem)

### Instalação e Execução
1.  Clone o repositório: `git clone https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados.git`
2.  Abra a solução (`.sln`) no Visual Studio.
3.  Configure a `connectionString` no código com as credenciais do seu banco de dados.
4.  Execute o projeto pressionando `F5`.
5.  Login padrão: `admin` / `admin1234`.

## Documentação <a id="documenta--o"></a>
A documentação completa do projeto, incluindo requisitos funcionais e não-funcionais, está detalhada nos seguintes arquivos:
* [Backlog do Produto](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/backlog.md)
* [Requisitos Não-Funcionais](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/reqnfunc.md)
* [Solução Proposta](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/solprop.md)

## Cronograma de Sprints <a id="sprint"></a>

| Sprint          |    Período    | Documentação                                     |
| --------------- | :-----------: | :---------------------------------------------: |
| 🔖 **SPRINT 1** | 18/08 - 25/08 | [Sprint 1](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint1.md) |
| 🔖 **SPRINT 2** | 25/08 - 01/09 | [Sprint 2](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint2.md) |
| 🔖 **SPRINT 3** | 01/09 - 08/09 | [Sprint 3](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint3.md) |
| 🔖 **SPRINT 4** | 08/09 - 15/09 | [Sprint 4](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint4.md) |
| 🔖 **SPRINT 5** | 15/09 - 22/09 | [Sprint 5](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint5.md) |
| 🔖 **SPRINT 6** | 22/09 - 29/09 | [Sprint 6](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint6.md) |
| 🔖 **SPRINT 7** | 29/09 - 06/10 | [Sprint 7](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint7.md) |
| 🔖 **SPRINT 8** | 06/10 - 13/10 | [Sprint 8](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint8.md) |
| 🔖 **SPRINT 9** | 13/10 - 20/10 | [Sprint 9](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint9.md) |
| 🔖 **SPRINT 10**| 20/10 - 27/10 | [Sprint 10](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint10.md) |
| 🔖 **SPRINT 11**| 27/10 - 03/11 | [Sprint 11](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint11.md) |
| 🔖 **SPRINT 12**| 03/11 - 14/11 | [Sprint 12](https://github.com/Fredeavatar/UML-Gerenciamento-de-chamados/blob/main/Sprints/Sprint12.md) |

## Diagramas UML <a id="diagramas-uml"></a>
A modelagem completa do sistema foi realizada utilizando os 13 diagramas da UML para documentar a arquitetura, a estrutura e o comportamento do software, conforme as boas práticas de engenharia de software.

### Diagramas Estruturais
| Diagrama | Descrição | Visualização |
| :--- | :--- | :---: |
| **Diagrama de Pacotes** | Mostra a organização arquitetural do sistema em módulos e suas dependências. | [Visualizar](Diagramas/1.Arquitetura/Diagrama_de_Pacotes.png) |
| **Diagrama de Classes Geral**| Apresenta o modelo de domínio com as principais entidades, repositórios e a hierarquia de usuários. | [Visualizar](link/para/DiagramaDeClasses_Geral.png) |
| **Diagrama de Componentes** | Descreve os principais componentes de software e hardware e como eles interagem. | [Visualizar](link/para/DiagramaDeComponentes.png) |
| **Diagrama de Implantação**| Ilustra a arquitetura física, mostrando onde cada componente é executado (cliente/servidor). | [Visualizar](link/para/DiagramaDeImplantacao.png) |
| **Diagrama de Objetos** | Apresenta uma "fotografia" do sistema com exemplos de objetos e seus dados em um momento específico. | [Visualizar](link/para/Chamado_Objetos.png) |
| **Diagrama de Estrutura Composta** | Detalha a arquitetura interna de um componente, mostrando suas partes e como colaboram. | [Visualizar](link/para/EstruturaComposta_ChamadoRepo.png) |

### Diagramas Comportamentais
| Diagrama | Descrição | Visualização |
| :--- | :--- | :---: |
| **Diagrama de Casos de Uso** | Descreve as funcionalidades do sistema sob a perspectiva dos atores. | [Visualizar](link/para/GestaoDeChamados_CasosDeUso.png) |
| **Diagrama de Atividades** | Modela os fluxos de trabalho passo a passo para os principais processos de negócio. | [Visualizar](link/para/criarChamado_Atividade.png) |
| **Diagrama de Máquina de Estados** | Detalha o ciclo de vida de um objeto `Chamado`, mostrando seus estados e transições. | [Visualizar](link/para/Chamado_MaquinaDeEstados.png) |
| **Diagrama de Sequência** | Mostra a troca de mensagens entre os objetos ao longo do tempo para realizar um caso de uso. | [Visualizar](link/para/criarChamado_Sequencia.png) |
| **Diagrama de Comunicação**| Enfatiza os relacionamentos e a troca de mensagens entre os objetos, sem focar na linha do tempo. | [Visualizar](link/para/fazerLogin_Comunicacao.png) |
| **Diagrama de Visão Geral da Interação** | Apresenta um fluxo de alto nível, conectando diferentes diagramas de sequência. | [Visualizar](link/para/VisaoGeral_Interacao.png) |
| **Diagrama de Temporização**| Foca nas restrições de tempo e na mudança de estado de um objeto ao longo do tempo. | [Visualizar](link/para/Chamado_Temporizacao.png) |



## Integrantes do grupo

| Nome | Github | Instagram
| :------------: | :-------------: | :-----------:|
| Frederico Barreto Godoi Dellú | [Acessar Github](https://github.com/Fredeavatar) | [Acessar Instagram](https://www.instagram.com/fredericodellu_?igsh=MXcwa3d0djQzZzZ5MQ==) |
