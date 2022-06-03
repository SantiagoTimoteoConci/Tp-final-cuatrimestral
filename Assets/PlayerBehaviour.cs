using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movement;
    public float rotation;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotation, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotation, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
           transform.Translate(0, 0, movement);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movement);
        }
    }

}
