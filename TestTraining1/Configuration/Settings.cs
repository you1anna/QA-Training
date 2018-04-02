using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTraining1.Configuration
{
    class Settings
    {
        public static string ContentApiUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["ContentApiUrl"];
            }
        }

    }
}
