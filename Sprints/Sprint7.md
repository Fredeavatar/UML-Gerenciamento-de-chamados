# Relatório da Sprint 7

## Sprint 7 - Definição do Diagrama de Componentes e de Implantação  
## Período: 29/09 a 06/10

### Objetivo do Sprint:
Esta sprint teve como objetivo a definição e modelagem do Diagrama de Componentes e do Diagrama de Implantação do sistema. Essas representações são fundamentais para:  
- Especificar a estrutura modular do sistema (componentes e suas responsabilidades).  
- Visualizar a distribuição física e lógica dos componentes na infraestrutura (servidores, dispositivos, etc.).  
- Apoiar decisões de arquitetura, escalabilidade e manutenção do sistema.  

O foco foi consolidar a visão arquitetural baseada nas funcionalidades já definidas nas sprints anteriores.

### Realizações:
#### 1. Diagrama de Componentes
- Identificação e modelagem dos principais módulos do sistema, incluindo:  
  - Módulo de Autenticação  
  - Módulo de Gerenciamento de Usuários  
  - Módulo de Chamados  
  - Módulo de Inteligência Artificial (IA)  
  - Módulo de Relatórios  
  - Módulo de Notificações  
  - Interface Web (Frontend)  
  - API REST  
  - Banco de Dados  

- Especificação das interfaces e contratos de comunicação entre os componentes:  
  - Comunicação via API REST entre frontend e backend  
  - Integração entre backend e serviço externo de IA  
  - Interações entre backend e banco de dados relacional  

- Definição de dependências entre componentes:  
  - O módulo de IA depende de um serviço externo.  
  - O módulo de relatórios consome dados de chamados e usuários.  
  - O módulo de notificações é acionado por eventos em chamados e usuários.

#### 2. Diagrama de Implantação
- Modelagem da infraestrutura necessária para o sistema em produção, incluindo:  
  - Servidor de Aplicação (Backend)  
  - Servidor Web (Frontend)  
  - Servidor de Banco de Dados  
  - Serviço de IA externo (API Cloud)  
  - Rede de comunicação segura (HTTPS, VPN opcional)  

- Distribuição dos componentes em nós físicos e virtuais:  
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

---

### Desafios Enfrentados
- Mapeamento claro dos componentes reutilizáveis: foi necessário revisar a arquitetura para garantir baixo acoplamento e alta coesão.  
- Definição da infraestrutura ideal: a equipe precisou considerar custos, segurança e desempenho ao propor a implantação.  
- Integração com serviços externos: o uso da IA como serviço exigiu análise cuidadosa sobre pontos de falha e latência.  
- Adoção de contêineres (Docker): parte da equipe teve curva de aprendizado ao representar corretamente a implantação em ambientes virtualizados.
