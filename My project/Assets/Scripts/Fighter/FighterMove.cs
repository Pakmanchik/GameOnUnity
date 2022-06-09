using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterMove : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _moveSpeed;

    public Coroutine StarMove(Transform target, float stoppingDistance = 0)
    {
        return StartCoroutine(MoveTo(target, stoppingDistance));
    }
    private IEnumerator MoveTo(Transform target,float stoppingDistance = 0)
    {
        while (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
             
            transform.position = Vector2.MoveTowards(transform.position, target.position,_moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
    public Coroutine StartLookRotation(Transform target)
    {
        Vector2 direction = (target.position - transform.position);
        Quaternion rotation = Quaternion.LookRotation(direction);
        return StartCoroutine(RotateTo(rotation));
    }
    public Coroutine StartRotation(Quaternion TargetRotation)
    {
        return StartCoroutine(RotateTo(TargetRotation));
    }

   
    public IEnumerator RotateTo (Quaternion TargetRotation)
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, TargetRotation, _rotateSpeed * Time.deltaTime);
        yield return null;
    }

}
