using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCal : MonoBehaviour
{

    //Access Modifier Datatype name;
    public int numberA = 10;
    public int numberB = 33;
    public int numberC = 7;



    // Start is called before the first frame update
    void Start()
    {
        int total;

        total = numberA + numberB;

        Debug.Log(numberA +" + "+ numberB +" = "+ total);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
