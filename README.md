# Design Patterns in .NET Core using C#
## _The idea supported by this project is provide some insights on Patterns_

[![Test status](https://github.com/xanwerneck/design-pattern-tutorial/actions/workflows/dotnet.yml/badge.svg)](https://github.com/xanwerneck/design-pattern-tutorial/)

At this moment the pattern provided is Strategy.
The next should be the Visitor, another behavior pattern.
Looking to receive any feedback about code and suggestions.

- Same pattern using some other programming languages
- Construct other examples using same pattern

## Design Patterns (Behavior)

- Strategy

To learn all about design patterns my suggestion is 
the [Design Patterns: Elements of Reusable Object-Oriented Software] wrote by [Gang of Four]

> It has been influential to the field of software engineering 
> and is regarded as an important source for object-oriented 
> design theory and practice. More than 500,000 copies 
> have been sold in English and in 13 other languages. [Wikipedia]

## Tech Stack and Tools

This current project was created using Visual Studio 2017
and Visual Studio Code. It is using a CI pipeline to execute 
test after push or any pull request.

- [.NET Core] - .NET Core
- [xunit] - xUnit
- [VS Code] - Visual Studio Code
- [ms-dotnettools.csharp] - ms-dotnettools.csharp

## Installation

This project requires [.NET Core] v2.1+ to run.

For running test...

```sh
cd DesignPatternTutorialTest
dotnet test --no-restore --verbosity normal
```

For build environments...

```sh
cd DesignPatternTutorial
dotnet build --configuration Release --no-restore
```
## License

MIT

**Free Software, Hell Yeah!**

[Design Patterns: Elements of Reusable Object-Oriented Software]: https://en.wikipedia.org/wiki/Design_Patterns
[Wikipedia]: https://en.wikipedia.org/wiki/Design_Patterns
[Gang of Four]: http://wiki.c2.com/?GangOfFour
[.NET Core]: https://dotnet.microsoft.com/download
[xunit]: https://xunit.net/
[VS Code]: https://code.visualstudio.com/
[ms-dotnettools.csharp]: https://github.com/OmniSharp/omnisharp-vscode.git