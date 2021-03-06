﻿using System.Linq;

namespace DuplicateCountingHelper
{
	public class DuplicateCounter
	{
		public static int DuplicateCount(string str)
		{
			str = str.ToLower();
			var duplicateSymbolCounter = 0;

			foreach (var symbolChar in str.ToCharArray())
			{
				var sameCharCount = str.Count(f => f == symbolChar);
				if (sameCharCount <= 1) continue;
				duplicateSymbolCounter++;
				str = str.Replace(symbolChar.ToString(), "");
			}

			return duplicateSymbolCounter;
		}
	}
}

//after finish the Kata, the answer:  public static int DuplicateCount(string str) => str.ToLower().GroupBy(v => v).Count(v => v.Count() >= 2);