# Medesso
![GitHub issues](https://img.shields.io/github/issues/adessoTurkey-dotNET/Medesso) ![Nuget](https://img.shields.io/nuget/dt/Medesso) ![GitHub contributors](https://img.shields.io/github/contributors/adessoTurkey-dotNET/Medesso)  ![GitHub forks](https://img.shields.io/github/forks/adessoTurkey-dotNET/Medesso) ![GitHub Repo stars](https://img.shields.io/github/stars/adessoTurkey-dotNET/Medesso?color=yellow) ![Nuget](https://img.shields.io/nuget/v/Medesso) ![GitHub](https://img.shields.io/github/license/adessoTurkey-dotNET/Medesso)

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
builder.Services.AddMedesso(assemblies);
```
## Features:

- ##### Mediator implementation in .NET
- ##### Dependency-free in-process messaging.

## Registers:
- ##### IMedessoMediator
- ##### IMedessoQueryHandler
- ##### IMedessoCommandHandler
- ##### IMedessoRequestPreProcessor
- ##### IMedessoRequestPostProcessor

## License:

Distributed under the MIT License. See LICENSE.md for more information.

## Contact:
Umit Akinci - umit__akinci@hotmail.com 
![Twitter URL](https://img.shields.io/twitter/url?label=LinkedIn&logo=linkedin&url=https%3A%2F%2Fwww.linkedin.com%2Fin%2F%25C3%25BCmit-ak%25C4%25B1nc%25C4%25B1-080733120%2F)  ![Twitter URL](https://img.shields.io/twitter/url?label=GitHub&logo=GitHub&url=https%3A%2F%2Fgithub.com%2FUmitAkinci)
