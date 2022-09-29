using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setNPCTarget : MonoBehaviour
{
    public GameObject NPC;
    private Animator animator; // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == NPC.gameObject) // change position of NPC target
        {
            StartCoroutine(Wait());
            float x, y, z;
            x = Random.Range(4, 20);
            z = Random.Range(4, 20);
            y = Random.Range(0, 1);
            transform.position = new Vector3(x, y, z);

        }
    }
    IEnumerator Wait()
    {
        animator.SetBool("isWalking", false);
        yield return new WaitForSeconds(5f);
    }
}
