using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public GameObject restart;
    public GameObject Platform;
    bool hasJump;
    Rigidbody rb;
    public GameObject win;
    int Num;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump = false;
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(rotationSpeed, 0, 0);
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(-rotationSpeed, 0, 0);
        }
    }

    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "ground")
        {
            hasJump = true;
        }

        if (col.gameObject.tag == "button")
        {
            Platform.transform.position += new Vector3(0.1f, 0, 0);
        }

    }


}
