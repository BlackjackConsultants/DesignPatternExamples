using System.Collections.Generic;
using DesignPatternExamples.Visitor.Acceptors;
using DesignPatternExamples.Visitor.Visitors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternExamples.State;

namespace DesignPatternExamples {
	/// <summary>
	/// The visitor pattern. is used when you have a list of different types and you have to execute 
    /// a method.  you dont want to have the method inside each type. or a switch for each type.
	/// </summary>
	[TestClass]
	public class StatePattern {
		/// <summary>
		/// The test visitor.
		/// </summary>
		[TestMethod]
		public void TestStatePattern() {
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            Assert.IsInstanceOfType(account.State, typeof(SilverState));
            account.Deposit(300.0);
            Assert.IsInstanceOfType(account.State, typeof(SilverState));
            account.Deposit(550.0);
            Assert.IsInstanceOfType(account.State, typeof(GoldState));
            account.PayInterest();
            Assert.IsInstanceOfType(account.State, typeof(GoldState));
            account.Withdraw(2000.00);
            Assert.IsInstanceOfType(account.State, typeof(RedState));
            account.Withdraw(1100.00);
            Assert.IsInstanceOfType(account.State, typeof(RedState));
        }
    }
}
