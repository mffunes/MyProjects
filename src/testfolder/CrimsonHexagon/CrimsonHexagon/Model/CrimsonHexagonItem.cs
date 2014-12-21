using Cassandra.Data.Linq;
using Sources.Infrastructure.Dal;

namespace CrimsonHexagon.Model
{
    [Table("crimsonhexagonitem")]
    public class CrimsonHexagonItem : BaseCassandraItem
    {
        [Column("description")]
        public string Description { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}
