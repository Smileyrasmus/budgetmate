namespace DataAccess.Models
{
    public class Account
    {
        public string Name { get; set; }
        public List<Account> SubAccounts { get; set; }
        public Account? Parent { get; set; }
        public TransactionType Type { get; set; }
        public decimal Total { get; set; }
        public List<LineItem> LineItems { get; set; }

        public Account(string name, TransactionType type)
        {
            Name = name;
            Type = type;
            SubAccounts = new List<Account>();
            LineItems = new List<LineItem>();
            Total = 0;

        }

        public void AddSubAccount(Account subAccount)
        {
            subAccount.Parent = this;
            SubAccounts.Add(subAccount);
        }

        public void AddLineItem(LineItem lineItem)
        {
            LineItems.Add(lineItem);

            // add lineitem to total
            decimal amount = lineItem.Amount;
            if (Type != lineItem.Type) amount = amount * -1; // if type is not equal, subtract from total instead of adding
            Total += amount;
        }
    }
}
