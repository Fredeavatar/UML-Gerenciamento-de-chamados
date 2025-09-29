# Relatorio da Sprint 6

## Sprint 6 - Criação de Diagramas de Sequencia. 
## Período: 22/09 a 29/09

### Objetivo do Sprint:
Esta sprint teve como objetivo avançar na definição de funcionalidades centrais do sistema, com foco em:
Estruturar os módulos de gerenciamento de usuários e chamados,Definir os parâmetros e critérios para a atuação da inteligência artificial no sistema,
Estabelecer os requisitos para o módulo de relatórios.
Essas definições são fundamentais para orientar o desenvolvimento das funcionalidades nas próximas sprints.

### Realizações:
#### 1. Gerenciamento de Usuários
- Definição das funcionalidades de cadastro, edição e gerenciamento de usuários.
- Especificação dos campos obrigatórios (nome, e-mail, senha, tipo de usuário, status).
- Estabelecimento de níveis de acesso (ex: administrador, agente, usuário comum).

#### 2. Inteligência Artificial (IA)
- Escolha da IA a ser utilizada: [Nome da IA/serviço escolhido, ex: ChatGPT API, IBM Watson, etc.] com base em critérios de escalabilidade, custo e integração.
- Definição de parâmetros para triagem automática de chamados, como:
- Análise de palavras-chave no título e descrição.
- Priorização com base em urgência e categoria.
- Categorização automática por área (ex: TI, RH, Financeiro).

#### 3. Gerenciamento de Chamados
- Definição dos campos do formulário de chamado, incluindo:
- Título
- Descrição detalhada
- Categoria
- Nível de urgência
- Anexos (opcional)
- Estabelecido quais dados são obrigatórios para submissão:
- Título, descrição, categoria e urgência.

#### 4. Gerenciamento de Relatórios
- Definição dos filtros por data para visualização de chamados:
- Período personalizado
- Filtros rápidos: Hoje, Últimos 7 dias, Últimos 30 dias
- Filtro por intervalo (Data de abertura e/ou fechamento)

### Desafios Enfrentados

- Escolha da IA: O mercado oferece diversas opções com propostas semelhantes, o que exigiu análise comparativa detalhada.
- Complexidade nos critérios de triagem automática: Alguns parâmetros exigiram testes preliminares com dados simulados para garantir eficácia.
- Alinhamento dos campos do chamado com o processo de triagem da IA: Foi necessário ajustar os dados coletados para alimentar corretamente o sistema inteligente.
- Escopo dos relatórios: A definição de filtros que fossem úteis sem tornar o sistema excessivamente complexo foi um ponto de debate entre a equipe e stakeholders.
