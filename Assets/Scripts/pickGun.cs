using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickGun : MonoBehaviour
{
    public GameObject gunInHand;
    public GameObject gunInDrawer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        gunInHand.transform.gameObject.SetActive(true);
        gunInDrawer.transform.gameObject.SetActive(false);
    }
}
