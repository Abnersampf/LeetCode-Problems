class Program
{
    static void Main(string[] args)
    {
        // LEETCODE PROBLEM 2529. Maximum Count of Positive Integer and Negative Integer:

        // Given an array nums sorted in non-decreasing order, return the maximum between the number of positive integers and the...
        // ...number of negative integers.

        // In other words, if the number of positive integers in nums is pos and the number of negative integers is neg, then return...
        // ...the maximum of pos and neg.

        // Note that 0 is neither positive nor negative.


        // Constraints:
        // 1 <= nums.length <= 2000
        // -2000 <= nums[i] <= 2000
        // nums is sorted in a non-decreasing order.


        // Example:
        // Input: nums = [-3,-2,-1,0,0,1,2]
        // Output: 3
        // Explanation: There are 2 positive integers and 3 negative integers. The maximum count among them is 3.

        int[] nums = CreateArray(100); // Instead of asking the user to type in the array number by number, I created a function...
                                       // ...that generates these numbers automatically

        int maxCount = MaximumCount(nums);

        Console.WriteLine("MaximumCount(): " + maxCount);
    }
    // Returns a sorted array in ascending order with the specified parameters.
    static int[] CreateArray(params int[] arguments)
    {
        // argument 1: Array length;
        // argument 2: Min value of each element. Or max value if argument 3 is not specified;
        // argument 3: Max value of each element;

        // NOTE: if the value 0 is entered as argument 1, the size of the array will be random, this size can vary from 1 to 2147483647...
        // ...If argument 2 and 3 are not specified, the value of each element can be from 0 to 2147483647.
        Random rnd = new Random();

        int[] nums;
        if (arguments[0] == 0)
            nums = new int[rnd.Next()];
        else
            nums = new int[arguments[0]];

        for (int i = 0; i < nums.Length; i++)
        {
            if (arguments.Length == 3)
                nums[i] = rnd.Next(arguments[1], arguments[2]);
            else if (arguments.Length == 2)
                nums[i] = rnd.Next(arguments[1]);
            else
                nums[i] = rnd.Next();
            if (i > 0)
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int n = nums[j];
                        nums[j] = nums[i];
                        nums[i] = n;
                    }
                }
        }
        return nums;
    }
    // Return the maximum betwen the number of positive integers and the number of negative integers.
    // NOTE: Returns 0 if both are equal.
    static int MaximumCount(int[] nums)
    {
        int pos = 0, neg = 0;
        foreach (int n in nums)
        {
            if (n != 0)
            {
                if (n < 0)
                    neg++;
                else
                    pos++;
            }
        }
        if (pos == neg)
            return 0;
        else
            return Math.Max(pos, neg);
    }
    // Do the same thing as MaximumCount(), but it takes up fewer lines and is slower.
    // NOTE: Returns only one of the 2 values if the 2 are equal.
    static int MaximumCount2(int[] nums)
    {
        return Math.Max(nums.Count(x => x > 0), nums.Count(x => x < 0));
    }
}
