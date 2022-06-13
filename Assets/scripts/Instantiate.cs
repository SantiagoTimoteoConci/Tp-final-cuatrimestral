using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject objectToClone;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        int counter = 0;
        while (counter < 5)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
