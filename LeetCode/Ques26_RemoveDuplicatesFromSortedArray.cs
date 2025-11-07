namespace LeetCode
{
    public static class Ques26_RemoveDuplicatesFromSortedArray
    {
        static int[] nums = [1, 1, 2, 2, 3];
        static int[] expectedNums = [1, 2, 3];

        static Ques26_RemoveDuplicatesFromSortedArray()
        {
            int k = RemoveDuplicates(nums);

            if (k == expectedNums.Length)
            {
                Console.WriteLine("Length is correct");
            }

            for (int i = 0; i < k; i++)
            {
                if (nums[i] == expectedNums[i])
                {
                    Console.WriteLine($"Element at index {i} is correct: {nums[i]}");
                }
                else
                {
                    Console.WriteLine($"Element at index {i} is incorrect: {nums[i]}, expected: {expectedNums[i]}");
                }
            }

        }

        static int RemoveDuplicates(int[] nums)
        {
            int count = 1;
            int previous = nums[0];

            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] != nums[j + 1] && nums[j + 1] != previous)
                {
                    nums[count] = nums[j + 1];
                    previous = nums[j + 1];
                    count++;
                }
            }

            return count;
        }
    }
}


