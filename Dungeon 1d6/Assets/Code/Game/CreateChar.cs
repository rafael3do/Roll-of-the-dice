using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateChar : MonoBehaviour
{
    public InputField Charname;
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
    int atack;
    int def;
    int life;
    public Text Txtattack;
    public Text Txtdefense;
    public Text Txtlife;
    public Text TxtBonus;
    public Button BtBonus;
    public Button AddAtack;
    public Button RemoveAtack;
    public Button AddDefense;
    public Button RemoveDefense;
    public Button AddLife;
    public Button RemoveLife;
    GameObject SelectionClasse;
    GameObject SelectionGender;
    GameObject SelectionProfile;
    // Start is called before the first frame update
    void Start()
    {
        points = 5;
        Txpoints.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (points > 0)
        {
            AddLife.enabled =  true;
            AddAtack.enabled = true;
            AddDefense.enabled=true;
        }
        else
        {
            AddLife.enabled = false;
            AddAtack.enabled = false;
            AddDefense.enabled=false;
        }
    }
    public void ClickWarrior()
    {
        SelectChar.transform.localPosition = Warrior.transform.localPosition;// new Vector2(-384.2f, 151);
        Warrior.GetComponent<Image>().color = Color.white;
        Archer.GetComponent<Image>().color = Color.gray;
        Mage.GetComponent<Image>().color = Color.gray;
        Ladino.GetComponent<Image>().color = Color.gray;
        SelectionClasse = Warrior;

    }
    public void ClickMage()
    {
        SelectChar.transform.localPosition = Mage.transform.localPosition;
        Warrior.GetComponent<Image>().color = Color.gray;
        Archer.GetComponent<Image>().color = Color.gray;
        Mage.GetComponent<Image>().color = Color.white;
        Ladino.GetComponent<Image>().color = Color.gray;
        SelectionClasse = Mage;
    }
    public void ClickArcher()
    {
        SelectChar.transform.localPosition = Archer.transform.localPosition;
        Warrior.GetComponent<Image>().color = Color.gray;
        Archer.GetComponent<Image>().color = Color.white;
        Mage.GetComponent<Image>().color = Color.gray;
        Ladino.GetComponent<Image>().color = Color.gray;
        SelectionClasse = Archer;
    }

    public void ClickLadino()
    {
        SelectChar.transform.localPosition = Ladino.transform.localPosition;
        Warrior.GetComponent<Image>().color = Color.gray;
        Archer.GetComponent<Image>().color = Color.gray;
        Mage.GetComponent<Image>().color = Color.gray;
        Ladino.GetComponent<Image>().color = Color.white;
        SelectionClasse= Ladino;
    }
    public void ClickMale()
    {
        SelectGender.transform.localPosition = Male.transform.localPosition;
        Male.GetComponent<Image>().color = Color.white;
        Female.GetComponent<Image>().color = Color.gray;
        SelectionGender = Male;
    }

    public void ClickFemale()
    {
        SelectGender.transform.localPosition = Female.transform.localPosition;
        Male.GetComponent<Image>().color = Color.gray;
        Female.GetComponent<Image>().color = Color.white;
        SelectionGender = Female;
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
        SelectionProfile = Prof1;
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
        SelectionProfile = Prof2;
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
        SelectionProfile = Prof3;
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
        SelectionProfile = Prof4;
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
        SelectionProfile = Prof5;
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
        SelectionProfile = Prof6;
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
        SelectionProfile = Prof7;
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
        SelectionProfile=Prof8;
    }
    public void RollDiceBonus()
    {
        int dice = Random.Range(1, 7);
        TxtBonus.text = dice.ToString();
        Txpoints.text =(dice+int.Parse(Txpoints.text)).ToString();
        points += dice;
        BtBonus.enabled=false;
    }
    public void AddMoreAtack()
    {
        if (points > 0)
        {
            atack += 1;
            Txtattack.text = atack.ToString();
            points--;
            Txpoints.text = points.ToString();
        }
       
    }
    public void RemoveMoreAtack()
    {
        if (atack> 0)
        {
            atack -= 1;
            Txtattack.text = atack.ToString();
            points++;
            Txpoints.text = points.ToString();
            
        }
    }

    public void AddMoreDefense()
    {
        if (points > 0)
        {
            def += 1;
            Txtdefense.text = def.ToString();
            points--;
            Txpoints.text = points.ToString();
        }
    }
    public void RemoveMoreDefense()
    {
        if (def > 0)
        {
            def -= 1;
            Txtdefense.text = def.ToString();
            points++;
            Txpoints.text = points.ToString();

        }
    }
    public void AddMoreLife()
    {
        if (points > 0)
        {
            life += 1;
            Txtlife.text = life.ToString();
            points--;
            Txpoints.text = (int.Parse(Txpoints.text) - 1).ToString();
        }
    }
    public void RemoveMoreLife()
    {
        if (life > 0)
        {
            life -= 1;
            Txtlife.text = life.ToString();
            points++;
            Txpoints.text = points.ToString();

        }
    }
    public void SetName()
    {
        name = Charname.text;
    }
    public void Return()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void MakeChar()
    {
        
        Char.attack = atack;
        Char.defense = def;
        Char.maxpointlifes = life;
        Char.namechar = name;
        Char.ImageChar = SelectionProfile;
        Char.ImgClass = SelectionClasse;
        Char.ImgGender = SelectionGender;
        Char.start = true;
       

    }
}
