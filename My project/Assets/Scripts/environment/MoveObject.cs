using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{   
    [SerializeField] string         objForMove;
    [SerializeField] int            sec = 0;

    public static bool              StopGoingEnemy = false;
    public static bool              Stopchest = false;
    public float                    speed = 50f;

   
    void Start()
    {
 
    }
   public void Update()
    {
        if (ButtonGo.GoesAll)
        {
           
            if (objForMove == "obj")
            {
                if (ButtonGo.GoesAll)
                {
                    transform.Translate(Vector3.left * speed * Time.deltaTime);
                    return;
                }
            }

        }
    }
    public void pauseGame()
    {
        StartCoroutine(GamePauser());
    }
    public IEnumerator GamePauser()
    {
        Debug.Log("Inside PauseGame()");
        yield return new WaitForSeconds(4);
        Debug.Log("Done with my pause");
    }

}
