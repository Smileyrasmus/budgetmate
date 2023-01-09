namespace DataAccess.Models
{
    public class LineItem
    {
        public Guid Id { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }

        public LineItem(TransactionType type, decimal amount)
        {
            Id = Guid.NewGuid();
            Type = type;
            Amount = amount;
        }
    }
}
