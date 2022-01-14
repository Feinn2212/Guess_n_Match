using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameType : MonoBehaviour
{
    public GameObject GearPanel;
    public GameObject UnderDev;
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
            AudioManager.instance.Play("pop");
            GearPanel.SetActive(true);
            showed = true;
        }
        else
        {
            AudioManager.instance.Play("pop");
            GearPanel.SetActive(false);
            showed = false;
        }
    }

    public void playGame()
    {
        AudioManager.instance.Play("pop");
        SceneManager.LoadScene("PlayGame");
    }

    public void soundtest()
    {
        AudioManager.instance.Play("pop");
        Debug.Log("Button Clicked");
    }

    public void ShowUnderDevelopemtn()
    {
        AudioManager.instance.Play("pop");
        UnderDev.SetActive(true);
    }

    public void HideUnderDevelopemtn()
    {
        AudioManager.instance.Play("pop");
        UnderDev.SetActive(false);
    }

}
