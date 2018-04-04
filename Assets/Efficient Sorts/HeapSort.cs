using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Heap sort(сортировка кучей) - Построим кучу для минимума на этом массиве. Тогда наименьший элемент окажется на 
/// первой позиции, а левая часть массива окажется почти отсортированной, так как ей будут 
/// соответствовать верхние узлы кучи. Теперь построим на этом же массиве кучу так, чтобы 
/// немного упорядочить правую часть массива. Эта куча должна быть кучей для максимума и быть 
/// "зеркальной" к массиву, то есть чтобы ее корень соответствовал последнему элементу массива. 
/// К получившемуся массиву применим сортировку вставками.
/// </summary>
public class HeapSort : MonoBehaviour
{
    int[] r = { 2, 5, 1, 10, 6, 9, 3, 7, 4, 8 };

    void Start()
    {
        Sorting();
    }

    public void hsort()
    {
        int i, t;
        for (i = 5; i >= 0; i--)
        {
            adjust(i, 9);
        }
        for (i = 8; i >= 0; i--)
        {
            t = r[i + 1];
            r[i + 1] = r[0];
            r[0] = t;
            adjust(0, i);
        }
    }

    private void adjust(int i, int n)
    {
        int t, j;
        try
        {
            t = r[i];
            j = 2 * i;
            while (j <= n)
            {
                if (j < n && r[j] < r[j + 1])
                    j++;
                if (t >= r[j])
                    break;
                r[j / 2] = r[j];
                j *= 2;
            }
            r[j / 2] = t;
        }
        catch (IndexOutOfRangeException e)
        {
            Debug.LogError("Array Out of Bounds " + e);
        }
    }

    public void Display()
    {
        for (int i = 0; i < 10; i++)
        {
            print(string.Format("{0}", r[i]));
        }
    }

    private void Sorting()
    {
        print("Элементы перед сортировкой: ");
        Display();
        hsort();
        print("Элементы после сортировки: ");
        Display();
    }
}
