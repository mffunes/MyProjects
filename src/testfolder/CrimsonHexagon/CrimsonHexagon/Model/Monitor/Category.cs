namespace CrimsonHexagon.Model.Monitor
{
    public class Category
    {
        public string status { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int trainingDocs { get; set; }
        public bool hidden { get; set; }
        public int sortOrder { get; set; }
    }
}
