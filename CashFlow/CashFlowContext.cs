using API_EF_SQLite.CashFlow.Entities;
using API_EF_SQLite.CashFlow.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Text;

namespace API_EF_SQLite.CashFlow
{
    public class CashFlowContext : DbContext, ICashFlowContext
    {
        public DbSet<Entities.CashFlowDAO> CashFlow { get; set; }
        public CashFlowContext(DbContextOptions<CashFlowContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CashFlowDAO>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Type).IsRequired();
                entity.Property(e => e.Value).IsRequired();
                entity.Property(e => e.Date).IsRequired();
            });

            modelBuilder.Entity<CashFlowDAO>(entity =>
            {
                entity.HasData(new CashFlowDAO { Id = 1, Type = TransactionType.Credit, Value = 1000, Date = new DateTime(2023, 05, 29) });
                entity.HasData(new CashFlowDAO { Id = 2, Type = TransactionType.Credit, Value = 1000, Date = new DateTime(2023, 05, 29) });
                entity.HasData(new CashFlowDAO { Id = 3, Type = TransactionType.Debit, Value = 900, Date = new DateTime(2023, 05, 30) });
                entity.HasData(new CashFlowDAO { Id = 4, Type = TransactionType.Credit, Value = 1000, Date = new DateTime(2023, 05, 30) });
                entity.HasData(new CashFlowDAO { Id = 5, Type = TransactionType.Debit, Value = 2000, Date = new DateTime(2023, 05, 30) });
                entity.HasData(new CashFlowDAO { Id = 6, Type = TransactionType.Debit, Value = 100, Date = new DateTime(2023, 05, 31) });
                entity.HasData(new CashFlowDAO { Id = 7, Type = TransactionType.Credit, Value = 90, Date = new DateTime(2023, 05, 31) });
                entity.HasData(new CashFlowDAO { Id = 8, Type = TransactionType.Credit, Value = 2000, Date = new DateTime(2023, 05, 31) });
            });
        }

        public IEnumerable<CashFlowDAO> GetBalance()
        {
            return CashFlow
                .GroupBy(x => x.Date.Date)
                .Select(g => new CashFlowDAO
                {
                    Date = g.Key.Date,
                    Value = (decimal)g.Sum(x => x.Type == TransactionType.Credit ? (double)x.Value : (double)-x.Value)
                })
                .ToList();
        }

        public void SaveTransaction(CashFlowDAO transaction)
        {
            CashFlow.Add(transaction);
            SaveChanges();
        }
    }
}
