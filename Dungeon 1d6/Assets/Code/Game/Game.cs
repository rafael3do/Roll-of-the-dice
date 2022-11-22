using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelGame;
    public GameObject panelChar;
    public GameObject panelProfiles;
    public GameObject ObjChar;

    void Start()
    {
        if (Global.isload)
        {
            Debug.Log("Loading");
            panelChar.SetActive(false);
            panelGame.SetActive(true);
            panelProfiles.SetActive(false);
            ObjChar.SetActive(false);
        }
        else
        {
            panelChar.SetActive(true);
            panelGame.SetActive(false);
            panelProfiles.SetActive(true);
            ObjChar.SetActive(true);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisableCreateChar()
    {
        panelChar.SetActive(false);
        panelGame.SetActive(true);
        panelProfiles.SetActive(false);
        //ObjChar.SetActive(false);
    }
}
