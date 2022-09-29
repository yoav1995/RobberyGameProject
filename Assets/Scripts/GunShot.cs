using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GunShot : MonoBehaviour
{
    public GameObject aCamera;
    public GameObject target;
    private LineRenderer lr;
    public GameObject startPoint;
    public GameObject aGun;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        lr=GetComponent<LineRenderer>();
        lr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hit;
            if(Physics.Raycast(aCamera.transform.position,aCamera.transform.forward,out hit))
            {
                target.transform.position = hit.point;
                StartCoroutine(FireFlash());
                if(hit.collider.gameObject==enemy.gameObject)
                {
                    StartCoroutine(FallAndStandBack());
                    
                }
            }
        }   
    }
    IEnumerator FallAndStandBack()
        {
        Animator animator = enemy.GetComponent<Animator>();
        animator.SetInteger("StateTransition", 1);// fall
        yield return new WaitForSeconds(3f);
        animator.SetInteger("StateTransition", 2);//stand up
        yield return new WaitForSeconds(2f);
        animator.SetInteger("StateTransition", 3);// walking
        NavMeshAgent nav = enemy.GetComponent<NavMeshAgent>();
        nav.enabled = true;
    }
    IEnumerator FireFlash()
    {
        AudioSource sound= aGun.GetComponent<AudioSource>();
        sound.Play();
        lr.enabled = true;
        lr.SetPosition(0, startPoint.transform.position);
        lr.SetPosition(1, target.transform.position);

        yield return new WaitForSeconds(0.05f);
        lr.enabled = false;
       

    }
}
