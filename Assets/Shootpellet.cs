using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootpellet : MonoBehaviour
{
    public GameObject pellet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(pellet, transform.position, transform.rotation);
        }
    }
}
