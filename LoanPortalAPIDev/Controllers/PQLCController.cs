using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoanPortalAPIDev.Models;
using LoanPortalAPIDev.Data;
using LoanPortalAPIDev.Utilities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanPortalAPIDev.Controllers
{
    [Route("/pqlc/v1.0")]
    [ApiController]
    [Produces("application/json")]
    public class PQLCController : ControllerBase
    {
        private readonly AppPostgresDbContext _context;

        public PQLCController(AppPostgresDbContext context)
        {
            _context = context;
        }



        // GET: api/<PQLCController>
        /// <summary>
        /// Retrieve list of PQLC submissions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PQLC_Loan>>> Get()
        {
            return await _context.PQLC_Loans.ToListAsync();
        }

        // GET api/<PQLCController>/5
        /// <summary>
        /// Retrieve a PQLC submission by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<PQLC_Loan>> GetPQLC(Guid id)
        {
            var loan = await _context.PQLC_Loans.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }
            return loan;
        }

        [HttpGet("ai")]
        [ApiExplorerSettings(IgnoreApi =false)]
        public async Task<ActionResult<string>> ChatAI(string message)
        {
            AI ai = new AI();
            return await ai.Chat(message);
        }

        // POST api/<PQLCController>
        /// <summary>
        /// Submit a new PQLC application.
        /// </summary>
        /// <param name="loan"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<PQLC_Loan>> PostPQLC(PQLC_Loan loan)
        {
            //Set default request values
            Guid appID_ = new Guid();
            loan.ID = appID_;
            loan.applicationDate = DateTime.UtcNow;
            loan.lastSavedDate = DateTime.UtcNow;
            loan.startDate = DateTime.UtcNow;
            loan.firstPaymentDate = DateTime.UtcNow;
            loan.maturityDate = DateTime.UtcNow;
            loan.actionedBy = "MC";
            loan.applicationName = "Mr Jim CARRY";
            loan.existingLoanBalance = 0;
            loan.proposedLoanBalance = 10000;
            loan.financeRate = 12.5M;
            loan.loanTerm = 24;
            loan.termType = "M";
            loan.loanProduct = "PERN";
            loan.householdDependants = 0;
            loan.householdAdult = 1;
            loan.clientNumber = "0001014598";
            loan.assets = new List<PQLC_Loan.Assets> { 
                new PQLC_Loan.Assets{ 
                    assetType = "HOME",
                    assetAmount = 750000,
                    customDescription = "",
                    ID = new Guid(),
                    appID = appID_
                },
                new PQLC_Loan.Assets{
                    assetType = "HHOLDCONT",
                    assetAmount = 12000,
                    customDescription = "",
                    ID = new Guid(),
                    appID = appID_
                }
            };
            loan.liabilities = new List<PQLC_Loan.Liabilities>
            {
                new PQLC_Loan.Liabilities{
                    liabilityType = "FIRSTMORT",
                    liabilityAmount = 350,
                    liabilityAmountFreq = "W",
                    consolidate = false,
                    creditLimit = 620000,
                    outstandingBalance = 201000,
                    customDescription="",
                    ID = new Guid()
                },
                new PQLC_Loan.Liabilities{
                    liabilityType = "CCARD",
                    liabilityAmount = 45,
                    liabilityAmountFreq = "W",
                    consolidate = false,
                    creditLimit = 4300,
                    outstandingBalance = 567,
                    customDescription="Mastercard",
                    ID = new Guid()
                }
            };
            loan.income = new List<PQLC_Loan.Income> { 
                new PQLC_Loan.Income{ 
                    incomeType = "WAGES",
                    incomeAmount = 3500,
                    incomeFrequency = "F",
                    customDescription="",
                    ID = new Guid()
                }
            };
            loan.expenses = new List<PQLC_Loan.Expense> { 
                new PQLC_Loan.Expense{ 
                    expenseType = "RATES",
                    expenseAmount = 280,
                    expenseFrequency = "F",
                    ID = new Guid()
                }
            };
            _context.PQLC_Loans.Add(loan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = loan.ID }, loan);
        }

        // PUT api/<PQLCController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<PQLCController>/5
        /// <summary>
        /// Delete a PQLC application
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePQLC(Guid id)
        {
            var loan = await _context.PQLC_Loans.FindAsync(id);

            if(loan == null)
            {
                return NotFound();
            }

            _context.PQLC_Loans.Remove(loan);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
