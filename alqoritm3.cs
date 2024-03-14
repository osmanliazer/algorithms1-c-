int[] arr = { 3, 5, 9, 12, 44, 7, 2 };
int min = arr[0];
int max = arr[0];
int sum = 0;

for (int i = 0; i <arr.Length; i++)
{
    if (arr[i] < min) 
    min= arr[i];

    if (arr[i] > max) 
    max = arr[i];

    sum += arr[i];
    {
        Console.WriteLine("ədədlərin cəmi" + sum);
    }
}