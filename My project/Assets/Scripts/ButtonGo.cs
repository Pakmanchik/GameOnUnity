using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonGo : MonoBehaviour
{
    private Text            textToEdit;
    bool                    Goes = false;

    public static bool GoesAll = false;// ���������� ��� ������ ����������� 
    void Start()
    {
        textToEdit = GetComponent<Text>(); 
   
    }
    public void ChangeText()
    {
        if(!Goes)
        {
         textToEdit.text = "���������";
            Goes = true;
            GoesAll = true;
            return;
        }
        if (Goes)
        {
            textToEdit.text = "������ �����������";
            Goes = false;
            GoesAll = false;
            return;
        }
        
    }
    public void minushp()
    {
        HPUI.current -= 10;
    }



}
