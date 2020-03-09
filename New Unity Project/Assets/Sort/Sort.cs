using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    MyLinkedList list;
    public GameObject[] cards;
    public GameObject[] sortedCards;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < sortedCards.Length; j++)
            {
                //if (cards[i].name >= sortedCards[j].name)
                {

                }
            }
        }
        string printString = "";
        int[] arr = new int[] { 2, 5, -4, 11, 0 };
        Debug.Log("Original array : ");
        foreach (var item in arr)
        {
            printString += " " + item;
        }
        Debug.Log(printString);
        printString = "";

        Quick_Sort(arr, 0, arr.Length - 1);
        Debug.Log("Sorted array : ");
        foreach (var item in arr)
        {
            printString += " " + item;
        }
        Debug.Log(printString);

    }
    //class Program
    private static void Quick_Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            if (pivot > 1)
            {
                Quick_Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quick_Sort(arr, pivot + 1, right);
            }
        }
    }
    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }
            while (arr[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                if (arr[left] == arr[right]) return right;
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
