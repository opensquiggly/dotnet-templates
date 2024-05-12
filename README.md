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