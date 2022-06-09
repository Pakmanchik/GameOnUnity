using UnityEngine;
using System.Collections;

[System.Serializable]
public class ScorSave
{
    public static ScorSave current;
    public Character NameSv;
    public Character ScoreSv;
  

    public void ScoreSave()
    {
        NameSv = new Character();
        ScoreSv= new Character();
       
    }
}
