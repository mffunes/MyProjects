using System.Collections.Generic;

namespace CrimsonHexagon.Model.Monitor
{
    public class Monitor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public bool enabled { get; set; }
        public string resultsStart { get; set; }
        public string resultsEnd { get; set; }
        public List<Tags> tags { get; set; }
        public List<Category> categories { get; set; }
        public string status { get; set; }
    }
}
