using System;
using log4net;
using log4net.Config;

namespace Logger
{
    public class Logger : ILogger
    {
        private static ILog log = LogManager.GetLogger("Logger");

        public Logger()
        {
            XmlConfigurator.Configure();
        }

        public void Debug(string message)
        {
            log.Debug(message);
        }

        public void Error(string message)
        {
            log.Error(message);
        }

        public void Fatal(string message)
        {
            log.Fatal(message);
        }

        public void Info(string message)
        {
            log.Info(message);
        }

        public void Warn(string message)
        {
            log.Warn(message);
        }
    }
}
