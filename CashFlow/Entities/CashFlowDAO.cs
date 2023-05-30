using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EF_SQLite.CashFlow.Entities
{
    public class CashFlowDAO
    {
        [Key]
        public int Id { get; set; }
        public TransactionType Type { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
    }
}
