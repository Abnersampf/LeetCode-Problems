public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
            for (int j = i; j < nums.Length; j++)
                if (j != i)
                    if (nums[i] + nums[j] == target)
                        return new int[2] { i, j };
        return null;
    }
}
