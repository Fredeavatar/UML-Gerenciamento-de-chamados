# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

<p align="center">
     <img src="docs/img/Fatal_System_Logo_FINAL.png" alt="logo da Fatal System" width="200">
     <h2 align="center"> Fatal System</h2>
</p>

<p align="center">
 | <a href="#desafio">Desafio</a> |
 <a href="#solucao">Solução</a> | 
 <a href="#backlog">Backlog do Produto</a> |
 <a href="#dor">DoR</a> |
 <a href="#dod">DoD</a> |
 <a href="#sprints">Cronograma de Sprints</a> |
 <a href="#tecnologias">Tecnologias</a> |
 <a href="#manual">Manual de Instalação</a> | 
 <a href="#equipe">Equipe</a> |
</p>

> Status do Projeto: Em Desenvolvimento 🚧
>
> Documentação Completa (Diagramas): [PDF](docs/Links/Diagramas.pdf) 📄 
>
> Casos de Uso Detalhados: [PDF](docs/Links/UseCaseD.pdf) 📄
>
> Vídeo do Projeto: [Link para Youtube, se houver] 📽️

## 🏅 Desafio <a id="desafio"></a>

O desafio consiste em criar um sistema de gerenciamento de chamados otimizado por uma Inteligência Artificial (IA). O objetivo é agilizar o fluxo de atendimento, classificar a prioridade automaticamente com base em regras definidas, propor soluções iniciais consultando o histórico, e reduzir a sobrecarga da equipe de TI, mantendo um registro detalhado para aprendizado contínuo e consultas futuras.

## 🏅 Solução <a id="solucao"></a>

O **Fatal System** é uma aplicação desktop desenvolvida em C# (.NET Windows Forms) que permite o registro, acompanhamento e resolução de chamados de suporte técnico. A solução integra a API Gemini do Google para realizar uma triagem inteligente: ao receber um novo chamado, a IA analisa os dados (título, descrição, categoria, impacto) e, baseando-se em regras de negócio e no histórico de soluções anteriores para a mesma categoria, sugere a identificação do problema, uma proposta de solução e a prioridade (Alta, Média, Baixa). A equipe de TI recebe essa análise preliminar, podendo validá-la ou corrigi-la antes de prosseguir com o tratamento. O sistema inclui gerenciamento de usuários (Admin, Funcionário, EquipeTI), funcionalidades de relatórios com filtros por data, exportação para CSV e PDF, e armazenamento de anexos. Todo o histórico de interações e soluções é persistido no banco de dados Azure SQL.

---

## 📋 Backlog do Produto <a id="backlog"></a>

*(Nota: Esta tabela é uma adaptação dos Casos de Uso, com Story Points e Sprints estimados para fins de exemplo. Os valores reais devem ser definidos pela equipe.)*

