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
            int position = 0;
            while ((position + subString.Length) <= text.Length)
	        {
	            if (text.Substring(position, subString.Length).Equals(subString))
                {
                    count++;
                }

                position++;
	        }

            return count;
        }
    }
}
