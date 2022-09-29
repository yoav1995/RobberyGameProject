using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woomanLugth : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(StartLugth());
        
    }
    IEnumerator StartLugth()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("isClose", true);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
