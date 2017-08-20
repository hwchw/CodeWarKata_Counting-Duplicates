using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuplicateCountingHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DuplicateCountingHelper.Tests
{
	[TestClass()]
	public class DuplicateCounterTests
	{
		[TestMethod()]
		public void DuplicateCountTest()
		{
			Assert.AreEqual(0, DuplicateCounter.DuplicateCount(""));
			Assert.AreEqual(0, DuplicateCounter.DuplicateCount("abcde"));
			Assert.AreEqual(2, DuplicateCounter.DuplicateCount("aabbcde"));
			Assert.AreEqual(2, DuplicateCounter.DuplicateCount("aabBcde"), "should ignore case");
			Assert.AreEqual(1, DuplicateCounter.DuplicateCount("Indivisibility"));
			Assert.AreEqual(2, DuplicateCounter.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
		}
	}
}
