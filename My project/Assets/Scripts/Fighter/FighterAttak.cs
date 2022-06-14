using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class FighterAttak : MonoBehaviour
{
    [SerializeField] private HeroFighter hv;
     private Fighter fg;
     private HPUI hPUI;
     
    [SerializeField] public float       _damage;
    private Fighter                     _target;
    public FighterAttak enemy;
    
    [SerializeField] private HeroFighter heroFighter;

    public void SetTarget(Fighter fighter)
    {
        _target = fighter;
    }
    public void Attack()
    {
        hv = GetComponent<HeroFighter>();
        fg = GetComponent<Fighter>();
        enemy = GetComponent<FighterAttak>();
        heroFighter = GetComponent<HeroFighter>();
        hPUI = GetComponent<HPUI>();
       

        if (fg.battleSide == "Enemy")
        {
            _target.TakeDamage(_damage);
            Debug.Log("Урон enemy " + _damage);
          
        }
        else
        {
           
            hv.SettingsHero();
            _target.TakeDamage(hv.DamageHero);
            hPUI.UpdateAttake();
            Debug.Log("Урон героя " + hv.DamageHero);
        }
        
       
    }

}
