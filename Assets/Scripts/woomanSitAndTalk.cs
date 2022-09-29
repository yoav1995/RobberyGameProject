using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woomanSitAndTalk : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("isClose", true);
        StartCoroutine(StartTalk());
    }
    IEnumerator StartTalk()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetInteger("isSitting", 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
