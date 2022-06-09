using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//��������� �� ��������� �����
    }
    public void GoMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);//��������� � ������� ����
       
    }
    public void ExitGame()
    {
#if UNITY_EDITOR //���� � ���������
        EditorApplication.isPlaying = false;// �� ������� �������� �����
#else 
        Application.Quit();
#endif
    }
}
