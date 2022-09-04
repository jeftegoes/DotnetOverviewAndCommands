# Dotnet overview and commands <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Commands](#1-commands)
  - [1.1. General commands](#11-general-commands)
  - [1.2. Solution commands](#12-solution-commands)

# 1. Commands

## 1.1. General commands

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

## 1.2. Solution commands

- Create a solution
  - dotnet new sln
- Add project into a solution
  - dotnet sln add `<dotnet_project>` # Remember, he must exists .csproj file.
