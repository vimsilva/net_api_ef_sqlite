using API_EF_SQLite.CashFlow.Entities;

namespace API_EF_SQLite.CashFlow.Interfaces
{
    public interface ICashFlowContext
    {
        public IEnumerable<CashFlowDAO> GetBalance();
        
        public void SaveTransaction(CashFlowDAO transaction);
    }
}
