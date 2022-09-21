using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace UserRegistrationUsingRegex
{
    public class NLog
    {

        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogInfo(string msg)
        {
            logger.Info(msg);
        }

    }
}

