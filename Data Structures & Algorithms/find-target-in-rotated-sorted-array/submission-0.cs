public class Solution {
    public int Search(int[] nums, int target) {
     int low=0;
     int high= nums.Length - 1;
     int found=-1;
     while(low <= high){
        int mid= low + (high -low)/2;
        if(nums[mid] == target){
            found = mid;
            break;
            }
        if(nums[mid] <= nums[high]){
            if(nums[mid] < target && target <= nums[high]){
                low=mid+1;
            }
            else{
                high= mid-1;
            }
        }
        else if(nums[mid] >= nums[high] ){
            if(nums[mid] > target && target >= nums[low]){
                high= mid-1;
            }
            else{
               low = mid + 1; 
            }
        }
     }   
      return found;
    }
}
