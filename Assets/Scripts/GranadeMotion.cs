using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeMotion : MonoBehaviour
{

    private Rigidbody rb;
    public GameObject aCamera;
    private float force;
    // Start is called before the first frame update
    void Start()
    {
        force = 8;
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Q))// Throwing grande
        {
            Vector3 direction = aCamera.transform.forward;
            direction.y = 0.9f;
            rb.AddForce(force*direction, ForceMode.Impulse);
            rb.useGravity = true;
        }
    }
}
