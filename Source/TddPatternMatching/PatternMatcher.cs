using System;
using System.Collections.Generic;

namespace TddPatternMatching
{
    public class PatternMatcher
    {
        string text;

        public PatternMatcher(string text)
        {
            if (text == null) throw new ArgumentNullException("text");

            this.text = text;
        }

        public int GetCount(string subString)
        {
            if (subString == null) throw new ArgumentNullException("subString");

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

        public ICollection<int> GetIndexes(string subString)
        {
            if (subString == null) throw new ArgumentNullException("subString");
            throw new NotImplementedException();
        }
    }
}
