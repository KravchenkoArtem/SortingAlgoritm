using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


/// <summary>
/// Insertion sort(сортировка вставками) – алгоритм сортирует массив по мере прохождения по 
/// его элементам.На каждой итерации берется элемент и сравнивается с каждым элементом в 
/// уже отсортированной части массива, таким образом находя «свое место», после чего элемент 
/// вставляется на свою позицию.Так происходит до тех пор, пока алгоритм не пройдет по всему
/// массиву.На выходе получим отсортированный массив.
/// </summary>

// Сложность алгоритма O(n^2) 
public class InsertionSort : MonoBehaviour
{
	void Start ()
    {
        Sorting();
    }

    private void Sorting()
    {
        int[] arr = new int[5] { 83, 12, 3, 34, 60 };
        int i;
        print("Не сортированный массив: ");
        for ( i = 0; i < arr.Length; i++)
        {
            print(arr[i]);
        }
        insertsort(arr, 5);
        print("Cортированный массив: ");
        for (i = 0; i < arr.Length; i++)
        {
            print(arr[i]);
        }
    }

    private static void insertsort(int[] data, int n)
    {
        int i, j;
        for (i = 1; i < n; i++)
        {
            int item = data[i];
            int ins = 0;
            for (j = i - 1; j >= 0 && ins != 1;)
            {
                if (item < data[j])
                {
                    data[j + 1] = data[j];
                    j--;
                    data[j + 1] = item;
                }
                else ins = 1;
            }
        }
    }
}
