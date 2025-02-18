# SWE-Healthy-And-Fit

## Web-aplikacija za praćenje zdravlja i fitnesa

**Technologies:**

- **Frontend:** Angular 16
- **Backend:** C# .NET 6
- **Baza podataka:** MySQL
- **ORM:** Entity Framework

## Versions:

- **Angular CLI:** 16.2.9
- **Node:** 18.18.2
- **Package Manager:** npm 9.8.1
- **Angular:** 16.2.12
- **.NET:** 6.0

# Startup commands

## CMD commands

dotnet tool install dotnet-ef -g

sqllocaldb create healthyandfit

sqllocaldb start healthyandfit

dotnet ef migrations add NAME

dotnet ef database update

### Certs problem:

dotnet tool update dotnet-dev-certs -g

## Azure Data Studio

New connection

Server: (localdb)\SWEProj

Database: Softversko


## Run project from cmd

backend: dotnet watch run

frontend: ng serve
