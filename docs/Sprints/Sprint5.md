# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 5

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
> Período: 15/09 a 22/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Avançar na modelagem da interação, focando no **Diagrama de Comunicação** (estrutura da colaboração) e no **Diagrama de Visão Geral da Interação** (fluxo entre interações), para entender como os elementos colaboram nas funcionalidades.

## 📋 Backlog da Sprint <a id="backlog-sprint"></a>

*(Itens do Backlog Geral abordados ou iniciados nesta Sprint)*

| Rank | Prioridade | User Story / Funcionalidade (Baseado nos Casos de Uso)                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :--------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  1   |    Alta    | Como usuário, quero fazer login no sistema... *(Modelagem da comunicação)* |      8       |    1   |    R01    |   ✅   |
|  6   |    Alta    | Como Admin, quero adicionar um novo usuário... *(Modelagem da comunicação)* |      8       |    3   |    R06    |   ✅   |
|  7   |    Média   | Como Admin, quero editar os dados de um usuário existente. *(Modelagem da comunicação)* |      5       |    4   |    R07    |   ✅   |
|  8   |    Média   | Como Admin, quero visualizar os detalhes de um usuário específico. *(Modelagem da comunicação)* |      3       |    4   |    R08    |   ✅   |
|  9   |    Média   | Como Equipe de TI, quero gerar relatórios... *(Modelagem da comunicação)* |      13      |    5   |    R09    |   ✅   |
|  10  |    Média   | Como Equipe de TI, quero filtrar relatórios... *(Modelagem da comunicação)* |      8       |    5   |    R10    |   ✅   |
|  -   |    N/A     | Modelagem da Visão Geral das Interações (Chamados e Usuários)                                                                                      |      ?       |    5   |    N/A    |   ✅   |

## 🚀 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Levantamento de Entidades:** Identificação dos objetos/componentes e suas responsabilidades.
* **Construção do Diagrama de Comunicação:** Mapeamento das interações, mensagens e relacionamentos para:
    * [Comunicação Fazer Login](../../Diagramas/3_Gestão_de_Acesso/Comunicação_Fazer_Login.png)
    * [Comunicação Adicionar Usuário](../../Diagramas/5_Gerenciamento_de_Usuarios/Adicionar_Usuario_Comunicação.png)
    * [Comunicação Editar Usuário](../../Diagramas/5_Gerenciamento_de_Usuarios/Editar_Usuario_Comunicação.png)
    * [Comunicação Visualizar Usuário](../../Diagramas/5_Gerenciamento_de_Usuarios/Visualizar_Usuario_Comunicação.png)
    * [Comunicação Editar Chamado](../../Diagramas/4_Gerenciamento_de_Chamados/Editar_Chamado_Comunicação.png)
    * [Comunicação Triar Chamado](../../Diagramas/4_Gerenciamento_de_Chamados/Triar_Chamado_Comunicação.png)
    * [Comunicação Filtrar Relatório](../../Diagramas/7_Gerenciamento_de_Relatórios/Filtrar_Relatorio_Comunicação.png)
    * [Comunicação Gerar Relatório](../../Diagramas/7_Gerenciamento_de_Relatórios/Gerar_Relatorio_Comunicação.png)
* **Construção do Diagrama de Visão Geral da Interação:** Desenvolvimento de diagramas de alto nível:
    * [Visão Geral da Interação Chamados](../../Diagramas/4_Gerenciamento_de_Chamados/Diagrama_de_Visão_Geral_da_interação.png)
    * [Visão Geral da Interação Gerenciamento de Usuários](../../Diagramas/5_Gerenciamento_de_Usuarios/Visão_Geral_Usuario.png)
* **Validação e Ajustes:** Apresentação e refinamento dos diagramas.
* **Documentação e Versionamento:** Inclusão na documentação do projeto.

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

* Complexidade em representar claramente as múltiplas interações entre objetos.
* Alinhamento das interações com as funcionalidades definidas anteriormente.
* Garantir que a visão geral fosse compreensível para diferentes públicos.
* Necessidade de iterar o diagrama para incorporar feedbacks.

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
