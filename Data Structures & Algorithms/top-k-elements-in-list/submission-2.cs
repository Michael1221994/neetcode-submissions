public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         //1. Build frequency map: value -> frequency
        var freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            freq[num] = freq.TryGetValue(num, out int count)
                ? count + 1
                : 1;
        }

        // 2. Return the k most frequent elements
        return freq
            .OrderByDescending(pair => pair.Value) // highest frequency first
            .ThenBy(pair => pair.Key)              // optional: deterministic tie-break
            .Take(k)
            .Select(pair => pair.Key)
            .OrderBy(x => x)                       // optional: final result ascending
            .ToArray();
    
    }
}
