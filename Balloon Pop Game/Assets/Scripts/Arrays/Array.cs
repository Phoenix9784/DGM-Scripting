using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public string[] friendName = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Becky"};

    public int[] numbers = {23,46,77,10,42,98,63,81};
    //                           { 0, 1, 2, 3, 4, 5, 6}

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend" + friendName[0]);
        Debug.Log(friendName[3] + " says wazzup as he walks to class");
        friendName[0] = "Veronica";
        Debug.Log("New friend" + friendName[0]);
        */
        foreach(int numbers in numbers)
        {
            print(numbers);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
