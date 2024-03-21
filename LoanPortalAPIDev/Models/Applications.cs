using System.ComponentModel;

namespace LoanPortalAPIDev.Models
{
    public class Applications
    {
        //Applications response body
        //{data:{}, included:[]}
        public Data? data { get; set; }

        public List<Included>? included { get; set; }




        [DisplayName("Data")]
        public class Data
        {
            public string? type { get; set; }
            public string? id { get; set; }
            public Attributes? attributes { get; set; }

            public class Attributes
            {
                public string? applicationInternalNumber { get; set; }
                public string? applicationName { get; set; }
                public string? loadedByClientNumber { get; set; }
                public string? owner { get; set; }
                public string? currentTaskWith { get; set; }
                public string? applicationTitle { get; set; }
                public string? salutation { get; set; }
                public string? tradingBranch { get; set; }
                public string? type { get; set; }
                public string? salesChannel { get; set; }
                public string? subPrime { get; set; }
                public string? comparisonRatesSupplied { get; set; }
                public string? paymentMethod { get; set; }

                public LoanPurpose? loanPurpose { get; set; }

                public class LoanPurpose
                {
                    public string? level1 { get; set; }
                    public string? level2 { get; set; }

                }

                public List<FinancialDetails>? financialDetails { get; set; }

                public class FinancialDetails
                {
                    public string? product { get; set; }
                    public PurchasePrice? purchasePrice { get; set; }

                    public class PurchasePrice
                    {
                        public double retailPrice { get; set; }
                        public double purchasePrice { get; set; }
                        public double options { get; set; }
                        public double accessories { get; set; }
                        public double fleetDiscount { get; set; }
                        public double bonusDiscountAmount { get; set; }
                        public double gst { get; set; }
                        public double lct { get; set; }
                    }

                    public double interestRate { get; set; }
                    public int term { get; set; }
                    public string? termType { get; set; }
                    public int paymentFrequencyUnit { get; set; }
                    public CodeDescriptionTypes? paymentFrequencyType { get; set; }

                    public class CodeDescriptionTypes
                    {
                        public string? code { get; set; }
                        public string? description { get; set; }
                    }
                    public string? signatureDate { get; set; }
                    public string? settlementDate { get; set; }
                    public Deposit? deposit { get; set; }

                    public class Deposit
                    {
                        public double tradeInAmount { get; set; }
                        public double payoutAmount { get; set; }
                        public double cashRefund { get; set; }
                        public double depositAmount { get; set; }
                    }

                    public double valueOfAdvInstalment { get; set; }
                    public double balloonAmount { get; set; }
                    public PaymentMethod? paymentMethod { get; set; }
                    public class PaymentMethod
                    {
                        public string? paymentMethod { get; set; }
                    }
                    public Fees? fees { get; set; }
                    public class Fees
                    {
                        public List<Fee>? fee { get; set; }

                        public class Fee
                        {
                            public string? code { get; set; }
                            public double amount { get; set; }
                            public string? capitalised { get; set; }
                            public string? description { get; set; }
                            public double gstAmount { get; set; }
                            public double itcAmount { get; set; }
                            public string? seq { get; set; }
                            public string? groupingCode { get; set; }
                        }
                    }

                    public Insurances? insurances { get; set; }
                    public class Insurances
                    {
                        public List<Insurance>? insurance { get; set; }
                        public class Insurance
                        {
                            public string? commencementDate { get; set; }
                            public string? expiryDate { get; set; }
                            public string? externalSystemReference { get; set; }
                            public double gstPremium { get; set; }
                            public string? insuranceType { get; set; }
                            public string? jointCover { get; set; }
                            public string? policyDescription { get; set; }
                            public string? policyNumber { get; set; }
                            public double premium { get; set; }
                            public string? seq { get; set; }
                            public double sumInsured { get; set; }
                            public Term term { get; set; }
                            public class Term
                            {
                                public string? unit { get; set; }
                                public int value { get; set; }
                            }
                        }
                        public string? refresh { get; set; }
                        public int total { get; set; }
                    }

                    public InstalmentBreakdown? instalmentBreakdown { get; set; }
                    public class InstalmentBreakdown
                    {
                        public Total? total { get; set; }
                        public class Total
                        {
                            public double principal { get; set; }
                            public double interest { get; set; }
                            public double nonCapitalisedFees { get; set; }
                            public double gst { get; set; }
                        }
                    
                        public List<InstalmentSummary>? instalmentSummary { get; set; }
                        public class InstalmentSummary
                        {
                            public double instalments { get; set; }
                            public double amount { get; set; }
                            public string? startDate { get; set; }
                            public string? endDate { get; set; }
                        }
                    
                        public string? seq { get; set; }
                    }

                }
            
                
            }
        
            public Relationships? relationships { get; set; }

            public class Relationships
            {
                public RelationshipTypes? securities { get; set; }
                
                public Originator? originator { get; set; }

                public RelationshipTypes? associatedClients { get; set; }

                public class RelationshipTypes
                {
                    public Links? links { get; set; }
                    public class Links
                    {
                        public string? related { get; set; }
                        public string? self { get; set; }
                    }

                    public List<Data>? data { get; set; }
                    public class Data
                    {
                        public string? type { get; set; }
                        public string? id { get; set; }
                    }
                }
                public class Originator
                {
                    public Links? links { get; set; }
                    public class Links
                    {
                        public string? related { get; set; }
                        public string? self { get; set; }
                    }

                    public Data? data { get; set; }
                    public class Data
                    {
                        public string? type { get; set; }
                        public string? id { get; set; }
                    }
                }
            }
            
            public Links? links { get; set; }
        
            public class Links
            {
                public string? self { get; set; }
            }


        }

        public class Included
        {
            public string? type { get; set; }
            public string? id { get; set; }
            public Attributes? attributes { get; set; }
            public class Attributes
            {
                public string? @id { get; set; }
                public string? role { get; set; }
            }
        
            public Relationships? relationships { get; set; }
            public class Relationships
            {
                public ClientMaint? clientMaint { get; set; }
                public class ClientMaint
                {
                    public Links? links { get; set; }
                    public class Links
                    {
                        public string? related { get; set; }
                        public string? self { get; set; }
                    }
                
                    public Data? data { get; set; }
                    public class Data
                    {
                        public string? type { get; set; }
                        public string? id { get; set; }
                    }
                }
            }
        
            public Links? links { get; set; }
            public class Links
            {
                public string? self { get; set; }
            }
        }

    }
}
