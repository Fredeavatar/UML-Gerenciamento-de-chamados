# Relatorio da Sprint 7

## Sprint 7 - Definição do Diagrama de Classes.
## Período: 06/10 a 13/10

### Objetivo do Sprint:
Esta sprint teve como objetivo a definição e modelagem do Diagrama de Componentes e do Diagrama de Implantação do sistema. Essas representações são fundamentais para:
  - Especificar a estrutura modular do sistema (componentes e suas responsabilidades).
  - Visualizar a distribuição física e lógica dos componentes na infraestrutura (servidores, dispositivos, etc.).
  - Apoiar decisões de arquitetura, escalabilidade e manutenção do sistema.
   
O foco foi consolidar a visão arquitetural baseada nas funcionalidades já definidas nas sprints anteriores.

### Realizações:
#### 1. Diagrama de Componentes

- *<b>Identificação e modelagem dos principais módulos do sistema, incluindo:</b>*
  - Módulo de Autenticação
  - Módulo de Gerenciamento de Usuários
  - Módulo de Chamados
  - Módulo de Inteligência Artificial (IA)
  - Módulo de Relatórios
  - Módulo de Notificações
  - Interface Web (Frontend)
  - API REST
  - Banco de Dados
    
- *<b>Especificação das interfaces e contratos de comunicação entre os componentes:</b>*
  - Comunicação via API REST entre frontend e backend
  - Integração entre backend e serviço externo de IA
  - Interações entre backend e banco de dados relacional
    
- *<b>Definição de dependências entre componentes:</b>*
  - O módulo de IA depende de um serviço externo.
  - O módulo de relatórios consome dados de chamados e usuários.
  - O módulo de notificações é acionado por eventos em chamados e usuários.

#### 2. Diagrama de Implantação
- *<b>Modelagem da infraestrutura necessária para o sistema em produção, incluindo:</b>*
  - Servidor de Aplicação (Backend)
  - Servidor Web (Frontend)
  - Servidor de Banco de Dados
  - Serviço de IA externo (API Cloud)
  - Rede de comunicação segura (HTTPS, VPN opcional)
    
- *<b>Distribuição dos componentes em nós físicos e virtuais:</b>*
  - Backend e frontend hospedados em containers separados (Docker)
  - Banco de dados em instância dedicada com backups automáticos
  - Serviço de IA hospedado externamente (ex: OpenAI, IBM Watson)
  - Definição de protocolos e portas utilizados:
  - HTTP/HTTPS para comunicação entre usuários e frontend
  - RESTful API entre frontend e backend (porta 8080)
  - Conexão segura com banco de dados (porta 5432, PostgreSQL)
  - Autenticação com token JWT
  - Considerações de segurança e escalabilidade:
  - Camadas separadas para permitir escalonamento horizontal
  - Uso de balanceador de carga para o frontend
  - Monitoramento de performance nos servidores


### Desafios Enfrentados

- <b>*Mapeamento claro dos componentes reutilizáveis:*</b> Foi necessário revisar a arquitetura para garantir baixo acoplamento e alta coesão.
  
- <b>*Definição da infraestrutura ideal:*</b> A equipe precisou considerar custos, segurança e desempenho ao propor a implantação.
  
- <b>*Integração com serviços externos:*</b> O uso da IA como serviço exigiu análise cuidadosa sobre pontos de falha e latência.
  
- <b>*Adoção de contêineres (Docker):*</b> Parte da equipe teve curva de aprendizado ao representar corretamente a implantação em ambientes virtualizados.
