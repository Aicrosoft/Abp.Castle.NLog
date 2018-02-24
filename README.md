# Abp.Castle.NLog
Abp的NLog日志输出模块。


## 使用方法
> - 使用Nuget管理卸载Abp.Castle.Log4Net
> - 使用Nuget安装Abp.Castle.NLog
> - 配置[nlog.config](doc/nlog.config) 文件，可下载直接使用
> - 修改Startup, 将原来的日志组件log4net替换为nlog 
> - 注释using Abp.Castle.Logging.Log4Net; 添加using Abp.Castle.Logging.NLog;
> - 修改ConfigureServices方法:`f => f.UseAbpNLog().WithConfig("nlog.config")`

好了，其它的不用动了了。

