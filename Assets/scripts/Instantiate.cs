using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject objectToClone;
    int num;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        while (num < 100000000000000000)
        {
            Instantiate(objectToClone);
            num++;
        }
    }
}

