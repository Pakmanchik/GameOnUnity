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
    private void Update()
    {
        if (Chanseevents.events == "enemy")//если активен ивент
        {
            if (objForMove == "enemy")//ивент - враг
            {
                if (Time.time < sec)//идти пока time меньше установленного времени(sec)
                {
                    transform.Translate(Vector3.left * speed * Time.deltaTime);
                    return;
                }
                else // остановиться, когда time больше sec
                {
                    enabled = false;// выключаем Update
                    ButtonGo.GoesAll = false;// останавливаем всё
                    StopGoingEnemy = true;
                }
            }
        }
        if (Chanseevents.events == "chest")//ивент - сундук
        {
            if (objForMove == "chest")
            {
                if (Time.time < sec)
                {
                    transform.Translate(Vector3.left * speed * Time.deltaTime);
                    return;
                }
                else
                {
                    enabled = false;// выключаем Update
                    ButtonGo.GoesAll = false;// останавливаем всё
                    Stopchest = true;
                }
            }
        }
        if (objForMove == "obj")
        {
            if (ButtonGo.GoesAll)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                return;
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
