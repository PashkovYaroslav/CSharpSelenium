using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CanadianTireLogin.Helpers
{
    public class ProjectConfig
    {
        public static String Login = ConfigurationManager.AppSettings["Login"];
        public static String Password = ConfigurationManager.AppSettings["Login"];
    }
}
