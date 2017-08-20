using System.Linq;

namespace DuplicateCountingHelper
{
	public class DuplicateCounter
	{
		public static int DuplicateCount(string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return 0;
			}
			var characters = str.ToCharArray();
			var duplicateSymbolCounter = 0;
			foreach (var symbolChar in characters)
			{
				int count = str.Count(f => f == symbolChar);
				if (count > 1)
				{
					duplicateSymbolCounter++;
					str = str.Replace(symbolChar.ToString(), "");
				}
			}	

			return duplicateSymbolCounter;

		}
	}
}