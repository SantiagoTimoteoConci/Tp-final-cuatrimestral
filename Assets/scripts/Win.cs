﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
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
        while (counter < 3)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Win")
        {
            SceneManager.LoadScene("win");
        }
    }
}