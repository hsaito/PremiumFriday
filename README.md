# PremiumFriday

PremiumFriday is a PowerShell module for validating "Premium Friday" dates and related utilities. It is implemented in C# and targets .NET 9.0, providing cmdlets for use in PowerShell environments.

## Features
- Validate if a given date is a Premium Friday
- Get the next Premium Friday date
- PowerShell module packaging and help documentation

## Getting Started

### Prerequisites
- .NET 9.0 SDK
- PowerShell 7.5.2 or later

### Building
To build the project, run:

```sh
# From the root directory
 dotnet build PremiumFriday/PremiumFriday.csproj
```

### Running Tests
To run unit tests:

```sh
dotnet test PremiumFriday.Tests/PremiumFriday.Tests.csproj
```

### Using the Module
After building, the module files will be in `PremiumFriday/bin/Debug/net9.0/`. You can import the module in PowerShell:

```powershell
Import-Module ./PremiumFriday/bin/Debug/net9.0/PremiumFriday.dll
```

## Project Structure
- `PremiumFriday/` - Main module source code
- `PremiumFriday.Tests/` - Unit tests
- `Help/` - PowerShell help documentation

## Documentation
Cmdlet documentation is available in the `Help/` folder and as XML help files in the output directory.

## License
See [LICENSE](LICENSE) for details.

## Author
Hideki Saito

