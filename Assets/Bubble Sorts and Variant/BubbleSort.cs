using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Bubble sort (сортировка пузырьком) – данный алгоритм меняет местами два соседних 
/// элемента, если первый элемент массива больше второго. Так происходит до тех пор, 
/// пока алгоритм не обменяет местами все неотсортированные элементы. Сложность 
/// данного алгоритма сортировки равна O(n^2).
/// Алгоритм считается учебным и практически не применяется вне учебной литературы (помойка)
/// </summary>
public class BubbleSort : MonoBehaviour
{
    void Start()
    {
        Sorting();
    }

    private static void Sorting()
    {
        int[] a = { 30, 20, 50, 40, 10 };
        int t;
        print("The Array is : ");
        for (int i = 0; i < a.Length; i++)
        {
            print(a[i]);
        }
        for (int j = 0; j <= a.Length - 2; j++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            }
        }
        print("The Sorted Array :");
        foreach (int aray in a)
            print(aray + " ");
    }
}


