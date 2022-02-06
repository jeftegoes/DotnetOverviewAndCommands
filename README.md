# Dotnet overview and commands <!-- omit in toc -->

## Contents <!-- omit in toc -->

## Commands

### General commands
- Create a Web API into the project
  - dotnet new webapi –o `<output_path>`
- Add reference to another ClassLib
  - dotnet add `<target_project>` reference `<project>` # Ex: dotnet add Calculations.Test reference Calculations
- Step By Step - Create class library into the project
  1. dotnet new classlib -o Infrastructure
  2. dotnet sln add "name of classlib"
  3. dotnet add reference ../classlib/
- Step By Step - Run project
  1. First enter in the path it contains startup.cs file
  2. Second run command: dotnet run
  3. Optional: dotnet watch run
- Restore project, download all dependencies of project
  - dotnet restore
- All informations about dotnet in the machine
  - dotnet –-info
- Build project and generate release
  - dotnet publish -c Release
- Verif if machines has https certificate valid
  - dotnet dev-certs https
- Trust localhost certificate 
  - dotnet dev-certs https -t
- List of tools installer with dotnet
  - dotnet tool list -g # -g appear globar

### Solution commands
- Create a solution
  - dotnet new sln
- Add project into a solution
  - dotnet sln add `<dotnet_project>` # Remember, he must exists .csproj file.

### dotnet entity framework (ef)
- Install globally dotnet ef into machine
  - dotnet tool install --global dotnet-ef
- Add migration into the project
  - dotnet ef migrations add `<name_migrations>` –o `<output_path>`
  - dotnet ef migrations add `<name_migrations>` -p `<project_name>` -s `<name_solution>` -o `<output_path>` # Ex: dotnet ef migrations add InitialCreate -p Infrastructure -s API 
-o Data/Migrations
- Create or update database with migrations
  - dotnet ef database update
  - dotnet ef database update -p `<project_name>` -s `<name_solution>` # Ex: dotnet ef database update -p Infrastructure -s API
- Drop database/migrations
  - dotnet ef database drop -p `<project_name>` -s `<name_solution>` # Ex: dotnet ef database drop -p Infrastructure -s API
- Remove migrations
  - dotnet ef migrations remove -p `<project_name>` -s `<name_solution>` # Ex: dotnet ef migrations remove -p Infrastructure -s API