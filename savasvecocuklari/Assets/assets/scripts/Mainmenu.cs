using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Hakkinda()
    {
        SceneManager.LoadScene(3);
    }
    public void Ayarlar()
    {
        SceneManager.LoadScene(4);
    }
}
