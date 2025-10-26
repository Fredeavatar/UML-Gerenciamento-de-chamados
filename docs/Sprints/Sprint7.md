# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 7

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
> Período: 29/09 a 06/10

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Definição e modelagem do Diagrama de Componentes e do Diagrama de Implantação do sistema. O objetivo é especificar a estrutura modular, visualizar a distribuição física/lógica na infraestrutura e apoiar decisões de arquitetura, escalabilidade e manutenção.

## 📋 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Diagrama de Componentes:**
    * Identificação e modelagem dos componentes: `App Windows Forms`, `Serviço de IA`, `SQL Server em nuvem Azure` (`Diagramas.pdf`, página 30).
    * Especificação das interfaces providas e requeridas: `IAcessoADados`, `IServicoDeSugestao`, `AcessoADadosSQLServer`, `ServicoDeSugestaoIA`.
    * Definição das dependências entre os componentes (ex: App Forms depende de IAcessoADados e IServicoDeSugestao).
* **Diagrama de Implantação:**
    * Modelagem da infraestrutura: Nó do Cliente (onde roda o App Windows Forms), Nó do Servidor de Banco de Dados (Azure SQL), Nó do Serviço de IA (nuvem Google). *(Inferido do diagrama de componentes e contexto)*.
    * Distribuição dos artefatos/componentes nos nós.
    * Definição dos protocolos de comunicação (ex: TDS, HTTPS).

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

* Mapeamento claro dos componentes reutilizáveis: foi necessário revisar a arquitetura para garantir baixo acoplamento e alta coesão.
* Definição da infraestrutura ideal: a equipe precisou considerar custos, segurança e desempenho ao propor a implantação.
* Integração com serviços externos: o uso da IA como serviço exigiu análise cuidadosa sobre pontos de falha e latência.
* Representar corretamente a implantação distribuída (Cliente/Nuvem).

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
