using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmovement : MonoBehaviour
{
    public float speed = 1100;
    public float turnSpeed = 300;


    private Rigidbody R;

    // Start is called before the first frame update
    void Start()
    {
        R = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        {
            R.AddRelativeForce(Vector3.forward * speed * 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            R.AddRelativeForce(-(Vector3.forward * speed * 10) / 2);
        }

        if (Input.GetKey(KeyCode.D))
        {
            R.AddTorque(Vector3.up * turnSpeed * 10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            R.AddTorque(-Vector3.up * turnSpeed * 10);
        }
    }
}
