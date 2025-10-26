# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 6

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
> Período: 22/09 a 29/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Modelar os Diagramas de Sequência para as funcionalidades centrais: Gerenciamento de usuários, Gerenciamento e triagem de chamados (incluindo IA), Anexar Arquivos, Geração/visualização de relatórios e Tratamento de Chamados. O objetivo é representar o fluxo temporal das interações entre objetos/atores.

## 📋 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Diagrama de Sequência - Adicionar Usuário:** Modelagem do fluxo desde o clique no botão até a gravação no banco e retorno (`Diagramas.pdf`, página 4).
* **Diagrama de Sequência - Editar Usuário:** Fluxo similar ao de adicionar, mas com foco na atualização (`Diagramas.pdf`, página 18).
* **Diagrama de Sequência - Visualizar Usuário:** Fluxo de duplo clique na lista até a exibição dos detalhes (`Diagramas.pdf`, página 50).
* **Diagrama de Sequência - Criar Chamado:** Detalhamento do preenchimento do formulário, validação, chamada à IA, gravação no banco e retorno ao usuário (`Diagramas.pdf`, página 54).
* **Diagrama de Sequência - Anexar Arquivo:** Interação para selecionar e carregar o arquivo para memória (`Diagramas.pdf`, página 7).
* **Diagrama de Sequência - Tratar Chamado:** Fluxo iniciado pela EquipeTI, captura de clique, atualização no banco (Chamado e Histórico) e retorno (`Diagramas.pdf`, página 37).
* **Diagrama de Sequência - Gerar/Filtrar Relatórios:** Interação para aplicar filtros, buscar dados no repositório (Chamado e Usuário) e exibir resultado (`Diagramas.pdf`, páginas 23, 27).
* **Diagrama de Sequência - Treinar IA:** Fluxo de revisão de histórico, ajuste de solução (opcional) e chamada ao método de ajuste da IA (`Diagramas.pdf`, página 41).

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
* Alinhamento entre formulários e lógica de IA: Ajustes foram necessários para garantir que os dados enviados fossem suficientes para a classificação.
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
