# TodoListWebApi

A simple ASP.NET Core Web API for managing a Todo List. This project uses Entity Framework Core for data access and provides a RESTful API for CRUD operations on todo items.

## Features

- Create, read, update, and delete todo items
- Entity Framework Core with SQL Server
- OpenAPI/Swagger documentation
- .NET 8 and C# 12

## Getting Started

### Prerequisites
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [.NET 8 SDK](https://dotnet.microsoft.com/download)

### Setup

1. **Clone the repository:**

  - ```git clone https://github.com/yourusername/TodoListWebApi.git cd TodoListWebApi```

2. **Configure the database connection:**
- Edit `appsettings.json` and set the `DefaultConnection` string to your SQL Server instance.

3. **Apply database migrations:**

 - ```dotnet ef database update```

4. **Run the API:**

 - ```dotnet run --project TodoListWebApi```

5. **Access Swagger UI:**
- Navigate to `https://localhost:7109/swagger` in your browser.

## Project Structure

- `TodoListWebApi/` - ASP.NET Core Web API project
- `TodoList/` - Core logic and models
- `TodoList.Tests/` - Unit tests

## Usage

Use the Swagger UI to interact with the API endpoints for managing todo items.
