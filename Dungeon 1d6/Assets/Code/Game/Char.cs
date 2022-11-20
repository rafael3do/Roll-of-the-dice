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
    public GameObject ImgGenderux;
    public static bool start=false;
    public GameObject PanelPlay;
    int hearts= 3;
    public Text TxtHearts;
    public Text StatusTurn;
    public int step = 0;
    public int dice;
    public Text valuedice;
    public Button BtDice;
    public Text TxtMsg;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void StartChar()
    {
        nameux.text = namechar;
        maxpointlifesux.text = maxpointlifes.ToString();
        pointlifes = maxpointlifes;
        defenseux.text = defense.ToString();
        attackux.text = attack.ToString();
        ImageCharux = ImageChar;
        ImgClassux = ImgClass;
        ImgGenderux = ImgGender;

        ImageCharux = Instantiate(ImageChar, ImageCharux.GetComponent<Transform>().localScale, Quaternion.identity);
        ImageCharux.transform.parent = PanelPlay.gameObject.transform;
        ImageCharux.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        ImageCharux.transform.localPosition = new Vector2(-143.0f, -160.0f);
        ImageCharux.GetComponent<Button>().enabled = false;

        ImgClassux = Instantiate(ImgClass, ImgClassux.GetComponent<Transform>().localScale, Quaternion.identity);
        ImgClassux.transform.parent = PanelPlay.gameObject.transform;
        ImgClassux.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        ImgClassux.transform.localPosition = new Vector2(-142.0f, -204.0f);
        ImgClassux.GetComponent<Button>().enabled = false;

        ImgGenderux = Instantiate(ImgGenderux, ImgGenderux.GetComponent<Transform>().localScale, Quaternion.identity);
        ImgGenderux.transform.parent = PanelPlay.gameObject.transform;
        ImgGenderux.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        ImgGenderux.transform.localPosition = new Vector2(-142.0f, -252.0f);
        ImgGenderux.GetComponent<Button>().enabled = false;

        hearts = 3;
        TxtHearts.text = hearts.ToString();

        start = false;
        Enemy.level = 1;
        Enemy.CheckEnemy();
        StatusTurn.text = "Rool Iniciative";
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            StartChar();
        }   
    }
    public void ClickDice()
    {
        switch (step)
        {
            case 0:
                RollIniciative();
                break;
            case 1:
                RollAttack();
                break;
            case 2:
                RollAttack();
                break;
            case 3:
                RollDamage();
                break;
                

        }
    }

    void RollIniciative()
    {
        dice = Random.Range(1, 7);
        valuedice.text = dice.ToString();
        TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:")+ " You roll initiative "+dice;
        if (dice>=3)
        {
            StatusTurn.text = "Your turn";
            step = 1;
        }
        else
        {
            StatusTurn.text = "Enemy turn";
            step = 2;
            TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:") + " Enemy has initiative ";
            StartCoroutine(IARollAttack());
            BtDice.enabled = false;
            BtDice.GetComponent<Image>().color = Color.gray;
        }
    }

    void RollAttack()
    {
        if (step==1)
        {
            
            dice = Random.Range(1, 7);
            valuedice.text = dice.ToString();
            var diceattack = dice + attack;
            TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:") + " You rolled attack and got " + dice;
            if (diceattack>Enemy.def)
            {
                StatusTurn.text = "Roll Damage";
                step = 3;
            }
            else
            {
                TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:") + " You failed the attack ";
                StatusTurn.text = "Enemy turn";
                step =4;
                BtDice.enabled = false;
                BtDice.GetComponent<Image>().color = Color.gray;
                StartCoroutine(IARollAttack());
            }
        }
        else if(step==2)
        {
            dice = Random.Range(1, 7);
            valuedice.text = dice.ToString();
            TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:") + " Enemy rolled attack and got " + dice;
            var diceattack = dice + attack;
            if (diceattack > defense)
            {
                StatusTurn.text = "Enemy Roll Damage";
                step = 5;
                BtDice.enabled = false;
                BtDice.GetComponent<Image>().color = Color.gray;
                StartCoroutine(IARollDamage());
            }
            else
            {
                TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:") + " Enemy failed the attack ";
                StatusTurn.text = "Your turn";
                step = 1;
                BtDice.enabled = true;
                BtDice.GetComponent<Image>().color = Color.white;
            }
        }
    }
    void RollDamage()
    {
        if (step==3)
        {
            StatusTurn.text = "Roll Damage";
            dice = Random.Range(1, 7);
            valuedice.text = dice.ToString();
            TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:") + " You attack enemy with " + dice;
            if (dice==6)
            {
                Enemy.life -= dice * 2;
                CheckEnemyLife();
            }
            else
            {
                Enemy.life -= dice;
                CheckEnemyLife();
            }
        }else if (step ==5)
        {
            StatusTurn.text = "Enemy Roll Damage";
            dice = Random.Range(1, 7);
            valuedice.text = dice.ToString();
            if (dice == 6)
            {
                pointlifes -= dice * 2;
                maxpointlifesux.text = pointlifes.ToString();
                BtDice.enabled = false;
                BtDice.GetComponent<Image>().color = Color.gray;
                CheckEnemyLife();
            }
            else
            {
                pointlifes -= dice;
                BtDice.enabled = false;
                maxpointlifesux.text = pointlifes.ToString();
                BtDice.GetComponent<Image>().color = Color.gray;
                CheckEnemyLife();
            }
        }
    }

    void CheckEnemyLife()
    {
        if (Enemy.life<=0)
        {
            TxtMsg.text += "\n" + System.DateTime.Now.ToString("[hh:mm:ss]:") + " You Killed enemy, go next room";
            Enemy.level++;
            Enemy.CheckEnemy();
            step = 0;
            BtDice.enabled = true;
            BtDice.GetComponent<Image>().color = Color.white;
            TxtMsg.text = "";
        }
        else if (pointlifes<=0)
        {
            step = 1;
            BtDice.enabled = true;
            BtDice.GetComponent<Image>().color = Color.white;
            StatusTurn.text = "Your Turn";
        }
        else
        {
            step = 1;
            BtDice.enabled = true;
            BtDice.GetComponent<Image>().color = Color.white;
            StatusTurn.text = "Your Turn";
        }
        


    }
    IEnumerator IARollAttack()
    {
        StatusTurn.text = "Enemy Roll Attack";
        yield return new WaitForSeconds(1.0f) ;
        RollAttack();
    }
    IEnumerator IARollDamage()
    {
        
        yield return new WaitForSeconds(1.0f);
        RollDamage();
    }



}
