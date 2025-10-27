# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 6

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
> Período: 22/09 a 29/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Modelar os **Diagramas de Sequência** para as funcionalidades centrais, representando o fluxo **temporal** das interações entre objetos/atores para realizar cada caso de uso.

## 📋 Backlog da Sprint <a id="backlog-sprint"></a>

*(Itens do Backlog Geral abordados ou iniciados nesta Sprint)*

| Rank | Prioridade | User Story / Funcionalidade (Baseado nos Casos de Uso)                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :--------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  1   |    Alta    | Como usuário, quero fazer login no sistema... *(Modelagem da sequência)* |      8       |    1   |    R01    |   ✅   |
|  2   |    Alta    | Como Funcionário, quero criar um novo chamado... *(Modelagem da sequência)* |      13      |   1-2  |    R02    |   ✅   |
|  5   |    Alta    | Como Equipe de TI, quero tratar um chamado pendente... *(Modelagem da sequência)* |      21      |   3-4  |    R05    |   ✅   |
|  6   |    Alta    | Como Admin, quero adicionar um novo usuário... *(Modelagem da sequência)* |      8       |    3   |    R06    |   ✅   |
|  7   |    Média   | Como Admin, quero editar os dados de um usuário existente. *(Modelagem da sequência)* |      5       |    4   |    R07    |   ✅   |
|  8   |    Média   | Como Admin, quero visualizar os detalhes de um usuário específico. *(Modelagem da sequência)* |      3       |    4   |    R08    |   ✅   |
|  9   |    Média   | Como Equipe de TI, quero gerar relatórios consolidados... *(Modelagem da sequência)* |      13      |    5   |    R09    |   ✅   |
| 10   |    Média   | Como Equipe de TI, quero filtrar os relatórios gerados... *(Modelagem da sequência)* |      8       |    5   |    R10    |   ✅   |
| 11   |    Baixa   | Como Admin, quero revisar chamados... (Treinar IA). *(Modelagem da sequência)* |      5       |    6   |    R11    |   ✅   |
|  -   |    Alta    | *Funcionalidade:* Anexar Arquivos *(Modelagem da sequência)* |      ?       |    ?   |     ?     |   ✅   |

*(Nota: Esta Sprint focou na modelagem de sequência de quase todas as funcionalidades principais)*

## 🚀 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Diagrama de Sequência - Adicionar Usuário:** ([Visualizar](../../Diagramas/5_Gerenciamento_de_Usuarios/Adicionar_Usuario_Sequencia.png)).
* **Diagrama de Sequência - Editar Usuário:** ([Visualizar](../../Diagramas/5_Gerenciamento_de_Usuarios/Editar_Usuario_Sequencia.png)).
* **Diagrama de Sequência - Visualizar Usuário:** ([Visualizar](../../Diagramas/5_Gerenciamento_de_Usuarios/Visualizar_Usuario_Sequencia.png)).
* **Diagrama de Sequência - Criar Chamado:** ([Visualizar](../../Diagramas/4_Gerenciamento_de_Chamados/Criar_Chamado_Sequencia.png)).
* **Diagrama de Sequência - Anexar Arquivo:** ([Visualizar](../../Diagramas/4_Gerenciamento_de_Chamados/Arquivo_Sequencia.png)).
* **Diagrama de Sequência - Tratar Chamado:** ([Visualizar](../../Diagramas/4_Gerenciamento_de_Chamados/Tratar_Chamado_Sequencia.png)).
* **Diagrama de Sequência - Gerar Relatórios:** ([Visualizar](../../Diagramas/7_Gerenciamento_de_Relatórios/Gerar_Relatorio_Sequencia.png)).
* **Diagrama de Sequência - Filtrar Relatórios:** ([Visualizar](../../Diagramas/7_Gerenciamento_de_Relatórios/Filtrar_Relatorio_Sequencia.png)).
* **Diagrama de Sequência - Treinar IA:** ([Visualizar](../../Diagramas/6_Gerenciamento_de_IA/TreinarIA_Sequencia.png)).
* **Diagrama de Sequência - Fazer Login:** ([Visualizar](../../Diagramas/3_Gestão_de_Acesso/Sequencia_Fazer_Login.png)).
* **Diagrama de Sequência - Visualizar Chamado:** ([Visualizar](../../Diagramas/4_Gerenciamento_de_Chamados/Visualizar_Chamado_Sequencia.png)).
* **Diagrama de Sequência - Editar Chamado:** ([Visualizar](../../Diagramas/4_Gerenciamento_de_Chamados/Editar_Chamado_Sequencia.png)).
* **Diagrama de Sequência - Triar Chamado:** ([Visualizar](../../Diagramas/4_Gerenciamento_de_Chamados/Triar_Chamado_Sequencia.png)).

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

* Escolha da IA: Exigiu pesquisa técnica detalhada para modelar corretamente a integração com o serviço selecionado.
* Complexidade nos fluxos de triagem automática: A IA demanda parâmetros bem definidos; o diagrama precisou considerar fluxos alternativos e falhas.
* Alinhamento entre formulários e lógica de IA: Ajustes foram necessários para garantir que os dados enviados fossem suficientes para a classification.
* Representação visual dos relatórios: A variedade de filtros trouxe desafios na modelagem de interações com o banco de dados, exigindo clareza na definição dos fluxos.

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
