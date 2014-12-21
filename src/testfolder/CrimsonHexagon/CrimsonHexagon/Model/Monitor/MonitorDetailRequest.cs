using System.ComponentModel.DataAnnotations;

namespace CrimsonHexagon.Model.Monitor
{
    public class MonitorDetailRequest : CrimsonHexagonBaseRequest
    {
        [Display(Name = "id")]
        public string MonitorId { get; set; }
    }
}
