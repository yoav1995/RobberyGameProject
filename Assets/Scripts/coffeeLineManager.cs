using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class coffeeLineManager : MonoBehaviour
{
    [Header("NPC's")]
    [SerializeField] public GameObject Sophie;
    [SerializeField] public GameObject TheBoss;
    [SerializeField] public GameObject Bryne;
    [SerializeField] public GameObject CashierWoman;

    private NavMeshAgent SophieNM; // 1st
    private NavMeshAgent TheBossNM; // 2nd
    private NavMeshAgent BryneNM; // 3rd
    
    private Animator SophieAnimator;
    private Animator TheBossAnimator;
    private Animator BryneAnimator;
    private Animator CashierWomanAnimator;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    private void Awake()
    {
        SophieAnimator = Sophie.GetComponent<Animator>();
        TheBossAnimator = TheBoss.GetComponent<Animator>();
        BryneAnimator = Bryne.GetComponent<Animator>();
        CashierWomanAnimator=CashierWoman.GetComponent<Animator>();

        SophieNM = Sophie.GetComponent<NavMeshAgent>();
        TheBossNM = TheBoss.GetComponent<NavMeshAgent>();
        BryneNM = Bryne.GetComponent<NavMeshAgent>();

    }

    private void Start()
    {
        StartCoroutine(HandleAll());
    }

    private void Update()
    {
    }

    IEnumerator HandleAll()
    {
        yield return new WaitForSeconds(10f);
        // Sophie Leaves
        yield return new WaitForSeconds(0.8f);
        CashierWomanAnimator.SetBool("isSelling", true);
        yield return new WaitForSeconds(1.5f);
        CashierWomanAnimator.SetBool("isSelling", false);
        yield return new WaitForSeconds(1f);
        SophieNM.SetDestination(target1.transform.position);
        yield return new WaitForSeconds(0.2f);
        SophieAnimator.SetBool("isWalking", true);
        yield return new WaitForSeconds(2f);
        //

        // Step rest forward
        TheBossNM.SetDestination(new Vector3(TheBoss.transform.position.x+6f, TheBoss.transform.position.y, TheBoss.transform.position.z));
        yield return new WaitForSeconds(0.2f);
        TheBossAnimator.SetInteger("isWalking", 2);
        yield return new WaitForSeconds(2f);
        TheBossAnimator.SetInteger("isWalking", 1);
        new WaitForSeconds(0.7f);
        BryneNM.SetDestination(new Vector3(Bryne.transform.position.x+4f, Bryne.transform.position.y, Bryne.transform.position.z));
        yield return new WaitForSeconds(0.2f);
        BryneAnimator.SetInteger("isWalking", 2);
        yield return new WaitForSeconds(1.7f);
        BryneAnimator.SetInteger("isWalking", 0);

        yield return new WaitForSeconds(10f);
        yield return new WaitForSeconds(0.8f);
        CashierWomanAnimator.SetBool("isSelling", true);
        yield return new WaitForSeconds(1.5f);
        CashierWomanAnimator.SetBool("isSelling", false);
        SophieAnimator.SetBool("isWalking", false);
        // theBoss SITS
        TheBossNM.SetDestination(target2.transform.position);
        yield return new WaitForSeconds(0.2f);
        TheBossAnimator.SetInteger("isWalking", 2);
        new WaitForSeconds(3f);

        BryneNM.SetDestination(new Vector3(Bryne.transform.position.x + 10f, Bryne.transform.position.y, Bryne.transform.position.z));
        yield return new WaitForSeconds(0.2f);
        BryneAnimator.SetInteger("isWalking", 2);
        yield return new WaitForSeconds(5f);
        BryneAnimator.SetInteger("isWalking", 0);
        

        TheBossNM.SetDestination(new Vector3(TheBoss.transform.position.x -1.5f, TheBoss.transform.position.y-4f, TheBoss.transform.position.z-1f));
        TheBossAnimator.SetInteger("isWalking", 4);
        StartCoroutine(Sits());

   
      

        //Bryne goes to drink 

        yield return new WaitForSeconds(10f);
        yield return new WaitForSeconds(0.8f);
        CashierWomanAnimator.SetBool("isSelling", true);
        yield return new WaitForSeconds(1.5f);
        CashierWomanAnimator.SetBool("isSelling", false);
        BryneNM.SetDestination(target3.transform.position);
        yield return new WaitForSeconds(1.5f);
        BryneAnimator.SetInteger("isWalking", 2);
        yield return new WaitForSeconds(11.5f);
        BryneAnimator.SetInteger("isWalking", 0);
        BryneNM.enabled = false;
        StartCoroutine(Drinks());
    }
  
    IEnumerator Drinks()
    {
        yield return new WaitForSeconds(1f);
        BryneAnimator.SetBool("drinks", true);
    }
    IEnumerator Sits()
    {
        yield return new WaitForSeconds(0.5f);
        TheBossAnimator.SetBool("sit", true);
    }
}

