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
				var count = 0;
				foreach (var targetChar in characters)
				{
					if (symbolChar == targetChar)
					{
						count++;
					}
				}
				if (count > 1)
				{
					duplicateSymbolCounter++;
				}
			}

			return duplicateSymbolCounter;

		}
	}
}