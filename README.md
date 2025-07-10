# API para criação de produtos

Projeto exemplo de API RESTful em ASP.NET Core, utilizando:

- Entity Framework Core  para acesso ao banco de dados
- Eventos com `EventArgs` para notificação de ações (ex: pedido aprovado)
- Arquitetura em camadas: Domain, Application, Infra, UI
- Boas práticas de desenvolvimento: injeção de dependência, separação de responsabilidades, async/await

---

## Funcionalidades

- Criar, listar produtos
- Evento disparado quando um produto é incluido, com tratamento via `EventArgs`
- Persistência de dados usando SQL Server (pode ser adaptado para outros bancos)
- Estrutura preparada para facilitar testes e manutenção

---

## Tecnologias

- .NET 8 (ASP.NET Core Web API)
- Entity Framework Core
- SQL Server
- C# 10/11
- 

### Pré-requisitos

- .NET 8 SDK ou superior instalado
- SQL Server rodando localmente ou acesso a um servidor SQL

1. Clone o repositório:

   ```bash
   git clone https://github.com/AlexxSilva/ProdutoAPI.git
   cd ProdutoAPI
   
2. Configure a connection string no arquivo appsettings.json:
   
   "ConnectionStrings": {
  "ConexaoPadrao": "Server=localhost;Database=Produtos;Trusted_Connection=True;"
}

Endpoints disponíveis
Método	URL	Descrição
GET	/api/produtos	Lista todos os produtos
POST	/api/produtos	Cria um novo produto

Eventos
Quando um produto é incluido, um evento é disparado e pode ser tratado para executar ações adicionais, como envio de e-mail (Em produção).
