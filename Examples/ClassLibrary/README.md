# 1. What is this project

- This is a simple class library that contains a single string-handling method.
- A class library defines types and methods that are called by an application. If the library targets .NET Standard 2.0, it can be called by any .NET implementation (including .NET Framework) that supports .NET Standard 2.0. If the library targets .NET 6, it can be called by any application that targets .NET 6.
- When we create a class library, we can distribute it as a NuGet package or as a component bundled with the application that uses it.

# 1.1. How is it organized

- [Library](Library/) (.NET Standart / Classlib )
- [ProjectThatUsesLibrary](ProjectThatUsesLibrary/) (.NET 6.0 / Console)
