using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelGame;
    public GameObject panelChar;
    void Start()
    {
        if (Global.isload)
        {
            Debug.Log("Loading");
            panelChar.SetActive(true);
            panelGame.SetActive(false);
        }
        else
        {
            panelChar.SetActive(false);
            panelGame.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
