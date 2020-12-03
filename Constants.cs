using System;
using System.Collections.Generic;
using System.Text;

namespace HttpApp.Models
{
    public class Constants
    {
        public class Credentials
        {
            public const string UserName = "<yourusername>";
            public const string Password = "<yourpassword>";
        }

        public class Urls
        {
            public const string BaseUrl = "https://webapibasicsstudenttracker.azurewebsites.net";

            public static readonly string BaseUrlApi = $"{BaseUrl}/api";

            public const string GetStudentsUnsecure = "/students";
            public const string GetStudentsSecure = "/securestudents";

            public const string PostToken = "/Tokens";

        }
    }
}
