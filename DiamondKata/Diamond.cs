namespace DiamondKata
{
    public class Diamond
    {
        public static string Create(char letter)
        {
            if (letter < 'A' || letter > 'Z')
            {
                throw new ArgumentException("Input must be a capital letter A-Z");
            }

            int n = letter - 'A' + 1;
            string[] lines = new string[n * 2 - 1];

            // Top Half part of the diamond
            for (int i = 0; i < n; i++)
            {
                char currentLetter = (char)('A' + i);
                var boarderSpaces = new string(' ', n - i - 1);
                string line = i == 0 ? (boarderSpaces + currentLetter + boarderSpaces) : (boarderSpaces + currentLetter);

                if (i > 0)
                {
                    var middleSpaces = new string(' ', 2 * i - 1);
                    line += middleSpaces + currentLetter + boarderSpaces;
                }

                lines[i] = line;
            }

            // Bottom half part of the diamond 
            for (int i = n - 2; i >= 0; i--)
            {
                lines[2 * n - 2 - i] = lines[i];
            }

            return string.Join("\n", lines) + "\n";
        }
    }
}
