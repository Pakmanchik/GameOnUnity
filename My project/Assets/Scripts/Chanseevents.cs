using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chanseevents : MonoBehaviour
{
    private Text                 textToEdit;
    public static string         events;
    
    [SerializeField] Fighter enemy;
    [SerializeField] Fighter hero;
    [SerializeField] ChestUp chest;

    private void Start()
    {
        textToEdit = GetComponent<Text>();
        textToEdit.text = "Свободное путешествие";
    }
    public void howEvent()
    {
        if (ButtonGo.GoesAll)// если нажали кнопку начала 
        {
            int chance = Random.Range(0, 101);
            if (chance >50)//шанс выпадения врага
            {
                Debug.Log("Враг");
                textToEdit.text = "Впереди Враг!";
                events = "enemy";
                StartCoroutine(Stop());
               

                
            }
            if (chance <= 50)// шанс выпадения сундука
            {
                Debug.Log("Сундук");
                events = "chest";
                textToEdit.text = "Смотри...Сундук!";
                StartCoroutine(Stop());

            }
        }
    }
    private IEnumerator Stop()
    {
        yield return new WaitForSeconds(2f);
        if(events == "enemy")
        {
            enemy.StartBattle();
            hero.StartBattle();
        }
        else
        {
            chest.GoingChest();
        }
       
    }


}
