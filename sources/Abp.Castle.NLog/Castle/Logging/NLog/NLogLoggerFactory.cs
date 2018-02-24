using Castle.Core.Logging;
using System;
using System.IO;
using NLogCore = NLog;

namespace Abp.Castle.Logging.NLog
{

    public class NLogLoggerFactory : AbstractLoggerFactory
    {
        private const string DefaultConfigFileName = "nlog.config";
        //private readonly ILoggerRepository _loggerRepository;

        public NLogLoggerFactory()
            : this(DefaultConfigFileName)
        {

        }

        public NLogLoggerFactory(string configFileName)
        {
            if (!File.Exists(configFileName))
            {
                throw new FileNotFoundException(configFileName);
            }
            NLogCore.LogManager.Configuration = new NLogCore.Config.XmlLoggingConfiguration(configFileName);
        }

        public override ILogger Create(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            return new NLogLogger(NLogCore.LogManager.GetLogger(name));
        }

        public override ILogger Create(string name, LoggerLevel level)
        {
            throw new NotSupportedException("Logger levels cannot be set at runtime. Please review your configuration file.");
        }
    }
}