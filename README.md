![logo]

# Abp.Castle.NLog
Abp的NLog日志输出模块。

----------------------
![license]
[![LICENSE](https://img.shields.io/badge/license-Anti%20996-blue.svg)](https://github.com/996icu/996.ICU/blob/master/LICENSE)

## Nuget Packages ##         
|Package|Status|
|:------|:-----:|
|Abp.Castle.NLog|[![NuGet version](https://badge.fury.io/nu/Abp.Castle.NLog.svg)](https://badge.fury.io/nu/Abp.Castle.NLog)|



[json]: https://www.nuget.org/packages/Newtonsoft.Json/ "Newtonsoft.Json"
[icon]: ./doc/icon48.png "Rbp icon"
[logo]: ./doc/icon128.png "Rbp Logo"
[license]: https://img.shields.io/github/license/RiseSoho/RiseNetBoilerplate.svg "MIT license"



----------------------

### 使用方法
> - 使用Nuget管理卸载Abp.Castle.Log4Net
> - 使用Nuget安装Abp.Castle.NLog
> - 配置[nlog.config](doc/nlog.config) 文件，可下载直接使用
> - 修改Startup, 将原来的日志组件log4net替换为nlog 
> - 注释using Abp.Castle.Logging.Log4Net; 添加using Abp.Castle.Logging.NLog;
> - 修改ConfigureServices方法:`f => f.UseAbpNLog().WithConfig("nlog.config")`

好了，其它的不用动了了。

### 参考
1. https://www.cnblogs.com/donaldtdz/p/8213440.html

