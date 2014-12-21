using System.Collections.Generic;
using CrimsonHexagon.Model;

namespace CrimsonHexagon.Client
{
    public interface ICrimsonHexagonClient
    {
        IList<CrimsonHexagonItem> GetCrimsonHexagonItems();
    }
}