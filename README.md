# DT.Backend — .NET 8 Web API

A clean-architecture .NET 8 Web API for the `DT` MySQL database, generated from the
existing schema. Built with EF Core (writes) + Dapper (reads), JWT auth, Swagger,
AutoMapper, and Serilog.

## Solution layout

```
DT.Backend.sln
src/
  DT.Domain/          Entity classes (POCOs, one per table)
  DT.Application/     DTOs, AutoMapper profile, repo/UoW interfaces
  DT.Infrastructure/  AppDbContext (Pomelo MySQL), GenericRepository,
                      UnitOfWork, DapperReader, DI registration
  DT.Api/             Controllers, JWT, Swagger, Program.cs
```

## Requirements

- Visual Studio 2022 (17.8+) or `dotnet` 8 SDK
- MySQL 8.x with the `DT` database loaded (run `DT_mysql.sql` then `DT_mysql_data.sql`)

## Configure

Edit `src/DT.Api/appsettings.json`:

```json
"ConnectionStrings": {
  "Default": "Server=localhost;Port=3306;Database=DT;User=root;Password=YOUR_PASSWORD;"
},
"Jwt": {
  "Key": "REPLACE_WITH_A_LONG_RANDOM_SECRET_AT_LEAST_32_CHARS"
}
```

## Run

```
dotnet restore
dotnet run --project src/DT.Api
```

Open https://localhost:7080/swagger.

## Auth

`POST /api/auth/login` returns a JWT. Send it as `Authorization: Bearer <token>` on
every other endpoint. The demo login accepts any non-empty email/password — replace
the body of `AuthController.Login` with a real check against the `Members` table.

## CRUD endpoints

Every table with a single-column primary key has a controller at `/api/{table}`
exposing `GET`, `GET/{id}`, `POST`, `PUT/{id}`, `DELETE/{id}`. The shared
`CrudControllerBase<,,,>` parses `int` ids automatically; override `ParseId` in a
subclass for `Guid` or composite keys.

Join tables (composite PKs) are exposed as `DbSet`s on `AppDbContext` and reachable
through `IUnitOfWork.Repository<T>()` or direct Dapper queries — write a custom
controller per junction as needed.

## Read with Dapper

Inject `IDapperReader` for fast read-only queries:

```csharp
var rows = await _dapper.QueryAsync<MyDto>("SELECT * FROM Bizs WHERE StateId=@s", new { s = 1 });
```

## Logging

Serilog writes to console and `logs/dt-YYYYMMDD.log` (daily rolling). Tune in
`appsettings.json` under `Serilog`.
