using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubegenerator : MonoBehaviour

{
    public Transform cubeTemplate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(cubeTemplate);
        }
    }
}