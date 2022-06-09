using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad
{

    public static List<ScorSave> savedGames = new List<ScorSave>();

    //методы загрузки и сохранения статические, поэтому их можно вызвать откуда угодно
    public static void Save()
    {
        SaveLoad.savedGames.Add(ScorSave.current);
        BinaryFormatter bf = new BinaryFormatter();
        //Application.persistentDataPath это строка; выведите ее в логах и вы увидите расположение файла сохранений
        FileStream file = File.Create(Application.persistentDataPath + "/SaveScore.gd");
        bf.Serialize(file, SaveLoad.savedGames);
        file.Close();
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveScore.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SaveScore.gd", FileMode.Open);
            SaveLoad.savedGames = (List<ScorSave>)bf.Deserialize(file);
            file.Close();
        }
    }
}