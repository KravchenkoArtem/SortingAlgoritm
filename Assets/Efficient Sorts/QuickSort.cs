using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Quick sort (быстрая сортировка) – суть алгоритма заключается в разделении массива на два 
/// под-массива, средней линией считается элемент, который находится в самом центре массива. 
/// В ходе работы алгоритма элементы, меньшие чем средний будут перемещены в лево, а большие 
/// в право. Такое же действие будет происходить рекурсивно и с под-массива, они будут 
/// разделяться на еще два под-массива до тех пор, пока не будет чего разделать 
/// (останется один элемент). На выходе получим отсортированный массив. Сложность алгоритма 
/// зависит от входных данных и в лучшем случае будет равняться O(n×2log2n). 
/// В худшем случае O(n^2). Существует также среднее значение, это O(n×log2n).
/// </summary>
public class QuickSort : MonoBehaviour
{
    private int[] array = new int[20];
    private int len;

    void Start()
    {
        Sorting();
    }

    public void sort(int left, int right)
    {
        int pivot, leftend, rightend;

        leftend = left;
        rightend = right;
        pivot = array[left];

        while (left < right)
        {
            while ((array[right] >= pivot) && (left < right))
            {
                right--;
            }
            if (left != right)
            {
                array[left] = array[right];
                left++;
            }

            while ((array[left] >= pivot) && (left < right))
            {
                left++;
            }

            if (left != right)
            {
                array[right] = array[left];
                right--;
            }
        }

        array[left] = pivot;
        pivot = left;
        left = leftend;
        right = rightend;

        if (left < pivot)
        {
            sort(left, pivot - 1);
        }
        if (right > pivot)
        {
            sort(pivot + 1, right);
        }

    }

    private void Sorting()
    {
        int[] array = { 41, 32, 15, 45, 63, 72, 57, 43, 32, 52, 183 };
        len = array.Length;
        sort(0, len - 1);
        for (int j = 0; j < len; j++)
        {
            //print(array[j]);
        }
    }
}
