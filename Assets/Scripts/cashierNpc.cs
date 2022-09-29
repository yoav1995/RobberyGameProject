using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cashierNpc : MonoBehaviour
{
    public Text robInstruction;
    private Animator animator;
    private AudioSource sound;
    public GameObject CrossHair;
    public GameObject CrossHairTouch;
    public GameObject Eye;
    public static int numCoins;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        numCoins = GlobalObjectManager.gold; // this is how to save gold on scene transition
        animator = GetComponent<Animator>();
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
                robInstruction.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.R))
                {
                    animator.SetBool("isScared", true);
                    numCoins+=50;
                    coinText.text = "GOLD:" + numCoins;
                    // sound.PlayDelayed(0.5f);
                }
            }
            else
            {
                CrossHair.SetActive(true);
                CrossHairTouch.SetActive(false);
                animator.SetBool("isScared", false);
                robInstruction.gameObject.SetActive(false);
            }

        }
    }
}
