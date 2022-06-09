using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefabs : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destr")
        {
            Destroy(gameObject);    
        }
    }
}
