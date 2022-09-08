# casdoor-dotnet-winform-example

README: [English](https://github.com/casdoor/casdoor-dotnet-winform-example/blob/master/README.md) | 中文

本项目使用 [Windows Forms](https://github.com/dotnet/winforms) 和 [dotnet](https://www.dot.net/) 来演示 Casdoor 的基本使用。

## 需求

[dotnet6 sdk](https://dotnet.microsoft.com/en-us/download) 或 [dotnet5 sdk](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

[webview2 runtime](https://developer.microsoft.com/zh-cn/microsoft-edge/webview2/#download-section) （通常已经预置在系统中了）

## 初始化

您需要为5个变量设置初始值，它们均为 string 类型：

| 名称         | 描述                                                                                             | 所在文件                  |
| ------------ | ------------------------------------------------------------------------------------------------------- | --------------------- |
| Domain       | Casdoor 服务器的 URL                                                                         | `CasdoorVariables.cs` |
| ClientId     | Casdoor 应用程序的客户端 ID                                                               | `CasdoorVariables.cs` |
| AppName      | Casdoor 应用程序的名称                                                                    | `CasdoorVariables.cs` |
| CallbackUrl  | Casdoor 应用程序的回调 URL ，用于重定向，默认为 `casdoor://callback`                       | `CasdoorVariables.cs` |
| ClientSecret | Casdoor 应用程序的客户端密钥                                                           | `CasdoorVariables.cs` |

如果不设置初始值，本项目将使用 [Casdoor online demo](https://door.casdoor.com) 作为默认 Casdoor 服务器，使用 [Casnode](https://door.casdoor.com/applications/app-casnode) 作为默认 Casdoor 应用程序。

## 运行

### Visual Studio

1. 打开 `casdoor-dotnet-winform-example.sln`
2. `Ctrl + F5` 执行

### 命令行

1. `cd casdoor-dotnet-winform-example`
2. `dotnet run --framework net6.0-windows` 或者 `dotnet run --framework net5.0-windows`
