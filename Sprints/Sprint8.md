# Relatório da Sprint 8

## Sprint 8 - Definição do Diagrama de Classes  
## Período: 06/10 a 13/10

### Objetivo do Sprint:
Esta sprint teve como objetivo a **definição e modelagem do Diagrama de Classes** do sistema. Esse diagrama é fundamental para:

- Especificar as classes do sistema, seus atributos, métodos e relacionamentos.
- Definir a estrutura estática e os contratos entre os objetos.
- Servir como base para o desenvolvimento orientado a objetos, garantindo organização e clareza no código.

O foco foi consolidar a modelagem dos principais domínios do sistema, alinhando as funcionalidades definidas nas sprints anteriores.

### Realizações:
#### 1. Modelagem das Classes Principais

- **Usuário**
  - Atributos: id, nome, email, senha, tipo, status
  - Métodos: autenticar(), atualizarPerfil(), alterarStatus()
  
- **Chamado**
  - Atributos: id, titulo, descricao, categoria, urgencia, status, dataAbertura, dataFechamento
  - Métodos: criarChamado(), atualizarStatus(), anexarArquivo()
  
- **Relatório**
  - Atributos: id, filtroDataInicio, filtroDataFim, tipoRelatorio
  - Métodos: gerarRelatorio(), aplicarFiltro()
  
- **IA_Triagem**
  - Atributos: modeloIA, parametrosTriagem
  - Métodos: analisarChamado(), categorizar(), priorizar()
  
- **Notificacao**
  - Atributos: id, destinatario, mensagem, statusEnvio
  - Métodos: enviar(), agendarEnvio()

#### 2. Definição dos Relacionamentos entre Classes

- **Usuário** — (1) —— (N) —> **Chamado**  
  Um usuário pode abrir múltiplos chamados.

- **Chamado** — (1) —— (1) —> **IA_Triagem**  
  Cada chamado é analisado pela IA para triagem automática.

- **Chamado** — (1) —— (N) —> **Notificacao**  
  Chamados geram múltiplas notificações para os usuários envolvidos.

- **Relatório** — depende dos dados das classes **Chamado** e **Usuário** para geração.

---

### Desafios Enfrentados

- Definir os métodos corretos para cada classe, garantindo que refletissem todas as funcionalidades esperadas.
- Alinhar a granularidade das classes para evitar classes muito genéricas ou excessivamente detalhadas.
- Modelar corretamente as associações, especialmente para a integração com a inteligência artificial.
- Garantir que o diagrama estivesse alinhado com os diagramas de sequência e componentes já criados.
