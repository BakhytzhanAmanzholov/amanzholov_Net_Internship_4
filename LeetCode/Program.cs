namespace LeetCode
{
    public class Solution
    {
        // Runtime 51 ms, Beats 66.54%, Memory 30 MB
        // https://leetcode.com/problems/palindrome-number/description/
        public bool IsPalindrome(int x)
        {
            var str = x.ToString();
            var left = 0;
            var right = str.Length - 1;

            while (left < right)
            {
                if (!str[left].Equals(str[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        // https://leetcode.com/problems/valid-parentheses/description/
        // Runtime 80 ms, Beats 49.87%, Memory 37.9 MB
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || !IsMatchingBracket(stack.Peek(), c))
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        // Method to IsValid
        private bool IsMatchingBracket(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }

        
        // https://leetcode.com/problems/remove-element/description/
        // Runtime 142 ms, Beats 54.9%, Memory 43 MB
        public int RemoveElement(int[] nums, int val)
        {
            int count =  0;
            int k = 0;

            for(int i = 0; i < nums.Length - count; i++)
            {
                if(nums[i] == val)
                {
                    k = Array.FindLastIndex(nums, x => x != val);
                    count++;

                    if (k == -1 || k < i)
                    {
                        break;
                    }

                    if (k != nums.Length - count)
                    {
                        count = nums.Length - 1 - k;
                    }

                    nums[i] = nums[k];
                    nums[k] = val;
                }
            }

            if (nums.Length != 0 && nums[0] == val)
            {
                return 0;
            }
            return nums.Length - nums.Count(x => x == val);
        }
    };
}