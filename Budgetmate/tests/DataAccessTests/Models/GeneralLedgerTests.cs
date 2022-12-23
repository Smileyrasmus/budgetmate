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
            Assert.True(accounts.Exists(a => a.Name == "Aktieudbytte"));
            Assert.True(accounts.Exists(a => a.Name == "Udgifter"));
            Assert.True(accounts.Exists(a => a.Name == "Aktiver"));
            Assert.True(accounts.Exists(a => a.Name == "Passiver"));
            Assert.True(accounts.Exists(a => a.Name == "Egenkapital"));
            Assert.True(accounts.Exists(a => a.Name == "Indkomst"));
        }
    }
}