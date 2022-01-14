using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject infoPanel;
    public void ToogleInfo()
    {
        AudioManager.instance.Play("pop");
        infoPanel.SetActive(true);
    }
    
    public void closeInfo()
    {
        AudioManager.instance.Play("pop");
        infoPanel.SetActive(false);
    }

    public void ConfirmExit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    public void nextScene()
    {
        AudioManager.instance.Play("pop");
        SceneManager.LoadScene("Select GameType");
    }
}
