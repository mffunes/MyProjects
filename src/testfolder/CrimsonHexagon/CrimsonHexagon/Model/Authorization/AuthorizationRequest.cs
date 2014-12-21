using System.ComponentModel.DataAnnotations;
using Sources.Infrastructure;

namespace CrimsonHexagon.Model.Authorization
{
    public class AuthorizationRequest : BaseRequest
    {
        [Display(Name = "username")]
        public string UserName { get; set; }

        [Display(Name = "password")]
        public string Password { get; set; }
    }
}
