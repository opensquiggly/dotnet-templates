### Introduction

These templates are used to create a full-stack project fashioned after the
OpenSquiggly project structure.

### Installation

```console
dotnet new install OpenSquiggly.Templates
```

### Usage

```console
dotnet new opensquiggly-monolith+sveltekit -n MyGreatThing
```

### Description

The main template, opensquiggly-monolith+sveltekit creates a full stack, monolithic project
structure using .NET 8.0 as the backend, SvelteKit as the frontend, Vite for frontend packaging,
and Tailwind for styling.

The generated project structure is output as follows:

```
src
|- YourProjectName.sln
|- App.DevOps.CodeGen
   |- App.DevOps.CodeGen.csproj
|- App.Web
   |- App.Web.csproj
|- AppLib.Common
   |- AppLib.Common.csproj
|- AppLib.MongoDb
   |- AppLib.MongoDb.csproj
|- AppLib.Types
   |- AppLib.Types.csproj
```

### Solution and Project Naming

The generated solution is named using the project name you provide. This should be either
the name of your product as you intend to market it, or an internal code name for the project.

The generated folders and projects (.csproj files), however, are given generic names prefixed
with either App or AppLib. Projects prefixed with "App" are either .exe or .dll main program
entry points that are executable using "dotnet run". Projects prefixed with "AppLib" are linkable
libraries.

You might wonder why we use generic names instead of names that are derived from the core
project name. It's because in our experience the company's marketing department tends to be
fickle about product names. It's not uncommon for the marketing department to change their
mind about a product name after-the-fact, and we want to make it easy for the developers to go
with the flow when a product name change occurs. We don't want to have to make too many changes
to the source code if or when the product is renamed.

Therefore, the top-level solution name is named after the product/project, because there needs
to be some kind of naming anchor that identifies what this project is actually for. If you have
multiple solutions open at the same time in different IDE windows, it's helpful for each solution
to have a unique name. By keeping the rest of the names generic, if the marketing department renames
the product, you'll simply change the name of the top-level solution file. The rest of the generically
named folders and .csproj files can remain generically named.
