public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int need = target - nums[i];

        if (seen.TryGetValue(need, out int index))
        {
            return new[] { index, i };
        }

        seen[nums[i]] = i;
    }

    return new int[0]; 
        // int[] solution = new int[2];
        // for (int i=0; i<nums.Length; i++){
        //     for (int j=i+1; j<nums.Length; j++){
        //         if(nums[i] + nums[j]== target){
        //             solution[0]=i;
        //             solution[1]=j;
        //         }
        //     }
        // }
        // return solution;
    }
}
