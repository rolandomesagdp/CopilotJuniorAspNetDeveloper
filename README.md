# Clean Architecture project template
This a .Net project template. It is the skeleton of a web application project (Asp.Net) that follows Clean Architecture principles and supports Docker containarization.
Uses an Sql Server DB via Entity Framework.

.Net version: 9.0.

## Architecture structure / projects structure:
- Domain:
  - A .Net Core Library
  - Pure C# classes
  - Only business rules
- Application:
  - A .Net Core Library
  - Use cases
  - Repositories Interfaces
  - Dtos
  - Validation rules
  - Depends on Domain
- Infrastructure:
  - Entity Framework Core DbContext
  - Repository Implementation
  - Migrations
  - External Services (email, storage, etc)
  - Depends on Application
- Web (API)
  - An Asp.Net Core Web Api
  - Controllers
  - Authentication/Authirization
  - Dependency Injection
  - Swagger
  - Startup configuration
  - Dockerfile with the required instructions to build a Docker image

# How to install the template in .Net SDK to be reused?

## Clean the solution up:
- Clone the repository.
- Delete bin/ and obj/ in all the projects if exists.
- Remove user‑specific files (*.user, .vs/)
- Remove git folders

## Install the template locally:
- Open a CMD at the .sln folder. Or, to bemore specifically, at the .template.config folder level
- run the command "dotnet new install ." where "." is the installation path.

## How to use the template
- run the command "dotnet new copilotjunioraspnetdeveloper -n <new-solution-name>"

## How to check if the template is installed
- dotnet new --list => prints a list of all the templates installed.
- dotnet new --search <short-name> => prints the information of the specified template

## How to know the parameters the template exposes:
- dotnet new <short-name> --help

## How to uninstall the template:
- dotnet new --uninstall <path-to-template> where <path-to-template> is the path to the folder where the template was living during the installation process.
It is very important to remember that path because, otherwise, there will be no way to uninstall (and update, reinstall) the template. If you pretend to keep updating this template in your local machine, it is highly recommended to keep the project folder in a safe place and always in that place to always keep working with the same path. This is the way it should be because the .NET SDK uses the installation path as the unique identifier of the template. And currently there is no cmd command that allows to recover the unique identifier of a given installed template.

# Entity Framework Migrations:

## Generate a migration
- Open cmd at .slnx file level
- run command "scripts\add-migration"

## Update database
- Open cmd at .slnx file level
- run command "scripts\update-database"

# Build a Docker image of the Web Application:
- Open a cmd at .slnx fole level, where the dockerignore file lives.
- Run the command "docker build -t <image-name> -f src/<solution-name>.Web/Dockerfile ."
- <image-name> is a parameter of you chose: can be anything as long as acomplishes with Docker requisites.
- <solution-name> is the name you decided for the solution when you created a project based on this template.
