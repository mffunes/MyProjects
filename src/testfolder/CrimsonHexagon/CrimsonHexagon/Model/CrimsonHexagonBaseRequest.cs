using System.ComponentModel.DataAnnotations;
using Sources.Infrastructure;

namespace CrimsonHexagon.Model
{
    public class CrimsonHexagonBaseRequest : BaseRequest
    {
        public CrimsonHexagonBaseRequest()
        {
            this.Version = 3;
        }

        [Display(Name = "auth")]
        public string AuthorizationToken { get; set; }

        [Display(Name = "version")]
        public int Version { get; set; }
    }
}
