using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// Selection sort (сортировка выбором) – суть алгоритма заключается в проходе по массиву 
/// от начала до конца в поиске минимального элемента массива и перемещении его в начало.
/// </summary>

// Сложность алгоритма O(n2) 
public class SelectionSort : MonoBehaviour
{
    private void Start()
    {
        Sorting();
    }

    private void Sorting()
    {
        int array_size = 10;
        int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
        print("Массив до сортировки выбором: ");
        for (int i = 0; i < array_size; i++)
        {
            print(array[i]);
        }
        int tmp, min_key;

        for (int j = 0; j < array_size - 1; j++)
        {
            min_key = j;
            for (int k = j + 1; k < array_size; k++)
            {
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }

            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }
        print("Массив после сортировки выбором: ");
        for (int i = 0; i < 10; i++)
        {
            print(array[i]);
        }
    }
}
