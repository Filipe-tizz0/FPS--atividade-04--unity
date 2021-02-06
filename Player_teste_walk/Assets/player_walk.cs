using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_walk : MonoBehaviour
{
    // Start is called before the first frame update
    public int player_speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * player_speed * Time.deltaTime;
        }
    }
}
