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
