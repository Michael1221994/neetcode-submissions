public class Solution {
    public bool IsPalindrome(string s) {
        
        int left = 0;
                int right = s.Length - 1;

                        while (left < right)
                                {
                                            // Skip special characters from the left
                                                        while (left < right && !char.IsLetterOrDigit(s[left]))
                                                                        left++;

                                                                                    // Skip special characters from the right
                                                                                                while (left < right && !char.IsLetterOrDigit(s[right]))
                                                                                                                right--;

                                                                                                                            // Compare ignoring case
                                                                                                                                        if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                                                                                                                                                        return false;

                                                                                                                                                                    left++;
                                                                                                                                                                                right--;
                                                                                                                                                                                        }

                                                                                                                                                                                                return true;
    }
}

