# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 4

<p align="center">
     <img src="../img/Fatal_System_Logo_FINAL.png" alt="logo da Fatal System" width="200">
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
> Período: 08/09 a 15/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Avançar na modelagem dinâmica com foco na criação do **Diagrama de Máquina de Estados**, detalhando as mudanças de estado do objeto `Chamado`. Essencial para controlar o ciclo de vida e facilitar a implementação dos fluxos de negócio.

## 📋 Backlog da Sprint <a id="backlog-sprint"></a>

*(Itens do Backlog Geral abordados ou iniciados nesta Sprint)*

| Rank | Prioridade | User Story / Funcionalidade (Baseado nos Casos de Uso)                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :--------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  5   |    Alta    | Como Equipe de TI, quero tratar um chamado pendente... *(Define transições Pendente->Em Andamento->Resolvido)* |      21      |   3-4  |    R05    |   ✅   |
|  -   |    Alta    | **Modelagem do Ciclo de Vida do Chamado** |      ?       |    4   |    N/A    |   ✅   |

## 🚀 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Identificação de Estados e Eventos:** Mapeamento dos estados (Pendente, Em Andamento, Resolvido, Finalizado) e eventos/ações que causam as transições para o `Chamado`.
* **Construção do Diagrama:** Criação do [**Diagrama de Máquina de Estados do Chamado**](../../Diagramas/4_Gerenciamento_de_Chamados/Diagrama_de_Maquina_de_Estados_Chamado.png).
* **Validação Técnica:** Revisão do diagrama pela equipe.
* **Documentação e Versionamento:** Detalhamento e inclusão no repositório.

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

* Complexidade em mapear estados intermediários e transições alternativas.
* Necessidade de alinhar as regras de negócio com as equipes.
* Balancear detalhamento versus simplicidade visual.
* Agilidade na revisão e reedição após feedbacks.

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
