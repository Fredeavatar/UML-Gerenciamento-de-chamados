# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 3

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
> Período: 01/09 a 08/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Desenvolvimento e entrega do **Diagrama de Atividades**, representando os fluxos principais de uso do sistema (baseados nos Casos de Uso da Sprint 2). O objetivo é alinhar a equipe e stakeholders sobre os processos de negócio antes de iniciar a modelagem detalhada da arquitetura.

## 📋 Backlog da Sprint <a id="backlog-sprint"></a>

*(Itens do Backlog Geral abordados ou iniciados nesta Sprint)*

| Rank | Prioridade | User Story / Funcionalidade (Baseado nos Casos de Uso)                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :--------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  -   |    Alta    | **Modelagem dos Fluxos de Atividades Principais** |      ?       |    3   |    N/A    |   ✅   |
|  6   |    Alta    | Como Admin, quero adicionar um novo usuário... *(Fluxo detalhado)* |      8       |    3   |    R06    |   ✅   |
|  *...*| *...* | *(Outros fluxos mapeados: Login, Criar/Tratar Chamado, Filtrar Relatório, etc.)* |      ?       |    3   |     ?     |   ✅   |

*(Nota: O principal foco foi a modelagem dos fluxos)*

## 🚀 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Levantamento dos Fluxos de Negócio:** Identificação e priorização dos processos principais a serem modelados.
* **Criação dos Diagramas de Atividades:** Desenho dos diagramas UML com atividades, decisões, paralelismos e swimlanes para:
    * [Adicionar Usuário](../../Diagramas/5_Gerenciamento_de_Usuarios/Adicionar_Usuario_Atividade.png)
    * [Anexar Arquivo](../../Diagramas/4_Gerenciamento_de_Chamados/Arquivo_Atividade.png)
    * [Criar Chamado](../../Diagramas/4_Gerenciamento_de_Chamados/Criar_Chamado_Atividade.png)
    * [Editar Usuário](../../Diagramas/5_Gerenciamento_de_Usuarios/Editar_Usuario_Atividade.png)
    * [Filtrar Relatório](../../Diagramas/7_Gerenciamento_de_Relatórios/Filtrar_Relatorio_Atividade.png)
    * [Gerar Relatório](../../Diagramas/7_Gerenciamento_de_Relatórios/Gerar_Relatorio_Atividade.png)
    * [Fazer Login](../../Diagramas/3_Gestão_de_Acesso/fazerLoginAti.png) Arrumar depois
    * [Tratar Chamado](../../Diagramas/4_Gerenciamento_de_Chamados/Tratar_Chamado_Atividade.png)
    * [Treinar IA](../../Diagramas/6_Gerenciamento_de_IA/TreinarIA_Atividade.png)
    * [Visualizar Chamado](../../Diagramas/4_Gerenciamento_de_Chamados/Visualizar_Chamado_Atividade.png)
    * [Visualizar Usuário](../../Diagramas/5_Gerenciamento_de_Usuarios/Visualizar_Usuario_Atividade.png)
* **Revisão Técnica e Ajustes:** Validação dos diagramas com a equipe e ajustes para clareza e completude.
* **Documentação e Versionamento:** Documentação complementar e versionamento no repositório.

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

* Complexidade na representação dos fluxos paralelos, exigindo revisão para evitar ambiguidades.
* Alinhamento entre equipes para garantir que o diagrama refletisse fielmente os processos reais.
* Adequação do nível de detalhe para não tornar o diagrama excessivamente complexo, mas suficientemente informativo.
* Atraso na validação final por parte dos stakeholders, impactando a preparação para as próximas etapas.

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
