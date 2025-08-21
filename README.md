# Gerenciamento de chamados

Esse trabalho é referente ao Projeto Integrado Multidisciplinar da Faculdade UNIP de São José dos Campos, criado em equipe.

## Desafio <a id="desafio"></a>
O desafio consiste em criar um sistema de gerenciamento de chamados triados por uma Inteligência Artificial (IA).

O sistema deve permitir que chamados abertos pelos usuários sejam analisados automaticamente pela IA, que irá propor soluções inteligentes para a equipe de TI responsável. A equipe, ao receber essas propostas, deve validar a veracidade das soluções sugeridas, podendo aceitá-las, ajustá-las ou rejeitá-las.

Conforme as respostas são tratadas, todo o histórico dos chamados é armazenado em um repositório centralizado, garantindo rastreabilidade e aprendizado contínuo. Esse histórico pode ser acessado tanto pela equipe de TI quanto pelo administrador e pela própria IA, permitindo consultas, análises e apoio na tomada de decisões em futuras ocorrências.

O objetivo principal é otimizar o fluxo de atendimento, reduzir a sobrecarga da equipe de TI e melhorar a eficiência do processo de resolução de chamados dentro da organização.


## Backlog do Sistema
Os requisitos do trabalho estão dividos em requisitos funcionais que descrevem funcionalidades do trabalho, e requisitos não funcionais descrevem requisitos como: tecnologia a ser utilizada, arquitetura, ambiente, etc. 

## Requisitos Funcionais

### 1. Gerenciamento de chamados

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|   1  |    Alta    | O sistema deve permitir que o usuário crie um novo chamado, informando título, descrição, categoria e prioridade.                                                                                              |      14      |    1   |          R01         |    ❌   |
|   2  |    Alta    | O usuário deve poder revisar os dados preenchidos antes de confirmar o envio do chamado.                                                                                                                       |      47      |    1   |          R02         |    ❌   |
|   3  |    Alta    | O sistema deve permitir anexar um ou mais arquivos ao chamado antes do envio e também após o chamado ter sido criado (enquanto estiver em aberto)                                                              |      28      |    1   |          R03         |    ❌   |
|   4  |    Alta    | Antes de enviar o chamado, o sistema realiza uma primeira checagem para garantir que todos os campos obrigatórios estejam preenchidos.                                                                         |      22      |    1   |          R04         |    ❌   |
|   5  |    Alta    | Se o sistema identificar um campo em branco, o chamado não é enviado e o funcionário é informado para preencher os dados.                                                                                      |      29      |    1   |          R05         |    ❌   |
|   6  |    Alta    | Caso a dupla checagem seja concluída com sucesso, o funcionário envia o chamado para a equipe de suporte.                                                                                                      |      41      |    1   |          R06         |    ❌   |
|   7  |    Alta    | Sistema permite anexar mais arquivos em um chamado já existente.                                                                                                                                               |       3      |    2   |          R07         |    ❌   |
|   8  |    Alta    | O sistema deve permitir que o usuário visualize os chamados criados, de acordo com o seu nível de acesso.                                                                                                      |       5      |    2   |          R08         |    ❌   |


### 2. Gerenciamento de Usuário

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|  9  |    Alta    | Como Administrador, eu gostaria de ser o primeiro usuário do sistema, já devidamente pré inserido no banco de dados, para que possa acessar a aplicação.                                                       |      44      |    1   |          R09         |    ❌   |
|  10  |    Média   | Como Administrador, eu quero cadastrar novos usuários na plataforma, para que somente pessoas autorizadas possam acessá-la.                                                                                    |      17      |    3   |          R10         |    ❌   |
|  11  |    Média   | Como usuário, eu quero acessar a aplicação através de uma interface de login, para que somente usuários autorizados possam utilizar o sistema.                                                                 |      13      |    3   |          R11         |    ❌   |
|  12  |    Média   | Como usuário autorizado, eu quero acessar o sistema através de um login, para utilizar a aplicação.                                                                                                            |      23      |    3   |          R12         |    ❌   |
|  13  |    Média   | Como usuário autenticado, eu quero poder fazer o logout da aplicação de forma segura, para que meus dados não fiquem acessíveis a terceiros.                                                                   |      18      |    3   |          R13         |    ❌   |
|  14  |    Média   | Como Administrador, quero poder editar os dados dos usuarios, caso os mesmos solicitem.                                                                                                                        |       2      |    2   |          R14         |    ❌   |
|  15  |    Média   | Como Administrador, eu quero visualizar a lista de usuários cadastrados, para que eu possa gerenciar quem tem acesso ao sistema.                                                                               |      20      |    3   |          R15         |    ❌   |
|  16  |    Média   | Como Administrador, eu quero redefinir a senha de um usuário, para que eu possa ajudá-lo caso ele não consiga acessar a conta.                                                                                 |      18      |    3   |          R16         |    ❌   |
|  17  |    Média   | Como Administrador, eu quero excluir usuários do sistema, para que possa revogar o acesso de usuários a aplicação.                                                                                             |      13      |    3   |          R17         |    ❌   |
|  18  |    Baixa   | Como Administrador, ter a capacidade de denominar niveis de acesso ao sistema de acordo com a função do funcionario.                                                                                           |       2      |    2   |          R18         |    ❌   |



