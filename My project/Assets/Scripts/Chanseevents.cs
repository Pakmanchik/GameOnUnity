using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chanseevents : MonoBehaviour
{
    private Text                 textToEdit;
    public static string         events;
    

    private void Start()
    {
        textToEdit = GetComponent<Text>();
        textToEdit.text = "��������� �����������";
    }
    public void howEvent()
    {
        int chance = Random.Range(0, 101);
        if (chance <= 50)//���� ��������� �����
        {
            textToEdit.text = "������� ����!";
            events = "enemy";
            
            return;
        }
        if( chance > 50)// ���� ��������� �������
        {
            events = "chest";
            textToEdit.text = "������...������!";
         
            return;
        }
    }
 
}
