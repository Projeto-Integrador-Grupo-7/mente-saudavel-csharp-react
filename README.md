# Projeto Mente Saudável (React + ASP.NET Core)

### Para rodar o BackEnd (Visual Studio):
Clicar com botão direito no projeto do backend (MenteSaudavel.Server) -> Clicar em "Set as Startup Project" -> Agora lá em cima no meio, onde tem um botão verde de play, selecionar "https" e dar play.

### Para rodar o BackEnd (Visual Studio Code):
Abrir o terminal do Visual Studio Code -> Navegar até a pasta do projeto backend (MenteSaudavel.Server) -> Digitar "dotnet run" -> Copiar o url que aparecer e colar no browser para testar a API.

### Para rodar o FrontEnd (Visual Studio e Visual Studio Code):
Abrir o terminal -> Navegar até a pasta do projeto frontend (mentesaudavel.client) -> Digitar "npm run dev" -> Copiar o url que aparecer e colar no browser para visualizar o frontend. 

### Erro "Connection String not initialized":
Clicar com botão direito no projeto do backend (MenteSaudavel.Server) -> Clicar em Manage User Secrets e colar essa connection string:
```
{
  "ConnectionStrings:DefaultConnectionString": "Server=localhost;Database=MenteSaudavelDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
