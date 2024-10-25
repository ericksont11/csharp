using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        /**
         * TODO: rewrite these three tests into a single, parameterized test.
         * You decide if you want to use [TestCase] or [TestCaseSource], but
         * I would like to know why you chose the option you chose afterwards.
         */
        [Test, TestCaseSource("WithdrawDepositData")]
        public void CreateNewSavingsAccount_DepositThenWithdraw_CheckNewBalance
            (int deposit, int withdrawl, int balance)
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(deposit);
            account.Withdraw(withdrawl);

            Assert.That(account.Balance, Is.EqualTo(balance));
        }

        private static IEnumerable<TestCaseData> WithdrawDepositData(){
            yield return new TestCaseData(100, 50, 50).
                SetName("2 and 2 equals 4");
            yield return new TestCaseData(1000, 1000, 0).
                SetName("1000 and 1000 equals 0");
            yield return new TestCaseData(250, 1, 249).
                SetName("250 and 1 equals 249");
        }
    }
}
