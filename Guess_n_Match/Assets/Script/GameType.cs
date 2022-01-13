using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameType : MonoBehaviour
{
    public GameObject GearPanel;
    private bool showed = false;

    public void QuitGame()
    {
        Debug.Log("Quitting Apllication...");
        Application.Quit();
        
    }
   
    public void ShowGearPanel()
    {
        if(showed == false)
        {
            GearPanel.SetActive(true);
            showed = true;
        }
        else
        {
            GearPanel.SetActive(false);
            showed = false;
        }
    }

    public void playGame()
    {
        SceneManager.LoadScene("PlayGame");
    }

    public void soundtest()
    {
        Debug.Log("Button Clicked");
    }

    

}
