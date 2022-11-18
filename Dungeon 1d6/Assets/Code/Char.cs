using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char : MonoBehaviour
{
    public static string namechar;
    public static int lifes;
    public static int pointlifes;
    public static int maxpointlifes;
    public static int attack;
    public static int defense;
    public static GameObject ImageChar;
    public static GameObject ImgClass;
    public static GameObject ImgGender;
    public Text nameux;
    public Text lifesux;
    public Text pointlifesux;
    public Text maxpointlifesux;
    public Text attackux;
    public Text defenseux;
    public GameObject ImageCharux;
    public GameObject ImgClassux;
    public GameObject ImageCharux2;
    public GameObject ImgGenderux;
    public static bool start=false;
    public GameObject PanelPlay;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void StartChar()
    {
        nameux.text = namechar;
        maxpointlifesux.text = maxpointlifes.ToString();
        defenseux.text = defense.ToString();
        attackux.text = attack.ToString();
        ImageCharux = ImageChar;
        ImgClassux = ImgClass;
        ImgGenderux = ImgGender;
        
        ImageCharux2=Instantiate(ImageChar, ImageCharux.GetComponent<Transform>().localScale, Quaternion.identity);
        ImageCharux2.transform.parent = PanelPlay.gameObject.transform;
        ImageCharux2.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            StartChar();
        }   
    }
}
