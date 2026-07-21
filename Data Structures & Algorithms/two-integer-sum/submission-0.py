class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        gt = {}
        for i in range(len(nums)):
            if nums[i] in gt:
                return [gt[nums[i]], i]
            else:
                gt[target - nums[i]] = i