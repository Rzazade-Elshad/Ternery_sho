using System;

namespace Ternary_Search
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int num = int.Parse(Console.ReadLine());

            int index = Ternary(arr, 0, arr.Length - 1, num);

            if (index != -1)
                Console.WriteLine($"Elementin indeksi: {index}");
            else
                Console.WriteLine("Element tapılmadı.");
        }
        static int Ternary(int[] arr, int left, int right, int num)
        {
            while (left <= right)
            {
                int mid1 =( left + right ) / 3;
                int mid2 =(right - ( right - left)/3);

                if (arr[mid1] == num)
                    return mid1; 
                if (arr[mid2] == num)
                    return mid2; 
                if (num < arr[mid1])
                    right = mid1 - 1;
                else if (num > arr[mid2])
                    left = mid2 + 1; 
                else
                {
                    left = mid1 + 1;
                    right = mid2 - 1; 
                }
            }
            return -1; 
        }
    }
}
