namespace DataAccess.Models
{
    public class Account
    {
        public string Name { get; set; }
        public List<Account> SubAccounts { get; set; }
        public Account? Parent { get; set; }

        public Account(string name)
        {
            Name = name;
            SubAccounts = new List<Account>();

        }

        public void AddSubAccount(Account subAccount)
        {
            subAccount.Parent = this;
            SubAccounts.Add(subAccount);
        }
    }
}
