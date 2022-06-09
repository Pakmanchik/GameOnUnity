using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//переходим на следующую сцену
    }
    public void GoMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);//переходим в главное меню
       
    }
    public void ExitGame()
    {
#if UNITY_EDITOR //если в редакторе
        EditorApplication.isPlaying = false;// то закрыть тестовый режим
#else 
        Application.Quit();
#endif
    }
}
