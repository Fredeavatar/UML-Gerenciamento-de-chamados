# Relatório da Sprint 9

## Sprint 9 - Definição do Diagrama de Objetos  
## Período: 13/10 a 20/10

### Objetivo do Sprint:
Esta sprint teve como objetivo a **definição e modelagem do Diagrama de Objetos** do sistema. Esse diagrama é fundamental para:

- Representar instâncias concretas das classes em um determinado momento do sistema.
- Demonstrar exemplos reais de objetos, seus estados e relacionamentos dinâmicos.
- Auxiliar na validação da modelagem de classes e dos fluxos de interação.

O foco foi construir uma visão prática do sistema em funcionamento, baseada nos modelos conceituais definidos nas sprints anteriores.

### Realizações:
#### 1. Modelagem de Objetos Instanciados

- **Usuário: Ana Silva**
  - id: 001
  - nome: Ana Silva
  - email: ana.silva@email.com
  - tipo: Administrador
  - status: Ativo

- **Chamado: CH12345**
  - id: CH12345
  - titulo: "Erro no acesso ao sistema"
  - categoria: TI
  - urgencia: Alta
  - status: Em andamento
  - dataAbertura: 15/10/2025

- **Relatório: Relatório_10_2025**
  - filtroDataInicio: 01/10/2025
  - filtroDataFim: 15/10/2025
  - tipoRelatorio: Chamados Abertos

- **IA_Triagem: Modelo_v1**
  - modeloIA: ChatGPT API v1
  - parametrosTriagem: {palavras-chave, prioridade, categoria}

- **Notificação: Notif_001**
  - destinatario: Ana Silva
  - mensagem: "Chamado CH12345 atualizado"
  - statusEnvio: Enviado

#### 2. Representação dos Relacionamentos entre Objetos

- O objeto **Usuário: Ana Silva** abriu o **Chamado: CH12345**.
- O **Chamado: CH12345** foi analisado pela instância **IA_Triagem: Modelo_v1** para categorização.
- Uma **Notificação: Notif_001** foi gerada para o usuário Ana Silva referente ao chamado.
- O **Relatório: Relatório_10_2025** inclui o chamado CH12345 dentro do filtro aplicado.

---

### Desafios Enfrentados

- Selecionar exemplos representativos que cubram os principais casos de uso do sistema.
- Garantir que os estados dos objetos fossem coerentes e refletissem o comportamento esperado.
- Ajustar o nível de detalhamento para que o diagrama de objetos fosse compreensível e útil para a equipe.
- Manter a consistência com os diagramas de classes e sequência previamente elaborados.