| Rank | Prioridade | User Story / Funcionalidade (Baseado nos Casos de Uso)                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :--------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  1   |    Alta    | Como usuário, quero fazer login no sistema para acessar as funcionalidades correspondentes à minha função (Admin, Funcionário, EquipeTI).               |      8       |    1   |    R01    |   ✅   |
|  2   |    Alta    | Como Funcionário, quero criar um novo chamado, preenchendo detalhes e anexando arquivos, para que a IA analise e a Equipe de TI possa tratar.          |      13      |   1-2  |    R02    |   ✅   |
|  3   |    Alta    | Como sistema (IA), quero classificar a prioridade de um novo chamado (Alta, Média, Baixa) baseado em regras e dados fornecidos.                        |      8       |    2   |    R03    |   ✅   |
|  4   |    Alta    | Como sistema (IA), quero propor uma solução inicial para um novo chamado, consultando o histórico de chamados resolvidos da mesma categoria.         |      13      |    2   |    R04    |   ✅   |
|  5   |    Alta    | Como Equipe de TI, quero tratar um chamado pendente, analisar a sugestão da IA, aplicar/editar a solução, e atualizar o status para Resolvido.       |      21      |   3-4  |    R05    |   ✅   |
|  6   |    Alta    | Como Admin, quero adicionar um novo usuário ao sistema, definindo suas informações e permissões.                                                   |      8       |    3   |    R06    |   ✅   |
|  7   |    Média   | Como Admin, quero editar os dados de um usuário existente.                                                                                        |      5       |    4   |    R07    |   ✅   |
|  8   |    Média   | Como Admin, quero visualizar os detalhes de um usuário específico.                                                                                |      3       |    4   |    R08    |   ✅   |
|  9   |    Média   | Como Equipe de TI, quero gerar relatórios consolidados sobre os chamados (ex: por status, prioridade).                                               |      13      |    5   |    R09    |   ✅   |
|  10  |    Média   | Como Equipe de TI, quero filtrar os relatórios gerados por um período específico (datas De/Até) e exportar (CSV/PDF).                              |      8       |    5   |    R10    |   ✅   |
|  11  |    Baixa   | Como Admin, quero revisar chamados resolvidos e potencialmente ajustar informações para melhorar a base de conhecimento da IA (Treinar IA).         |      5       |    6   |    R11    |   🚧   |

---

## 🏃‍ DoR - Definition of Ready <a id="dor"></a>

* User Story clara e com **Critérios de Aceitação** definidos.
* Subtarefas (Tasks) mapeadas a partir da User Story.
* Design da interface (quando aplicável) aprovado.
* Modelagem do Banco de Dados (se houver alterações) definida.

## 🏆 DoD - Definition of Done <a id="dod"></a>

* Código implementado conforme a User Story e Critérios de Aceitação.
* Testes realizados (unitários, integração, funcionais - conforme aplicável).
* Funcionalidade validada pelo PO ou Stakeholder.
* Código revisado (Code Review) e sem débitos técnicos críticos.
* Merge realizado na branch principal (ex: `main` ou `develop`).
* Documentação relevante atualizada (código, manuais, etc.).

---

## 📅 Cronograma de Sprints <a id="sprints"></a>

| Sprint         |    Período    | Documentação                                     |
| ------------- | :-----------: | :---------------------------------------------: |
| 🔖 **SPRINT 1** | 18/08 - 25/08 | [Sprint 1](link/para/Sprint1.md) |
| 🔖 **SPRINT 2** | 25/08 - 01/09 | [Sprint 2](link/para/Sprint2.md) |
| 🔖 **SPRINT 3** | 01/09 - 08/09 | [Sprint 3](link/para/Sprint3.md) |
| 🔖 **SPRINT 4** | 08/09 - 15/09 | [Sprint 4](link/para/Sprint4.md) |
| 🔖 **SPRINT 5** | 15/09 - 22/09 | [Sprint 5](link/para/Sprint5.md) |
| 🔖 **SPRINT 6** | 22/09 - 29/09 | [Sprint 6](link/para/Sprint6.md) |
| 🔖 **SPRINT 7** | 29/09 - 06/10 | [Sprint 7](link/para/Sprint7.md) |
| 🔖 **SPRINT 8** | 06/10 - 13/10 | [Sprint 8](link/para/Sprint8.md) |
| 🔖 **SPRINT 9** | 13/10 - 20/10 | [Sprint 9](link/para/Sprint9.md) |
| 🔖 **SPRINT 10**| 20/10 - 27/10 | [Sprint 10](link/para/Sprint10.md) |
| 🔖 **SPRINT 11**| 27/10 - 03/11 | [Sprint 11](link/para/Sprint11.md) |
| 🔖 **SPRINT 12**| 03/11 - 14/11 | [Sprint 12](link/para/Sprint12.md) |
*(Atualize os links para apontarem para os arquivos corretos no seu repositório)*

## 💻 Tecnologias <a id="tecnologias"></a>

