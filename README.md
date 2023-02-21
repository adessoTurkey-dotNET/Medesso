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


static Assembly[] GetAssemblies()
{
    var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            
    return Directory
        .GetFiles(path, "Medesso.Sample.*.dll", SearchOption.TopDirectoryOnly)
        .Select(AssemblyLoadContext.Default.LoadFromAssemblyPath)
        .ToArray();
}

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
- ###### Umit Akinci - umit__akinci@hotmail.com -  [![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/%C3%BCmit-ak%C4%B1nc%C4%B1-080733120/) [![github](https://img.shields.io/badge/github-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/UmitAkinci)


- ###### Devran Canikli - [![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/devrancanikli/) [![github](https://img.shields.io/badge/github-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/devrancanikli)
