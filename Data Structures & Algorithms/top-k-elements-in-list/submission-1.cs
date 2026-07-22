public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        List<int>[] buckets = new List<int>[nums.Length + 1];
        List<int> res = new List<int>();
        
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }
            
        foreach (int num in nums)
        {
            counts[num] = counts.GetValueOrDefault(num, 0) + 1;
        }
        
        foreach (var pair in counts)
        {
            buckets[pair.Value].Add(pair.Key);
        }

        for (int count = buckets.Length - 1; count >= 1; count--)
        {
            foreach (int num in buckets[count])
            {
                res.Add(num);

                if (res.Count == k)
                {
                    return res.ToArray();
                }
            }
        }
        
        return res.ToArray();
    }
}