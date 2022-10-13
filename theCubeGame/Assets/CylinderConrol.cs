using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderConrol : MonoBehaviour
{
    public Transform cylindertemplate;
    float turningspeed = 180;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Vector3.down * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))


            transform.Rotate(Vector3.up, -turningspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))

            transform.position += Vector3.back * Time.deltaTime;



        {
            if (Input.GetKeyDown(KeyCode.Space))
                Instantiate(cylindertemplate);
            }
        {


        }
    }
}
        

    

        







