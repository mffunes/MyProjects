
using System.ComponentModel.DataAnnotations;

namespace CrimsonHexagon.Model.Monitor
{
    public class MonitorListRequest : CrimsonHexagonBaseRequest
    {
        [Display(Name = "username")]
        public string UserName { get; set; }
    }
}
