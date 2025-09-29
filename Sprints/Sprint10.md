# Relatório da Sprint 10

## Sprint 10 - Definição do Diagrama de Pacotes  
## Período: 20/10 a 27/10

### Objetivo do Sprint:
Esta sprint teve como objetivo a **definição e modelagem do Diagrama de Pacotes** do sistema. Esse diagrama é essencial para:

- Organizar e agrupar as classes e componentes em pacotes lógicos.
- Facilitar a compreensão da estrutura do sistema em níveis mais altos.
- Auxiliar na modularização e manutenção do código, promovendo baixo acoplamento entre pacotes.

O foco foi estruturar a arquitetura do sistema em blocos coerentes alinhados com os domínios funcionais já definidos.

### Realizações:
#### 1. Estruturação dos Pacotes Principais

- **Pacote: Autenticação**
  - Contém classes relacionadas à autenticação e controle de acesso.
  
- **Pacote: Usuários**
  - Inclui classes para cadastro, gerenciamento e perfil de usuários.
  
- **Pacote: Chamados**
  - Abriga classes responsáveis pela criação, acompanhamento e fechamento de chamados.
  
- **Pacote: Inteligência Artificial**
  - Contém classes para integração e processamento da triagem automática de chamados.
  
- **Pacote: Relatórios**
  - Engloba classes para geração, filtragem e exportação de relatórios.
  
- **Pacote: Notificações**
  - Classes responsáveis pelo envio e gerenciamento de notificações aos usuários.
  
- **Pacote: Interface**
  - Contém componentes da interface web (frontend) e APIs.

#### 2. Definição das Dependências entre Pacotes

- O pacote **Usuários** depende do pacote **Autenticação** para validar permissões.
- O pacote **Chamados** depende dos pacotes **Usuários** e **Inteligência Artificial** para triagem.
- O pacote **Relatórios** consome dados dos pacotes **Chamados** e **Usuários**.
- O pacote **Notificações** é acionado por eventos gerados em **Chamados** e **Usuários**.
- O pacote **Interface** interage com todos os pacotes para oferecer a experiência completa ao usuário.

---

### Desafios Enfrentados

- Definir limites claros entre os pacotes para evitar sobreposição de responsabilidades.
- Balancear a granularidade dos pacotes para manter modularidade sem fragmentar demais o sistema.
- Garantir que as dependências fossem unidirecionais para evitar ciclos e facilitar manutenção.
- Alinhar a estrutura de pacotes com os requisitos de escalabilidade e flexibilidade futuros.