<h4 align="center">
  <img src="https://img.shields.io/badge/C%23-blueviolet?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/.NET%20Framework-blue?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Framework">
  <img src="https://img.shields.io/badge/Windows%20Forms-lightblue?style=for-the-badge&logo=windows&logoColor=black" alt="Windows Forms">
  <img src="https://img.shields.io/badge/Azure%20SQL-blue?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="Azure SQL">
  <img src="https://img.shields.io/badge/Gemini%20API-orange?style=for-the-badge&logo=google&logoColor=white" alt="Gemini API">
  <img src="https://img.shields.io/badge/ScottPlot-purple?style=for-the-badge" alt="ScottPlot">
  <img src="https://img.shields.io/badge/iTextSharp-red?style=for-the-badge" alt="iTextSharp">
  <img src="https://img.shields.io/badge/Astah%20UML-grey?style=for-the-badge" alt="Astah UML">
  <img src="https://img.shields.io/badge/Git-black?style=for-the-badge&logo=git&logoColor=white" alt="Git">
  <img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" alt="GitHub">
</h4>

## 📖 Manual de Instalação <a id="manual"></a>

### 🛠 Pré-requisitos

* Visual Studio 2019 ou superior (com carga de trabalho ".NET desktop development")
* .NET Framework 4.8 (ou a versão especificada no seu projeto)
* **Acesso a uma instância do SQL Server (Azure SQL ou local).**
* **As tabelas do banco de dados (`Usuario`, `Chamado`, `Historico`, `Arquivo`) devem ser criadas previamente.** 
* Git instalado ([Download](https://git-scm.com/downloads))
* **Uma Chave de API válida para o Google Gemini.**

---

### 1. Clonar o Repositório

```bash
git clone [https://github.com/Frederico-Dellu/Gerenciamento-de-chamados.git](https://github.com/Frederico-Dellu/Gerenciamento-de-chamados.git)
cd Gerenciamento-de-chamados
```
---

### 2. Configurar Conexão com Banco de Dados

* Abra a solução (`.sln`) no Visual Studio.
* **Localize e atualize a `connectionString`** nos arquivos de código-fonte que acessam o banco (ex: `Relatorio.cs`, `FormRelatorioDetalhado.cs`, `Funcoes.cs`, etc.). Você precisará informar o endereço do seu servidor, nome do banco, usuário e senha.
* Certifique-se de que o banco de dados apontado pela `connectionString` **contenha as tabelas necessárias** para o sistema (`Usuario`, `Chamado`, `Historico`, `Arquivo`).
* **Script de Criação do Banco:** [schema_criacao.sql](Script/ScriptSQL.sql) *(Para criar a estrutura exata das tabelas)*

---

### 3. Configurar Chave da API Gemini

* Abra o arquivo `App.config` na raiz do seu projeto.
* **Localize ou adicione a chave `GEMINI_API_KEY`** dentro da seção `<appSettings>`.
* **Insira sua chave de API válida** como valor para esta chave. A aplicação precisa desta chave para se comunicar com a IA Gemini.

---

### 4. Compilar e Executar

* No Visual Studio, vá em `Build` > `Rebuild Solution` (Compilar > Recriar Solução).
* Após a compilação bem-sucedida, pressione `F5` ou clique no botão "Start" (Iniciar) para executar a aplicação.
* Utilize um usuário e senha válidos (previamente cadastrados no seu banco de dados) para fazer login.

---

## 🎓 Equipe <a id="equipe"></a>

<div align="center">
 <table>
   <tr>
     <th>Membro</th>
     <th>Função</th>
     <th>Github</th>
     <th>Instagram</th>
   </tr>
   <tr>
     <td>Frederico Barreto Godoi Dellú</td>
     <td>Desenvolvedor / Documentação</td>
     <td><a href="https://github.com/Fredeavatar"><img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"></a></td>
     <td><a href="https://www.instagram.com/fredericodellu_?igsh=MXcwa3d0djQzZzZ5MQ=="><img src="https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white" alt="Instagram"></a></td>
   </tr>
   </table>
</div>

