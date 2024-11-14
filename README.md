# Customers API

Este proyecto es una API para gestionar clientes tomando de https://github.com/Elfocrash/clean-minimal-api, 
implementada en C# utilizando ASP.NET Core. La API permite crear, leer, actualizar y eliminar (CRUD) informaci�n sobre clientes, utilizando patrones de dise�o como Value Objects y Dapper para la interacci�n con la base de datos.

## Tabla de Contenidos

- [Caracteristicas](#caracteristicas)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Instalacion](#instalacion)
- [Uso](#uso)

## Caracteristicas

- Gesti�n de clientes con propiedades como nombre, correo electr�nico, nombre completo, nombre de usuario y fecha de nacimiento.
- Validaci�n de datos utilizando FluentValidation.
- Uso de Value Objects para encapsular l�gica de validaci�n y mantener la inmutabilidad.
- Interacci�n con la base de datos utilizando Dapper.
- Documentaci�n de la API con FastEndpoints y Swagger.

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
�
+-- Contracts
� +-- Data
� +-- Requests
� +-- Responses
�
+-- Database
� +-- DatabaseInitializer.cs
� +-- IDbConnectionFactory.cs
�
+-- Domain
� +-- Common
� +-- Customer.cs
�
+-- Endpoints
� +-- CreateCustomerEndpoint.cs
� +-- UpdateCustomerEndpoint.cs
� +-- GetCustomerEndpoint.cs
� +-- GetAllCustomersEndpoint.cs
� +-- DeleteCustomerEndpoint.cs
�
+-- Mapping
� +-- DomainToDtoMapper.cs
� +-- DtoToDomainMapper.cs
� +-- ApiContractToDomainMapper.cs
�
+-- Repositories
� +-- ICustomerRepository.cs
� +-- CustomerRepository.cs
�
+-- Services
� +-- ICustomerService.cs
� +-- CustomerService.cs
�
+-- Validation
� +-- CreateCustomerRequestValidator.cs
� +-- UpdateCustomerRequestValidator.cs
�
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

3. Configura la cadena de conexi�n en `appsettings.json` si es necesario.

4. Ejecuta la aplicaci�n:
   ```bash
   dotnet run
   ```

## Uso

La API est� disponible en `https://localhost:5001/swagger/index.html`. Puedes utilizar herramientas como Insomnia o Postman para interactuar con los endpoints.

