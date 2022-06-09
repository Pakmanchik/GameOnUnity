using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class FighterAttak : MonoBehaviour
{
    [SerializeField] private HeroFighter hv;
     private Fighter fg;
     
    [SerializeField] private float       _damage;
    private Fighter                     _target;


    public void SetTarget(Fighter fighter)
    {
        _target = fighter;
    }
    public void Attack()
    {
        hv = GetComponent<HeroFighter>();
        fg = GetComponent<Fighter>();
        
        if (fg.battleSide == "Enemy")
        {
            _target.TakeDamage(_damage);
            Debug.Log("Урон enemy " + _damage);
        }
        else
        {
            hv.SettingsHero();
            _target.TakeDamage(hv.DamageHero);
            Debug.Log("Урон героя " + hv.DamageHero);
        }
        
       
    }

}
