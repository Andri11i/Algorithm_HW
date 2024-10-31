using Algorithm_HW;

int[] nums = { 3, 7, 1, 2, 8, 4, 5 };
int n = 8;

int missingNumber = MissingNumberFinder.FindMissingNumber(nums, n);
Console.WriteLine("Відсутнє число: " + missingNumber);