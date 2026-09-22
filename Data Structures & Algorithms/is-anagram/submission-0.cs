public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] firstword= s.ToCharArray();
        char[] secondword=t.ToCharArray();

        if(firstword.Length != secondword.Length){
            return false;
        }
        var freqs = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (freqs.ContainsKey(c))
                freqs[c]++;
            else
                freqs[c] = 1;
        }

        var freqt = new Dictionary<char, int>();

        foreach (char c in t)
        {
            if (freqt.ContainsKey(c))
                freqt[c]++;
            else
                freqt[c] = 1;
        }
         if (freqs.Count != freqt.Count) return false;

        foreach (var kvp in freqs)
        {
            if (!freqt.TryGetValue(kvp.Key, out int count) || count != kvp.Value)
                return false;
        }
        return true;

        // for(int i=0; i<firstword.Length; i++){
        //     for (int j=secondword.Length - 1; j>=0; j--){
        //         if(firstword[i] != secondword[j]){
        //             return false;
        //         }
        //         else 
        //             break;
        //     }
        // }
        // return true;
    }
}
