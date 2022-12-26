using DataAccess.Models;

namespace DataAccessTests.Models
{
    public class AccountTests
    {
        [Fact]
        public void AddSubAccount_AddingSubAccount_Succcess()
        {
            // arrange
            Account account = new("Test Account");
            Account subAccount = new("Test Sub Account");

            // act
            account.AddSubAccount(subAccount);

            // assert
            Assert.Single(account.SubAccounts);
            Assert.Equal(account.SubAccounts[0], subAccount);
        }

        [Fact]
        public void AddSubAccount_SubAccountGainsParent_Succcess()
        {
            // arrange
            Account account = new("Test Account");
            Account subAccount = new("Test Sub Account");

            // act
            account.AddSubAccount(subAccount);

            // assert
            Assert.Equal(subAccount.Parent, account);
        }
    }
}
