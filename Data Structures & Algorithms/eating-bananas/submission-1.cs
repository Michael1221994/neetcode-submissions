public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low= 1;
        int max= ReturnBiggestPile(piles);
        int result= max;
        while(low<=max){
            int mid= low+ (max - low)/2;
            if(NumberOfHours(piles,mid, h)<=h){
                result=mid;
                max= mid -1;
            }
            else{
                low=mid+1;
            }
        }
        return result;
    }

    public int ReturnBiggestPile(int[] piles){
        int x=0;
        for(int i=0; i< piles.Length; i++){
            if(piles[i]> x){
                x=piles[i];
            }
            continue;
        }
        return x;
    }
     
    public int NumberOfHours(int[] piles, int k, int h){
        int hours=0;
        foreach(int pile in piles){
            hours += (pile + k-1)/k;
            if(hours>h)
                return hours;
        }
        return hours;
    }
}
