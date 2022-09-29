using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChestDrawer1 : MonoBehaviour
{

    public GameObject CrossHair;
    public GameObject CrossHairTouch;
    public GameObject Eye;
    public Text Instruction;
    private Animator animator;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        sound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Eye.transform.position, Eye.transform.forward, out hit))
        {
            if (hit.transform.gameObject == this.gameObject)//this.GameObject is the script object
            {
                CrossHair.SetActive(false);
                CrossHairTouch.SetActive(true);
                Instruction.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.O))
                {
                    animator.SetBool("isOpen", true);
                    sound.PlayDelayed(0.5f);
                }
                if (Input.GetKeyDown(KeyCode.C))
                {
                    animator.SetBool("isOpen", false);
                    sound.Play();
                }
            }
            else
            {
                CrossHair.SetActive(true);
                CrossHairTouch.SetActive(false);
                Instruction.gameObject.SetActive(false);
            }
        }

    }
}

