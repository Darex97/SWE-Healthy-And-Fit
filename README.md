# SWE-Healthy-And-Fit

## Web-aplikacija za praćenje zdravlja i fitnesa

**Technologies:**

- **Frontend:** Angular 13
- **Backend:** C# .NET 5
- **Baza podataka:** MySQL
- **ORM:** Entity Framework

## Versions:

- **Angular CLI:** 13.3.3
- **Node:** 12.11.1
- **Angular:** 13.3.0
- **.NET:** 5.0

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
