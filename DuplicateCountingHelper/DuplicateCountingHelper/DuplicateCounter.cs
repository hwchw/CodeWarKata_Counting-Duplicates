using System.Linq;

namespace DuplicateCountingHelper
{
	public class DuplicateCounter
	{
		public static int DuplicateCount(string str)
		{
			var characters = str.ToCharArray();
			var duplicateSymbolCount =
				characters.Select(symbolChar =>characters
					.Count(targetChar => symbolChar == targetChar))
					.Count(count => count > 1);
			return duplicateSymbolCount;
		}
	}
}