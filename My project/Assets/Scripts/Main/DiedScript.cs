using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiedScript : MonoBehaviour
{
    [SerializeField] public GameObject die;
    // Start is called before the first frame update
    public void DieWindow()
    {
        die.SetActive(true);
    }

   
}
