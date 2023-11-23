// Read a line of space-separated numbers from the console input and store them as strings in the inputNumbers array.
string[] inputNumbers = Console.ReadLine().Split(' ');

// Create an integer array called numbers with the same length as inputNumbers.
int[] numbers = new int[inputNumbers.Length];

// Convert each string element from inputNumbers to an integer and store it in the numbers array.
for (int i = 0; i < inputNumbers.Length; i++)
{
    numbers[i] = int.Parse(inputNumbers[i]);
}

// Read the number of rotations from the console input.
int rotations = int.Parse(Console.ReadLine());

// Perform right rotations on the numbers array based on the input number of rotations.
for (int i = 0; i < rotations; i++)
{
    // Store the last element of the array in lastElement.
    int lastElement = numbers[numbers.Length - 1];

    // Shift all elements one position to the right in the numbers array.
    for (int j = numbers.Length - 1; j > 0; j--)
    {
        numbers[j] = numbers[j - 1];
    }

    // Wrap the last element (stored in lastElement) to the beginning of the array.
    numbers[0] = lastElement;
}

// Print the rotated numbers array, separating the elements with commas.
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]);

    // Add a comma and space if the current element is not the last element in the array.
    if (i < numbers.Length - 1)
    {
        Console.Write(", ");
    }
}
