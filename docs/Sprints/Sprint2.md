# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 2

<p align="center">
     <img src="../../img/Fatal_System_Logo_FINAL.png" alt="logo da Fatal System" width="200">
     <h2 align="center"> Fatal System</h2>
</p>

<p align="center">
 | <a href="#objetivo">Objetivo da Sprint</a> |
 <a href="#backlog-sprint">Backlog da Sprint</a> |
 <a href="#realizacoes">Principais Realizações</a> |
 <a href="#dor">DoR</a> |
 <a href="#dod">DoD</a> |
 <a href="#desafios">Desafios</a> |
 <a href="#equipe">Equipe</a> |
</p>

> Status da Sprint: Concluída ✅
> Período: 25/08 a 01/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Avançar na definição das funcionalidades centrais, focando em estruturar os módulos de gerenciamento de usuários e chamados, definir parâmetros para a IA e estabelecer requisitos para relatórios. Foco na modelagem dos **Diagramas de Casos de Uso**.

## 📋 Backlog da Sprint <a id="backlog-sprint"></a>

*(Itens do Backlog Geral abordados ou iniciados nesta Sprint)*

| Rank | Prioridade | User Story / Funcionalidade (Baseado nos Casos de Uso)                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :--------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  -   |    Alta    | **Modelagem dos Casos de Uso** (Visão geral das funcionalidades por ator) |      ?       |    2   |    N/A    |   ✅   |
|  3   |    Alta    | Como sistema (IA), quero classificar a prioridade... *(Definição conceitual)* |      8       |    2   |    R03    |   ✅   |
|  4   |    Alta    | Como sistema (IA), quero propor uma solução... *(Definição conceitual)* |      13      |    2   |    R04    |   ✅   |
|  9   |    Média   | Como Equipe de TI, quero gerar relatórios... *(Definição de requisitos)* |      13      |    5   |    R09    |   🚧   |

## 🚀 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Gerenciamento de Usuários:** Definição de funcionalidades (CRUD), campos e níveis de acesso.
    * Modelagem: [Caso de Uso Usuário](../../Diagramas/5_Gerenciamento_de_Usuarios/Caso_de_Uso_Usuario.png)
* **Inteligência Artificial (IA):** Escolha preliminar do serviço (Gemini API) e definição de parâmetros para triagem.
    * Modelagem: [Caso de Uso IA](../../Diagramas/6_Gerenciamento_de_IA/Caso_de_Uso_IA.png)
* **Gerenciamento de Chamados:** Definição dos campos do formulário e dados obrigatórios.
    * Modelagem: [Casos de Uso Gerenciamento de Chamados](../../Diagramas/4_Gerenciamento_de_Chamados/Casos_de_Uso_Gerenciamento_de_Chamados.png)
* **Gerenciamento de Relatórios:** Definição dos filtros de visualização.
    * Modelagem: [Caso de Uso Relatórios](../../Diagramas/7_Gerenciamento_de_Relatórios/Caso_de_Uso_Relatorios.png)
* **Gestão de Acesso:** Definição do fluxo de login.
    * Modelagem: [Caso de Uso Gestão de Acesso](../../Diagramas/3_Gestão_de_Acesso/Gestão_de_Acesso_Caso_de_Uso.png)

## 🏃‍ DoR - Definition of Ready <a id="dor"></a>

| Critério                        | Descrição                                                                                          |
| :------------------------------ | :------------------------------------------------------------------------------------------------- |
| Clareza na Descrição            | A User Story está escrita no formato “Como [persona], quero [ação] para que [objetivo]”.             |
| Critérios de Aceitação Definidos| A história possui critérios objetivos que indicam o que é necessário para considerá-la concluída.  |
| Cenários de Teste Especificados | A história tem pelo menos 1 cenário de teste estruturado (Dado, Quando, Então).                     |
| Independente                    | A história pode ser implementada sem depender de outra tarefa da mesma Sprint.                      |
| Compreensão Compartilhada       | Toda a equipe (incluindo PO e devs) compreende o propósito da história.                             |
| Estimável                       | A história foi pontuada no Planning Poker ou tem uma estimativa clara.                              |
| Documentos de Apoio             | Se necessário, mockups, fluxos ou modelos de dados estão anexados ou referenciados.                 |
| Critérios técnicos acordados    | As necessidades de Frontend e Backend foram claramente separadas (quando aplicável).                 |

## 🏆 DoD - Definition of Done <a id="dod"></a>

| Critério                          | Descrição                                                                                    |
| :-------------------------------- | :------------------------------------------------------------------------------------------- |
| Critérios de Aceitação atendidos  | Todos os cenários de teste da história foram executados e aprovados.                           |
| Testes manuais realizados         | Onde aplicável, os dados são corretamente armazenados e recuperáveis.                          |
| Código revisado                   | O código foi revisado por pelo menos um colega de equipe.                                    |
| Documentação interna atualizada   | Foi atualizado o que for necessário: API, estrutura de dados, endpoints, etc.                 |
| Integração com outras partes testada| As interfaces entre Frontend e Backend foram validadas.                                      |
| Build/Testes automatizados        | A funcionalidade não quebra a aplicação e passa nos testes automatizados existentes.          |
| Validação do PO                   | O Product Owner validou a entrega com base nos critérios definidos.                             |
| Pronto para deploy                | O item está testado, validado e pode ser integrado ao produto final.                            |

## 🔥 Desafios Enfrentados <a id="desafios"></a>

* **Escolha da IA:** Análise comparativa detalhada entre diversas opções de mercado.
* **Complexidade nos critérios de triagem:** Necessidade de testes preliminares com dados simulados para garantir eficácia dos parâmetros.
* **Alinhamento dos campos do chamado com a IA:** Ajustes para garantir que os dados coletados fossem suficientes para a triagem inteligente.
* **Escopo dos relatórios:** Discussões para definir filtros úteis sem tornar o sistema excessivamente complexo.

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
