# mysql-migrations-docker-test

Small example project to show an implementation using ASP.NET CORE, Entity Framework, MySql and Docker.

Useful links:

- https://mysqlconnector.net/tutorials/efcore/-
- https://www.connectionstrings.com/

## How to run?

- Run the docker containers from the docker compose.
- Using PhpMyAdmin go into SQL container and create a DB with the name 'temp'.
- Open project in VSCode, in PMC (Package manager console) run this;

> dotnet tool install --global dotnet-ef
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet ef migrations add InitialCreate
> dotnet ef database update
