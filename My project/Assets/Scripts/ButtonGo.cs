using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonGo : MonoBehaviour
{
    [SerializeField] private Text   textToEdit;
    [SerializeField] private Fighter hv;
    bool                            Goes = false;
  
    public static bool GoesAll = false;// Переменная для начала путешествия 
    // Chanseevents chanseevents = new Chanseevents();
    void Start()
    {
        textToEdit = GetComponent<Text>(); 
   
    }
    public void ChangeText()
    {
        if(!Goes)
        {
            hv._fighterAnimator.Run();
            
            textToEdit.text = "Отдохнуть";
            Goes = true;
            GoesAll = true;
            Debug.Log("if !goes");
            
            return;
        }
        if (Goes)
        {
            textToEdit.text = "Начать путешествие";
            Goes = false;
            GoesAll = false;
            Debug.Log("if goes");
            return;
        }
        
    }
   




}




