namespace LoanPortalAPIDev.Data
{
    public class LPIPremiumRates
    {
        
        
        

        public List<Rates>? rates { get; set; }
        /*
         * { rates:
         *  [
         *   {
         *         death: 0.000437  
         *   }
         *  ]
         * }
         * 
         */

        public class Rates {
            //private DateTime
            public DateTime effectiveDate { get; set; }
            public double death { get; set; }


            public List<Disability>? disability { get; set; }

            public class Disability
            {
                public int term { get; set; }
                public double rate { get; set; }
            }

            public List<Redundancy>? redundancy { get; set; }

            public class Redundancy
            {
                public int term { get; set; }
                public double rate { get; set; }
            }

            public List<CriticalIllness>? criticalIllness { get; set; }

            public class CriticalIllness
            {
                public int term { get; set; }
                public double rate { get; set; }
            }

            public List<Bankruptcy>? bankruptcy { get; set; }

            public class Bankruptcy
            {
                public int term { get; set; }
                public double rate { get; set; }
            }
        }
    }
}
