using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameScene : MonoBehaviour
{

    public void LoadScene()
    {
        AudioManager.instance.Play("pop");
        SceneManager.LoadScene("Select GameType");
    }
    public void MainMenu()
    {
        AudioManager.instance.Play("pop");
        SceneManager.LoadScene("Start Menu");
    }

    public void Restart()
    {
        AudioManager.instance.Play("pop");
        SceneManager.LoadScene("PlayGame");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
