using System.Collections;
using UnityEngine;



[RequireComponent(typeof(FightAnimator), typeof(FighterMove),typeof(FighterAttak))]
public class Fighter : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private GameObject enemy;
    [SerializeField] private Fighter _target;
    [SerializeField] private float _fightDistance;
    [SerializeField] private StayPoint _StayPoint;
    [SerializeField] public string battleSide;
    [SerializeField] private HeroFighter hv;

    public FightAnimator _fighterAnimator;
    private FighterMove _fighterMove;
    private FighterAttak _fighterAttack;
  

    private float _health;

    private void Awake()
    {
        _fighterAnimator = GetComponent<FightAnimator>();
        _fighterMove = GetComponent<FighterMove>();
        _fighterAttack = GetComponent<FighterAttak>();
        
       
    }

  
    public   void StartBattle()
    {
        hv.SettingsHero();
       if(battleSide == "Enemy")
        {
            _health = _maxHealth;
        }
        else
        {
            _health = hv.HealthHero;
        }
      
        
        if (_target != null)
            StartOffensive(_target); // если цель выбрана, то продолжить
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        Debug.Log(_health + "-" + gameObject.name);
    }

  

    public void StartOffensive(Fighter target)
    {
        StartCoroutine(Offensive(target));
    }

    private IEnumerator Offensive(Fighter target)
    {   
        if(battleSide == "Enemy")
        {

            _fighterAnimator.Run();
              yield return _fighterMove.StarMove(_StayPoint.transform);
            ButtonGo.GoesAll = false;
              _fighterAnimator.Idle();
              yield return new WaitForSeconds(4f);
        }
        else
        {
            _fighterAnimator.Idle();
          yield return new WaitForSeconds(5f);
        }
        _fighterAnimator.Run();// подойти к врагу
        yield return _fighterMove.StarMove(target.transform, _fightDistance);
        _fighterAnimator.Idle();// остановиться перед врагом
        _fighterAttack.SetTarget(target);//выбрать цель
      
       while (target._health > 0)//пока цель жива 
       {
            _fighterAttack.Attack();
            yield return new WaitForSeconds(_fighterAnimator.StartAttak());// нанести урон
            yield return new WaitForSeconds(1f);
                if (_health <= 0)
                {
                break;
                }
       }
        
        if (_health > 0)// если твое здоровье больше врага
        {

            _fighterAnimator.Run();//уйти от врага на свою позицию 
            yield return _fighterMove.StarMove(_StayPoint.transform);//начальная позиция

            _fighterAnimator.Idle();// остановиться после
            Debug.Log("NotRun");
            hv.Score(25);
           // Debug.Log(_heroFighter.ScoreAll + " cчет");
        }
        else
        {
            if(battleSide == "Enemy")
            {
               
                _fighterAnimator.Die();
                yield return new WaitForSeconds(0.9f);
                transform.position = new Vector3(954f, 254f, 0f);
                _fighterAnimator.Idle();
                

            }
            else 
            {
                _fighterAnimator.DeathAll();
                yield return new WaitForSeconds(3f);
                if (PlayerPrefs.GetInt("score") <= hv.ScoreAll)
                    PlayerPrefs.SetInt("score", hv.ScoreAll);
            }
            
            
        }
        
    } 
    private void Die()
    {
        _fighterAnimator.Die();// запустить анимацию смерти
       
    }

}
