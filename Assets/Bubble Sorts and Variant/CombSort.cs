using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Comb sort (сортировка расческой) – идея работы алгоритма крайне похожа на 
/// сортировку обменом, но главным отличием является то, что сравниваются не 
/// два соседних элемента, а элементы на промежутке, к примеру, в пять элементов. 
/// Это обеспечивает от избавления мелких значений в конце, что способствует 
/// ускорению сортировки в крупных массивах. Первая итерация совершается с шагом, 
/// рассчитанным по формуле (размер массива)/(фактор уменьшения), где фактор 
/// уменьшения равен приблизительно 1,247330950103979, или округлено до 1,3. 
/// Вторая и последующие итерации будут проходить с шагом (текущий шаг)/(фактор уменьшения) 
/// и будут происходить до тех пор, пока шаг не будет равен единице. Практически в любом случае 
/// сложность алгоритма равняется O(n×log2n).
/// </summary>

public class CombSort : MonoBehaviour {

    int[] data = new int[] { -10, 250, -58, 85, -119, 0, 785 };

	void Start ()
    {
        Sorting();
    }

    private void Sorting()
    {
        CombSorting(ref data);
        for (int i = 0; i < data.Length; i++)
        {
            print(data[i]);
        }
    }
	
    public static void CombSorting(ref int[] data)
    {
        double gap = data.Length;
        bool swaps = true;

        while(gap > 1 || swaps)
        {
            gap /= 1.247330950103979;
            if (gap < 1)
                gap = 1;

            int i = 0;
            swaps = false;

            while(i + gap < data.Length)
            {
                int igap = i + (int)gap;
                if (data[i] > data[igap])
                {
                    int temp = data[i];
                    data[i] = data[igap];
                    data[igap] = temp;
                    swaps = true;
                }
                ++i;
            }
        }
    }
}
