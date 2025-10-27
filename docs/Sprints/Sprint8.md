# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 8

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
> Período: 06/10 a 13/10

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Definição e modelagem do **Diagrama de Classes Geral**, especificando a estrutura estática do domínio (entidades, atributos, relacionamentos) e as classes de suporte (repositórios, serviços).

## 📋 Backlog da Sprint <a id="backlog-sprint"></a>

*(Itens do Backlog Geral abordados ou iniciados nesta Sprint)*

| Rank | Prioridade | User Story / Funcionalidade                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :----------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  -   |    Alta    | **Modelagem do Domínio Principal** (Classes Usuario, Chamado, Historico, Arquivo) |      ?       |    8   |    N/A    |   ✅   |
|  -   |    Média   | **Definição das Classes de Serviço e Utilitárias** (Funcoes, AIService, Repositories) |      ?       |    8   |    N/A    |   ✅   |

## 🚀 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Modelagem das Classes Principais:** `Usuario`, `Chamado`, `Historico`, `Arquivo`, `Funcoes`, `UsuarioRepository`, `ChamadoRepository`, `HistoricoRepository`, `Admin`, `EquipeDeTi`, `Funcionario`. Definição de atributos e relacionamentos principais.
* **Visualização:** [**Diagrama de Classe Geral**](../../Diagramas/2_Modelo_De_Dominio/Diagrama_de_Classe_Geral.png).
* **Modelagem de Classes Específicas (Detalhes):**
    * [Classe Arquivo](../../Diagramas/4_Gerenciamento_de_Chamados/Arquivo_Classe.png)
    * [Classe Criar Chamado (Contexto)](../../Diagramas/4_Gerenciamento_de_Chamados/Criar_Chamado_Classe.png)
    * [Classe Editar Chamado (Contexto)](../../Diagramas/4_Gerenciamento_de_Chamados/Editar_Chamado_Classe.png)
    * [Classe Tratar Chamado (Contexto)](../../Diagramas/4_Gerenciamento_de_Chamados/Tratar_Chamado_Classe.png)
    * [Classe Triar Chamado (Contexto)](../../Diagramas/4_Gerenciamento_de_Chamados/Triar_Chamado_Classe.png)
    * [Classe Visualizar Chamado (Contexto)](../../Diagramas/4_Gerenciamento_de_Chamados/Visualizar_Chamado_Classe.png)
    * [Classe Adicionar Usuário (Contexto)](../../Diagramas/5_Gerenciamento_de_Usuarios/Adicionar_Usuario_Classe.png)
    * [Classe Editar Usuário (Contexto)](../../Diagramas/5_Gerenciamento_de_Usuarios/Editar_Usuario_Classe.png)
    * [Classe Visualizar Usuário (Contexto)](../../Diagramas/5_Gerenciamento_de_Usuarios/Visualizar_Usuario_Classe.png)
    * [Classe Treinar IA (Contexto)](../../Diagramas/6_Gerenciamento_de_IA/TreinarIA_Classe.png)
    * [Classe Filtrar Relatório (Contexto)](../../Diagramas/7_Gerenciamento_de_Relatórios/Filtrar_Relatorio_Classe.png)
    * [Classe Gerar Relatório (Contexto)](../../Diagramas/7_Gerenciamento_de_Relatórios/Gerar_Relatorio_Classe.png)
    * [Classe Gestão de Acesso (Contexto)](../../Diagramas/3_Gestão_de_Acesso/Gestão_de_Acesso_Classe_Geral.png)

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

* Definir métodos corretos para cada classe.
* Alinhar granularidade das classes.
* Modelar corretamente as associações e dependências.
* Garantir alinhamento com diagramas comportamentais anteriores.

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
