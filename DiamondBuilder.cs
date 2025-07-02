namespace DiamonKata
{
	public static class DiamondBuilder
	{
		public static string Build(char letter)
		{
			if (letter < 'A' || letter > 'Z')
			{
				throw new ArgumentException("Input must be an uppercase letter from A to Z.", nameof(letter));
			}

			int letterIndex = letter - 'A';
			int diamondWidth = 2 * letterIndex + 1;

			var topHalf = new List<string>();
			for (int i = 0; i <= letterIndex; i++)
			{
				topHalf.Add(GenerateRow((char)('A' + i), diamondWidth));
			}

			var bottomHalf = new List<string>(topHalf);
			bottomHalf.Reverse();

			var allRows = new List<string>(topHalf);
			allRows.AddRange(bottomHalf.GetRange(1, bottomHalf.Count - 1));

			return string.Join("\n", allRows);
		}

		private static string GenerateRow(char currentChar, int diamondWidth)
		{
			if (currentChar == 'A')
			{
				return CenterText("A", diamondWidth);
			}

			int charIndex = currentChar - 'A';
			int innerSpaces = 2 * charIndex - 1;
			string rowContent = $"{currentChar}{new string(' ', innerSpaces)}{currentChar}";

			return CenterText(rowContent, diamondWidth);
		}

		private static string CenterText(string text, int totalWidth)
		{
			int leftPadding = (totalWidth - text.Length) / 2;

			return text
				.PadLeft(text.Length + leftPadding, ' ')
				.PadRight(totalWidth, ' ');
		}
	}
}
