using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_EF_SQLite.CashFlow.Entities
{
    public class CashFlowDTO
    {
        [Required]
        [Range(0, 1)]
        public TransactionType Type { get; set; }
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Value { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }

    public enum TransactionType
    {
        Credit,
        Debit
    }
}
