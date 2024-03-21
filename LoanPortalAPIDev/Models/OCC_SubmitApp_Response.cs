namespace LoanPortalAPIDev.Models
{
    public class OCC_SubmitApp_Response
    {
        public Data? data { get; set; }
        public List<Errors>? errors { get; set; }

        public class Errors
        {
            public string? status { get; set; }
            public string? title { get; set; }
            public string? detail { get; set; }
        }

        public class Data
        {
            public string? type { get; set; }
            public string? id { get; set; }

            public Attributes? attributes { get; set; }
            public Links? links { get; set; }

            public class Links
            {
                public string? self { get; set; }
            }

            public class Attributes
            {
                public string? applicationRef { get; set; }
                public Message? message { get; set; }

                public class Message
                {
                    public string? value { get; set; }
                    public string? id { get; set; }
                    public string? cat { get; set; }

                }
                public string? result { get; set; }
            }
        }
    }
}
