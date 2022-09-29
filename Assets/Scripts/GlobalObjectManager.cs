using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalObjectManager : MonoBehaviour
{
    public static GlobalObjectManager instance;
    public static int gold=0;
    public Text coinText;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else if(instance != null)
        {
            Destroy(gameObject); //we are destroying a copy of globalObject
        }
        DontDestroyOnLoad(gameObject);
        coinText.text = "GOLD:" + gold;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
