# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 5

<p align="center">
     <img src="../docs/img/Fatal_System_Logo_FINAL.png" alt="logo da Fatal System" width="200">
     <h2 align="center"> Fatal System</h2>
</p>

<p align="center">
 | <a href="#objetivo">Objetivo da Sprint</a> |
 <a href="#realizacoes">Principais Realizações</a> |
 <a href="#dor">DoR</a> |
 <a href="#dod">DoD</a> |
 <a href="#desafios">Desafios</a> |
 <a href="#equipe">Equipe</a> |
</p>

> Status da Sprint: Concluída ✅
> Período: 15/09 a 22/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Avançar na modelagem da interação entre objetos e componentes, focando na criação do Diagrama de Comunicação e do Diagrama de Visão Geral da Interação. O objetivo é compreender como os elementos do sistema colaboram para realizar funcionalidades, suportando o desenvolvimento e a arquitetura.

## 📋 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Levantamento de Entidades:** Identificação dos principais objetos e componentes (Forms, Repositories, Classes de Domínio) e suas responsabilidades em processos como Login e Adição/Edição de Usuários.
* **Construção do Diagrama de Comunicação:** Mapeamento das interações, mensagens numeradas e relacionamentos entre objetos para casos de uso específicos (ex: Login, AddUsuario, EditarUsuario - conforme `Diagramas.pdf`, páginas 3, 17, etc.). Foco na colaboração estrutural.
* **Construção do Diagrama de Visão Geral da Interação:** Desenvolvimento de diagramas de alto nível mostrando a sequência de interações entre diferentes partes do sistema (ex: Visão Geral Chamados, Visão Geral Usuários - `Diagramas.pdf`, páginas 12, 29).
* **Validação e Ajustes:** Apresentação dos diagramas para feedback e realização de ajustes para clareza e alinhamento com os requisitos.
* **Documentação e Versionamento:** Detalhamento das interações e inclusão dos diagramas na documentação do projeto.

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

* Complexidade em representar claramente as múltiplas interações entre objetos sem perder a simplicidade visual.
* Alinhamento das interações com as funcionalidades definidas em sprints anteriores para garantir consistência.
* Garantir que a visão geral seja compreensível para diferentes públicos, do time técnico a stakeholders não técnicos.
* Necessidade de iterar o diagrama para incorporar feedbacks diversos em pouco tempo.

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
