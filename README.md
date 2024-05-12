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
  YourProjectName.sln
  App.DevOps.CodeGen
  App.Web
  AppLib.Common
  AppLib.MongoDb
  AppLib.Types
```

### Solution and Project Naming

The generated solution is named using the project name you provide. This should be either
the name of your project as you intend to market it, or an internal code name of the project.

The generated projects (.csproj files), however, are given generic names prefixed with either
App or AppLib. Why do we use generic names instead of names that are derived from the core
project name.

It's because in our experience the company's marketing department tends to be fickle about
product names. It's not uncommon for the marketing department to change their mind about a
product name after-the-fact, and we want to make it easy for the developers to go with the
flow when a product name change occurs. We don't want to have to make too many changes to the
source code when renaming a product.

So the top-level solution name is named after the project, because there needs to be some
kind of naming anchor that identifies what this project is actually for. If the marketing
department renames the product, you'll simply change the name of this one single file. The
rest of the generically named folders and .csproj files can remain generically named.