### 3. Gerenciamento de Relatórios

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|  19  |    Baixa   | Como usuário, De acordo com o nível de acesso, gerar relatórios anuais, mensais e semanais.                                                                                                                    |       2      |    2   |          R19         |    ❌   |
|  20  |    Baixa   | Como usuário, Poder gerar relatórios baseado em prioridades.                                                                                                                                                   |       1      |    2   |          R20         |    ❌   |
|  21  |    Baixa   | Como usuário, Gerar relatórios de acordo com o tipo de chamado mais requisitado.                                                                                                                               |      16      |    3   |          R21         |    ❌   |
|  22  |    Baixa   | Como usuario, poder Filtrar os relatórios de acordo com data, prioridade e tipo.                                                                                                                               |      16      |    3   |          R22         |    ❌   |
|  23  |    Baixa   | Como Admnistrador, poder visualizar os relatórios gerados.                                                                                                                                                     |      16      |    3   |          R23         |    ❌   |

### 4. Gerenciamento de IA

| Rank | Prioridade | User Story                                                                                                                                                                                                     | Story Points | Sprint | Requisito do Cliente | Status |
| :--: | :--------: | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------: | :----: | :------------------: | :----: |
|  24  |    Baixa   | A IA deve classificar automaticamente os chamados em níveis de prioridade (alta, média, baixa) com base no conteúdo e na urgência relatada.                                                                    |      16      |    3   |          R24         |    ❌   |
|  25  |    Baixa   | A IA vai identificar o chamado e agrupar na sua respectiva categoria.                                                                                                                                          |      16      |    3   |          R25         |    ❌   |
|  26  |    Baixa   | IA recebe o chamado e analisa as palavras chaves.                                                                                                                                                              |      16      |    3   |          R26         |    ❌   |
|  27  |    Baixa   | A IA também deve encaminhar o chamado para o setor responsável com base na análise feita.                                                                                                                      |      16      |    3   |          R27         |    ❌   |
|  28  |    Baixa   | IA concede solução para setor responsável de TI de acordo com o sugerido pelas palavras chaves.                                                                                                                |      16      |    3   |          R28         |    ❌   |


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

## Requisitos Não-Funcionais
### 1. UML

* Astah UML

### 2. Banco de Dados Relacionais
* Br Modelo (DER e MER)
* SQL Server

### 3. Documentação
* Word
* Excel

## Solução Proposta
* Priorização e Categorização de chamados por IA
* Capacidade de IA propor soluções dos chamados para Equipe de TI
* Geração de relatórios mensais, semanais e anuais dos chamados
* Criação de Usuario pelo Admin


## Tecnologias Utilizadas
* [Figma](https://www.figma.com/)
* [Astah](https://astah.net/)
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
* [Br Modelo](https://www.brmodeloweb.com/lang/pt-br/index.html)


## Integrantes do grupo

Nome | Github | Instagram
------------ | ------------- | -----------

Frederico Barreto Godoi Dellú| [Acessar Github](https://github.com/Fredeavatar) | [Acessar Instagram](https://www.instagram.com/fredericodellu_?igsh=MXcwa3d0djQzZzZ5MQ==)
