# 📋 Gerenciador de Pedidos

Este projeto é uma aplicação simples para **gerenciamento de pedidos**, desenvolvida como parte de um teste.

## 🧩 Tecnologias utilizadas:

#### ⚙️ Backend (API)
- ASP.NET Core Web API  
- Entity Framework Core (acesso a dados)  
- SQL Server (banco de dados relacional)  
- Swagger (documentação e testes dos endpoints)

#### 🖥️ Frontend
- Blazor (interface web moderna em C#)

## 🧪 Como rodar o projeto localmente

### 🔄 Pré-requisitos

- [.NET 6 SDK ou superior](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- Visual Studio ou VS Code com extensão C#

### 🧰 Passos para executar

Execute a migration para criar o banco:

```bash
Add-Migration InitialCreate -OutputDir DataBase/Migrations
Update-Database
```
---
