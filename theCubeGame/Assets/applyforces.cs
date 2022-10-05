using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyforces : MonoBehaviour
{
    Rigidbody ourRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ourRigidbody.AddExplosionForce(1000, transform.position + Vector3.up, 1);
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += Vector3.down;
     
}
}