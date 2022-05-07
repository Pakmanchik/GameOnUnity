using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEvent : MonoBehaviour
{
    [SerializeField]
    string obj;
    public float speed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        if (Chanseevents.events == "enemy")
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            pauseGame();
            speed = 0;

            return;
        }
    }

    // Update is called once per frame
    public void pauseGame()
    {
        StartCoroutine(waiter());
    }

    private IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(4);
        Debug.Log("pause");
        Time.timeScale = 1;
    }
}
