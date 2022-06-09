using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class FightAnimator : MonoBehaviour
{
   
    public Animator _animator;

    private const string IdleParametr = "Idle";
    private const string AttakParametr = "Attak";
    private const string RunParametr = "Run";
    public const string DeathParametr = "Death";
    public const string DieParametr = "Die";

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }



    public float StartAttak()
    {
        _animator.SetTrigger(AttakParametr);
        AnimatorClipInfo[] clipInfo = _animator.GetCurrentAnimatorClipInfo(0);
       return clipInfo[0].clip.length;//возвращаем размер анимации 
    }
    public void Run()
    {
        _animator.SetBool(RunParametr,true);

    }
    public void DeathAll()
    {
        _animator.SetBool(DieParametr, true);

    }
    public float Die()
    {
        _animator.SetTrigger(DeathParametr);
        AnimatorClipInfo[] clipInfodeath = _animator.GetCurrentAnimatorClipInfo(0);
        return clipInfodeath[0].clip.length;//возвращаем размер анимации 
    }
    public void Idle()
    {
        _animator.SetBool(RunParametr, false);  
    }


}
