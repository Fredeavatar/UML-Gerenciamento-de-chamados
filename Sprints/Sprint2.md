# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 2

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
> Período: 25/08 a 01/09

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Avançar na definição das funcionalidades centrais do sistema, focando em estruturar os módulos de gerenciamento de usuários e chamados, definir os parâmetros para a atuação da inteligência artificial (IA) e estabelecer os requisitos para o módulo de relatórios, orientando o desenvolvimento futuro.

## 📋 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Gerenciamento de Usuários:**
    * Definição das funcionalidades de CRUD (Cadastro, Edição, Gerenciamento).
    * Especificação de campos obrigatórios (nome, e-mail, senha, tipo, status).
    * Estabelecimento de níveis de acesso (administrador, agente, usuário comum).
* **Inteligência Artificial (IA):**
    * Escolha preliminar da IA/serviço a ser utilizado (baseado em escalabilidade, custo, integração).
    * Definição de parâmetros para triagem automática (análise de palavras-chave, priorização por urgência/categoria, categorização por área).
* **Gerenciamento de Chamados:**
    * Definição dos campos do formulário (Título, Descrição, Categoria, Urgência, Anexos).
    * Estabelecimento dos dados obrigatórios para submissão (título, descrição, categoria, urgência).
* **Gerenciamento de Relatórios:**
    * Definição dos filtros de visualização (Período personalizado, filtros rápidos, intervalo de datas).

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
