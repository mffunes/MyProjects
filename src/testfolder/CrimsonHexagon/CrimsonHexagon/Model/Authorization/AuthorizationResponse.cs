using System;

namespace CrimsonHexagon.Model.Authorization
{
    public class AuthorizationResponse
    {
        public string auth { get; set; }
        public DateTime expires { get; set; }
        public string status { get; set; }
    }
}
