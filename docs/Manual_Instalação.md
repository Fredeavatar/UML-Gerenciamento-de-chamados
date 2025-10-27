## 📖 Manual de Instalação <a id="manual"></a>

### 🛠 Pré-requisitos

* Visual Studio 2019 ou superior (com carga de trabalho ".NET desktop development")
* .NET Framework 4.8 (ou a versão especificada no seu projeto)
* **Acesso a uma instância do SQL Server (Azure SQL ou local).**
* **As tabelas do banco de dados (`Usuario`, `Chamado`, `Historico`, `Arquivo`) devem ser criadas previamente.** 
* Git instalado ([Download](https://git-scm.com/downloads))
* **Uma Chave de API válida para o Google Gemini.**

---

### 1. Clonar o Repositório

```bash
git clone [https://github.com/Frederico-Dellu/Gerenciamento-de-chamados.git](https://github.com/Frederico-Dellu/Gerenciamento-de-chamados.git)
cd Gerenciamento-de-chamados
```
---

### 2. Configurar Conexão com Banco de Dados

* Abra a solução (`.sln`) no Visual Studio.
* **Localize e atualize a `connectionString`** nos arquivos de código-fonte que acessam o banco (ex: `Relatorio.cs`, `FormRelatorioDetalhado.cs`, `Funcoes.cs`, etc.). Você precisará informar o endereço do seu servidor, nome do banco, usuário e senha.
* Certifique-se de que o banco de dados apontado pela `connectionString` **contenha as tabelas necessárias** para o sistema (`Usuario`, `Chamado`, `Historico`, `Arquivo`).
* **Script de Criação do Banco:** [schema_criacao.sql](Script/ScriptSQL.sql) *(Para criar a estrutura exata das tabelas)*

---

### 3. Configurar Chave da API Gemini

* Abra o arquivo `App.config` na raiz do seu projeto.
* **Localize ou adicione a chave `GEMINI_API_KEY`** dentro da seção `<appSettings>`.
* **Insira sua chave de API válida** como valor para esta chave. A aplicação precisa desta chave para se comunicar com a IA Gemini.

---

### 4. Compilar e Executar

* No Visual Studio, vá em `Build` > `Rebuild Solution` (Compilar > Recriar Solução).
* Após a compilação bem-sucedida, pressione `F5` ou clique no botão "Start" (Iniciar) para executar a aplicação.
* Utilize um usuário e senha válidos (previamente cadastrados no seu banco de dados) para fazer login.

---
