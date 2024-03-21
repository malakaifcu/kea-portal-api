namespace LoanPortalAPIDev.Models
{
    public class ApplicationsByDateSince
    {
        public List<Data> data { get; set; }

        public class Data
        {
            public string type { get; set; }
            public string id { get; set; }
            public Attributes attributes { get;set;}
            public Links links { get; set; }
            public class Attributes
            {
                public string lastSavedDateTime { get; set; }
            }
            public class Links
            {
                public string self { get; set; }
            }
        }
    }
}
