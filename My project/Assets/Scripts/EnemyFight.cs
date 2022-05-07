using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFight : MonoBehaviour
{
    [SerializeField]            public float speed = 1.5f;
    [SerializeField]            private GameObject obj;

    Vector3                     WereToSpawn;
    // Start is called before the first frame update
 public void Start()
    {

      
    }
    private void Update()
    {
     if (MoveObject.StopGoingEnemy == true)
        {
            Debug.Log("Персонаж пришел");
            HPUI.current -= 100;
            
            enabled = false;
        }
    }


}
