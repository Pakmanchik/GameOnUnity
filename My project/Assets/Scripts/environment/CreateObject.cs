using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{

    [SerializeField] string nameObj;
    [SerializeField] private GameObject obj;
    [SerializeField] private float spawnflate = 2f;
    [SerializeField] private GameObject objenemy;
    [SerializeField] private GameObject objchest;

    Vector3 WereToSpawn;
    float rand;
    float nextspawn = 0.0f;
  
    


    // Start is called before the first frame update
    void Start()
    {
        enabled = true;
    }

    // Update is called once per frame
    public void Update()
    {
        if (ButtonGo.GoesAll)// если нажали кнопку начала
        {
            if (Time.time > nextspawn)// высчитываем частоту появления обьектов
            {
                if (nameObj == "cloud")//облака
                {
                    nextspawn = Time.time + spawnflate;
                    rand = Random.Range(368f, 415f);
                    WereToSpawn = new Vector3(1473f, rand, 8);

                }
                if (nameObj == "wayy")//дорога
                {
                    nextspawn = Time.time + spawnflate;
                    WereToSpawn = new Vector3(1441f, 62.8075f, 0);

                }
                if (nameObj == "enemy")// если обьект имеет данный тип , то...
                {
                    enabled = true;// выключаем Update
                    if (Chanseevents.events == "enemy")//если ивент - появление врага
                    {
                  
                        obj = objenemy;
                     
                        WereToSpawn = new Vector3(1087f, 111f, 1f);

                        enabled = false;

                    }

                    if (Chanseevents.events == "chest")// если ивент - появление сундука
                    {
                        obj = objchest;
                        
                        WereToSpawn = new Vector3(980f, 155f, 1f);

                        enabled = false;


                    }



                }
                if (nameObj == "obj") //объекты
                {
                    nextspawn = Time.time + spawnflate;
                    WereToSpawn = new Vector3(1473f, 279f, 7);

                }

                Instantiate(obj, WereToSpawn, Quaternion.identity);
            }
        }
    }
    public void CreateEnemy()
    {
        if (ButtonGo.GoesAll)
        {
            WereToSpawn = new Vector3(1087f, 111f, 1f);

        }
        Instantiate(objenemy, WereToSpawn, Quaternion.identity);
    }

}

    

