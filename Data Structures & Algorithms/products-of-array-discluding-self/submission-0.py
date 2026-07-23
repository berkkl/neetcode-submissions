class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        left = [[] for i in range(len(nums))]
        right = [[] for i in range(len(nums))]
        result = [[] for i in range(len(nums))]

        l_carry = 1
        for i in range(len(nums)):
            left[i] = l_carry
            l_carry = (nums[i]) * l_carry
        
        r_carry = 1
        for j in range(len(nums) - 1, -1, -1):
            right[j] = r_carry
            r_carry = nums[j] * r_carry

        for k in range(len(nums)):
            result[k] = left[k] * right[k]

        return result;