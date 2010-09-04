namespace TddPatternMatching
{
    public class PatternMatcher
    {
        string text;

        public PatternMatcher(string text)
        {
            this.text = text;
        }

        public int GetCount(string subString)
        {
            int count = 0;
            foreach (var character in text)
            {
                if (character.ToString().Equals(subString))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
