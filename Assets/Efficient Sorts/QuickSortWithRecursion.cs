using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// С рекурсией т.е метод вызывает самого себя.
public class QuickSortWithRecursion : MonoBehaviour
{
    private void Start()
    {
        Sorting();
    }

    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSort_Recursive(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort_Recursive(arr, pivot + 1, right);
            }
        }
    }

    private void Sorting()
    {
        int[] numbers = { 3, 8, 7, 5, 2, -1, 9, 6, 4 };
        int len = 9;
        print("Быстрая сортировка с использованием рекурсивного метода");
        QuickSort_Recursive(numbers, 0, len - 1);
        for (int i = 0; i < 9; i++)
        {
            print(numbers[i]);
        }
    }
}
