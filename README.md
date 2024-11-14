# Customers API

Este proyecto es una API para gestionar clientes tomando de https://github.com/Elfocrash/clean-minimal-api, 
implementada en C# utilizando ASP.NET Core. La API permite crear, leer, actualizar y eliminar (CRUD) información sobre clientes, utilizando patrones de diseño como Value Objects y Dapper para la interacción con la base de datos.

## Tabla de Contenidos

- [Caracteristicas](#caracteristicas)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Instalacion](#instalacion)
- [Uso](#uso)

## Caracteristicas

- Gestión de clientes con propiedades como nombre, correo electrónico, nombre completo, nombre de usuario y fecha de nacimiento.
- Validación de datos utilizando FluentValidation.
- Uso de Value Objects para encapsular lógica de validación y mantener la inmutabilidad.
- Interacción con la base de datos utilizando Dapper.
- Documentación de la API con FastEndpoints y Swagger.

## Tecnologias Utilizadas

- C#
- ASP.NET Core
- Dapper
- FluentValidation
- SQLite
- FastEndpoints
- Swagger

## Estructura del Proyecto

Customers.Api
¦
+-- Contracts
¦ +-- Data
¦ +-- Requests
¦ +-- Responses
¦
+-- Database
¦ +-- DatabaseInitializer.cs
¦ +-- IDbConnectionFactory.cs
¦
+-- Domain
¦ +-- Common
¦ +-- Customer.cs
¦
+-- Endpoints
¦ +-- CreateCustomerEndpoint.cs
¦ +-- UpdateCustomerEndpoint.cs
¦ +-- GetCustomerEndpoint.cs
¦ +-- GetAllCustomersEndpoint.cs
¦ +-- DeleteCustomerEndpoint.cs
¦
+-- Mapping
¦ +-- DomainToDtoMapper.cs
¦ +-- DtoToDomainMapper.cs
¦ +-- ApiContractToDomainMapper.cs
¦
+-- Repositories
¦ +-- ICustomerRepository.cs
¦ +-- CustomerRepository.cs
¦
+-- Services
¦ +-- ICustomerService.cs
¦ +-- CustomerService.cs
¦
+-- Validation
¦ +-- CreateCustomerRequestValidator.cs
¦ +-- UpdateCustomerRequestValidator.cs
¦
+-- Program.cs

## Instalacion

1. Clona el repositorio:
   ```bash
   git clone https://github.com/migueldeltorodev/migueldeltorodev.CleanApi
   cd Customers.Api
   ```

2. Restaura las dependencias:
   ```bash
   dotnet restore
   ```

3. Configura la cadena de conexión en `appsettings.json` si es necesario.

4. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```

## Uso

La API está disponible en `https://localhost:5001/swagger/index.html`. Puedes utilizar herramientas como Insomnia o Postman para interactuar con los endpoints.

