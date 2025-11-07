// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using LeetCode;

Console.WriteLine("Please enter the question no to execute: -");
Console.WriteLine("1. Two Sum");
Console.WriteLine("26. Remove Duplicates From Sorted Array");
int quesNo = int.Parse(Console.ReadLine());

switch (quesNo)
{
    case 1:
        int[] nums = [2, 11, 7, 15];
        var response = TwoSum(nums, 9);
        Console.WriteLine($"{response[0]}, {response[1]}");
        break;
    case 26:
        RuntimeHelpers.RunClassConstructor(typeof(Ques26_RemoveDuplicatesFromSortedArray).TypeHandle);
        break;
    default:
        Console.WriteLine("Invalid question number.");
        break;
}

int[] TwoSum(int[] nums, int target)
{
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        for (int j = i + 1; j < length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return [i, j];
            }
        }

    }
    return [];
}
