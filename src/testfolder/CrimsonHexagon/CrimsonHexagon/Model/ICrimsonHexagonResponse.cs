using System.Collections.Generic;

namespace CrimsonHexagon.Model
{
    public interface ICrimsonHexagonResponse
    {
        IList<CrimsonHexagonItem> GetCrimsonHexagonItem();
    }
}
