# Relatório da Sprint 11

## Sprint 11 - Definição do Diagrama de Estrutura Composta  
## Período: 27/10 a 03/11

### Objetivo do Sprint:
Esta sprint teve como objetivo a **definição e modelagem do Diagrama de Estrutura Composta** do sistema. Esse diagrama é fundamental para:

- Representar a estrutura interna dos componentes do sistema.
- Detalhar como os componentes são compostos por partes internas e como essas partes interagem.
- Fornecer uma visão detalhada da organização interna dos elementos para apoiar o desenvolvimento e manutenção.

O foco foi detalhar a composição dos principais módulos e seus relacionamentos internos, alinhando-os com os diagramas anteriores.

### Realizações:
#### 1. Modelagem da Estrutura Interna dos Componentes Principais

- **Componente: Módulo de Usuários**
  - Partes internas: Gerenciador de Cadastro, Validador de Dados, Controle de Permissões
  - Conexões internas para garantir o fluxo correto de dados e permissões

- **Componente: Módulo de Chamados**
  - Partes internas: Criador de Chamados, Analisador de Prioridade, Atualizador de Status
  - Interações entre as partes para processamento completo do ciclo do chamado

- **Componente: Módulo de Inteligência Artificial**
  - Partes internas: Interface com API Externa, Processador de Texto, Módulo de Classificação
  - Definição clara das conexões e fluxo de dados entre as partes

- **Componente: Módulo de Relatórios**
  - Partes internas: Gerador de Filtros, Compilador de Dados, Exportador de Relatórios
  - Comunicação interna para geração e entrega dos relatórios

#### 2. Definição das Conexões e Portas de Comunicação

- Especificação das portas que conectam as partes internas dentro de cada componente.
- Definição dos protocolos e tipos de dados que trafegam entre as partes.
- Estabelecimento das interfaces públicas e privadas para garantir encapsulamento e modularidade.

---

### Desafios Enfrentados

- Detalhar a estrutura interna sem perder a visão geral do sistema, mantendo o equilíbrio entre granularidade e complexidade.
- Garantir a clareza na definição das conexões internas, especialmente em componentes com várias partes.
- Ajustar os diagramas para refletir as interações reais já previstas nos diagramas de sequência e componentes.
- Promover alinhamento entre os times de desenvolvimento e arquitetura para adoção da estrutura definida.
