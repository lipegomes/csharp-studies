- Documentação oficial microsoft:
https://docs.microsoft.com/en-us/dotnet/core/tools/

- Criar pasta raiz que irá conter os projetos:

```
mkdir DevStore
```

- Criar gitignore:

```
dotnet new gitignore

```

- Criar diretórios dos projetos:

```
mkdir DevStore.Api

mkdir DevStore.Domain

mkdir DevStore.Infra

mkdir DevStore.Shared

mkdir DevStore.Tests
```

- Criar aplicação web vázia n pasta DevStore.Api:

```
dotnet new web
```

- Criar aplicação library na pasta DevStore.Domain:

```
dotnet new classlib
```

- Criar aplicação library na pasta DevStore.Infra:

```
dotnet new classlib
```

- Criar aplicação library na pasta DevStore.Shared:

```
dotnet new classlib
```
dotnet new mstest

- Criar aplicação Unit Test Project na pasta DevStore.Tests:

```
dotnet new mstest
```

- Cria o template "Solution File" na pasta raiz:

```
dotnet new sln
```

- Adicionar os projetos dentro do arquivo sln:

```
dotnet sln add .\DevStore.Api\DevStore.Api.csproj

dotnet sln add .\DevStore.Domain\DevStore.Domain.csproj

dotnet sln add .\DevStore.Infra\DevStore.Infra.csproj

dotnet sln add .\DevStore.Shared\DevStore.Shared.csproj

dotnet sln add .\DevStore.Tests\DevStore.Tests.csproj
```
