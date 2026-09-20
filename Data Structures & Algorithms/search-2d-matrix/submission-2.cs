public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
		int row_end=matrix.Length-1;
		
		for(int i=0; i<=row_end; i++){
            int start_c=0;
		    int end_c=matrix[0].Length-1;
			while(start_c<=end_c){
				int mid=start_c+(end_c-start_c)/2;
				if(matrix[i][mid]==target){
					return true;
				}
				else if(matrix[i][mid]<target){
					start_c=mid+1;
				}
				else if(matrix[i][mid]>target){
					end_c=mid-1;
				}

			}
		}
		return false;

	}
}
