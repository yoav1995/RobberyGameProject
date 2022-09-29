using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinMotion : MonoBehaviour
{
    // Start is called before the first frame update
    public Text coinText;
    public static int numCoins;
    public GameObject allCoins;
    public GameObject agent;
    private AudioSource pickSound;
    private Collider player;
    void Start()
    {
        numCoins = GlobalObjectManager.gold; // this is how to save gold on scene transition
        pickSound =allCoins.GetComponent<AudioSource>();
        player = agent.GetComponent<CapsuleCollider>();
    }
    private void OnTriggerEnter(Collider player)
    {
            numCoins++;
            coinText.text = "GOLD:" + numCoins;
            pickSound.Play();
            this.gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
