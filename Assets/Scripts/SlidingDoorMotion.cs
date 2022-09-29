using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoorMotion : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    private AudioSource audioSrc;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("isOpenSlide", true);
        audioSrc.PlayDelayed(0.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isOpenSlide", false);
        audioSrc.PlayDelayed(0.8f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
