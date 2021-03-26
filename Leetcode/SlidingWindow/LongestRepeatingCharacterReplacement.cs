using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestRepeatingCharacterReplacement
	{
        public static int CharacterReplacement(string s, int k)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            int size = s.Length;
            int left = 0;
            int right = 0;
            int maxInWindow = 0;
            char maxChar = s[0];
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            int longestSubstring = 0;

            while (right < size)
            {
                if (charMap.ContainsKey(s[right]))
                {
                    charMap[s[right]]++;
                }
                else
                {
                    charMap.Add(s[right], 1);
                }

                if (maxInWindow < charMap[s[right]])
                {
                    maxChar = s[right];
                    maxInWindow = charMap[s[right]];
                }
                if (right - left + 1 - maxInWindow > k)
                {
                    while (right - left + 1 - maxInWindow > k)
                    {
                        if (charMap.ContainsKey(s[left]))
                        {
                            charMap[s[left]]--;
                            if (charMap[s[left]] == 0)
                            {
                                charMap.Remove(s[left]);
                            }
                        }

                        if (s[left] == maxChar)
                        {
                            maxInWindow--;
                            KeyValuePair<char, int> kv = charMap.OrderByDescending(x => x.Value).FirstOrDefault();
                            if(maxInWindow < kv.Value)
							{
                                maxInWindow = kv.Value;
                                maxChar = kv.Key;
							}
                        }
                        left++;
                    }
                }
                longestSubstring = Math.Max(longestSubstring, right - left + 1);
                right++;
            }
            return longestSubstring;
        }
    }
}
