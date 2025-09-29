# Relatório da Sprint 6

## Sprint 6 - Criação de Diagramas de Sequência  
## Período: 22/09 a 29/09

### Objetivo do Sprint:
O principal objetivo desta sprint foi modelar os diagramas de sequência correspondentes às funcionalidades centrais do sistema. Essa atividade visa representar, de forma clara e técnica, o fluxo de interação entre os usuários (atores) e os componentes do sistema, servindo como base para a implementação futura das funcionalidades. As áreas de foco incluíram:

- Gerenciamento de usuários  
- Gerenciamento e triagem inteligente de chamados  
- Geração e visualização de relatórios  

Esses diagramas auxiliam no alinhamento entre equipe técnica e stakeholders, reduzindo ambiguidades e antecipando possíveis ajustes de lógica.

### Realizações:
#### 1. Diagrama de Sequência - Gerenciamento de Usuários
- Modelagem das sequências para as ações de:
  - Cadastro de novo usuário  
  - Edição de perfil  
  - Alteração de status (ativo/inativo)  
- Representação das interações entre o ator "Administrador", a interface do sistema e o backend.  
- Inclusão da validação de campos obrigatórios: nome, e-mail, senha, tipo de usuário e status.  
- Diagrama contempla a verificação de permissões com base no tipo de usuário.

#### 2. Diagrama de Sequência - Inteligência Artificial na Triagem de Chamados
- Modelagem da lógica de triagem automática ao criar um chamado.  
- Interação entre o ator "Usuário", o sistema e o serviço de IA selecionado: [Nome da IA escolhida, ex: ChatGPT API ou IBM Watson].  
- Passos representados:  
  - Envio de dados do chamado (título, descrição, urgência, categoria)  
  - Análise por palavras-chave  
  - Priorização e categorização automática  
- Inclusão de fluxos alternativos para casos em que a IA não consiga classificar o chamado.  
- Retorno do resultado da IA ao sistema.

#### 3. Diagrama de Sequência - Submissão e Acompanhamento de Chamados
- Criação do diagrama que representa:  
  - Preenchimento e envio do formulário de chamado  
  - Validação dos campos obrigatórios: título, descrição, categoria e urgência  
  - Armazenamento do chamado e atribuição de ID  
  - Confirmação visual ao usuário  
- Fluxo de acompanhamento com a visualização de status e atualizações.

#### 4. Diagrama de Sequência - Geração de Relatórios
- Representação das interações para:  
  - Aplicação de filtros (datas e status)  
  - Consulta ao banco de dados  
  - Geração e exibição de relatório  
- Filtros modelados:  
  - Período personalizado  
  - Filtros rápidos (Hoje, Últimos 7 dias, Últimos 30 dias)  
  - Intervalo de abertura/fechamento  
- Atores envolvidos: Administrador e Analista

---

### Desafios Enfrentados
- Escolha da IA: Exigiu pesquisa técnica detalhada para modelar corretamente a integração com o serviço selecionado.  
- Complexidade nos fluxos de triagem automática: A IA demanda parâmetros bem definidos; o diagrama precisou considerar fluxos alternativos e falhas.  
- Alinhamento entre formulários e lógica de IA: Ajustes foram necessários para garantir que os dados enviados fossem suficientes para a classificação.  
- Representação visual dos relatórios: A variedade de filtros trouxe desafios na modelagem de interações com o banco de dados, exigindo clareza na definição dos fluxos.
