using NuGet.ProjectModel;
using System.ComponentModel.DataAnnotations;

namespace LoanPortalAPIDev.Data
{
    public class PQLC_Loan
    {
        private Guid app_ID;
        [Key]
        public Guid ID { 
            get { return app_ID; }
            set { app_ID = value; }
        }
        public DateTime applicationDate { get; set; }
        public DateTime lastSavedDate { get; set; }
        public string? applicationName { get; set; }
        public string? clientNumber { get; set; }
        public string? actionedBy { get; set; }
        public string? loanProduct { get; set; }
        public double existingLoanBalance { get; set; }
        public double proposedLoanBalance { get; set; }
       
        public decimal financeRate { get; set; }
        public int loanTerm { get; set; }
        public string? termType { get; set; }
        public double instalmentAmount { get; set; }
        public string? instalmentFrequency { get; set; }
        public double interestAccrued { get; set; }
        public DateTime startDate { get; set; }
        public DateTime firstPaymentDate { get; set; }
        public DateTime maturityDate { get; set; }

        public int householdAdult { get; set; }
        public int householdDependants { get; set; }
        

        public List<Assets>? assets { get; set; }
        
        public List<Liabilities>? liabilities { get; set; }

        public List<Income>? income { get; set; }
        public List<Expense>? expenses { get; set; }
        public class Expense
        {
            [Key]
            private Guid expenseId { get; set; }
            public Guid appID { get; set; }
            public Guid ID
            {
                get { return expenseId; }
                set { expenseId = value; }
            }
            public string? expenseType { get; set; }
            public double expenseAmount { get; set; }
            public string? expenseFrequency { get; set; }
            public string? customDescription { get; set; }
        }

        public class Income
        {
            [Key]
            private Guid incomeId { get; set; }
            public Guid appID { get; set; }
            public Guid ID { 
                get { return incomeId; }
                set { incomeId = value; }
            }
            public string? incomeType { get; set; }
            public double incomeAmount { get; set; }
            public string? incomeFrequency { get; set; }
            public string? customDescription { get; set; }
        }

        public class Liabilities
        {
            [Key]
            private Guid liabilityId { get; set; }
            public Guid appID { get; set; }
            public Guid ID
            {
                get { return liabilityId; }
                set { liabilityId = value; }
            }
            public string? liabilityType { get; set; }
            public double liabilityAmount { get; set; }
            public string? liabilityAmountFreq { get; set; }
            public string? customDescription { get; set; }
            public bool consolidate { get; set; }
            public double creditLimit { get; set; }
            public double outstandingBalance { get; set; }
        }
        
        public class Assets
        {
            [Key]
            private Guid assetId { get; set; }
            public Guid appID { get; set; }
            public Guid ID{
                get { return assetId; }
                set { assetId = value; }
            }
            public string? assetType { get; set; }
            public double assetAmount { get; set; }
            public string? customDescription { get; set; }
        }
        

    }
}
