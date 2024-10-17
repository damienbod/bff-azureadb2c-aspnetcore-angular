# Azure AD B2C BFF security architecture using ASP.NET Core and nx Angular standalone

[![.NET and npm build](https://github.com/damienbod/bff-azureadb2c-aspnetcore-angular/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/bff-azureadb2c-aspnetcore-angular/actions/workflows/dotnet.yml) [![License](https://img.shields.io/badge/license-Apache%20License%202.0-blue.svg)](https://github.com/damienbod/bff-azureadb2c-aspnetcore-angular/blob/main/LICENSE)

## Documentation

See this: https://github.com/damienbod/bff-aspnetcore-angular

Or **Microsoft.Identity.Web** for Azure AD B2C setups

## Debugging

Start the Angular project from the **ui** folder

```
nx serve --ssl
```

Start the ASP.NET Core project from the **server** folder

```
dotnet run
```

Or just open Visual Studio and run the solution.

## Credits and used libraries

- NetEscapades.AspNetCore.SecurityHeaders
- Yarp.ReverseProxy
- Microsoft.Identity.Web
- ASP.NET Core
- Angular 
- Nx

## Angular nx Updates

```
nx migrate latest

nx migrate --run-migrations=migrations.json
```

## History

- 2024-10-17 Updated packages, updated security headers performance
- 2024-10-06 Updated Angular 18.2.7

## Links

https://github.com/damienbod/bff-aspnetcore-angular

https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core

https://nx.dev/getting-started/intro

https://github.com/AzureAD/microsoft-identity-web

https://github.com/isolutionsag/aspnet-react-bff-proxy-example

https://github.com/damienbod/bff-auth0-aspnetcore-angular

https://github.com/damienbod/bff-openiddict-aspnetcore-angular

https://github.com/damienbod/bff-aspnetcore-vuejs

https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular
