using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public Text TxtNameEnemy;
    public static string uxTxtNameEnemy;
    public Text TxtMaxLifeEnemy;
    public static Text uxTxtMaxLifeEnemy;
    public Text TxtCurrentLifeEnemy;
    public static Text uxTxtCurrentLifeEnemy;
    public static GameObject Imgenemy;
    public static int level;
    public static int atack;
    public static int def;
    public static int life;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }

    public static void CheckEnemy()
    {
        switch (level)
        {
            case 1:
                uxTxtNameEnemy = "Rat";
                atack = 1;
                def = 0;
                life = 1;
                break;
            case 2:
                uxTxtNameEnemy = "Slime";
                atack = 2;
                def = 1;
                life = 2;
                break;
            case 3:
                uxTxtNameEnemy = "Skeleton";
                atack = 4;
                def = 3;
                life = 4;
                break;
            case 4:
                uxTxtNameEnemy = "Fungus";
                atack = 4;
                def = 4;
                life = 4;
                break;
            case 5:
                uxTxtNameEnemy = "Bonus 1";
                atack = 0;
                def = 0;
                life = 0;
                break;
            case 6:
                uxTxtNameEnemy = "Kobold";
                atack = 3;
                def = 6;
                life = 5;
                break;
            case 7:
                uxTxtNameEnemy = "Gelatinous";
                atack = 5;
                def = 3;
                life = 6;
                break;
            case 8:
                uxTxtNameEnemy = "Snake";
                atack = 6;
                def = 4;
                life = 5;
                break;
            case 9:
                uxTxtNameEnemy = "Goblins";
                atack = 5;
                def = 6;
                life = 6;
                break;
            case 10:
                uxTxtNameEnemy = "Bonus 2";
                atack = 0;
                def = 0;
                life = 0;
                break;
            case 11:
                uxTxtNameEnemy = "Spider";
                atack = 4;
                def = 7;
                life = 7;
                break;
            case 12:
                uxTxtNameEnemy = "Behoolder";
                atack = 5;
                def = 6;
                life = 7;
                break;
            case 13:
                uxTxtNameEnemy = "Lich";
                atack = 8;
                def = 10;
                life = 14;
                break;
            case 14:
                uxTxtNameEnemy = "Bonus 3";
                atack = 0;
                def = 0;
                life =0;
                break;
            case 15:
                uxTxtNameEnemy = "Red Dragon";
                atack = 8;
                def = 10;
                life = 50;
                break;
            case 16:
                uxTxtNameEnemy = "End dungeon";
                break;
        }
        
    }
    public void UpdateText()
    {
        TxtNameEnemy.text = uxTxtNameEnemy;
        TxtMaxLifeEnemy.text = life.ToString();
    }
}
