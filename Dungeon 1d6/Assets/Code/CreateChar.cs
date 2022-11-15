using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateChar : MonoBehaviour
{
    public GameObject SelectChar;
    public GameObject SelectGender;
    public GameObject SelectProfile;
    public GameObject Male;
    public GameObject Female;
    public GameObject Warrior;
    public GameObject Archer;
    public GameObject Mage;
    public GameObject Ladino;
    public GameObject Prof1;
    public GameObject Prof2;
    public GameObject Prof3;
    public GameObject Prof4;
    public GameObject Prof5;
    public GameObject Prof6;
    public GameObject Prof7;
    public GameObject Prof8;
    public Text Txpoints;
    int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        points = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Txpoints.text = points.ToString();
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
        SelectGender.transform.localPosition = Male.transform.localPosition;
        Male.GetComponent<Image>().color = Color.white;
        Female.GetComponent<Image>().color = Color.gray;
    }

    public void ClickFemale()
    {
        SelectGender.transform.localPosition = Female.transform.localPosition;
        Male.GetComponent<Image>().color = Color.gray;
        Female.GetComponent<Image>().color = Color.white;
    }
    public void ClickProf1()
    {
        SelectProfile.transform.localPosition = Prof1.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.white;
        Prof2.GetComponent<Image>().color = Color.gray;
        Prof3.GetComponent<Image>().color = Color.gray;
        Prof4.GetComponent<Image>().color = Color.gray;
        Prof5.GetComponent<Image>().color = Color.gray;
        Prof6.GetComponent<Image>().color = Color.gray;
        Prof7.GetComponent<Image>().color = Color.gray;
        Prof8.GetComponent<Image>().color = Color.gray;
    }
    public void ClickProf2()
    {
        SelectProfile.transform.localPosition = Prof2.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.gray;
        Prof2.GetComponent<Image>().color = Color.white;
        Prof3.GetComponent<Image>().color = Color.gray;
        Prof4.GetComponent<Image>().color = Color.gray;
        Prof5.GetComponent<Image>().color = Color.gray;
        Prof6.GetComponent<Image>().color = Color.gray;
        Prof7.GetComponent<Image>().color = Color.gray;
        Prof8.GetComponent<Image>().color = Color.gray;
    }
    public void ClickProf3()
    {
        SelectProfile.transform.localPosition = Prof3.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.gray;
        Prof2.GetComponent<Image>().color = Color.gray;
        Prof3.GetComponent<Image>().color = Color.white;
        Prof4.GetComponent<Image>().color = Color.gray;
        Prof5.GetComponent<Image>().color = Color.gray;
        Prof6.GetComponent<Image>().color = Color.gray;
        Prof7.GetComponent<Image>().color = Color.gray;
        Prof8.GetComponent<Image>().color = Color.gray;
    }
    public void ClickProf4()
    {
        SelectProfile.transform.localPosition = Prof4.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.gray;
        Prof2.GetComponent<Image>().color = Color.gray;
        Prof3.GetComponent<Image>().color = Color.gray;
        Prof4.GetComponent<Image>().color = Color.white;
        Prof5.GetComponent<Image>().color = Color.gray;
        Prof6.GetComponent<Image>().color = Color.gray;
        Prof7.GetComponent<Image>().color = Color.gray;
        Prof8.GetComponent<Image>().color = Color.gray;
    }
    public void ClickProf5()
    {
        SelectProfile.transform.localPosition = Prof5.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.gray;
        Prof2.GetComponent<Image>().color = Color.gray;
        Prof3.GetComponent<Image>().color = Color.gray;
        Prof4.GetComponent<Image>().color = Color.gray;
        Prof5.GetComponent<Image>().color = Color.white;
        Prof6.GetComponent<Image>().color = Color.gray;
        Prof7.GetComponent<Image>().color = Color.gray;
        Prof8.GetComponent<Image>().color = Color.gray;
    }
    public void ClickProf6()
    {
        SelectProfile.transform.localPosition = Prof6.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.gray;
        Prof2.GetComponent<Image>().color = Color.gray;
        Prof3.GetComponent<Image>().color = Color.gray;
        Prof4.GetComponent<Image>().color = Color.gray;
        Prof5.GetComponent<Image>().color = Color.gray;
        Prof6.GetComponent<Image>().color = Color.white;
        Prof7.GetComponent<Image>().color = Color.gray;
        Prof8.GetComponent<Image>().color = Color.gray;
    }
    public void ClickProf7()
    {
        SelectProfile.transform.localPosition = Prof7.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.gray;
        Prof2.GetComponent<Image>().color = Color.gray;
        Prof3.GetComponent<Image>().color = Color.gray;
        Prof4.GetComponent<Image>().color = Color.gray;
        Prof5.GetComponent<Image>().color = Color.gray;
        Prof6.GetComponent<Image>().color = Color.gray;
        Prof7.GetComponent<Image>().color = Color.white;
        Prof8.GetComponent<Image>().color = Color.gray;
    }
    public void ClickProf8()
    {
        SelectProfile.transform.localPosition = Prof8.transform.localPosition;
        Prof1.GetComponent<Image>().color = Color.gray;
        Prof2.GetComponent<Image>().color = Color.gray;
        Prof3.GetComponent<Image>().color = Color.gray;
        Prof4.GetComponent<Image>().color = Color.gray;
        Prof5.GetComponent<Image>().color = Color.gray;
        Prof6.GetComponent<Image>().color = Color.gray;
        Prof7.GetComponent<Image>().color = Color.gray;
        Prof8.GetComponent<Image>().color = Color.white;
    }
}
