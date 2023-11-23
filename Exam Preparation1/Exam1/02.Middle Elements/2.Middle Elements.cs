List<double> nums = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

double firstNumber = nums[nums.Count / 2];
double secondNumber = nums[(nums.Count / 2)-1] ;

Console.WriteLine($"{(firstNumber + secondNumber) / 2:F2}");