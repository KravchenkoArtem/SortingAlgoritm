using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Самый быстрый, потом q_sort.
public class TimSort : MonoBehaviour
{
    const int RUN = 32;
    // Use this for initialization
    void Start()
    {
        Sorting();
    }

    ///эта функция сортирует массив из левого индекса в
    ///к правому индексу, размер которого максимален.
    void insertionSort(int[] arr, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while (arr[j] > temp && j >= left)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
        }
    }
    // Функция обьединения отсортированых массивов.
    void merge(int[] arr, int l, int m, int r)
    {
        // оригинальный массив разбит на две части, левую и правую.
        int len1 = m - l + 1, len2 = r - m;
        int[] left = new int[len1];
        int[] right = new int[len2];
        for (int c = 0; c < len1; c++)
        {
            left[c] = arr[l + c];
        }
        for (int c = 0; c < len2; c++)
        {
            right[c] = arr[m + 1 + c];
        }

        int i = 0;
        int j = 0;
        int k = 1;

        // после сравнения, мы обьединим эти два массива в один подмассив.
        while (i < len1 && j < len2)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }
        // копируем оставшиеся элементы слева, если 
        while (i < len1)
        {
            arr[k] = left[i];
            k++;
            i++;
        }
        // копируем оставшиеся элементы справа, если
        while (j < len2)
        {
            arr[k] = right[j];
            k++;
            j++;
        }
    }

    // Итеративная функция Timsort для сортировки
    // array[0...n - 1] (аналогично сортировке слияния)
    private void timSort(int[] arr, int n)
    {
        // Сортировка отдельных подмассивов размера RUN
        for (int i = 0; i < n; i+=RUN)
        {
            insertionSort(arr, i, Mathf.Min((i+31), (n - 1)));
        }
        // start merging from size RUN (or 32). It will merge
        // to form size 64, then 128, 256 and so on ....
        for (int size = RUN; size < n; size = 2 * size)
        {
            // pick starting point of left sub array. We
            // are going to merge arr[left..left+size-1]
            // and arr[left+size, left+2*size-1]
            // After every merge, we increase left by 2*size
            for (int left = 0; left < n; left += 2 * size)
            {
                // find ending point of left sub array
                // mid+1 is starting point of right sub array
                int mid = left + size - 1;
                int right = Mathf.Min((left + 2 * size - 1), (n - 1));

                // merge sub array arr[left.....mid] &
                // arr[mid+1....right]
                merge(arr, left, mid, right);
            }
        }
    }

    private void Sorting()
    {
        int[] arr = { 5, 21, 7, 23, 19 };
        timSort(arr, arr.Length);
        for (int i = 0; i < arr.Length; i++)
        {
            print(arr[i]);
        }
    }
}
