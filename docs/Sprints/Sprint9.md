# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 9

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
> Período: 13/10 a 20/10

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Definição e modelagem do **Diagrama de Objetos**, representando instâncias concretas das classes em um momento específico ("fotografia") para validar a modelagem de classes e os fluxos de interação com exemplos reais.

## 📋 Backlog da Sprint <a id="backlog-sprint"></a>

*(Itens do Backlog Geral abordados ou iniciados nesta Sprint)*

| Rank | Prioridade | User Story / Funcionalidade                                                                                             | Story Points | Sprint | Requisito | Status |
| :--: | :--------: | :----------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :-------: | :----: |
|  -   |    Média   | **Validação da Modelagem através de Exemplo Concreto** |      ?       |    9   |    N/A    |   ✅   |

## 🚀 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Modelagem de Objetos Instanciados:** Criação de cenários exemplo com instâncias das classes e seus atributos preenchidos com dados fictícios:
    * Cenário Chamado: `Frederico: Funcionario`, `chamado15: Chamado`, `anexo01: Arquivo`, `resposta001` a `resposta005`: `Historico` ([Visualizar](../../Diagramas/4_Gerenciamento_de_Chamados/Diagrama_de_Objetos_Chamado.png)).
    * Cenário Usuário: `adminFrederico: admin`, `usuarioGabriel: Funcionario` ([Visualizar](../../Diagramas/5_Gerenciamento_de_Usuarios/Objeto_Usuario.png)).
* **Representação dos Relacionamentos (Links):** Demonstração visual das conexões entre os objetos instanciados nos cenários.

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

* Selecionar exemplos representativos que cobrissem cenários chave.
* Garantir a coerência dos estados (valores) dos objetos com o comportamento esperado.
* Ajustar o nível de detalhe para manter o diagrama compreensível.
* Manter a consistência com diagramas de classes e sequência.

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
