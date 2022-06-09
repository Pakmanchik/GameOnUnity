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
        textToEdit.text = "��������� �����������";
    }
    public void howEvent()
    {
        if (ButtonGo.GoesAll)// ���� ������ ������ ������ 
        {
            int chance = Random.Range(0, 101);
            if (chance >50)//���� ��������� �����
            {
                Debug.Log("����");
                textToEdit.text = "������� ����!";
                events = "enemy";
                StartCoroutine(Stop());
               

                
            }
            if (chance <= 50)// ���� ��������� �������
            {
                Debug.Log("������");
                events = "chest";
                textToEdit.text = "������...������!";
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
