using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Keeping press key
        if (Input.GetKey(KeyCode.W))
        {
            // length of each frame
            // dir*speed * time of frame
            transform.Translate(new Vector3(0.00f, 0.0f, 1.0f) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0.00f, 0.0f, -1.0f) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //turn left (y)
            transform.Rotate(new Vector3(0.00f, -1.0f, 0.0f) * rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //turn right
            transform.Rotate(new Vector3(0.00f, 1.0f, 0.0f) * rotateSpeed * Time.deltaTime);
        }
    }
}
