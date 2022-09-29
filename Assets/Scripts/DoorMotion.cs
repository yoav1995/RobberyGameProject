using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    // Start is called before the first frame update
     private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("isOpening",true);

    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isOpening", false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
