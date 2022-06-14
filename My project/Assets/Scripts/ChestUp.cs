using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestUp : MonoBehaviour
{
    [SerializeField] private StayPoint _StayPoint;
    [SerializeField] private GameObject chest;
    [SerializeField] private HeroFighter hr;
    [SerializeField] private Fighter hrf;
   
    private FighterMove _Move;
    private HeroFighter _herofighter;
    public Animator _animator;

    private const string RunParametr = "Run";


    public void GoingChest()
    {
        transform.position = new Vector3(954f, 163f, 0f);
        _Move = GetComponent<FighterMove>();
        _herofighter = GetComponent<HeroFighter>();
      
        StartCoroutine(ChestDoes());
      

    }
    private IEnumerator ChestDoes()
    {
        yield return _Move.StarMove(_StayPoint.transform);//дойти до точки
        ButtonGo.GoesAll = false;
        Open();
        yield return new WaitForSeconds(2f);
        transform.position = new Vector3(954f, 163f, 0f);
        _animator.SetBool(RunParametr, false);
    }
    public void Open()
    {
        _animator.SetBool(RunParametr, true);
        hrf._fighterAnimator.Idle();
        hr.BonusUp();
    }
  
}
