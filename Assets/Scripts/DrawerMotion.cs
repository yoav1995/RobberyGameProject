using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerMotion : MonoBehaviour
{
    private Animator animator;
    AudioSource sound2;

    void Start()
    {
        animator = GetComponent<Animator>();
        sound2 = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("isOpenDrawer", true);
        sound2.PlayDelayed(0.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isOpenDrawer", false);
        sound2.PlayDelayed(0.5f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
