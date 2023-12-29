static int MaximumCount(int[] nums)
{
    int pos = 0, neg = 0;
    foreach (int n in nums)
        if (n != 0)
        {
            if (n < 0)
                neg++;
            else
                pos++;
        }
    return Math.Max(pos, neg);
}
