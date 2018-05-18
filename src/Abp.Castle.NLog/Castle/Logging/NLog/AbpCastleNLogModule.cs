using Abp.Modules;

namespace Abp.Castle.Logging.NLog
{
    /// <summary>
    /// ABP Castle Log4Net module.
    /// </summary>
    [DependsOn(typeof(AbpKernelModule))]
    public class AbpCastleLog4NetModule : AbpModule
    {

    }
}