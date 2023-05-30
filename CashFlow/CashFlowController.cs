using API_EF_SQLite.CashFlow.Interfaces;
using API_EF_SQLite.CashFlow.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_EF_SQLite.CashFlow
{
    [Route("api")]
    [ApiController]
    public class CashFlowController : ControllerBase
    {
        private readonly ICashFlowCore _core;

        public CashFlowController(ICashFlowCore core)
        {
            _core = core;
        }

        // GET: api/balance
        [HttpGet]
        [Route("balance")]
        public IActionResult Get()
        {
            var result = _core.GetBalance();
            return StatusCode((int)HttpStatusCode.OK, result) ;
        }

        // POST api/trasaction
        [HttpPost]
        [Route("transaction")]
        public void Post([FromBody] CashFlowDTO transaction)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            _core.SetTransaction(transaction);
        }
    }
}
