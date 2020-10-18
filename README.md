# RemoteExecutor

RemoteExecutor 是一个基于服务器的**异步**(重点！！这意味着**控制机和受控机不要求同时运行**)远程监控工具，**你可能需要有物理接触受控机的权力才能部署它**。

[查看开发文档](docs/SUMMARY.md)

## 特性（开发目标）

- 一键+一次性部署，无需任何后续操作
- 开机自动启动
- 自动更新主程序
- 可配置性
- 可选择上传日志文件
- 可以向服务器上传指定文件
- 可以自动将可移动存储设备中的文件**增量**复制到本地，并按需上传
- 可远程执行任意代码

## 参与开发

本项目主要使用C# .NET Framework 4.8(可以自行构建针对于低版本运行时的程序)和Java实现, IDE使用Visual Studio。

## 短期开发目标

- 配置文件支持
  - SharedLibrary
    - [ ] 从`config.json`中读取配置
    - [ ] `Configuration`类
    - [ ] `ConfigManager`类
  - Client
    - [ ] 读取配置文件
  - Console
    - [ ] 读取配置文件
- 待定
