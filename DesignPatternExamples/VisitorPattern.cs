using System.Collections.Generic;
using DesignPatternExamples.Visitor.Acceptors;
using DesignPatternExamples.Visitor.Visitors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternExamples {
	/// <summary>
	/// The visitor pattern. is used when you have a list of different types and you have to execute 
    /// a method.  you dont want to have the method inside each type. or a switch for each type.
	/// </summary>
	[TestClass]
	public class VisitorPattern {
		/// <summary>
		/// The test visitor.
		/// </summary>
		[TestMethod]
		public void TestVisitor() {
			const int expected = 600;
            // you have a list that have different types like jar, bottle and blisterpack, because the way
            // that pills are counted is different for each type, the visit method of the visitor will
            // do the actual counting.  think of the visit method of the visitor as the execute method
            // of the strategy pattern
			var packageList = new List<object> {
				new Jar { Pieces = 275 },
				new Jar { Pieces = 25 },
				new Bottle { Items = 100 },
				new BlisterPack { TabletPairs = 25 },
				new Jar { Pieces = 150 },
			};

			var visitor = new PillCountVisitor();

			foreach (IAcceptor item in packageList) {
				item.Accept(visitor);
			}

			Assert.AreEqual(expected, visitor.Count);
		}
	}
}
