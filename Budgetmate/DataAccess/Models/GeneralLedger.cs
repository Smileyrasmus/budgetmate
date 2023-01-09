namespace DataAccess.Models
{
    public class GeneralLedger
    {
        public List<Account> Accounts { get; private set; }

        public GeneralLedger()
        {
            Accounts = new List<Account>
            {
                new Account("Aktieudbytte", TransactionType.Debit),
                new Account("Udgifter", TransactionType.Debit),
                new Account("Aktiver", TransactionType.Debit),
                new Account("Passiver", TransactionType.Credit),
                new Account("Egenkapital", TransactionType.Credit),
                new Account("Indkomst", TransactionType.Credit)
            };
        }
    }
}