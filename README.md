[![Nuget](https://img.shields.io/badge/package-PackZero.HostedConsoleService-brightgreen.svg?maxAge=259200)](https://www.nuget.org/packages/PackZero.HostedConsoleService)
[![CodeQL](https://github.com/msx752/PackZero.HostedConsoleService/actions/workflows/codeql.yml/badge.svg?branch=main)](https://github.com/msx752/PackZero.HostedConsoleService/actions/workflows/codeql.yml)
[![MIT](https://img.shields.io/badge/License-MIT-blue.svg?maxAge=259200)](https://github.com/msx752/PackZero.HostedConsoleService/blob/main/LICENSE.md)

# PackZero.HostedConsoleService
Single Response Model for the ActionResult


# How to Use
``` c#
using PackZero.HostedConsoleService;
```
define class `public class AppHostedService : IHostedService`

Example Program.cs definion
``` c#
var host = Host.CreateDefaultBuilder(args);

host.RunAppZeroConsole<AppHostedService>(actionServices: services =>
{
    services.AddLogging(); //any service definitions
});
```