using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroFighter :  MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float damage;
    [SerializeField] private Text textToEdit;
    [SerializeField] private Text textToEditDamage;

   

    public int ChestBonusHp = 0;
    public int ChestBonusDamage = 0;
    public int ScoreAll = 0;
    public float HealthHero;
    public float DamageHero;
    public string d = "dd";
    
    public void SettingsHero()
    {
         HealthHero = health + 25 * ChestBonusHp;
          DamageHero = damage + 5 * ChestBonusDamage;
    }
    public void Score(int score)
    {
        ScoreAll += score;
        Debug.Log(ScoreAll);
        ss();
    }
   
    public void BonusUp()
    {
        Debug.Log(HealthHero);
        ChestBonusHp += 1;
       ChestBonusDamage += 1;
        Debug.Log(ChestBonusHp);
        SettingsHero();
        Debug.Log(HealthHero);  
    }
    public void ss()
    {
        textToEdit.text = ScoreAll.ToString();
    }

}
