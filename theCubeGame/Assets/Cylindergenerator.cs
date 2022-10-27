using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class    Cylindergenerator : MonoBehaviour

{
    public Transform cylinderTemplate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(cylinderTemplate, transform.position, transform.rotation);
        }
    }
}