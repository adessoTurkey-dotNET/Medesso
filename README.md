# Medesso
![GitHub issues](https://img.shields.io/github/issues/adessoTurkey-dotNET/Medesso) ![Nuget](https://img.shields.io/nuget/dt/Medesso) ![GitHub contributors](https://img.shields.io/github/contributors/adessoTurkey-dotNET/Medesso)  ![GitHub forks](https://img.shields.io/github/forks/adessoTurkey-dotNET/Medesso) ![GitHub Repo stars](https://img.shields.io/github/stars/adessoTurkey-dotNET/Medesso?color=yellow) ![Nuget](https://img.shields.io/nuget/v/Medesso)

##### Medesso is a customized library inspired by Mediatr library. We develop and use it in line with our needs.

### How To Install

Install with Nuget:
```sh
install-package Medesso
```
 NET Core command line:
```sh
dotnet add package Medesso
```

# Configuration
```sh
var assemblies = GetAssemblies();
builder.Services.AddValidatorsFromAssemblies(assemblies);
builder.Services.AddMedesso(assemblies);
```
## Features

- ##### Mediator implementation in .NET
- ##### Dependency-free in-process messaging.

## Registers
- ##### IMedessoMediator
- ##### IMedessoQueryHandler
- ##### IMedessoCommandHandler
- ##### IMedessoRequestPreProcessor
- ##### IMedessoRequestPostProcessor

