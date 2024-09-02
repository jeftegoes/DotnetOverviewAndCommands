# Dotnet overview and commands <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. What is C#](#1-what-is-c)
- [2. What is .NET](#2-what-is-net)
- [3. What is the difference between .NET Framework, .NET Core and .NET?](#3-what-is-the-difference-between-net-framework-net-core-and-net)
- [4. How C# is compiled](#4-how-c-is-compiled)
- [5. Typical dotnet application](#5-typical-dotnet-application)
- [6. Why Microsoft created .NET?](#6-why-microsoft-created-net)
  - [6.1. Why does it matter?](#61-why-does-it-matter)
- [7. .NET Standard](#7-net-standard)
  - [7.1. .NET Standard Why?](#71-net-standard-why)
  - [7.2. Portable Class Library (PCL) and Shared Projects?](#72-portable-class-library-pcl-and-shared-projects)
  - [7.3. .NET Standard 2.0](#73-net-standard-20)
- [8. Deployments options](#8-deployments-options)
  - [8.1. Self contained](#81-self-contained)
  - [8.2. Framework Dependent](#82-framework-dependent)
  - [8.3. Package Size](#83-package-size)
- [9. Performance](#9-performance)
  - [9.1. Measuring memory](#91-measuring-memory)
- [10. Commands](#10-commands)
  - [10.1. General commands](#101-general-commands)
  - [10.2. Solution commands](#102-solution-commands)
  - [10.3. Aspnet codegenerator commands](#103-aspnet-codegenerator-commands)
- [11. Tools](#11-tools)

# 1. What is C#

- C# is a programming language.
- Object Oriented.
- Strongly typed.
- Simple to use and general-purpose.
- Some the things we can write in C#:
  - **Backend Development** (API, EF Core, Linq, Async, OOP)
  - **Front End** (ASP.Net, MVC, Razor, Blazor)
  - **Mobile** (Maui, Xamarin)
  - **Game** (Unity)
  - **Desktop** (Maui, WinForms, WPF)

# 2. What is .NET

- A C# compiler.
- A runtime to execute C# (Core CLR).
- Libraries to provide out-of-the-box functionalities (BCL Functions).
- A garbage collector to manage memory.
- .NET (dotnet) is a framework for building applications on Windows, Linux and MAC OS.
  - .NET is not limited to C# examples are F# or VB.NET.

# 3. What is the difference between .NET Framework, .NET Core and .NET?

![Dotnet timeline](/Images/DotnetTimeline.jpg)

# 4. How C# is compiled

# 5. Typical dotnet application

- ![Typical dotnet application diagram](Images/TypicalDotnetApplication.png)
  - Tied to Windows and IIS.
  - First release: 2002 (no cloud, no Microservices).

# 6. Why Microsoft created .NET?

- New requirements:
  - Cross-platform.
  - Open-Source.
  - "Similar" to classic .NET.
  - Good for cloud, good for microservices -> lightweight and fast.
- **PERFORMANCE!!!!**
- ![.NET Core diagram](Images/DotnetCorePlataform.png)

## 6.1. Why does it matter?

- Almost zero framework overhead = almost zero overhead for your application.
- It's a C# library built on top of .NET: you have the same platform available for your libraries and applications.
- Many C# features and new .NET APIs were "invented" during the development of .NET and ASP.NET to achieve this performance.

# 7. .NET Standard

- Contract that defines an API surface.
- Versions: 1.0 - 2.0.
- A list of Types and methods that are available in different versions.
- ".NET" flavors implement the standard.
- .NET Standard version are backward compatible.

## 7.1. .NET Standard Why?

- Code sharing!
- Target the standard - run everywhere.
- Full framework, .NET Core, Mono (Xamarin): all support .NET Standard 2.0.
- As a library author: you should target .NET Standard (and not e.g. .NET Core).

## 7.2. Portable Class Library (PCL) and Shared Projects?

- PCL and Shared Projects: Previous attempt to share code across .NET Platforms (e.g. Full Framework and Xamarin).
- **Recommendation: use .NET Standard.**

## 7.3. .NET Standard 2.0

- ![.NET Standard 2.0 versions](/Images/DotnetStandardVersions.png)
- Doubled the number of APIs.
- Supports `mscorlib` based .NET Framework libs.

# 8. Deployments options

- Self contained.
- Framework Dependent or Shared Framework.
- [.NET application publishing overview](https://learn.microsoft.com/en-us/dotnet/core/deploying/)

## 8.1. Self contained

- Contains the CLR.
- No preinstalled framework needed.
- Bigger deployment package which targets a specific OS (The executable is not cross-platform).
- `dotnet publish --runtime win-x86 --self-contained true`

## 8.2. Framework Dependent

- Only contains the application’s code.
- Requires preinstalled .NET Core on the target machine.
- Cross platform deployment package.
- Small package size.
- **Default.**
- `dotnet publish --runtime win-x86 --self-contained false`

## 8.3. Package Size

![Package size difference](/Images/DeploymentOptionsPackageSize.png)

# 9. Performance

## 9.1. Measuring memory

# 10. Commands

## 10.1. General commands

- Create a Web API into the project
  - `dotnet new webapi -o <output_path>`
- Add reference to another ClassLib
  - dotnet add `<target_project>` reference `<project>` # Ex: dotnet add Calculations.Test reference Calculations
- Step By Step - Create class library into the project
  1. `dotnet new classlib -o Infrastructure`
  2. `dotnet sln add "name of classlib"`
  3. `dotnet add reference ../classlib/`
- Step By Step - Run project
  1. First enter in the path it contains `startup.cs` file
  2. Second run command: `dotnet run`
  3. Optional: `dotnet watch run`
- Restore project, download all dependencies of project
  - `dotnet restore`
- All informations about dotnet in the machine
  - `dotnet --info`
- Build project and generate release
  - `dotnet publish -c Release`
- Verif if machines has https certificate valid
  - `dotnet dev-certs https`
- Trust localhost certificate
  - `dotnet dev-certs https -t`
- List of tools installer with dotnet
  - `dotnet tool list -g # -g appear globar`
- Generate NuGet package
  - `dotnet pack`
  - **OR**
  - Adding this tag to automatically generate package on build:
    - <GeneratePackageOnBuild>true</GeneratePackageOnBuild>

## 10.2. Solution commands

- Create a solution
  - `dotnet new sln`
- Add project into a solution
  - dotnet sln add `<dotnet_project>` # Remember, he must exists .csproj file.

## 10.3. Aspnet codegenerator commands

- `dotnet aspnet-codegenerator --project "D:\CSharp\DotnetDapperOverview\ExampleDapper" controller --force --controllerName CompanyController --model ExampleDapper.Models.Company --dataContext ExampleDapper.Data.ApplicationDbContext --relativeFolderPath Controllers --controllerNamespace ExampleDapper.Controllers`

# 11. Tools

- `dotnet tool install --global dotnet-aspnet-codegenerator --version X.X.X`
