using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roteteCube : MonoBehaviour
{
    // Start is called before the first frame update
    float SpinForce=100;
    float spintvertical=100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spintvertical * Time.deltaTime, SpinForce * Time.deltaTime, 0);
    }
}
