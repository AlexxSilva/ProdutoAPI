📦 ProdutoAPI


API RESTful de exemplo desenvolvida em ASP.NET Core, com foco em boas práticas de arquitetura e extensibilidade. A API permite criação e listagem de produtos, utilizando Entity Framework Core, eventos com EventArgs, e uma estrutura em camadas.

🚀 Funcionalidades
✅ Criar e listar produtos.

🔔 Disparo de evento ao cadastrar um produto (EventArgs), permitindo integração com ações adicionais (ex: envio de e-mail).

💾 Persistência de dados com SQL Server (adaptável para outros bancos).

🧪 Estrutura preparada para testes e manutenção.

🏗️ Arquitetura
Domain: entidades e contratos.

Application: interfaces e serviços de aplicação.

Infra: implementação de acesso a dados com Entity Framework Core.

UI: camada de apresentação com ASP.NET Core Web API.

🛠️ Tecnologias Utilizadas
.NET 8 (ASP.NET Core Web API)

Entity Framework Core

SQL Server

C# 10/11

Injeção de dependência

async/await

EventArgs para eventos customizados

📋 Pré-requisitos
.NET 8 SDK ou superior instalado

Instância do SQL Server rodando localmente ou remotamente

🧪 Como rodar o projeto
bash
Copiar
Editar
git clone https://github.com/AlexxSilva/ProdutoAPI.git
cd ProdutoAPI
📄 Configure a string de conexão no appsettings.json:
json
Copiar
Editar
"ConnectionStrings": {
  "ConexaoPadrao": "Server=localhost;Database=Produtos;Trusted_Connection=True;"
}
🔄 Execute as migrações (se necessário):
bash
Copiar
Editar
dotnet ef database update
▶️ Rode a aplicação:
bash
Copiar
Editar
dotnet run
📡 Endpoints disponíveis
Método	URL	Descrição
GET	/api/produtos	Lista todos os produtos
POST	/api/produtos	Cria um novo produto

🔔 Eventos
Sempre que um produto é incluído, um evento personalizado é disparado usando EventArgs, permitindo acoplamento leve para notificações ou integrações, como:

Envio de e-mails


