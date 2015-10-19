using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CanadianTireLogin.Helpers
{
    public class Configuration
    {
        private String login;
        private String password;

        public String Login
        {
            get { return ConfigurationManager.AppSettings["Login"]; }
            set { login = value; }
        }

        public String Password
        {
            get { return ConfigurationManager.AppSettings["Password"]; }
            set { password = value; }
        }
    }
}
