# args2json

[![NuGet Package](https://img.shields.io/nuget/v/args2json.svg)](https://www.nuget.org/packages/args2json)

A dotnet tool to print command line arguments as json.

## Installation

Make sure at least [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0) is installed.

Execute the command `dotnet tool install --global args2json --version 1.0.0`

## Usage

```
Usage:
  args2json [arguments]
```

## Example

`dotnet args2json --version-pattern "^5\.0\.\3$" --output "./bin"`

Prints out:

```json
[
  "--version-pattern",
  "^5\\.0\\.\\3$",
  "--output",
  "./bin"
]
```

# LICENSE

args2json is licensed under MIT license. See [LICENSE](./LICENSE) for more details.