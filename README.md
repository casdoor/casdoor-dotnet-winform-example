# casdoor-dotnet-winform-example

README: English | [中文](https://github.com/casdoor/casdoor-dotnet-winform-example/blob/master/README-zh-cn.md)


This project was bootstrapped with [Windows Forms](https://github.com/dotnet/winforms) and [dotnet](https://www.dot.net/).

## Prerequisites

[dotnet6 sdk](https://dotnet.microsoft.com/en-us/download) or [dotnet5 sdk](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

[webview2 runtime](https://developer.microsoft.com/zh-cn/microsoft-edge/webview2/#download-section) (It's already preinstalled in your windows generally)

## Init example

You need to init requires 5 parameters, which are all string type:

| Name         | Description                                                                                             | File                  |
| ------------ | ------------------------------------------------------------------------------------------------------- | --------------------- |
| Domain       | Your Casdoor server host/domain                                                                         | `CasdoorVariables.cs` |
| ClientId     | The Client ID of your Casdoor application                                                               | `CasdoorVariables.cs` |
| AppName      | The name of your Casdoor application                                                                    | `CasdoorVariables.cs` |
| CallbackUrl  | The path of the callback URL for your Casdoor application, will be `casdoor://callback` if not provided | `CasdoorVariables.cs` |
| ClientSecret | The Client Secret of your Casdoor application                                                           | `CasdoorVariables.cs` |

If you don't set these parameters, this project will use the [Casdoor online demo](https://door.casdoor.com) as the defult Casdoor server and use the [Casnode](https://door.casdoor.com/applications/app-casnode) as the default Casdoor application.

## How to run it

### Visual Studio

1. Open `casdoor-dotnet-winform-example.sln`
2. Press `Ctrl + F5` to start

### Command line

1. `cd casdoor-dotnet-winform-example`
2. `dotnet run --framework net6.0-windows` or `dotnet run --framework net5.0-windows`
