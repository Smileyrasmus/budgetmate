namespace DataAccess.Models
{
    public class GeneralLedger
    {
        public List<Account> Accounts { get; private set; }

        public GeneralLedger()
        {
            Accounts = new List<Account>
            {
                new Account("Aktieudbytte"),
                new Account("Udgifter"),
                new Account("Aktiver"),
                new Account("Passiver"),
                new Account("Egenkapital"),
                new Account("Indkomst")
            };
        }
    }
}