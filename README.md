# Game Store

This project aim be a perfect game store. It is dived in 2 applications, an web api developed in ASP.NET Core 2.0 and a website utilizing Angular 4+. 

### Prerequisites

- You will need Visual Studio 2017 (preview 15.3), .NET Core SDK and the latest stable build of Node.js(for npm only) 
- The latest SDK and tools can be downloaded from https://dot.net/core. 
- Read the .NET Core 2.0 [release announcement](https://blogs.msdn.microsoft.com/dotnet/2017/08/14/announcing-net-core-2-0/) for more information.
- the latest Node.js installer could be found [here](https://nodejs.org/en/)

Also you can run the application in Visual Studio Code (Windows, Linux or MacOS).

To know more about how to setup your enviroment visit the [Microsoft .NET Download Guide](https://www.microsoft.com/net/download)

### Installing

#### API

Install nuget packages required and run

```
cd GameStore.UI.WebApi
dotnet restore
dotnet run
```

#### UI

Install npm packages required and urn

```
cd GameStore.UI.Site
npm install
ng serve
```

## Technologies implemented:

- ASP.NET Core 2.0
- Entity Framework Core 2.0
- .NET Core Native DI
- AutoMapper
- Swagger UI

## Architecture:

- Full architecture with responsibility separation concerns, SOLID and Clean Code
- Domain Driven Design (Layers and Domain Model Pattern)
- Unit of Work
- Repository and Generic Repository

## Acknowledgments

Inspired by the [Equinox Project](https://github.com/EduardoPires/EquinoxProject) from [Eduardo Pires](http://www.eduardopires.net.br/)

