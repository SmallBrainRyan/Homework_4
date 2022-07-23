using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    //Call your function using an int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
    //Your return values should be a List<int> that holds {1,3,5,7,9}
    void Start()
    {
        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach(int i in OnlyOddOnes(array))
        {
            print(i);
        }
    }

    //Create a function called OnlyOddOnes that takes in an int array as a parameter and returns 
    //a List of integers that were odd inside the array
    List<int> OnlyOddOnes(int[] array)
    {
        List<int> finishline = new List<int> ();
        foreach (int var in array)
        {
            if(var%2 != 0)
            {
                finishline.Add(var);
            }
        }
        return finishline;
        
    }
}
