using API_EF_SQLite.CashFlow.Interfaces;
using API_EF_SQLite.CashFlow.Entities;
using Newtonsoft.Json;

namespace API_EF_SQLite.CashFlow
{
    public class CashFlowCore : ICashFlowCore
    {
        public readonly ICashFlowContext _context;
        public CashFlowCore(ICashFlowContext context)
        {
            _context = context;
        }

        public string GetBalance()
        {
            return JsonConvert.SerializeObject(_context.GetBalance().Select(x => new {Date = x.Date.ToString("dd/MM/yyyy"), Value = x.Value}));
        }

        public void SetTransaction(CashFlowDTO transaction)
        {
            var objDao = new CashFlowDAO
            {
                Type = transaction.Type,
                Value = transaction.Value,
                Date = transaction.Date
            };

            _context.SaveTransaction(objDao);
        }
    }
}
