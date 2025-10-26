
# Backlog do produto

### 1. Gerenciamento de chamado
<pre>1.a) Criar chamado:
O sistema deve permitir que o usuário crie um novo chamado, informando título, descrição, categoria e prioridade.
O usuário deve poder revisar os dados preenchidos antes de confirmar o envio do chamado.
O sistema deve permitir anexar um ou mais arquivos ao chamado antes do envio e também após o chamado ter sido criado (enquanto estiver em aberto).<br>
1.a.a) Checar chamado:
Antes de enviar o chamado, o sistema realiza uma primeira checagem para garantir que todos os campos obrigatórios estejam preenchidos. 
Se o sistema identificar um campo em branco, o chamado não é enviado e o funcionário é informado para preencher os dados. 
Caso a dupla checagem seja concluída com sucesso, o funcionário envia o chamado para a equipe de suporte.<br>
1.a.b) Anexar mais arquivos:
Sistema permite anexar mais arquivos em um chamado já existente.<br>
  
1.b) Visualizar chamado:
O sistema deve permitir que o usuário visualize os chamados criados, de acordo com o seu nível de acesso.<br> </pre>

### 2. Gerenciamento de Usuário
<pre>2.a) Cadastrar usuário:
Admin cadastra novo usuário.
Sistema gera matrícula.
Admin cadastra senha.<br>
  
2.b) Editar Usuario:
Adm pode editar usuários já criados<br>
  
2.c)Visualizar usuários
Adm pode visualizar funcionários cadastrados.
Adm vai denominar quais permissões os usuários possuem</pre>

### 3. Gerenciamento de Relatórios

<pre>3.a) Gerar relatórios:
De acordo com o nível de acesso pode gerar relatórios anuais, mensais e semanais.
Gerar relatórios baseado em prioridades.
Gerar relatórios de acordo com o tipo de chamado mais requisitado.<br>

3.b) Buscar relatórios:
Filtrar os relatórios de acordo com data, prioridade e tipo.<br>

3.c) Visualizar relatórios:
Admin pode visualizar os relatórios gerados.</pre>
</pre>

### 4. Gerenciamento de IA

<pre>4.a) Priorizar e categorizar chamados:
A IA deve classificar automaticamente os chamados em níveis de prioridade (alta, média, baixa) com base no conteúdo e na urgência relatada.
A IA vai identificar o chamado e agrupar na sua respectiva categoria.
A IA também deve encaminhar o chamado para o setor responsável com base na análise feita.
O administrador poderá revisar e alterar a prioridade, se necessário.<br>
  
4.b) Aplicar solução inteligente:
IA recebe o chamado.
IA analisa palavras chaves do chamado.
IA concede solução para setor responsável de TI de acordo com o sugerido pelas palavras chaves.<br>

</pre>
</pre>

# Modelo em tabela

### 1. Gerenciamento de chamados

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|   1  |    Alta    | O sistema deve permitir que o usuário crie um novo chamado, informando título, descrição, categoria e prioridade.                                                                                              |      20      |    1   |          R05         |    ✅   |
|   2  |    Alta    | O usuário deve poder revisar os dados preenchidos antes de confirmar o envio do chamado.                                                                                                                       |      20      |    1   |          R05         |    ✅   |
|   3  |    Media    | O sistema deve permitir anexar um ou mais arquivos ao chamado antes do envio.                                                                                                                                 |      20      |    1   |          R06         |    ✅   |
|   4  |    Alta    | Antes de enviar o chamado, o sistema realiza uma primeira checagem para garantir que todos os campos obrigatórios estejam preenchidos.                                                                         |      20      |    1   |          R05         |    ❌   |
|   5  |    Alta    | Se o sistema identificar um campo em branco, o chamado não é enviado e o funcionário é informado para preencher os dados.                                                                                      |      20      |    1   |          R05         |    ❌   |
|   6  |    Alta    | Caso a dupla checagem seja concluída com sucesso, o funcionário envia o chamado para a equipe de suporte.                                                                                                      |      20      |    1   |          R05         |    ❌   |
|   7  |    Media    | Sistema permite anexar mais arquivos em um chamado já existente.                                                                                                                                               |       20      |    2   |          R06         |    ❌   |
|   8  |    Alta    | O sistema deve permitir que o usuário visualize os chamados criados, de acordo com o seu nível de acesso.                                                                                                      |       20      |    2   |          R07         |    ❌   |


