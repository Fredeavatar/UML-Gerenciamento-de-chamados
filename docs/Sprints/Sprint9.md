# PIM - Análise e Desenvolvimento de Sistemas (UNIP SJC)

# Fatal System - Gerenciamento de Chamados com Triagem por IA

# Documentação - Sprint 9

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
> Período: 13/10 a 20/10

## 🏅 Objetivo da Sprint <a id="objetivo"></a>

Definição e modelagem do Diagrama de Objetos do sistema. O objetivo é representar instâncias concretas das classes em um momento específico (uma "fotografia"), demonstrando exemplos reais de objetos, seus estados (valores dos atributos) e relacionamentos para validar a modelagem de classes e os fluxos.

## 📋 Principais Realizações da Sprint <a id="realizacoes"></a>

* **Modelagem de Objetos Instanciados:**
    * `Frederico: Funcionario` (IdUsuario=2, Nome=Frederico, CPF=..., RG=..., FuncaoUsuario=Operador, Sexo=Masculino, Setor=RH, ...).
    * `chamado15: Chamado` (IdChamado=15, FK_IdUsuario=2, PrioridadeChamado=Media, Titulo="Impressora queimou", Categoria=Hardware, DataChamado=15/01/2025 11:00, StatusChamado=Pendente, ...).
    * `anexo01: Arquivo` (IdArquivo=1, TipoArquivo=png, NomeArquivo="ImpressoraQueima...", FK_IdChamado=15).
    * `resposta001: Historico` (IdHistorico=1, FK_IdChamado=15, DataSolucao=15/01/2025 09:30, Acao=Criação, Solucao="Chamado registrado...").
    * `resposta002: Historico` (IdHistorico=2, FK_IdChamado=15, DataSolucao=15/01/2025 09:30, Acao=Mudança de Status, Solucao="O status... 'Pendente' para 'Em Andamento'").
    * (Incluídos outros objetos `Historico` do exemplo na Página 19 do `Diagramas.pdf`).
* **Representação dos Relacionamentos (Links):**
    * Link entre `Frederico: Funcionario` e `chamado15: Chamado`.
    * Link entre `chamado15: Chamado` e `anexo01: Arquivo`.
    * Links entre `chamado15: Chamado` e todos os seus objetos `Historico` associados (`resposta001` a `resposta005`).

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

* Selecionar exemplos representativos que cubram os principais casos de uso do sistema.
* Garantir que os estados (valores dos atributos) dos objetos fossem coerentes e refletissem o comportamento esperado no cenário escolhido.
* Ajustar o nível de detalhamento para que o diagrama de objetos fosse compreensível e útil para a equipe.
* Manter a consistência com os diagramas de classes e sequência previamente elaborados.

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
