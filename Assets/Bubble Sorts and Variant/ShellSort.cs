using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Сортировка Шелла (англ. Shell sort) — алгоритм сортировки, являющийся 
/// усовершенствованным вариантом сортировки вставками. Идея метода 
/// Шелла состоит в сравнении элементов, стоящих не только рядом, но и на 
/// определённом расстоянии друг от друга. Иными словами — это сортировка 
/// вставками с предварительными «грубыми» проходами. Аналогичный метод 
/// усовершенствования пузырьковой сортировки называется сортировка расчёской.
/// </summary>
public class ShellSort : MonoBehaviour
{
    void Start ()
    {
        SortingArrayWithShellSort();
        
    }
	
    private void SortingArrayWithShellSort()
    {
        int[] array = { 297, 183, 464, 321, 562, 124, 643, 867, 241, 534, 744, 126, 722 };
        ShellSorting(array);
        for (int i = 0; i < array.Length; i++)
        {
            print(array[i]);
        }
    }

    private void ShellSorting(int[] array)
    {
        int n = array.Length;
        int gap = n / 2;
        int temp;

        while (gap > 0)
        {
            for (int i = 0; i + gap < n; i++)
            {
                int j = i + gap;
                temp = array[j];

                while(j - gap >= 0 && temp < array[j - gap])
                {
                    array[j] = array[j - gap];
                    j = j - gap;
                }
                array[j] = temp;
            }
            gap = gap / 2;
        }
    }
}
