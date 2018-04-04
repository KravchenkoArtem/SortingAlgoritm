using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Сортировка слиянием (англ. merge sort) — алгоритм сортировки, который упорядочивает списки 
/// (или другие структуры данных, доступ к элементам которых можно получать только 
/// последовательно, например — потоки) в определённом порядке. Эта сортировка — хороший пример
/// использования принципа «разделяй и властвуй». Сначала задача разбивается на несколько 
/// подзадач меньшего размера. Затем эти задачи решаются с помощью рекурсивного вызова или 
/// непосредственно, если их размер достаточно мал. Наконец, их решения комбинируются, и 
/// получается решение исходной задачи.
/// </summary>
public class MergeSort : MonoBehaviour
{
	void Start ()
    {
        Sorting();
    }

    static public void DoMerge (int [] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, temp_pos;

        left_end = (mid - 1);
        temp_pos = left;
        num_elements = (right - left + 1);

        while((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
            {
                temp[temp_pos++] = numbers[left++];
            }
            else
            {
                temp[temp_pos++] = numbers[mid++];
            }
        }
        while (left <= left_end)
            temp[temp_pos++] = numbers[left++];
        while (mid <= right)
            temp[temp_pos++] = numbers[mid++];

        for(i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void MergeSort_Recursive(int[] numbers, int left, int right)
    {
        int mid;
        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSort_Recursive(numbers, left, mid);
            MergeSort_Recursive(numbers, (mid + 1), right);

            DoMerge(numbers, left, (mid + 1), right);
        }
    }

    private void Sorting()
    {
        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
        int len = 9;
        print("Сортировка слиянием с использованием рекурсии");
        MergeSort_Recursive(numbers, 0, len - 1);
        for (int i = 0; i < 9; i++)
        {
            print(numbers[i]);
        }
    }
}
