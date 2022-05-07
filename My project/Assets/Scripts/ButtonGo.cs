using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonGo : MonoBehaviour
{
    private Text            textToEdit;
    bool                    Goes = false;

    public static bool GoesAll = false;// Переменная для начала путешествия 
    void Start()
    {
        textToEdit = GetComponent<Text>(); 
   
    }
    public void ChangeText()
    {
        if(!Goes)
        {
         textToEdit.text = "Отдохнуть";
            Goes = true;
            GoesAll = true;
            return;
        }
        if (Goes)
        {
            textToEdit.text = "Начать путешествие";
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