### 2. Gerenciamento de Usuário

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|  9  |    Alta    | Como Administrador, eu gostaria de ser o primeiro usuário do sistema, já devidamente pré inserido no banco de dados, para que possa acessar a aplicação.                                                       |      20      |    1   |          R01         |    ✅   |
|  10  |    Alta   | Como Administrador, eu quero cadastrar novos usuários na plataforma, para que somente pessoas autorizadas possam acessá-la.                                                                                    |      20      |    3   |          R02         |    ✅   |
|  11  |    Alta   | Como usuário, eu quero acessar a aplicação através de uma interface de login, para que somente usuários autorizados possam utilizar o sistema.                                                                 |      20      |    3   |          R01         |    ✅   |
|  12  |    Alta   | Como usuário autorizado, eu quero acessar o sistema através de um login, para utilizar a aplicação.                                                                                                            |      20      |    3   |          R01         |    ✅   |
|  13  |    Alta   | Como usuário autenticado, eu quero poder fazer o logout da aplicação de forma segura, para que meus dados não fiquem acessíveis a terceiros.                                                                   |      20      |    3   |          R01         |    ✅   |
|  14  |    Média   | Como Administrador, quero poder editar os dados dos usuarios, caso os mesmos solicitem.                                                                                                                        |       15      |    2   |          R03         |    ❌   |
|  15  |    Média   | Como Administrador, eu quero visualizar a lista de usuários cadastrados, para que eu possa gerenciar quem tem acesso ao sistema.                                                                               |      15      |    3   |          R04         |    ❌   |
|  16  |    Alta   | Como Administrador, eu quero redefinir a senha de um usuário, para que eu possa ajudá-lo caso ele não consiga acessar a conta.                                                                                 |      20      |    3   |          R03         |    ❌   |
|  17  |    Alta   | Como Administrador, eu quero excluir usuários do sistema, para que possa revogar o acesso de usuários a aplicação.                                                                                             |      20      |    3   |          R03         |    ❌   |
|  18  |    Alta   | O sistema deve garantir a proteção dos dados dos usuarios conforme as diretrizes da LGPD.                                                                                                                     |       20      |    2   |          R14         |    ❌   |



### 3. Gerenciamento de Relatórios

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|  19  |    Media   | Como usuário, De acordo com o nível de acesso, gerar relatórios anuais, mensais e semanais.                                                                                                                    |       15      |    2   |          R13         |    ❌   |
|  20  |    Baixa   | Como usuário, Poder gerar relatórios baseado em prioridades.                                                                                                                                                   |       10      |    2   |          R13         |    ❌   |
|  21  |    Baixa   | Como usuário, Gerar relatórios de acordo com o tipo de chamado mais requisitado.                                                                                                                               |      10      |    3   |          R13         |    ❌   |
|  22  |    Baixa   | Como usuario, poder Filtrar os relatórios de acordo com data, prioridade e tipo.                                                                                                                               |      10      |    3   |          R13         |    ❌   |
|  23  |    Baixa   | Como Admnistrador, poder visualizar os relatórios gerados.                                                                                                                                                     |      10      |    3   |          R13         |    ❌   |

### 4. Gerenciamento de IA

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|  24  |    Alta   | A IA deve classificar automaticamente os chamados em níveis de prioridade (alta, média, baixa) com base no conteúdo e na urgência relatada.                                                                    |      20      |    3   |          R08         |    ❌   |
|  25  |    Alta   | A IA vai identificar o chamado e agrupar na sua respectiva categoria e encaminhar uma solução a equipe de TI.                                                                                                  |      20      |    3   |          R08         |    ❌   |
|  26  |    Alta   | O admin deve atualizar o banco de dados da IA baseado no historico de chamados resolvidos por ela.                                                                                                            |      20      |    3   |          R09         |    ❌   | 
|  27  |    Alta   | A equipe de TI deve analisar os chamados encaminhados pela IA, de acordo com a prioridade definida e atualizar o status do chamado.                                                                            |      20      |    3   |          R10 e R11         |    ❌   |
|  28  |    Alta   | o Admin pode alterar a prioridade do chamado após sua abertura e classificação pela IA.                                                                                                                        |      20      |    3   |          R12         |    ❌   |
