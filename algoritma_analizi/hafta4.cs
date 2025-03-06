internal class Program
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

          
            if (arr[middle] == target)
            {
                return middle;
            }

           
            if (arr[middle] > target)
            {
                right = middle - 1;
            }
         
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
    public static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int hedef = 7;

        int result = BinarySearch(numbers, hedef);

        console.WriteLine(result);
    }
}
