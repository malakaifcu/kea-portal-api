using LoanPortalAPIDev.Data;
using LoanPortalAPIDev.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanPortalAPIDev.Controllers
{
    [Route("lpi/v1.0")]
    [ApiController]
    public class LoanProtectionInsurancePremiumController : ControllerBase
    {
        
        // GET: api/<LoanProtectionInsurancePremiumController>
        [HttpGet]
        public LPIPremiumRates Get()
        {
            LPIPremiumRates allRates = new LPIPremiumRates();
            allRates.rates = new List<LPIPremiumRates.Rates> { new LPIPremiumRates.Rates { 
                effectiveDate=new DateTime(2023,03,31,10,15,00),
                death=0.000437,
                disability=new List<LPIPremiumRates.Rates.Disability>{ 
                    new LPIPremiumRates.Rates.Disability { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=12,rate =0.003567 }
                },
                criticalIllness=new List<LPIPremiumRates.Rates.CriticalIllness>{
                    new LPIPremiumRates.Rates.CriticalIllness { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=12,rate =0.003567 }
                },
                redundancy=new List<LPIPremiumRates.Rates.Redundancy>{
                    new LPIPremiumRates.Rates.Redundancy { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=12,rate =0.003567 }
                },
                bankruptcy=new List<LPIPremiumRates.Rates.Bankruptcy>{
                    new LPIPremiumRates.Rates.Bankruptcy { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=12,rate =0.003567 }
                }
            },
            new LPIPremiumRates.Rates {
                effectiveDate=new DateTime(2022,03,31,10,15,00),
                death=0.000301,
                disability=new List<LPIPremiumRates.Rates.Disability>{
                    new LPIPremiumRates.Rates.Disability { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.Disability { term=12,rate =0.003567 }
                },
                criticalIllness=new List<LPIPremiumRates.Rates.CriticalIllness>{
                    new LPIPremiumRates.Rates.CriticalIllness { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.CriticalIllness { term=12,rate =0.003567 }
                },
                redundancy=new List<LPIPremiumRates.Rates.Redundancy>{
                    new LPIPremiumRates.Rates.Redundancy { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.Redundancy { term=12,rate =0.003567 }
                },
                bankruptcy=new List<LPIPremiumRates.Rates.Bankruptcy>{
                    new LPIPremiumRates.Rates.Bankruptcy { term=12,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=24,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=36,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=48,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=60,rate =0.003567 },
                    new LPIPremiumRates.Rates.Bankruptcy { term=12,rate =0.003567 }
                }
            }
            };
            return allRates;
        }

        // GET api/<LoanProtectionInsurancePremiumController>/5
        /// <summary>
        /// Get quote for LPI up-front premium
        /// </summary>
        /// <param name="premiumCost"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<PremiumCostQuote> Get(PremiumCost premiumCost)
        {
            double prem = premiumCost.premium;
            int term = premiumCost.term;
            double loan = premiumCost.loan;
            double rate = premiumCost.rate;

            PremiumCostQuote q = new  PremiumCostQuote();
            double gp = 0;
            for(int i = 0; i <= term; i++)
            {
                gp = gp + loan * prem * (1 - 1 / Math.Pow((1 + (rate / 100) / 12), term - (i + 1) + 1)) / (1 - 1 / Math.Pow((1 + (rate / 100) / 12), term));
            }

            q.quote = gp * (1 + gp / loan); //Include rebate in gross premium

            return q;
        }


        // PUT api/<LoanProtectionInsurancePremiumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoanProtectionInsurancePremiumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
