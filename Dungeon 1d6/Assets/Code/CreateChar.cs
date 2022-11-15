using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateChar : MonoBehaviour
{
    public GameObject SelectChar;
    public GameObject SelectGender;
    public GameObject Male;
    public GameObject Female;
    public GameObject Warrior;
    public GameObject Archer;
    public GameObject Mage;
    public GameObject Ladino;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickWarrior()
    {
        SelectChar.transform.localPosition = Warrior.transform.localPosition;// new Vector2(-384.2f, 151);
        Warrior.GetComponent<Image>().color = Color.white;
        Archer.GetComponent<Image>().color = Color.gray;
        Mage.GetComponent<Image>().color = Color.gray;
        Ladino.GetComponent<Image>().color = Color.gray;

    }
    public void ClickMage()
    {
        SelectChar.transform.localPosition = Mage.transform.localPosition;
        Warrior.GetComponent<Image>().color = Color.gray;
        Archer.GetComponent<Image>().color = Color.gray;
        Mage.GetComponent<Image>().color = Color.white;
        Ladino.GetComponent<Image>().color = Color.gray;
    }
    public void ClickArcher()
    {
        SelectChar.transform.localPosition = Archer.transform.localPosition;
        Warrior.GetComponent<Image>().color = Color.gray;
        Archer.GetComponent<Image>().color = Color.white;
        Mage.GetComponent<Image>().color = Color.gray;
        Ladino.GetComponent<Image>().color = Color.gray;
    }

    public void ClickLadino()
    {
        SelectChar.transform.localPosition = Ladino.transform.localPosition;
        Warrior.GetComponent<Image>().color = Color.gray;
        Archer.GetComponent<Image>().color = Color.gray;
        Mage.GetComponent<Image>().color = Color.gray;
        Ladino.GetComponent<Image>().color = Color.white;
    }
    public void ClickMale()
    {

    }

    public void ClickFemale()
    {

    }
}
