using DataAccess.Models;

namespace DataAccessTests.Models
{
    public class AccountTests
    {
        [Fact]
        public void AddSubAccount_AddingSubAccount_Succcess()
        {
            // arrange
            Account account = new("Test Account", TransactionType.Debit);
            Account subAccount = new("Test Sub Account", TransactionType.Debit);

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
            Account account = new("Test Account", TransactionType.Debit);
            Account subAccount = new("Test Sub Account", TransactionType.Debit);

            // act
            account.AddSubAccount(subAccount);

            // assert
            Assert.Equal(subAccount.Parent, account);
        }

        [Fact]
        public void AddLineItem_AddedLinesShouldAddToTotal_TotalRises()
        {
            // arrange
            Account debitAccount = new("Test Account", TransactionType.Debit);
            LineItem debitLineItem = new(TransactionType.Debit, 100);
            Account creditAccount = new("Test Account", TransactionType.Credit);
            LineItem creditLineItem = new(TransactionType.Credit, 100);

            // act
            debitAccount.AddLineItem(debitLineItem);
            creditAccount.AddLineItem(creditLineItem);

            // assert
            Assert.Equal(100, debitAccount.Total);
            Assert.Equal(100, creditAccount.Total);
        }
    }
}
