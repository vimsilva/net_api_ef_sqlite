using API_EF_SQLite.CashFlow.Entities;

namespace API_EF_SQLite.CashFlow.Interfaces
{
    public interface ICashFlowCore
    {
        public string GetBalance();
        public void SetTransaction(CashFlowDTO transaction);
    }
}
