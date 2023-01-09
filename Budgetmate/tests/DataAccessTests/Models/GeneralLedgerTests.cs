using DataAccess.Models;

namespace DataAccessTests.Models
{
    public class GeneralLedgerTests
    {
        [Fact]
        public void GetAccounts_NewGeneralLedger_DefaultAccountsExists()
        {
            // Given
            GeneralLedger generalLedger = new GeneralLedger();

            // When
            List<Account> accounts = generalLedger.Accounts;

            // Then
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Assert.True(accounts.Exists(a => a.Name == "Aktieudbytte"));
            Assert.True(accounts.Find(a => a.Name == "Aktieudbytte").Type == TransactionType.Debit);
            Assert.True(accounts.Exists(a => a.Name == "Udgifter"));
            Assert.True(accounts.Find(a => a.Name == "Udgifter").Type == TransactionType.Debit);
            Assert.True(accounts.Exists(a => a.Name == "Aktiver"));
            Assert.True(accounts.Find(a => a.Name == "Aktiver").Type == TransactionType.Debit);

            Assert.True(accounts.Exists(a => a.Name == "Passiver"));
            Assert.True(accounts.Find(a => a.Name == "Passiver").Type == TransactionType.Credit);
            Assert.True(accounts.Exists(a => a.Name == "Egenkapital"));
            Assert.True(accounts.Find(a => a.Name == "Egenkapital").Type == TransactionType.Credit);
            Assert.True(accounts.Exists(a => a.Name == "Indkomst"));
            Assert.True(accounts.Find(a => a.Name == "Indkomst").Type == TransactionType.Credit);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}