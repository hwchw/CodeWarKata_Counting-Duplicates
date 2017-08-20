using System.Linq;

namespace DuplicateCountingHelper
{
	public class DuplicateCounter
	{
		public static int DuplicateCount(string str)
		{
			str = str.ToLower();
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