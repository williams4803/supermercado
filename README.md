# Supermercado API

API ASP.NET Core para cadastro e gerenciamento de **Funcionários** e **Produtos**.

## Tecnologias

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server LocalDB
- Swagger/OpenAPI

## Como executar

1. Restaurar e compilar o projeto
2. Aplicar migrations no banco
3. Executar a API

### Banco de dados

A connection string está em `appsettings.json`:

- Banco: `hipermercado`
- Servidor: `(localdb)\\MSSQLLocalDB`

## Endpoints principais

### Funcionários

- `GET /api/Funcionarios`
- `GET /api/Funcionarios/{id}`
- `POST /api/Funcionarios`
- `PUT /api/Funcionarios/{id}`
- `DELETE /api/Funcionarios/{id}`

### Produtos

- `GET /api/Produtos`
- `GET /api/Produtos/{id}`
- `POST /api/Produtos`
- `PUT /api/Produtos/{id}`
- `DELETE /api/Produtos/{id}`

## Testes via Swagger

Com a API em execução, acesse:

- `https://localhost:7029/swagger`

## Exemplos de payload

### Funcionário (POST)

```json
{
  "name": "João Silva",
  "cpf": "123.456.789-00",
  "endereco": "Rua das Flores, 10",
  "email": "joao@email.com"
}
```

### Produto (POST)

```json
{
  "nome": "Arroz",
  "descricao": "Arroz tipo 1 5kg",
  "valor": 25.90
}
```
