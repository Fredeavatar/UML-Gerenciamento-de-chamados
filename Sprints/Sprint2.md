# Relatório da Sprint 2

## Sprint 2 - Definição do gerenciamento de usuários, IA, chamados e relatórios  
## Período: 25/08 a 01/09

### Objetivo do Sprint:
Esta sprint teve como objetivo avançar na definição das funcionalidades centrais do sistema, com foco em:

- Estruturar os módulos de gerenciamento de usuários e chamados.
- Definir os parâmetros e critérios para a atuação da inteligência artificial no sistema.
- Estabelecer os requisitos para o módulo de relatórios.

Essas definições são fundamentais para orientar o desenvolvimento das funcionalidades nas próximas sprints.

### Realizações:
#### 1. Gerenciamento de Usuários
- Definição das funcionalidades de cadastro, edição e gerenciamento de usuários.
- Especificação dos campos obrigatórios: nome, e-mail, senha, tipo de usuário e status.
- Estabelecimento de níveis de acesso, como administrador, agente e usuário comum.

#### 2. Inteligência Artificial (IA)
- Escolha da IA a ser utilizada: [Nome da IA/serviço escolhido, ex: ChatGPT API, IBM Watson, etc.] com base em critérios de escalabilidade, custo e integração.
- Definição de parâmetros para triagem automática de chamados, incluindo:
  - Análise de palavras-chave no título e descrição.
  - Priorização com base em urgência e categoria.
  - Categorização automática por área, como TI, RH e Financeiro.

#### 3. Gerenciamento de Chamados
- Definição dos campos do formulário de chamado, contemplando:
  - Título
  - Descrição detalhada
  - Categoria
  - Nível de urgência
  - Anexos (opcional)
- Estabelecimento dos dados obrigatórios para submissão: título, descrição, categoria e urgência.

#### 4. Gerenciamento de Relatórios
- Definição dos filtros para visualização de chamados, incluindo:
  - Período personalizado
  - Filtros rápidos: Hoje, Últimos 7 dias, Últimos 30 dias
  - Filtro por intervalo (data de abertura e/ou fechamento)

---

### Desafios Enfrentados
- **Escolha da IA:** Diversas opções semelhantes no mercado exigiram análise comparativa detalhada.
- **Complexidade nos critérios de triagem automática:** Alguns parâmetros precisaram de testes preliminares com dados simulados para garantir eficácia.
- **Alinhamento dos campos do chamado com o processo de triagem da IA:** Ajustes necessários para que os dados coletados alimentassem corretamente o sistema inteligente.
- **Escopo dos relatórios:** Definição de filtros úteis sem tornar o sistema excessivamente complexo gerou debates entre equipe e stakeholders.
