# RemoteGenius 开发文档

~~竟然还真有大佬来看我这个蒟蒻的辣鸡项目~~

## 项目总览

本项目主要使用C# .NET Framework 4.8(你也可以自行构建针对于低版本运行时的程序)和Java实现, IDE使用Visual Studio 2019。

|子项目名称     |语言   |目标文件           |用途                               |
|---------------|-------|:------------------|-----------------------------------|
|SharedLibrary  |C#     |SharedLibrary.dll  |共用库+API                         |
|Client         |C#     |Client.exe         |受控端软件                         |
|ClientLauncher |C#     |ClientLauncher.exe |进行启动前准备工作+控制自动更新    |
|Console        |C#     |Console.exe        |控制端软件                         |
|ConsoleUpdater |C#     |Updater.exe        |用于进行控制端的更新               |
|Server         |Java   |server.jar         |服务端                             |
|ClientInstaller|C#     |Installer.exe      |用于在受控机上一键部署客户端       |
|ConfigManager  |C#     |reconf.exe         |控制台应用程序，用于在控制机上(物理控制)调整客户端设置|

## 文档目录

[蓝色的链接](#文档目录)代表已经完成/正在编写，普通的文本代表该章节尚未开始编写。

### 第一部分——标准约定

如果你想开发**兼容版第三方服务端/受控端/控制端**，请一定要阅读这一部分

1. [配置文件约定](配置文件约定.md)
2. [通讯协议和格式约定](通讯协议和格式约定.md)
3. 标准操作

### 第二部分——具体实现

此部分用于描述本项目的**具体实现**，若你想**参与主项目开发**，则还需选择阅读这一部分

1. [启动流程](启动流程.md)
2. 工作流程
