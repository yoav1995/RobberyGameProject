using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class portalToCoffee : MonoBehaviour
{
   // public GameObject screen;// this is the object that has fadeIn Animation
    public Animator animator;
    private void Start()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        index = 1 - index;// next scene index
      StartCoroutine(StartSceneTransition(index)); // start parallel execution of function
  
    }
    IEnumerator StartSceneTransition(int sceneIndex)
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        GlobalObjectManager.gold = coinMotion.numCoins; //save coins to global object
        animator.SetTrigger("startFadeIn");
        yield return new WaitForSeconds(3); //delay
        SceneManager.LoadScene(sceneIndex);
    }
}
